CREATE TABLE PersonelTbl(
	PID int PRIMARY KEY,
	PAdSoyad varchar(60) not null,
	PTelefon nvarchar(50) not null,
	PCinsiyet varchar(6) not null,
	PYas int not null,
	PZamanlama nvarchar(50) not null,
	PBrans nvarchar(50) not null,
)