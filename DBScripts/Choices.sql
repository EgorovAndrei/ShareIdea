USE [ShareIdea]
GO

/****** Object:  Table [dbo].[Choices]    Script Date: 6.17.2016 6:41:24 PM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[Choices](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[title] [nchar](150) NULL,
	[description] [nchar](150) NULL,
 CONSTRAINT [PK_Choices] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO


