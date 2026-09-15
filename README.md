# Proyecto Form Persona
este proyecto es un CRUD(Crear,Editar,eliminar,Ver) para practicar 
el aplicativo gira entorno a un objeto persona : 
## Persona:
*es un objeto con los siguientes atributos*

- id 
- nombre
- telefono
---
### con el cual se puede 
- [] Crear
- [] editar
- [] eliminar


## Script de la db

```USE [db_practica]
GO

/****** Objeto: Table [dbo].[persona] Fecha de script: 15/09/2026 9:17:44 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[persona](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[nombre] [varchar](45) NOT NULL,
	[telefono] [varchar](10) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO```


