USE [Curso]

DROP TABLE[Aluno]

CREATE TABLE [Aluno](
    [Id] INT NOT NULL,
    [Nome] NVARCHAR(80) NOT NULL,
    [Nascimento] DATETIME NULL,
    [Active] BIT NOT NULL DEFAULT(0),
)
GO

ALTER TABLE [Aluno]
    ALTER COLUMN [Active] BIT NOT NULL