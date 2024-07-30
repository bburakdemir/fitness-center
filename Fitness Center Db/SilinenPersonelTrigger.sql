CREATE TRIGGER tr_SilinenPersonelTrigger
ON PersonelTbl
AFTER DELETE
AS
BEGIN
    SET NOCOUNT ON;

    DELETE FROM MaasTbl
    WHERE MaasTbl.PMID IN (SELECT deleted.PID FROM deleted);
END;
