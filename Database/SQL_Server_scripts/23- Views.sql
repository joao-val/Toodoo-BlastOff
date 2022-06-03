CREATE OR ALTER VIEW vwContagemCursosPorCategoria AS
    SELECT TOP 100
        [Categoria].[Nome],
        COUNT([Curso].[CategoriaId]) AS [Cursos],
        [Categoria].[Id]        
    FROM 
        [Categoria]
        INNER JOIN [Curso] ON [Curso].[CategoriaId] = [Categoria].[Id]
    GROUP BY
        [Categoria].[Id],
        [Categoria].[Nome],
        [Curso].[CategoriaId]
    HAVING
        COUNT([Curso].[CategoriaId]) > 1

-- SELECT * FROM vwContagemCursosPorCategoria
-- WHERE Id = 1