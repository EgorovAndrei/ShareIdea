USE [ShareIdea]
GO

/****** Object:  Table [dbo].[ChoiceComments]    Script Date: 6.17.2016 6:40:31 PM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[ChoiceComments](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[idChoice] [int] NULL,
	[idUser] [int] NULL,
	[text] [nchar](200) NULL,
 CONSTRAINT [PK_ChoiceComments] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO


