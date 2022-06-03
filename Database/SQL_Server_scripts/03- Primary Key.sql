USE [Curso]

DROP TABLE[Aluno]

CREATE TABLE [Aluno](
    [Id] INT NOT NULL,
    [Nome] NVARCHAR(80) NOT NULL,
    [Email] NVARCHAR(180) NOT NULL,
    [Nascimento] DATETIME NULL,
    [Active] BIT NOT NULL DEFAULT(0),

    CONSTRAINT [PK_Aluno] PRIMARY KEY([Id]),
    CONSTRAINT [UQ_Aluno_Email] UNIQUE([Email]),
    
)
GO

ALTER TABLE [Aluno]
    ADD PRIMARY KEY ([Id])

ALTER TABLE [Aluno]
    DROP CONSTRAINT [PK_Aluno_]