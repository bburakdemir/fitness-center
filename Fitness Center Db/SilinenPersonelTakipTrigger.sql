CREATE TRIGGER tr_SilinenPersonelTakip
ON PersonelTbl
AFTER DELETE 
AS
BEGIN
	INSERT INTO SilinenPersoneller( PID, PAdSoyad, PTelefon, PCinsiyet, PYas, PZamanlama, PBrans)
	SELECT PID, PAdSoyad, PTelefon, PCinsiyet, PYas, PZamanlama, PBrans
	FROM DELETED;
END;