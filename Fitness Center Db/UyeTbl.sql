CREATE TABLE UyeTbl(

	UID int not null identity(100,1) PRIMARY KEY,
	UAdSoyad varchar(60) not null,
	UTelefon nvarchar(50) not null,
	UCinsiyet varchar(6) not null,
	UYas int not null,
	UZamanlama nvarchar(50) not null,
	UOdeme int not null,
	USporTuru nvarchar(50) not null,

)