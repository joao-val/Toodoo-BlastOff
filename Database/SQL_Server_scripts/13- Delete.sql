SELECT * FROM [Curso]

BEGIN TRANSACTION
    DELETE
        [Categoria]
    WHERE
        [Id] = 4
COMMIT --ROLLBACK