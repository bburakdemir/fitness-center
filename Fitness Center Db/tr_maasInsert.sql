CREATE TRIGGER tr_maasInsert
	ON PersonelTbl
	AFTER INSERT 
	AS
	BEGIN
		INSERT INTO MaasTbl(PMID, PAdSoyad,PMaas)
		SELECT PID, PAdSoyad, 11500 AS PMaas
		FROM inserted;
	END;