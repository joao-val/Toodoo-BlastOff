SELECT * FROM [Curso]

BEGIN TRANSACTION
    UPDATE
        [Categoria]
    SET
        [Nome] ='Azure'
    WHERE
        [Id] = 4
COMMIT --ROLLBACK