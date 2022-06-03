SELECT * FROM [Course]
SELECT * FROM [Student]
SELECT * FROM [StudentCourse]

DECLARE @studentId UNIQUEIDENTIFIER =  (SELECT NEWID())

INSERT INTO
    [Student]
VALUES (
    '542eba8f-1de7-4261-95d6-1eaa0c075760',
    'André Baltieri',
    'hello@balta.io',
    '12345678901',
    '12345678',
    NULL,
    GETDATE()
)

INSERT INTO
    [StudentCourse]
VALUES (
    '5f5a33f8-4ff3-7e10-cc6e-3fa000000000',
    '542eba8f-1de7-4261-95d6-1eaa0c075760',
    50,
    0,
    '2020-01-13 12:35:54',
    GETDATE()
)