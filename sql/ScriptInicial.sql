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

IF SCHEMA_ID(N'Cadastro') IS NULL EXEC(N'CREATE SCHEMA [Cadastro];');
GO

CREATE TABLE [Cadastro].[Pais] (
    [Id] uniqueidentifier NOT NULL,
    [Nome] VARCHAR(100) NOT NULL,
    [Codigo] VARCHAR(20) NULL,
    CONSTRAINT [PK_Pais] PRIMARY KEY ([Id])
);
GO

CREATE TABLE [Cadastro].[Estado] (
    [Id] uniqueidentifier NOT NULL,
    [Nome] VARCHAR(100) NOT NULL,
    [Sigla] VARCHAR(2) NOT NULL,
    [IdPais] uniqueidentifier NOT NULL,
    CONSTRAINT [PK_Estado] PRIMARY KEY ([Id]),
    CONSTRAINT [FK_Estado_IdPais] FOREIGN KEY ([IdPais]) REFERENCES [Cadastro].[Pais] ([Id]) ON DELETE NO ACTION
);
GO

CREATE TABLE [Cadastro].[Cidade] (
    [Id] UNIQUEIDENTIFIER NOT NULL,
    [Nome] VARCHAR(MAX) NOT NULL,
    [IdEstado] uniqueidentifier NOT NULL,
    CONSTRAINT [PK_Cidade] PRIMARY KEY ([Id]),
    CONSTRAINT [FK_Cidade_IdEstado] FOREIGN KEY ([IdEstado]) REFERENCES [Cadastro].[Estado] ([Id]) ON DELETE NO ACTION
);
GO

CREATE TABLE [Ceps] (
    [Id] uniqueidentifier NOT NULL,
    [CodigoEnderecamentoPostal] nvarchar(max) NULL,
    [IdCidade] UNIQUEIDENTIFIER NOT NULL,
    CONSTRAINT [PK_Ceps] PRIMARY KEY ([Id]),
    CONSTRAINT [FK_Cep_IdCidade] FOREIGN KEY ([IdCidade]) REFERENCES [Cadastro].[Cidade] ([Id]) ON DELETE NO ACTION
);
GO

CREATE INDEX [IX_Ceps_IdCidade] ON [Ceps] ([IdCidade]);
GO

CREATE INDEX [IX_Cidade_IdEstado] ON [Cadastro].[Cidade] ([IdEstado]);
GO

CREATE INDEX [IX_Estado_IdPais] ON [Cadastro].[Estado] ([IdPais]);
GO

INSERT INTO [__EFMigrationsHistory] ([MigrationId], [ProductVersion])
VALUES (N'20210119013103_Inicial', N'5.0.2');
GO

COMMIT;
GO

