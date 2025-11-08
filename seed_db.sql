USE [LynkDb]
GO
/****** Object:  Table [dbo].[__EFMigrationsHistory]    Script Date: 11/8/2025 4:52:51 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[__EFMigrationsHistory](
	[MigrationId] [nvarchar](150) NOT NULL,
	[ProductVersion] [nvarchar](32) NOT NULL,
 CONSTRAINT [PK___EFMigrationsHistory] PRIMARY KEY CLUSTERED 
(
	[MigrationId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[BlogImages]    Script Date: 11/8/2025 4:52:51 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[BlogImages](
	[Id] [uniqueidentifier] NOT NULL,
	[FileName] [nvarchar](max) NOT NULL,
	[FileExtension] [nvarchar](max) NOT NULL,
	[Title] [nvarchar](max) NOT NULL,
	[Url] [nvarchar](max) NOT NULL,
	[DateCreated] [datetime2](7) NOT NULL,
 CONSTRAINT [PK_BlogImages] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[BlogPostCategory]    Script Date: 11/8/2025 4:52:51 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[BlogPostCategory](
	[BlogPostsId] [uniqueidentifier] NOT NULL,
	[CategoriesId] [uniqueidentifier] NOT NULL,
 CONSTRAINT [PK_BlogPostCategory] PRIMARY KEY CLUSTERED 
(
	[BlogPostsId] ASC,
	[CategoriesId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[BlogPosts]    Script Date: 11/8/2025 4:52:51 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[BlogPosts](
	[Id] [uniqueidentifier] NOT NULL,
	[Title] [nvarchar](max) NOT NULL,
	[ShortDescription] [nvarchar](max) NOT NULL,
	[Content] [nvarchar](max) NOT NULL,
	[FeaturedImageUrl] [nvarchar](max) NOT NULL,
	[UrlHandle] [nvarchar](max) NOT NULL,
	[PublishedDate] [datetime2](7) NOT NULL,
	[Author] [nvarchar](max) NOT NULL,
	[IsVisible] [bit] NOT NULL,
 CONSTRAINT [PK_BlogPosts] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Categories]    Script Date: 11/8/2025 4:52:51 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Categories](
	[Id] [uniqueidentifier] NOT NULL,
	[Name] [nvarchar](max) NOT NULL,
	[UrlHandle] [nvarchar](max) NOT NULL,
 CONSTRAINT [PK_Categories] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
INSERT [dbo].[__EFMigrationsHistory] ([MigrationId], [ProductVersion]) VALUES (N'20250928130511_Initial Migration', N'8.0.20')
INSERT [dbo].[__EFMigrationsHistory] ([MigrationId], [ProductVersion]) VALUES (N'20251028214252_AddRelationships', N'8.0.20')
INSERT [dbo].[__EFMigrationsHistory] ([MigrationId], [ProductVersion]) VALUES (N'20251107205802_AddBlogImageEntity', N'8.0.20')
GO
INSERT [dbo].[BlogPostCategory] ([BlogPostsId], [CategoriesId]) VALUES (N'81495368-62a1-434c-7268-08db615ccdfb', N'dad1ce9d-b688-4e1d-e031-08de1ed155ef')
INSERT [dbo].[BlogPostCategory] ([BlogPostsId], [CategoriesId]) VALUES (N'95b073b3-26ab-4559-1045-08de1ed50f95', N'dad1ce9d-b688-4e1d-e031-08de1ed155ef')
INSERT [dbo].[BlogPostCategory] ([BlogPostsId], [CategoriesId]) VALUES (N'dd321313-b9cb-4fb1-1046-08de1ed50f95', N'dad1ce9d-b688-4e1d-e031-08de1ed155ef')
INSERT [dbo].[BlogPostCategory] ([BlogPostsId], [CategoriesId]) VALUES (N'05582190-bc36-4647-1047-08de1ed50f95', N'dad1ce9d-b688-4e1d-e031-08de1ed155ef')
INSERT [dbo].[BlogPostCategory] ([BlogPostsId], [CategoriesId]) VALUES (N'cd9441fe-196b-46f8-1048-08de1ed50f95', N'dad1ce9d-b688-4e1d-e031-08de1ed155ef')
INSERT [dbo].[BlogPostCategory] ([BlogPostsId], [CategoriesId]) VALUES (N'81495368-62a1-434c-7268-08db615ccdfb', N'4d2bb3dd-45bb-4844-e032-08de1ed155ef')
INSERT [dbo].[BlogPostCategory] ([BlogPostsId], [CategoriesId]) VALUES (N'95b073b3-26ab-4559-1045-08de1ed50f95', N'4d2bb3dd-45bb-4844-e032-08de1ed155ef')
INSERT [dbo].[BlogPostCategory] ([BlogPostsId], [CategoriesId]) VALUES (N'05582190-bc36-4647-1047-08de1ed50f95', N'4d2bb3dd-45bb-4844-e032-08de1ed155ef')
INSERT [dbo].[BlogPostCategory] ([BlogPostsId], [CategoriesId]) VALUES (N'cd9441fe-196b-46f8-1048-08de1ed50f95', N'4d2bb3dd-45bb-4844-e032-08de1ed155ef')
INSERT [dbo].[BlogPostCategory] ([BlogPostsId], [CategoriesId]) VALUES (N'4e2f4984-dae1-4cf4-1049-08de1ed50f95', N'e7a2aa35-b734-4b4d-e033-08de1ed155ef')
INSERT [dbo].[BlogPostCategory] ([BlogPostsId], [CategoriesId]) VALUES (N'05582190-bc36-4647-1047-08de1ed50f95', N'fd4e0f6d-ad56-49a0-e034-08de1ed155ef')
INSERT [dbo].[BlogPostCategory] ([BlogPostsId], [CategoriesId]) VALUES (N'4e2f4984-dae1-4cf4-1049-08de1ed50f95', N'fd4e0f6d-ad56-49a0-e034-08de1ed155ef')
INSERT [dbo].[BlogPostCategory] ([BlogPostsId], [CategoriesId]) VALUES (N'dd321313-b9cb-4fb1-1046-08de1ed50f95', N'8b8e2770-c269-4ee9-e035-08de1ed155ef')
INSERT [dbo].[BlogPostCategory] ([BlogPostsId], [CategoriesId]) VALUES (N'05582190-bc36-4647-1047-08de1ed50f95', N'8b8e2770-c269-4ee9-e035-08de1ed155ef')
INSERT [dbo].[BlogPostCategory] ([BlogPostsId], [CategoriesId]) VALUES (N'cd9441fe-196b-46f8-1048-08de1ed50f95', N'8b8e2770-c269-4ee9-e035-08de1ed155ef')
INSERT [dbo].[BlogPostCategory] ([BlogPostsId], [CategoriesId]) VALUES (N'cd9441fe-196b-46f8-1048-08de1ed50f95', N'b740b411-c5e3-415e-e036-08de1ed155ef')
INSERT [dbo].[BlogPostCategory] ([BlogPostsId], [CategoriesId]) VALUES (N'81495368-62a1-434c-7268-08db615ccdfb', N'3ff02f9b-b146-4aca-e037-08de1ed155ef')
GO
INSERT [dbo].[BlogPosts] ([Id], [Title], [ShortDescription], [Content], [FeaturedImageUrl], [UrlHandle], [PublishedDate], [Author], [IsVisible]) VALUES (N'81495368-62a1-434c-7268-08db615ccdfb', N'Creating a Simple Calculator Application using ASP.NET Core Console App', N'ASP.NET Core is a powerful framework for building cross-platform web applications. While it is commonly used for developing web applications, ASP.NET Core can also be leveraged to create console applications. In this blog post, we will explore in detail how to create a simple calculator application using ASP.NET Core console app. We will cover the step-by-step process of setting up the project, implementing the calculator logic, and running the application. So, let''s get started!', N'## Introduction
ASP.NET Core is a powerful framework for building cross-platform web applications. While it is commonly used for developing web applications, ASP.NET Core can also be leveraged to create console applications. In this blog post, we will explore in detail how to create a simple calculator application using ASP.NET Core console app. We will cover the step-by-step process of setting up the project, implementing the calculator logic, and running the application. So, let''s get started!

## Prerequisites
Before we begin, make sure you have the following installed on your machine:
- .NET Core SDK (latest version)
- Visual Studio Code or any other text editor of your choice

## Step 1: Creating a New ASP.NET Core Console App
To start, open your terminal or command prompt and navigate to the directory where you want to create your project. Run the following command to create a new ASP.NET Core console app:

```csharp
dotnet new console -n CalculatorApp
```
This will create a new directory named "CalculatorApp" with the basic structure of an ASP.NET Core console app.

## Step 2: Implementing the Calculator Logic
In the "CalculatorApp" directory, open the Program.cs file in your text editor. This is the entry point for our console application. Inside the **Main** method, we will implement the calculator logic. Here''s an example implementation of a simple calculator that can perform addition, subtraction, multiplication, and division:


```csharp
using System;

namespace CalculatorApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the Calculator App!");

            Console.WriteLine("Enter the first number:");
            double num1 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Enter the second number:");
            double num2 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Enter the operator (+, -, *, /):");
            string operation = Console.ReadLine();

            double result = 0;

            switch (operation)
            {
                case "+":
                    result = num1 + num2;
                    break;
                case "-":
                    result = num1 - num2;
                    break;
                case "*":
                    result = num1 * num2;
                    break;
                case "/":
                    if (num2 != 0)
                    {
                        result = num1 / num2;
                    }
                    else
                    {
                        Console.WriteLine("Error: Division by zero is not allowed.");
                        return;
                    }
                    break;
                default:
                    Console.WriteLine("Error: Invalid operator.");
                    return;
            }

            Console.WriteLine($"Result: {result}");
        }
    }
}
```

## Step 3: Running the Application
Once you have implemented the calculator logic, save the changes in your text editor. Open your terminal or command prompt and navigate to the "CalculatorApp" directory. Run the following command to build and run the application:

```csharp
dotnet run
```

You will see the console application prompt you to enter the numbers and the operator. After providing the required inputs, it will display the result of the calculation.

## Conclusion
Congratulations! You have successfully created a simple calculator application using ASP.NET Core console app. This demonstrates the versatility of ASP.NET Core, allowing you to build not only web applications but also console applications. You can further enhance the calculator app by adding more functionalities or improving the user interface. Feel free to experiment and explore the possibilities. Happy coding!

Remember to adjust the file and project names accordingly based on your preferences when following the instructions.
', N'https://i.imgflip.com/2rj8rq.png?a489384', N'simple-calculator-app-aspnet-core', CAST(N'2025-11-07T00:00:00.0000000' AS DateTime2), N'Aleks Davitkov', 1)
INSERT [dbo].[BlogPosts] ([Id], [Title], [ShortDescription], [Content], [FeaturedImageUrl], [UrlHandle], [PublishedDate], [Author], [IsVisible]) VALUES (N'95b073b3-26ab-4559-1045-08de1ed50f95', N'About This Project', N'Lynk is a personal blog platform built with modern web technologies, designed to connect ideas and share knowledge. Its name reflects the goal of bridging connections between people and giving voice to what needs to be said. This project is a work in progress, combining practical development with subtle storytelling.', N'## Introduction
Lynk is a blog platform developed with **C# .NET 8** for the backend and **Angular 16** for the frontend, planned to be upgraded to **Angular 18** in the future. It allows users to read and post blogs while providing a responsive and interactive experience.  

The name “Lynk” reflects the idea of creating connections between ideas, knowledge, and people.

This project is still in development. Some features, like **JWT-based login**, **filtering**, and **sorting**, are yet to be implemented. The timeline for completion is uncertain due to other responsibilities, but the focus remains on creating a polished and functional platform.

## Project Goals
- Build a responsive, interactive blog platform.
- Explore subtle storytelling through blogs, blending technical tutorials, fun facts, and reflective pieces.

## Current Status
- **Backend:** C# .NET 8 API, handling blog CRUD operations.
- **Frontend:** Angular 16, with future upgrade planned to Angular 18.
- **Pending Features:** JWT authentication, content filtering, sorting, and minor UI improvements.

## Conclusion
Lynk is more than a technical project; it is a platform to share ideas, create connections, and give voice to the subtle messages that often go unspoken. While it is still a work in progress, the goal is to merge technical skills with storytelling, providing an engaging experience for readers.', N'https://eu-images.contentstack.com/v3/assets/blt6feb61a0e5161fff/bltf8c5d31698b582df/67288224d2544492cbd7f8f7/Lynk-logo.jpg', N'about-this-project', CAST(N'2025-11-08T14:37:50.1040000' AS DateTime2), N'Aleks Davitkov', 1)
INSERT [dbo].[BlogPosts] ([Id], [Title], [ShortDescription], [Content], [FeaturedImageUrl], [UrlHandle], [PublishedDate], [Author], [IsVisible]) VALUES (N'dd321313-b9cb-4fb1-1046-08de1ed50f95', N'ISS - International Space Station', N'The International Space Station (ISS) orbits Earth at roughly 28,000 km/h, serving as a hub for scientific research and international collaboration. In this blog, we explore some fascinating facts about the ISS and the life of astronauts aboard it.', N'## Introduction
The **International Space Station (ISS)** is a remarkable feat of engineering and international cooperation. Orbiting Earth approximately every 90 minutes, it provides a unique environment for experiments in **physics, biology, and technology**.  

---

## Fun Facts About the ISS
- **Orbiting Speed:** ~**28,000 km/h** completing an orbit every **90 minutes**. Astronauts experience **16 sunrises and sunsets per day**! 
- **International Collaboration:** Built and operated by **NASA, Roscosmos, ESA, JAXA, and CSA**, a true symbol of global teamwork. 🤝  
- **Microgravity Life:** Astronauts adapt to weightlessness moving, sleeping, and performing experiments differently than on Earth.   
- **Research Hub:** Experiments impossible on Earth are routine aboard the ISS: human physiology, materials testing, and robotics.  
- **Communication:** Constant contact with mission control ensures coordination across distance.   
- **Aging Station:** Launched in **1998**, the ISS is over two decades old. Plans for **newer-generation space stations** are already underway, keeping humanity’s orbiting laboratory alive. ⏳✨

---

## Life Aboard the ISS
Life aboard the ISS is challenging yet inspiring:  
- Limited space & strict schedules  
- Adaptation to **microgravity**  
- Conducting groundbreaking research  
- Enjoying **breathtaking views of Earth** a perspective only a few humans experience 🌏  

---

## 🛰 Conclusion
The ISS isn’t just a laboratory, it’s a testament to **human ingenuity, collaboration, and perseverance**. It reminds us that even in isolation, teamwork, communication, and shared goals can transcend distance.', N'https://cdn.mos.cms.futurecdn.net/ECLNNSjx7LFnMGQSjsHEVe-1200-80.jpg', N'iss-space-station', CAST(N'2025-11-08T14:45:44.1830000' AS DateTime2), N'Aleks Davitkov', 1)
INSERT [dbo].[BlogPosts] ([Id], [Title], [ShortDescription], [Content], [FeaturedImageUrl], [UrlHandle], [PublishedDate], [Author], [IsVisible]) VALUES (N'05582190-bc36-4647-1047-08de1ed50f95', N'The Dawn of AI', N'Artificial Intelligence is reshaping our world. Some fear it, some embrace it. Is it a genuine leap forward or just another corporate illusion?', N'## Introduction  
Artificial Intelligence has moved from theoretical discussions and sci-fi films into everyday life. Whether we notice it or not, AI powers search engines, recommendations, automation, and tools that assist in programming, design, and communication.

But with this rise comes a fundamental question:  
**Is AI a revolutionary leap forward or a polished corporate illusion promising more than it can deliver?**

The truth lies somewhere in between, shaped by how we choose to use it.

---

## What AI Really Is  
At its core, AI is a combination of:  
- **Machine Learning**  
- **Neural Networks**  
- **Large-scale data processing**  
- **Statistical predictions**

These systems don’t “think” like humans, but they **recognize patterns**, generate responses, and automate tasks with increasing accuracy.

> AI isn''t magic. It''s mathematics wearing a friendly interface.

---

## The Fear  
Some people fear AI for several reasons:

- **Job displacement**: automation replacing human roles  
- **Loss of creativity**: machines generating content previously unique to humans  
- **Privacy concerns**: the data behind AI models  
- **Unknown future**: rapid change without clear limits  

Fear often comes from uncertainty and AI is moving faster than most technologies in history.

---

## The Embrace  
On the other side, many welcome AI with open arms:

- Developers use AI to speed up coding  
- Artists experiment with new creative tools  
- Businesses streamline workflows  
- Students learn faster  
- Individuals become more productive  

AI can amplify human potential when used responsibly.

> “Every tool can either replace you or empower you. It depends on how you choose to hold it.”

---

## Corporate Illusion or Real Transformation?  
Some believe AI is overhyped, a marketing buzzword used to sell products.  
Others see it as the **next industrial revolution**, comparable to electricity or the internet.

The truth?  
AI is powerful, but imperfect. Transformative, but still evolving.  
The world is not becoming automated *overnight*, yet it is undeniably changing.

---

## Conclusion  
AI stands at the intersection of **fear and excitement**, **progress and uncertainty**.  
Whether we see it as a revolution or an illusion depends on how we engage with it.

What’s certain is that AI is here. Its dawn marks a new chapter in human creativity, technology, and connection.', N'https://next.lk/wp-content/uploads/2025/07/Navigating-the-AI-Frontier.jpg', N'the-dawn-of-ai  ', CAST(N'2025-11-08T14:55:45.3970000' AS DateTime2), N'Aleks Davitkov', 1)
INSERT [dbo].[BlogPosts] ([Id], [Title], [ShortDescription], [Content], [FeaturedImageUrl], [UrlHandle], [PublishedDate], [Author], [IsVisible]) VALUES (N'cd9441fe-196b-46f8-1048-08de1ed50f95', N'The 3D Evolution', N'From wireframes to photorealism, the evolution of 3D has transformed how we create, design, and experience the digital world. Let’s take a brief look at how it all began, how far it’s come, and where it’s heading.', N'## The Beginning  
3D Graphics started with **simple wireframes**,  mathematical structures forming cubes, spheres, and lines. In the early 1970s and 80s, rendering even a rotating object was an achievement. Every polygon counted. Every frame mattered.  

---

## The Breakthroughs  
With the 90s came hardware acceleration, texture mapping, and lighting models. Games like *Quake* and *Tomb Raider* changed everything. Suddenly, 3D wasn’t just geometry it had **mood**, **depth**, and **emotion**.  

Then came **CGI in movies**  *Jurassic Park*, *Toy Story*, *The Matrix*.  
The worlds we imagined could finally exist on screen. The line between reality and simulation blurred beautifully.

---

## The Modern Era  
Fast forward to today:  
- Real-time rendering in engines like **Unreal Engine 5**  
- Physically-based rendering (PBR) for lifelike materials  
- Motion capture, photogrammetry, and AI-assisted animation  
- Seamless integration between **art and code**

3D has become the bridge between imagination and engineering.  
We no longer ask *if* something can be made, only *how far* we can take it.

---

## The Future  
The next evolution lies in **AI-assisted generation**, **procedural worlds**, and **interactive storytelling**. 3D creation is becoming more accessible, intuitive, and limitless.

> “The tool evolves, but the artist’s intention remains the same, to create something that feels alive.”

---

## Conclusion  
The evolution of 3D mirrors human progress, from curiosity to mastery. What began as lines on a screen has become entire universes.  

And yet, the core remains the same: **a desire to build worlds from imagination.**', N'https://img.freepik.com/premium-vector/retro-futuristic-3d-mesh-element_23-2151196138.jpg', N'the-3d-evolution', CAST(N'2025-11-08T15:04:06.8660000' AS DateTime2), N'Aleks Davitkov', 1)
INSERT [dbo].[BlogPosts] ([Id], [Title], [ShortDescription], [Content], [FeaturedImageUrl], [UrlHandle], [PublishedDate], [Author], [IsVisible]) VALUES (N'4e2f4984-dae1-4cf4-1049-08de1ed50f95', N'Art of Awareness', N'Awareness is more than observation, it’s connection. In this reflection, we explore how perception shapes reality, and how moments of awareness can change the way we see the world and each other.', N'## Introduction  
Awareness isn’t just about *seeing* it’s about *noticing.*  
The space between moments. The quiet signals that often go unheard.  

In programming, in art, in life, awareness guides us.  
It’s what turns repetition into rhythm, and coincidence into intention.  

---

## The Subtle Shift  
Most of us move through life in automation scrolling, coding, speaking; without pausing to notice the *why* behind our actions.  
Awareness interrupts that loop. It asks:  

- *Did you really see that moment?*  
- *Or did you only pass through it?*  

When you’re aware, everything changes, even silence has meaning.

---

## Connection  
True awareness is connection with self, with others, with the invisible threads that tie events together. You might not always understand why something feels significant.  
But you sense it. You know it matters.  

And maybe, in those quiet intersections of thought and timing, we recognize that awareness is both **art and message** waiting to be seen.

---

## Conclusion  
Awareness is the bridge between what is seen and what is felt.  
Between logic and intuition.  
Between all that exists, and all that is yet to be understood.  
[Until next time.](https://www.youtube.com/watch?v=qxm3zru0lws&list=RDqxm3zru0lws&start_radio=1)', N'https://img.freepik.com/premium-photo/woman-with-head-brain-words-x2-bottom_577115-113344.jpg', N'art-of-awareness', CAST(N'2025-11-08T15:17:46.9200000' AS DateTime2), N'Aleks Davitkov', 1)
GO
INSERT [dbo].[Categories] ([Id], [Name], [UrlHandle]) VALUES (N'dad1ce9d-b688-4e1d-e031-08de1ed155ef', N'Tech', N'tech-blogs')
INSERT [dbo].[Categories] ([Id], [Name], [UrlHandle]) VALUES (N'4d2bb3dd-45bb-4844-e032-08de1ed155ef', N'Programming', N'programming-blogs')
INSERT [dbo].[Categories] ([Id], [Name], [UrlHandle]) VALUES (N'e7a2aa35-b734-4b4d-e033-08de1ed155ef', N'Psychology', N'psychology-blogs')
INSERT [dbo].[Categories] ([Id], [Name], [UrlHandle]) VALUES (N'fd4e0f6d-ad56-49a0-e034-08de1ed155ef', N'Philosophy', N'philosophy-blogs')
INSERT [dbo].[Categories] ([Id], [Name], [UrlHandle]) VALUES (N'8b8e2770-c269-4ee9-e035-08de1ed155ef', N'Science', N'science-blogs')
INSERT [dbo].[Categories] ([Id], [Name], [UrlHandle]) VALUES (N'b740b411-c5e3-415e-e036-08de1ed155ef', N'3D', N'3d-blogs')
INSERT [dbo].[Categories] ([Id], [Name], [UrlHandle]) VALUES (N'3ff02f9b-b146-4aca-e037-08de1ed155ef', N'Tutorial', N'tutorial-blogs')
GO
ALTER TABLE [dbo].[BlogPostCategory]  WITH CHECK ADD  CONSTRAINT [FK_BlogPostCategory_BlogPosts_BlogPostsId] FOREIGN KEY([BlogPostsId])
REFERENCES [dbo].[BlogPosts] ([Id])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[BlogPostCategory] CHECK CONSTRAINT [FK_BlogPostCategory_BlogPosts_BlogPostsId]
GO
ALTER TABLE [dbo].[BlogPostCategory]  WITH CHECK ADD  CONSTRAINT [FK_BlogPostCategory_Categories_CategoriesId] FOREIGN KEY([CategoriesId])
REFERENCES [dbo].[Categories] ([Id])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[BlogPostCategory] CHECK CONSTRAINT [FK_BlogPostCategory_Categories_CategoriesId]
GO
