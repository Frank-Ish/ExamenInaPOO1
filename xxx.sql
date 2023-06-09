USE [master]
GO/****** Object:  Database [dbExamen1POO]    Script Date: 09/01/2018 14:39:10 ******/
CREATE DATABASE [dbExamen1POO]
go
USE [dbExamen1POO]
GO
CREATE TABLE [dbo].[tbAutomovil](
	[placa] [int] NOT NULL,
	[vin] [varchar](13) NOT NULL,
	[marca] [int] NOT NULL,
	[tipo] [int] NOT NULL,
	[color] [int] NOT NULL,
	[estado] [bit] NOT NULL,
 CONSTRAINT [PK_tbAutomovil] PRIMARY KEY CLUSTERED 
(
	[placa] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[tbColor]    Script Date: 09/01/2018 14:39:10 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[tbColor](
	[id] [int] NOT NULL,
	[color] [varchar](50) NOT NULL,
 CONSTRAINT [PK_tbColor] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[tbMarca]    Script Date: 09/01/2018 14:39:10 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[tbMarca](
	[id] [int] NOT NULL,
	[marca] [varchar](50) NOT NULL,
 CONSTRAINT [PK_tbMarca] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[tbTipoVehiculo]    Script Date: 09/01/2018 14:39:10 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[tbTipoVehiculo](
	[id] [int] NOT NULL,
	[tipo] [varchar](50) NOT NULL,
 CONSTRAINT [PK_tbTipoVehiculo] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
ALTER TABLE [dbo].[tbAutomovil]  WITH CHECK ADD  CONSTRAINT [FK_tbAutomovil_tbColor] FOREIGN KEY([color])
REFERENCES [dbo].[tbColor] ([id])
GO
ALTER TABLE [dbo].[tbAutomovil] CHECK CONSTRAINT [FK_tbAutomovil_tbColor]
GO
ALTER TABLE [dbo].[tbAutomovil]  WITH CHECK ADD  CONSTRAINT [FK_tbAutomovil_tbMarca] FOREIGN KEY([marca])
REFERENCES [dbo].[tbMarca] ([id])
GO
ALTER TABLE [dbo].[tbAutomovil] CHECK CONSTRAINT [FK_tbAutomovil_tbMarca]
GO
ALTER TABLE [dbo].[tbAutomovil]  WITH CHECK ADD  CONSTRAINT [FK_tbAutomovil_tbTipoVehiculo] FOREIGN KEY([tipo])
REFERENCES [dbo].[tbTipoVehiculo] ([id])
GO
ALTER TABLE [dbo].[tbAutomovil] CHECK CONSTRAINT [FK_tbAutomovil_tbTipoVehiculo]
GO
USE [master]
GO
ALTER DATABASE [dbExamen1POO] SET  READ_WRITE 
GO


select * from tbAutomovil
select * from tbTipoVehiculo
select * from tbMarca
select * from tbColor