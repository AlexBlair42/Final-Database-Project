USE [TheaterAppDB]
GO

/****** Object:  Table [dbo].[Box_Office]    Script Date: 11/14/2016 2:19:58 AM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[Box_Office](
	[employee_id] [int] NOT NULL,
	[date] [date] NULL,
	[price_kid] [money] NULL,
	[price_matinee] [money] NULL,
	[price_adult] [money] NULL,
	[price_discounted] [money] NULL,
	[price_studentsenior] [money] NULL,
PRIMARY KEY CLUSTERED 
(
	[employee_id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]


/****** Object:  Table [dbo].[Concessions]    Script Date: 11/14/2016 2:20:20 AM ******/
CREATE TABLE [dbo].[Concessions](
	[employee_id] [int] NULL,
	[product_id] [int] NULL,
	[price] [money] NULL
) ON [PRIMARY]
GO

/****** Object:  Table [dbo].[Movie]    Script Date: 11/14/2016 2:20:39 AM ******/
CREATE TABLE [dbo].[Movie](
	[movie_id] [int] NOT NULL,
	[movie_title] [nchar](100) NULL,
PRIMARY KEY CLUSTERED 
(
	[movie_id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO

/****** Object:  Table [dbo].[Product]    Script Date: 11/14/2016 2:20:53 AM ******/
CREATE TABLE [dbo].[Product](
	[product_id] [int] NOT NULL,
	[product_name] [nchar](30) NULL,
	[inv_count] [int] NULL,
	[supplier] [nchar](50) NULL,
	[last_delivered] [date] NULL,
	[last_ordered] [date] NULL,
PRIMARY KEY CLUSTERED 
(
	[product_id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO

/****** Object:  Table [dbo].[Schedule]    Script Date: 11/14/2016 2:21:03 AM ******/
CREATE TABLE [dbo].[Schedule](
	[schedule_id] [int] NOT NULL,
	[movie_id] [int] NULL,
	[theatre_id] [int] NULL,
	[date] [date] NULL,
	[time] [time](1) NULL,
PRIMARY KEY CLUSTERED 
(
	[schedule_id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO

/****** Object:  Table [dbo].[Staff]    Script Date: 11/14/2016 2:21:11 AM ******/
CREATE TABLE [dbo].[Staff](
	[employee_id] [int] NOT NULL,
	[fname] [nchar](30) NULL,
	[lname] [nchar](30) NULL,
	[type_id] [int] NULL,
PRIMARY KEY CLUSTERED 
(
	[employee_id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO

/****** Object:  Table [dbo].[Theater]    Script Date: 11/14/2016 2:21:18 AM ******/
CREATE TABLE [dbo].[Theater](
	[Theater_num] [int] NOT NULL,
	[Theater_name] [nchar](30) NULL,
	[Max_cap] [int] NULL,
PRIMARY KEY CLUSTERED 
(
	[Theater_num] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO

/****** Object:  Table [dbo].[Type]    Script Date: 11/14/2016 2:21:25 AM ******/
CREATE TABLE [dbo].[Type](
	[type_id] [int] NOT NULL,
	[staff_type] [nchar](20) NULL,
	[salary] [money] NULL,
PRIMARY KEY CLUSTERED 
(
	[type_id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO









