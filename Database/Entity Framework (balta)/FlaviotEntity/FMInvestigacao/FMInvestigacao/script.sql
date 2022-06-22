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

CREATE TABLE [Vilao] (
    [IdVilao] int NOT NULL IDENTITY,
    [Nome] VARCHAR(45) NOT NULL,
    [NumCrime] INT NOT NULL,
    CONSTRAINT [PK_Vilao] PRIMARY KEY ([IdVilao])
);
GO

CREATE TABLE [Crime] (
    [IdCrime] int NOT NULL IDENTITY,
    [Data] DATETIME NOT NULL,
    [Nome] VARCHAR(45) NOT NULL,
    [Local] VARCHAR(45) NULL,
    [Duracao] INT NOT NULL,
    [VilaoIdVilao] int NULL,
    CONSTRAINT [PK_Crime] PRIMARY KEY ([IdCrime]),
    CONSTRAINT [FK_Vilao_Crime] FOREIGN KEY ([VilaoIdVilao]) REFERENCES [Vilao] ([IdVilao]) ON DELETE CASCADE
);
GO

CREATE INDEX [IX_Crime_VilaoIdVilao] ON [Crime] ([VilaoIdVilao]);
GO

INSERT INTO [__EFMigrationsHistory] ([MigrationId], [ProductVersion])
VALUES (N'20220620181201_migracao1', N'6.0.6');
GO

COMMIT;
GO

