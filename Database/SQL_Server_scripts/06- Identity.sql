USE [Curso]


DROP TABLE [Curso]
CREATE TABLE [Curso](
    [Id] INT NOT NULL IDENTITY (1, 1),
    [Nome] NVARCHAR(80) NOT NULL,
    [CategoriaId] INT NOT NULL,

    CONSTRAINT [PK_Curso] PRIMARY KEY([Id]),
    CONSTRAINT [FK_Curso_Categoria] FOREIGN KEY([CategoriaId])
        REFERENCES [Categoria]([Id])
    
)
GO
