CREATE TRIGGER SilinenUyeTakip
ON UyeTbl
AFTER DELETE 
AS
BEGIN
	INSERT INTO SilinenUyeler( UID, UAdSoyad, UTelefon, UCinsiyet, UYas, UZamanlama, UOdeme, USporTuru)
	SELECT UID, UAdSoyad, UTelefon, UCinsiyet, UYas, UZamanlama, UOdeme, USporTuru
	FROM DELETED;
END;