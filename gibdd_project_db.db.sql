BEGIN TRANSACTION;
CREATE TABLE IF NOT EXISTS "Brand" (
	"id"	INTEGER NOT NULL UNIQUE,
	"name"	TEXT NOT NULL CHECK(typeof("name") = "text" AND length("name") <= 25),
	PRIMARY KEY("id" AUTOINCREMENT)
);
CREATE TABLE IF NOT EXISTS "CarСategory" (
	"id"	INTEGER NOT NULL UNIQUE,
	"name"	TEXT NOT NULL CHECK(typeof("name") = "text" AND length("name") <= 25),
	PRIMARY KEY("id" AUTOINCREMENT)
);
CREATE TABLE IF NOT EXISTS "Fine" (
	"id"	INTEGER NOT NULL UNIQUE,
	"name"	TEXT NOT NULL CHECK(typeof("name") = "text" AND length("name") <= 40),
	"value"	TEXT NOT NULL CHECK(typeof("value") = "text" AND length("value") <= 10),
	"status"	TEXT NOT NULL CHECK(typeof("status") = "text" AND length("status") <= 25),
	"id_type"	INTEGER NOT NULL,
	"id_transport"	INTEGER NOT NULL,
	FOREIGN KEY("id_type") REFERENCES "TypeFine"("id") ON DELETE CASCADE ON UPDATE CASCADE,
	FOREIGN KEY("id_transport") REFERENCES "Transport"("id") ON DELETE CASCADE ON UPDATE CASCADE,
	PRIMARY KEY("id" AUTOINCREMENT)
);
CREATE TABLE IF NOT EXISTS "GIBDD" (
	"Id"	INTEGER NOT NULL UNIQUE,
	"name"	TEXT NOT NULL CHECK(typeof("name") = "text" AND length("name") <= 100),
	"address"	TEXT NOT NULL CHECK(typeof("adress") = "text" AND length("adress") <= 70),
	"startwork"	TEXT NOT NULL CHECK(typeof("startwork") = "text" AND length("startwork") <= 15),
	"stopwork"	TEXT NOT NULL CHECK(typeof("stopwork") = "text" AND length("stopwork") <= 15),
	PRIMARY KEY("Id" AUTOINCREMENT)
);
CREATE TABLE IF NOT EXISTS "Model" (
	"id"	INTEGER NOT NULL UNIQUE,
	"name"	TEXT NOT NULL CHECK(typeof("name") = "text" AND length("name") <= 25),
	"id_brand"	INTEGER NOT NULL,
	"id_carcategory"	INTEGER NOT NULL,
	FOREIGN KEY("id_carcategory") REFERENCES "CarСategory"("id") ON DELETE CASCADE ON UPDATE CASCADE,
	FOREIGN KEY("id_brand") REFERENCES "Brand"("id") ON DELETE CASCADE ON UPDATE CASCADE,
	PRIMARY KEY("id" AUTOINCREMENT)
);
CREATE TABLE IF NOT EXISTS "Role" (
	"id"	INTEGER NOT NULL UNIQUE,
	"name"	TEXT NOT NULL CHECK(typeof("name") = "text" AND length("name") <= 20),
	PRIMARY KEY("id" AUTOINCREMENT)
);
CREATE TABLE IF NOT EXISTS "Transport" (
	"id"	INTEGER NOT NULL UNIQUE,
	"id_model"	INTEGER NOT NULL,
	"state_number"	TEXT NOT NULL CHECK(typeof("state_number") = "text" AND length("state_number") <= 12),
	"status"	TEXT NOT NULL CHECK(typeof("status") = "text" AND length("status") <= 15),
	"year"	TEXT NOT NULL CHECK(typeof("year") = "text" AND length("year") <= 4),
	"id_user"	INTEGER NOT NULL,
	FOREIGN KEY("id_user") REFERENCES "User"("id") ON DELETE CASCADE ON UPDATE CASCADE,
	FOREIGN KEY("id_model") REFERENCES "Model"("id") ON DELETE CASCADE ON UPDATE CASCADE,
	PRIMARY KEY("id" AUTOINCREMENT)
);
CREATE TABLE IF NOT EXISTS "TypeFine" (
	"id"	INTEGER NOT NULL UNIQUE,
	"purpose"	TEXT NOT NULL CHECK(typeof("purpose") = "text" AND length("purpose") <= 150),
	"value"	TEXT NOT NULL,
	"date"	TEXT NOT NULL,
	PRIMARY KEY("id" AUTOINCREMENT)
);
CREATE TABLE IF NOT EXISTS "User" (
	"id"	INTEGER NOT NULL UNIQUE,
	"surname"	TEXT NOT NULL,
	"name"	TEXT NOT NULL,
	"patronymic"	TEXT,
	"birthday"	TEXT NOT NULL,
	"gender"	TEXT NOT NULL CHECK(typeof("gender") = "text" AND length("gender") <= 9),
	"login"	TEXT NOT NULL CHECK(typeof("login") = "text" AND length("login") <= 15),
	"password"	TEXT NOT NULL CHECK(typeof("password") = "text" AND length("password") <= 12),
	"id_role"	INTEGER NOT NULL,
	FOREIGN KEY("id_role") REFERENCES "Role"("id") ON DELETE CASCADE ON UPDATE CASCADE,
	PRIMARY KEY("id" AUTOINCREMENT)
);
INSERT INTO "Brand" VALUES (1,'BMW');
INSERT INTO "Brand" VALUES (2,'Audi');
INSERT INTO "Brand" VALUES (3,'Opel');
INSERT INTO "Brand" VALUES (4,'Nissan');
INSERT INTO "Brand" VALUES (5,'Toyota');
INSERT INTO "CarСategory" VALUES (1,'Универсал');
INSERT INTO "CarСategory" VALUES (2,'Седан');
INSERT INTO "CarСategory" VALUES (3,'Хэтчбек');
INSERT INTO "CarСategory" VALUES (4,'Купе');
INSERT INTO "CarСategory" VALUES (5,'Внедорожник');
INSERT INTO "Fine" VALUES (1,'Превышение','500','Оплачен',1,1);
INSERT INTO "Fine" VALUES (2,'Разметка','500','Оплачен',3,2);
INSERT INTO "Fine" VALUES (3,'Движение','5000','Неоплачен',5,3);
INSERT INTO "Fine" VALUES (4,'ОСАГО','800','Оплачен',4,4);
INSERT INTO "Fine" VALUES (5,'Превышение','500','Неоплачен',2,5);
INSERT INTO "GIBDD" VALUES (4,'Отделение ГИБДД по России №221','ул. Смирнова 221','10:00','22:00');
INSERT INTO "GIBDD" VALUES (5,'Отделение полиции №12','ул. Пушкина 19','10:00','22:00');
INSERT INTO "GIBDD" VALUES (6,'Отделение ГИБДД №1','ул. Центральная 3','09:30','23:30');
INSERT INTO "GIBDD" VALUES (7,'Отделение ГИБДД по Костромской области №2','ул. Ленина 149','08:00','17:00');
INSERT INTO "GIBDD" VALUES (8,'Областной участок ГИБДД г. Костромы','ул. Беговая 10','10:00','00:00');
INSERT INTO "Model" VALUES (1,'RS6 ',2,1);
INSERT INTO "Model" VALUES (2,'Astra',3,3);
INSERT INTO "Model" VALUES (3,'M5 F90',1,2);
INSERT INTO "Model" VALUES (4,'Land Cruiser 300',5,5);
INSERT INTO "Model" VALUES (5,'Qashqai',4,5);
INSERT INTO "Role" VALUES (1,'Администратор');
INSERT INTO "Role" VALUES (2,'Пользователь');
INSERT INTO "Role" VALUES (3,'Гость');
INSERT INTO "Transport" VALUES (1,1,'О111ОО 44','Не в угоне','2018',2);
INSERT INTO "Transport" VALUES (2,3,'Л066АВ 44','Не в угоне','2021',1);
INSERT INTO "Transport" VALUES (3,2,'К312УА 123','Не в угоне','2009',4);
INSERT INTO "Transport" VALUES (4,4,'А123МР 797','Не в угоне','2017',3);
INSERT INTO "Transport" VALUES (5,5,'Т817РТ 31','В угоне','2015',5);
INSERT INTO "TypeFine" VALUES (1,'Превышение скорости на 20км/ч','500','30');
INSERT INTO "TypeFine" VALUES (2,'Превышение скорости на 30км/ч','500','30');
INSERT INTO "TypeFine" VALUES (3,'Нарушение правил разметки','500','45');
INSERT INTO "TypeFine" VALUES (4,'Движение с отсутствием ОСАГО','800','45');
INSERT INTO "TypeFine" VALUES (5,'Выезд/движение по полосе встречного движения','5000','45');
INSERT INTO "User" VALUES (1,'Евграфов','Дмитрий','Витальевич','19.08.2005','Мужской','HatReD','lov66forever',1);
INSERT INTO "User" VALUES (2,'Мельников','Никита','Сергеевич','18.03.2005','Мужской','Dokichan','1234qq',1);
INSERT INTO "User" VALUES (3,'Иванов','Иван','Иванович','21.09.1997','Мужской','ivanOff','ivan123',2);
INSERT INTO "User" VALUES (4,'Павлова','Элина','Михайловна','14.11.2002','Женский','elinapavlova','trpo_tech',2);
INSERT INTO "User" VALUES (5,'Андреева','Анна','Андреевна','11.05.2000','Женский','annaAndr','andr_123',3);
COMMIT;
