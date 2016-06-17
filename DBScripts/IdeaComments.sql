USE [ShareIdea]
GO

/****** Object:  Table [dbo].[IdeaComments]    Script Date: 6.17.2016 6:41:39 PM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[IdeaComments](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[idIdea] [int] NULL,
	[idUser] [int] NULL,
	[text] [nchar](200) NULL,
 CONSTRAINT [PK_IdeaComments] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO


