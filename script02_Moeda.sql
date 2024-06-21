IF OBJECT_ID(N'[__EFMigrationsHistory]') IS NULL
BEGIN
    CREATE TABLE [__EFMigrationsHistory] (
        [MigrationId] nvarchar(150) NOT NULL,
        [ProductVersion] nvarchar(32) NOT NULL,
        CONSTRAINT [PK___EFMigrationsHistory] PRIMARY KEY ([MigrationId])
    );
END;
GO

BEGIN TRANSACTION;
GO

CREATE TABLE [TB_MOEDA] (
    [Id] int NOT NULL IDENTITY,
    [Name] nvarchar(max) NOT NULL,
    [Valor] float NOT NULL,
    [Quantidade] float NOT NULL,
    [DataCompra] datetime2 NOT NULL,
    [DataVenda] datetime2 NOT NULL,
    [Lucro] float NOT NULL,
    [Prejuizo] float NOT NULL,
    [Imposto] float NOT NULL,
    CONSTRAINT [PK_TB_MOEDA] PRIMARY KEY ([Id])
);
GO

IF EXISTS (SELECT * FROM [sys].[identity_columns] WHERE [name] IN (N'Id', N'DataCompra', N'DataVenda', N'Imposto', N'Lucro', N'Name', N'Prejuizo', N'Quantidade', N'Valor') AND [object_id] = OBJECT_ID(N'[TB_MOEDA]'))
    SET IDENTITY_INSERT [TB_MOEDA] ON;
INSERT INTO [TB_MOEDA] ([Id], [DataCompra], [DataVenda], [Imposto], [Lucro], [Name], [Prejuizo], [Quantidade], [Valor])
VALUES (1, '2024-04-27T15:04:31.0740644+00:00', '2024-04-27T15:04:31.0740661+00:00', 25.5E0, 250.0E0, N'BTC', 0.0E0, 0.0050000000000000001E0, 65000.0E0),
(2, '2024-04-27T15:04:31.0740663+00:00', '2024-04-27T15:04:31.0740663+00:00', 25.5E0, 125.0E0, N'ETH', 0.0E0, 0.02E0, 3500.0E0),
(3, '2024-04-27T15:04:31.0740665+00:00', '2024-04-27T15:04:31.0740665+00:00', 25.5E0, 30.0E0, N'SHIB', 0.0E0, 1123456.2E0, 2.4369999999999999E-05),
(4, '2024-04-27T15:04:31.0740667+00:00', '2024-04-27T15:04:31.0740667+00:00', 25.5E0, 5.0E0, N'DOGE', 0.0E0, 124353.556E0, 0.16E0),
(5, '2024-04-27T15:04:31.0740669+00:00', '2024-04-27T15:04:31.0740669+00:00', 25.5E0, 0.0E0, N'ADA', 50.0E0, 1202.1199999999999E0, 0.45660000000000001E0),
(6, '2024-04-27T15:04:31.0740671+00:00', '2024-04-27T15:04:31.0740671+00:00', 25.5E0, 12.0E0, N'BNB', 0.0E0, 54.0E0, 500.0E0),
(7, '2024-04-27T15:04:31.0740673+00:00', '2024-04-27T15:04:31.0740673+00:00', 25.5E0, 50.0E0, N'FLOKI', 0.0E0, 456543156.12E0, 3.5649999999999999E-05);
IF EXISTS (SELECT * FROM [sys].[identity_columns] WHERE [name] IN (N'Id', N'DataCompra', N'DataVenda', N'Imposto', N'Lucro', N'Name', N'Prejuizo', N'Quantidade', N'Valor') AND [object_id] = OBJECT_ID(N'[TB_MOEDA]'))
    SET IDENTITY_INSERT [TB_MOEDA] OFF;
GO

INSERT INTO [__EFMigrationsHistory] ([MigrationId], [ProductVersion])
VALUES (N'20240427180431_Migracaoinicial', N'8.0.6');
GO

COMMIT;
GO

BEGIN TRANSACTION;
GO

DECLARE @var0 sysname;
SELECT @var0 = [d].[name]
FROM [sys].[default_constraints] [d]
INNER JOIN [sys].[columns] [c] ON [d].[parent_column_id] = [c].[column_id] AND [d].[parent_object_id] = [c].[object_id]
WHERE ([d].[parent_object_id] = OBJECT_ID(N'[TB_MOEDA]') AND [c].[name] = N'Name');
IF @var0 IS NOT NULL EXEC(N'ALTER TABLE [TB_MOEDA] DROP CONSTRAINT [' + @var0 + '];');
ALTER TABLE [TB_MOEDA] ALTER COLUMN [Name] Varchar(200) NOT NULL;
GO

ALTER TABLE [TB_MOEDA] ADD [UsuarioId] int NULL;
GO

CREATE TABLE [TB_USUARIOS] (
    [Id] int NOT NULL IDENTITY,
    [Username] Varchar(200) NOT NULL,
    [PasswordHash] varbinary(max) NULL,
    [PasswordSalt] varbinary(max) NULL,
    [Foto] varbinary(max) NULL,
    [Latitude] float NULL,
    [Longitude] float NULL,
    [DataAcesso] datetime2 NULL,
    [Perfil] Varchar(200) NOT NULL DEFAULT 'Insvetidor',
    [Email] Varchar(200) NOT NULL,
    CONSTRAINT [PK_TB_USUARIOS] PRIMARY KEY ([Id])
);
GO

UPDATE [TB_MOEDA] SET [DataCompra] = '2024-06-09T00:11:10.4792555+00:00', [DataVenda] = '2024-06-09T00:11:10.4792564+00:00', [UsuarioId] = NULL
WHERE [Id] = 1;
SELECT @@ROWCOUNT;

GO

UPDATE [TB_MOEDA] SET [DataCompra] = '2024-06-09T00:11:10.4792566+00:00', [DataVenda] = '2024-06-09T00:11:10.4792566+00:00', [UsuarioId] = NULL
WHERE [Id] = 2;
SELECT @@ROWCOUNT;

GO

UPDATE [TB_MOEDA] SET [DataCompra] = '2024-06-09T00:11:10.4792568+00:00', [DataVenda] = '2024-06-09T00:11:10.4792569+00:00', [UsuarioId] = NULL
WHERE [Id] = 3;
SELECT @@ROWCOUNT;

GO

UPDATE [TB_MOEDA] SET [DataCompra] = '2024-06-09T00:11:10.4792570+00:00', [DataVenda] = '2024-06-09T00:11:10.4792571+00:00', [UsuarioId] = NULL
WHERE [Id] = 4;
SELECT @@ROWCOUNT;

GO

UPDATE [TB_MOEDA] SET [DataCompra] = '2024-06-09T00:11:10.4792572+00:00', [DataVenda] = '2024-06-09T00:11:10.4792573+00:00', [UsuarioId] = NULL
WHERE [Id] = 5;
SELECT @@ROWCOUNT;

GO

UPDATE [TB_MOEDA] SET [DataCompra] = '2024-06-09T00:11:10.4792574+00:00', [DataVenda] = '2024-06-09T00:11:10.4792574+00:00', [UsuarioId] = NULL
WHERE [Id] = 6;
SELECT @@ROWCOUNT;

GO

UPDATE [TB_MOEDA] SET [DataCompra] = '2024-06-09T00:11:10.4792576+00:00', [DataVenda] = '2024-06-09T00:11:10.4792576+00:00', [UsuarioId] = NULL
WHERE [Id] = 7;
SELECT @@ROWCOUNT;

GO

IF EXISTS (SELECT * FROM [sys].[identity_columns] WHERE [name] IN (N'Id', N'DataAcesso', N'Email', N'Foto', N'Latitude', N'Longitude', N'PasswordHash', N'PasswordSalt', N'Perfil', N'Username') AND [object_id] = OBJECT_ID(N'[TB_USUARIOS]'))
    SET IDENTITY_INSERT [TB_USUARIOS] ON;
INSERT INTO [TB_USUARIOS] ([Id], [DataAcesso], [Email], [Foto], [Latitude], [Longitude], [PasswordHash], [PasswordSalt], [Perfil], [Username])
VALUES (1, NULL, 'seuEmail@gamil.com', NULL, -23.520024100000001E0, -46.596497999999997E0, 0x836AF6F04A20793E92ECB0A2DBC87FC9382AB2EF3F13CD3C63EE0EF2DD6B348DA60FC12822853B044142E1991571B9C66A76243F07A3CD84BAE0A0B5590D056DB9C88C5066B2611CD6A71BA50585E7437CBDCAD7CF47FC40C60720B7ABA91794ABB1B94CDF92897DCF74A16AB0A8522251308FD3470723F211D0F235A1B51C2C, NULL, 'Admin', 'usuarioadmin');
IF EXISTS (SELECT * FROM [sys].[identity_columns] WHERE [name] IN (N'Id', N'DataAcesso', N'Email', N'Foto', N'Latitude', N'Longitude', N'PasswordHash', N'PasswordSalt', N'Perfil', N'Username') AND [object_id] = OBJECT_ID(N'[TB_USUARIOS]'))
    SET IDENTITY_INSERT [TB_USUARIOS] OFF;
GO

CREATE INDEX [IX_TB_MOEDA_UsuarioId] ON [TB_MOEDA] ([UsuarioId]);
GO

ALTER TABLE [TB_MOEDA] ADD CONSTRAINT [FK_TB_MOEDA_TB_USUARIOS_UsuarioId] FOREIGN KEY ([UsuarioId]) REFERENCES [TB_USUARIOS] ([Id]);
GO

INSERT INTO [__EFMigrationsHistory] ([MigrationId], [ProductVersion])
VALUES (N'20240609031110_Usuario', N'8.0.6');
GO

COMMIT;
GO

BEGIN TRANSACTION;
GO

DECLARE @var1 sysname;
SELECT @var1 = [d].[name]
FROM [sys].[default_constraints] [d]
INNER JOIN [sys].[columns] [c] ON [d].[parent_column_id] = [c].[column_id] AND [d].[parent_object_id] = [c].[object_id]
WHERE ([d].[parent_object_id] = OBJECT_ID(N'[TB_MOEDA]') AND [c].[name] = N'DataCompra');
IF @var1 IS NOT NULL EXEC(N'ALTER TABLE [TB_MOEDA] DROP CONSTRAINT [' + @var1 + '];');
ALTER TABLE [TB_MOEDA] DROP COLUMN [DataCompra];
GO

EXEC sp_rename N'[TB_MOEDA].[DataVenda]', N'Data', N'COLUMN';
GO

ALTER TABLE [TB_MOEDA] ADD [Operacao] int NOT NULL DEFAULT 0;
GO

UPDATE [TB_MOEDA] SET [Data] = '2024-06-20T17:44:27.8267376+00:00', [Operacao] = 2
WHERE [Id] = 1;
SELECT @@ROWCOUNT;

GO

UPDATE [TB_MOEDA] SET [Data] = '2024-06-20T17:44:27.8267462+00:00', [Operacao] = 2
WHERE [Id] = 2;
SELECT @@ROWCOUNT;

GO

UPDATE [TB_MOEDA] SET [Data] = '2024-06-20T17:44:27.8267465+00:00', [Operacao] = 2
WHERE [Id] = 3;
SELECT @@ROWCOUNT;

GO

UPDATE [TB_MOEDA] SET [Data] = '2024-06-20T17:44:27.8267467+00:00', [Operacao] = 2
WHERE [Id] = 4;
SELECT @@ROWCOUNT;

GO

UPDATE [TB_MOEDA] SET [Data] = '2024-06-20T17:44:27.8267470+00:00', [Operacao] = 2
WHERE [Id] = 5;
SELECT @@ROWCOUNT;

GO

UPDATE [TB_MOEDA] SET [Data] = '2024-06-20T17:44:27.8267471+00:00', [Operacao] = 2
WHERE [Id] = 6;
SELECT @@ROWCOUNT;

GO

UPDATE [TB_MOEDA] SET [Data] = '2024-06-20T17:44:27.8267473+00:00', [Operacao] = 2
WHERE [Id] = 7;
SELECT @@ROWCOUNT;

GO

UPDATE [TB_USUARIOS] SET [PasswordHash] = 0x7C6AD3FE10A1D5635364B8815BFCD3497A3FEFD78D3D6AC301C11AF8EA4EE03A7B91DB5B37F036C0660B2D21A832D25E01B8C396D5AF80445DD5DAE600D01B1EAA949657845D2FE9B0CDFA647D37001E39035A8206B600418226067E3933BCD72364DFF6F2855C1EAF07D5ECBFEB8716A436B0CA5206135F44CF761B0B42ACBA
WHERE [Id] = 1;
SELECT @@ROWCOUNT;

GO

INSERT INTO [__EFMigrationsHistory] ([MigrationId], [ProductVersion])
VALUES (N'20240620174428_Moeda', N'8.0.6');
GO

COMMIT;
GO
INSERT INTO [__EFMigrationsHistory] ([MigrationId], [ProductVersion])
VALUES (N'20240620233917_Autenticar', N'8.0.6');
GO

COMMIT;
GO


