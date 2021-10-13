-- B
CREATE TABLE data_staff (
	staff_id INT IDENTITY(1,1) PRIMARY KEY,
	nama VARCHAR(50) NULL, 
	alamat VARCHAR(200) NULL,
	handphone VARCHAR(15) NULL
);

-- C & D
INSERT INTO data_staff(nama,alamat,handphone)
VALUES('BEJO','SURABAYA','081234567895');
INSERT INTO data_staff(nama,alamat,handphone)
VALUES('BUDI','MALANG','081344556679');
INSERT INTO data_staff(nama,alamat,handphone)
VALUES('ANI','YOGYAKARTA','081241582679');
INSERT INTO data_staff(nama,alamat,handphone)
VALUES('DANNY','BANDUNG','081388356211');
INSERT INTO data_staff(nama,alamat,handphone)
VALUES('DIO','SEMARANG','081331166720');

-- E
ALTER TABLE data_staff 
ADD joindate DATE;

INSERT INTO data_staff(nama,alamat,handphone,joindate)
VALUES('DERRY','MAlANG','081224166775','2021-10-06');


--SELECT * FROM data_staff ds;

-- F
SELECT TOP 2 * FROM data_staff ds;
-- G
SELECT TOP 3 * FROM data_staff ds;
-- H
CREATE TABLE staff_outsource (
	staff_outsource_id INT IDENTITY(1,1) PRIMARY KEY,
	nama VARCHAR(50) NULL, 
	alamat VARCHAR(200) NULL,
	handphone VARCHAR(15) NULL,
	joindate DATE NULL
);

INSERT INTO staff_outsource(nama,alamat,handphone)
VALUES('BEJO','SURABAYA','081234567895');
INSERT INTO staff_outsource(nama,alamat,handphone)
VALUES('BUDI','MALANG','081344556679');
INSERT INTO staff_outsource(nama,alamat,handphone)
VALUES('ANI','YOGYAKARTA','081241582679');
INSERT INTO staff_outsource(nama,alamat,handphone)
VALUES('DANNY','BANDUNG','081388356211');
INSERT INTO staff_outsource(nama,alamat,handphone)
VALUES('DIO','SEMARANG','081331166720');
INSERT INTO staff_outsource(nama,alamat,handphone,joindate)
VALUES('DERRY','MAlANG','081224166775','2021-10-06');

-- I
INSERT INTO staff_outsource(nama,alamat,handphone,joindate)
VALUES('HADI','MALANG','081346422144','2021-10-01');
INSERT INTO staff_outsource(nama,alamat,handphone,joindate)
VALUES('SISIL','MALANG','081355213367','2021-10-01');
INSERT INTO staff_outsource(nama,alamat,handphone,joindate)
VALUES('ANDRI','BANDUNG','081399821126','2021-10-02');
INSERT INTO staff_outsource(nama,alamat,handphone,joindate)
VALUES('SELVI','JAKARTA','082133217764','2021-10-03');
INSERT INTO staff_outsource(nama,alamat,handphone,joindate)
VALUES('DINA','JAKARTA','089566722433','2021-10-05');
INSERT INTO staff_outsource(nama,alamat,handphone,joindate)
VALUES('ADI','SURABAYA','089326755413','2021-10-05');
INSERT INTO staff_outsource(nama,alamat,handphone,joindate)
VALUES('ULFA','JAKARTA','089126722132','2021-10-03');
INSERT INTO staff_outsource(nama,alamat,handphone,joindate)
VALUES('MIKO','SURABAYA','089331724213','2021-10-01');
INSERT INTO staff_outsource(nama,alamat,handphone,joindate)
VALUES('RADITYA','BANDUNG','089566712100','2021-10-02');
INSERT INTO staff_outsource(nama,alamat,handphone,joindate)
VALUES('VICKO','MEDAN','089562311441','2021-10-04');

-- J
SELECT ds.nama 
FROM data_staff ds 
INNER JOIN staff_outsource so
	ON ds.joindate = so.joindate;

-- K
SELECT *
FROM data_staff ds
RIGHT JOIN staff_outsource so
	ON ds.staff_id = so.staff_outsource_id;

-- L
SELECT *
FROM data_staff ds
LEFT JOIN staff_outsource so 
	ON ds.staff_id = so.staff_outsource_id;

-- M
SELECT ds.* 
FROM data_staff ds
UNION ALL
SELECT so.* 
FROM staff_outsource so
