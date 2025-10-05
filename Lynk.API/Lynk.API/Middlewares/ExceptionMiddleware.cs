using Lynk.API.Shared.CustomExceptions;
using System.Net;
using System.Text.Json;

namespace Lynk.API.Middlewares
{
    public class ExceptionMiddleware
    {
        private readonly RequestDelegate _next;

        public ExceptionMiddleware(RequestDelegate next)
        {
            _next = next;
        }

        public async Task InvokeAsync(HttpContext context)
        {
            try
            {
                await _next(context);
            }
            catch (Exception ex)
            {
                await HandleExceptionAsync(context, ex);
            }
        }

        private static Task HandleExceptionAsync(HttpContext context, Exception exception)
        {
            HttpStatusCode status;
            string message;

            switch (exception)
            {
                case AppException e:
                    status = HttpStatusCode.BadRequest;
                    message = e.Message;
                    break;
                case KeyNotFoundException e:
                    status = HttpStatusCode.NotFound;
                    message = e.Message;
                    break;
                default:
                    status = HttpStatusCode.InternalServerError;
                    message = "Internal server error. Contact admin.";
                    break;
            }

            var response = new { StatusCode = (int)status, Message = message };
            var payload = JsonSerializer.Serialize(response);

            context.Response.ContentType = "application/json";
            context.Response.StatusCode = (int)status;

            return context.Response.WriteAsync(payload);
        }
    }
}
