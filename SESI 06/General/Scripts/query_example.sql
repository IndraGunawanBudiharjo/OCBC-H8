USE DB_SESI06;

CREATE TABLE TB_SISWA (

SISWA_ID INT IDENTITY(1,1) PRIMARY KEY,
NIS VARCHAR(10),
NAMA VARCHAR(50) NULL, 
ALAMAT VARCHAR(100) NULL,
TG_LAHIR DATE NULL,
J_KELAMIN VARCHAR(1) NULL
);

ALTER TABLE TB_SISWA 
ALTER COLUMN J_KELAMIN VARCHAR(10);

INSERT INTO TB_SISWA(NIS,NAMA,ALAMAT,TG_LAHIR,J_KELAMIN)
VALUES('10001','BEJO','SURABAYA','2010-10-06','PRIA');
INSERT INTO TB_SISWA(NIS,NAMA,ALAMAT,TG_LAHIR,J_KELAMIN)
VALUES('10002','ANI','MALANG','2010-10-06','WANITA');

--SELECT * FROM TB_SISWA WHERE NIS = '10001';

--SELECT * FROM TB_SISWA WHERE ALAMAT LIKE 'SU%';
--
--SELECT * FROM TB_SISWA WHERE TG_LAHIR BETWEEN '09-10-2010' AND '10-10-2010';

--UPDATE TB_SISWA SET NAMA = 'BEJO SUTEDJO' WHERE NIS = '10001';
--
--DELETE TB_SISWA WHERE NIS = '10002';


