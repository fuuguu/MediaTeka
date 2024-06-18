CREATE PROCEDURE [dbo].[Procedure]
	@Жанр nchar(50)
AS
	SELECT * FROM dbo.Жанры
	WHERE [Название жанра] = @Жанр
RETURN 0
