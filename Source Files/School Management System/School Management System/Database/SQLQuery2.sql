CREATE TABLE teachers
(
	id INT PRIMARY KEY IDENTITY (1,1),
	teacher_id VARCHAR (MAX) NULL,
	teacher_name VARCHAR (MAX) NULL,
	teacher_gender VARCHAR (MAX) NULL,
	teacher_address VARCHAR (MAX) NULL,
	teacher_email VARCHAR (MAX) NULL,
	teacher_phone VARCHAR (MAX) NULL,
	teacher_nic VARCHAR (MAX) NULL,
	teacher_image VARCHAR (MAX) NULL,
	date_insert DATE,
	date_update DATE,
	date_delete DATE,
);
SELECT * FROM teachers ;