USE [DB_CLIENTE]
GO
/****** Object:  Table [dbo].[tbl_cliente]    Script Date: 11/06/2018 17:20:31 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tbl_cliente](
	[id_cliente] [varchar](50) NOT NULL,
	[nome_cliente] [varchar](100) NOT NULL,
	[nome_empresa] [varchar](100) NOT NULL,
	[email] [varchar](100) NOT NULL,
	[cnpj] [char](14) NOT NULL,
	[telefone_comercial] [char](10) NOT NULL,
	[celular] [char](11) NOT NULL,
	[cep] [char](8) NOT NULL,
	[cidade] [char](100) NOT NULL,
	[estado] [char](2) NOT NULL,
 CONSTRAINT [PK_tbl_cliente] PRIMARY KEY CLUSTERED 
(
	[id_cliente] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[tbl_vendedor]    Script Date: 11/06/2018 17:20:31 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tbl_vendedor](
	[id_vendedor] [int] IDENTITY(1,1) NOT NULL,
	[login] [char](20) NOT NULL,
	[senha] [char](30) NOT NULL,
 CONSTRAINT [PK_tbl_vendedor] PRIMARY KEY CLUSTERED 
(
	[id_vendedor] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  StoredProcedure [dbo].[proc_list_cliente]    Script Date: 11/06/2018 17:20:31 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[proc_list_cliente]
AS
BEGIN

	SELECT * FROM tbl_cliente
END
GO
/****** Object:  StoredProcedure [dbo].[proc_login_vendedor]    Script Date: 11/06/2018 17:20:31 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[proc_login_vendedor]
	-- Add the parameters for the stored procedure here
	@login	CHAR(20),
	@senha	CHAR(30)
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;
	
	SELECT * FROM tbl_vendedor where login = @login  and senha = @senha
END
GO
/****** Object:  StoredProcedure [dbo].[proc_return_cliente]    Script Date: 11/06/2018 17:20:31 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[proc_return_cliente]
	@id_cliente VARCHAR(100)
AS
BEGIN

	SELECT * FROM tbl_cliente
	where id_cliente = @id_cliente
END
GO
/****** Object:  StoredProcedure [dbo].[proc_save_cliente]    Script Date: 11/06/2018 17:20:31 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[proc_save_cliente]
	-- Add the parameters for the stored procedure here
	@id_cliente				VARCHAR(50),
	@nome_cliente			VARCHAR(100),
	@nome_empresa			VARCHAR(100),
	@email					VARCHAR(100),
	@cnpj					CHAR(14),
	@telefone_comercial		CHAR(14),
	@celular				CHAR(11),
	@cep					CHAR(8),
	@cidade					VARCHAR(100),
	@estado					CHAR(2)
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;
	
	INSERT INTO tbl_cliente
	(
		id_cliente,
		nome_cliente,
		nome_empresa,
		email,
		cnpj,
		telefone_comercial,
		celular,
		cep,
		cidade,
		estado
	)
	values
	(
		@id_cliente,
		@nome_cliente,
		@nome_empresa,
		@email,
		@cnpj,
		@telefone_comercial,
		@celular,
		@cep,
		@cidade,
		@estado
	)
END
GO
/****** Object:  StoredProcedure [dbo].[proc_update_cliente]    Script Date: 11/06/2018 17:20:31 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[proc_update_cliente]
	-- Add the parameters for the stored procedure here
	@id_cliente				VARCHAR(50),
	@nome_cliente			VARCHAR(100),
	@nome_empresa			VARCHAR(100),
	@email					VARCHAR(100),
	@cnpj					CHAR(14),
	@telefone_comercial		CHAR(14),
	@celular				CHAR(11),
	@cep					CHAR(8),
	@cidade					VARCHAR(100),
	@estado					CHAR(2)
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;
	
	UPDATE tbl_cliente
	SET
		nome_cliente = @nome_cliente,
		nome_empresa = @nome_empresa,
		email = @email,
		cnpj = @cnpj,
		telefone_comercial = @telefone_comercial,
		celular = @celular,
		cep = @cep,
		cidade = @cidade,
		estado = estado
	WHERE id_cliente = @id_cliente
END
GO
