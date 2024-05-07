CREATE TABLE Tarifs(
ID_tarif INT PRIMARY KEY,
name NVARCHAR(MAX) NOT NULL,
price_per_month REAL NOT NULL,
services NTEXT NOT NULL
);

CREATE TABLE Departments(
ID_department INT PRIMARY KEY,
name NVARCHAR(250) NOT NULL,
description NVARCHAR(250) NOT NULL
);

CREATE TABLE Posts(
ID_post INT PRIMARY KEY,
ID_department INT NOT NULL,
name NVARCHAR(250) NOT NULL,
salary REAL NOT NULL,
description NVARCHAR(250) NOT NULL,
FOREIGN KEY (ID_department) REFERENCES Departments(ID_department) ON DELETE CASCADE ON UPDATE CASCADE
);

CREATE TABLE Auth(
ID_account INT PRIMARY KEY,
login NVARCHAR(MAX) NOT NULL,
password NVARCHAR(MAX) NOT NULL,
pass_level INT
);

CREATE TABLE Workers(
ID_worker INT PRIMARY KEY,
account INT NOT NULL,
surname NVARCHAR(250) NOT NULL,
name NVARCHAR(250) NOT NULL,
patronymic NVARCHAR(250) NOT NULL,
post INT NOT NULL,
department INT NOT NULL,
birth_date DATE NOT NULL,
phone_number NVARCHAR(20) NOT NULL,
FOREIGN KEY (account) REFERENCES Auth(ID_account) ON DELETE CASCADE ON UPDATE CASCADE,
FOREIGN KEY (post) REFERENCES Posts(ID_post) ON DELETE CASCADE ON UPDATE CASCADE,
FOREIGN KEY (department) REFERENCES Departments(ID_department)
);

CREATE TABLE Service_information(
ID_information INT PRIMARY KEY,
ID_worker INT NOT NULL,
passportserial_number NVARCHAR(15) NOT NULL,
issued NVARCHAR(MAX) NOT NULL,
date_of_issue DATE NOT NULL,
division_code NVARCHAR(15) NOT NULL,
gender NVARCHAR(15) NOT NULL,
address_password NVARCHAR(MAX) NOT NULL,
residential_address NVARCHAR(MAX) NOT NULL,
military_ID_series NVARCHAR(200) NOT NULL,
snils NVARCHAR(200) NOT NULL,
employment_record NVARCHAR(MAX) NOT NULL,
diploma NVARCHAR(MAX) NOT NULL,
medical_book INT NOT NULL,
FOREIGN KEY (ID_worker) REFERENCES Workers(ID_worker) ON DELETE CASCADE ON UPDATE CASCADE,
);

CREATE TABLE Customers(
ID_customer INT PRIMARY KEY,
name NVARCHAR(200) NOT NULL,
inn DECIMAL(18, 0) NOT NULL,
kpp DECIMAL(18, 0) NOT NULL,
ogrn DECIMAL(18, 0) NOT NULL,
registration_form NVARCHAR(200) NOT NULL,
worker INT,
FOREIGN KEY (worker) REFERENCES Workers(ID_worker) ON DELETE CASCADE ON UPDATE CASCADE,
);

CREATE TABLE Accounting(
ID_note INT PRIMARY KEY,
customer INT NOT NULL,
tarif INT NOT NULL,
start_date DATE NOT NULL,
end_date DATE NOT NULL,
total real,
FOREIGN KEY (customer) REFERENCES Customers(ID_customer) ON DELETE CASCADE ON UPDATE CASCADE,
FOREIGN KEY (tarif) REFERENCES Tarifs(ID_tarif) ON DELETE CASCADE ON UPDATE CASCADE
);


CREATE TABLE ArchiveWorkers(
ID_archive INT PRIMARY KEY,
surname NVARCHAR(250),
name NVARCHAR(250),
patronymic NVARCHAR(250),
post INT,
department INT,
birth_date DATE,
phone_number NVARCHAR(20),
passportserial_number NVARCHAR(15),
issued NVARCHAR(MAX),
date_of_issue DATE,
division_code NVARCHAR(15),
gender NVARCHAR(15),
address_password NVARCHAR(MAX),
residential_address NVARCHAR(MAX),
military_ID_series NVARCHAR(200),
snils NVARCHAR(200),
employment_record NVARCHAR(MAX),
diploma NVARCHAR(MAX),
medical_book INT,
);

CREATE TABLE ArchiveAccounting(
ID_archive INT PRIMARY KEY,
customer INT NOT NULL,
inn DECIMAL(18, 0) NOT NULL,
kpp DECIMAL(18, 0) NOT NULL,
ogrn DECIMAL(18, 0) NOT NULL,
registration_form NVARCHAR(200) NOT NULL,
worker NVARCHAR(200) NOT NULL,
tarif NVARCHAR(200),
start_date DATE,
end_date DATE,
total real
);