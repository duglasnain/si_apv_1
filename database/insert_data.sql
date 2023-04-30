USE College;

INSERT INTO Discipline
VALUES	('Matematica'),
		('Fizica'),
		('Limba romana'),
		('Chimie'),
		('Biologie'),
		('Limba franceza'),
		('Limba engleza'),
		('Informatica'),
		('Geografie'),
		('Istorie'),
		('Educatie fizica'),
		('Educatie pentru societate');

INSERT INTO Specialitate
VALUES	('Contabilitate'),
		('Impozite si percepere fiscala'),
		('Finante si asigurari'),
		('Finante si banci'),
		('Planificarea si administrarea afacerilor'),
		('Administrarea aplicatiilor web'),
		('Programarea si analiza produselor program');

GO
INSERT INTO Grupe(nume_grupa, id_specialitate, nr_sectie)
VALUES('CON1901G', 1, 3),('CON1902G', 1, 3),
('CON1903G', 1, 3),('CON1904G', 1, 3),('IPF1905G', 2, 3),('FA1906G', 3, 3),('FA1907G', 3, 3),('FA1908G', 3, 3),
('FB1909G', 4, 3),('PAA1910G', 5, 3),('PAA1911G', 5, 3),('AAW1912G', 6, 3),('PAP1913G', 7, 3),('CON2001G', 1, 2),
('CON2002G', 1, 2),('CON2003G', 1, 2),('CON2004G', 1, 2),('IPF2005G', 2, 2),('FA2006G', 3, 2),('FA2007G', 3, 2),
('FA2008G', 3, 2),('FB2009G', 4, 2),('PAA2010G', 5, 2),('PAA2011G', 5, 2),('AAW2012G', 6, 2),('PAP2013G', 7, 2),
('CON2101G', 1, 1),('CON2102G', 1, 1),('CON2103G', 1, 1),('CON2104G', 1, 1),('IPF2105G', 2, 1),('FA2106G', 3, 1),
('FA2107G', 3, 1),('FA2108G', 3, 1),('FB2109G', 4, 1),('PAA2110G', 5, 1),('PAA2111G', 5, 1),('AAW2112G', 6, 1),
('PAP2113G', 7, 1);

INSERT INTO Catedre
VALUES	('Contabilitate si analiza economica'),
		('Finante'),
		('Administrarea afacerilor'),
		('Informatica'),
		('Matematica si fizica'),
		('Limba si comunicare'),
		('Stiinte socio-umane');

		 --matem --matem
		   --rom --rom
		    --l str --l str
			 --fiz --fiz1
			 --chim--bio
			  --info --info
			   --ist
			   --afaceri --afaceri --afaceri
			    --contab --contab --contab --contab
				 --ed per societate
INSERT INTO Angajati
VALUES	('Basiul', 'Anatolie', '1969/6/9', '9009573396896', 'M', 'basiulTop@ceef.md', 696969),
		('Cazacu', 'Doina', '2002/10/15', '9033439079155', 'M', 'numePrenume@gmail.com', 696969),
		('Tofanu', 'Neli', '1900/3/5', '9059408686907', 'F', 'neLidotcom@gmail.com', 12000),
		('Pinch', 'George', '2001/11/9', '9046610119701', 'M', 'Washington@ceef.md', 12000),
		('Zagnat', 'Tiranida', '1704/2/15', '9071288343436', 'F', 'oracle@gmail.com', 12000),
		('Young-Gi', 'Ilari', '1943/01/01', '1289086102993', 'M', 'rekina8790@meidecn.com', 12000),
		('Kai', 'Ottilia', '1943/12/06', '6212518916702', 'F', 'luka110@eliotkids.com', 10000),
		('Tarqik', 'Julianne', '1943/12/08', '2199114429478', 'F', 'commi@getcashstash.com', 10000),
		('Adelaida', 'Victoria', '1946/06/21', '8767341218784', 'F', 'eduardodib@4funpedia.com', 10000),
		('Dalca', 'Inessa', '1953/01/01', '4322689642267', 'F', 'dip44sale@ogvoice.com', 10000),
		('Lenin', 'Djuro', '1953/03/10', '7202756329764', 'M', 'nnnaatttaa@ashbge.online', 20000),
		('Alekseev', 'Filip', '1953/09/01', '4039774625184', 'M', 'lilyjin@getcashstash.com', 20000),
		('Baran', 'Loredana', '1955/11/06', '0910203563035', 'F', 'crashoh6@emvil.com', 10000),
		('Orlov', 'Roksolana', '1957/12/13', '4717637801467', 'F', 'alievaalbina@mobilebankapp.org', 10000),
		('Iliescu', 'Darya', '1963/05/31', '6838826234180', 'F', 'kuwa@otpku.com', 20000),
		('Ungur', 'Martyn', '1968/06/03', '5010143043681', 'M', 'lamesa652@ytgoogle.com', 20000),
		('Holub', 'Rareș', '1971/07/01', '3906061511577', 'M', 'promoego@dexamail.com', 20000),
		('Gheorghe', 'Delia', '1992/09/04', '7293447635091', 'F', 'sbc1996pn@4funpedia.com', 20000),
		('Petran', 'Sabina', '1993/05/30', '4954555965044', 'F', 'lifokuei@btcmod.com', 20000),
		('Sala', 'Eugenia', '1994/07/21', '1096778507187', 'F', 'gena94gena@4funpedia.com', 20000),
		('Lupei', 'Iacob', '1987/01/28', '9183711401323', 'M', 'eromylt@bebekurap.xyz', 20000),
		('Dumitru', 'Marina', '1968/06/03', '3707493434280', 'F', 'lyudickl@mobilebankapp.org', 3000);

INSERT INTO Cabinete
VALUES	(101, 1),(102, 2),(103, 3),(104, null),(105, null),(106, null),(107, null),(108, null),(109, 4),(110, null),(111, null),(112, null),(113, null),(114, null),(115, null),(116, null),(117, null),(118, 22),(119, null),
		(201, null),(202, null),(203, 5),(204, 6),(205, null),(206, null),(207, 7),(208, null),(209, null),(210, 8),(211, null),(212, null),(213,9),(214, null),(215, null),(216, 21),(217, null),(218, null),(219, null),
		(301, null),(302, null),(303, null),(304, 19),(305, null),(306, null),(307, 18),(308, null),(309, null),(310, null),(311, null),(312, null),(313, null),(314, null),(315, 10),(316, 20),(317, null),(318, null),(319, null),
		(401, null),(402, 16),(403, 17),(404, 15),(405, null),(406, null),(407, 14),(408, null),(409, null),(410, 13),(411, null),(412, null),(413, null),(414, 12),(415, 11),(416, null),(417, null),(418, null),(419, null);

INSERT INTO Elevi
VALUES	('Negrescu', 'Elena', 'F', 1), ('Isaev', 'Lioubov', 'F', 1), ('Dumitrescu', 'Elena', 'F', 1),
		('Ignatiev', 'Mirela', 'F', 2), ('Stoica', 'Yesfir', 'F', 2), ('Cojocari', 'Elvira', 'F', 2),
		('Stan', 'Anghelina', 'F', 3), ('Rusu', 'Tatiana', 'F', 3), ('Daniel', 'Daria', 'F', 3),
		('Rusu', 'Noemi', 'F', 4), ('Rusu', 'Isabella', 'F', 4), ('Rusu', 'Daniel', 'M', 4),
		('Rusu', 'Irina', 'F', 5), ('Alexandrescu', 'Ion', 'M', 5), ('Negrescu', 'Constantin', 'M', 5),
		('Ignatiev', 'Mirela', 'F', 6), ('Bălan', 'Daria', 'F', 6), ('Lupu', 'Albert', 'M', 6),
		('Albu', 'Viorela', 'F', 7), ('Dumitrescu', 'Cristiana', 'M', 7), ('Ceban', 'Alexandr', 'M', 7),
		('Dumitrescu', 'Luminița', 'F', 8), ('Bălan', 'Natalia', 'F', 8), ('Rusu', 'Petru', 'M', 8),
		('Filippov', 'Emilia', 'F', 9), ('Grigorescu', 'Nicolae', 'M', 9), ('Cojocaru', 'Denis', 'M', 9),
		('Sala', 'Cornelia', 'F', 10), ('Petran', 'Daniel', 'M', 10), ('Popescu', 'Dionisie', 'M', 10),
		('Cojocari', 'Cristiana', 'F', 11), ('Negrescu', 'Tudor', 'M', 11), ('Cojocaru', 'Nicolae', 'M', 11),
		('Radu', 'Simion', 'M', 12), ('Răzvan', 'Luca', 'M', 12), ('Adam', 'Marin', 'M', 12),
		('Rusu', 'Radu', 'M', 13), ('Lazarescu', 'Martin', 'M', 13), ('Russu', 'Corneliu', 'M', 13),
		('Ionesco', 'Corina', 'F', 14), ('Dumitrescu', 'Ekaterina', 'F', 14), ('Nicolescu', 'Lorena', 'F', 14),
		('Lupei', 'Loredana', 'F', 15), ('Lungu', 'Gavrila', 'F', 15), ('Tofan', 'Iulia', 'F', 15),
		('Ignatiev', 'Ecaterina', 'F', 16), ('Lupu', 'Livia', 'F', 16), ('Naumov', 'Yuliya', 'F', 16),
		('Cojocaru', 'Iulia', 'F', 17), ('Nani', 'Cristiana', 'F', 17), ('Stan', 'Cristiana', 'F', 17),
		('Blanari', 'Sofia', 'F', 18), ('Dalca', 'Isabella', 'F', 18), ('Filippov', 'Romulus', 'M', 18),
		('Albescu', 'Cristiana', 'F', 19), ('Rusu', 'Viorela', 'F', 19), ('Rusu', 'Sebastian', 'M', 19),
		('Rusu', 'Clara', 'F', 20), ('Stoica', 'Nicoleta', 'F', 20), ('Rusu', 'Marcel', 'M', 20),
		('Ignatiev', 'Marcela', 'F', 21), ('Ungur', 'Daniel', 'M', 21), ('Namolovan', 'Radu', 'M', 21),
		('Kovalchuk', 'Irina', 'F', 22), ('Ionescu', 'Loredana', 'F', 22), ('Popovici', 'Marin', 'M', 22),
		('Ignatiev', 'Tatiana', 'F', 23), ('Volvei', 'Sofia', 'F', 23), ('Blanaru', 'Cristian', 'M', 23),
		('Negrescu', 'Nicolae', 'M', 24), ('Lungu', 'Radu', 'M', 24), ('Sokolovsky', 'Albert', 'M', 24),
		('Ceban', 'Cristiana', 'F', 25), ('Grigorescu', 'Daniel', 'M', 25), ('Dalca', 'Marin', 'M', 25),
		('Kozlov', 'Daciana', 'F', 26), ('Lupei', 'Ekaterina', 'F', 26), ('Ignatiev', 'Cristiana', 'F', 26),
		('Constantinescu', 'Cristiana', 'F', 27), ('Blanari', 'Ruxandra', 'F', 27), ('Negrescu', 'Marcela', 'F', 27),
		('Kovalev', 'Rozalia', 'F', 28), ('Albescu', 'Tatiana', 'F', 28), ('Fodorcea', 'Cristiana', 'F', 28),
		('Rusu', 'Daria', 'F', 29), ('Aglaya', 'Renata', 'F', 29), ('Popa', 'Loredana', 'F', 29),
		('Rusu', 'Cristiana', 'F', 30), ('Cojocaru', 'Lucian', 'M', 30), ('Bogomolov', 'Cristiana', 'F', 30),
		('Ardelean', 'Viorela', 'F', 31), ('Andreev', 'Gheorghe', 'M', 31), ('Lesnic', 'Petru', 'M', 31),
		('Urechi', 'Cristiana', 'F', 32), ('Dumitrescu', 'Daria', 'F', 32), ('Pogomi', 'Radu', 'M', 32),
		('Cojocaru', 'Mirela', 'F', 33), ('Badragan', 'Isabella', 'F', 33), ('Vasilyev', 'Daniel', 'M', 33),
		('Antonescu', 'Anastasia', 'F', 34), ('Eremei', 'Adriana', 'F', 34), ('Rusu', 'David', 'M', 34),
		('Negrescu', 'Mirela', 'F', 35), ('Dumitrescu', 'Mirela', 'F', 35), ('Amborici', 'Albert', 'M', 35),
		('Popa', 'Cristiana', 'F', 36), ('Rusu', 'Irina', 'F', 36), ('Popa', 'Calin', 'M', 36),
		('Shwetz', 'Livia', 'F', 37), ('Ceban', 'Marin', 'M', 37), ('Rusu', 'Albert', 'M', 37),
		('Radu', 'Elena', 'F', 38), ('Balan', 'Dan', 'M', 38), ('Rusu', 'Marin', 'M', 38),
		('Andreev', 'Petru', 'M', 39), ('Grigorescu', 'Gheorghe', 'M', 39), ('Dumitrescu', 'Radu', 'M', 39);
		

Select * from Specialitate;
Select * from Catedre;
Select * from Discipline;
Select * from Angajati;
Select * from Grupe;
Select * from Cabinete;
Select * from Elevi;

Select * from Prof_disc_grupa;
Select * from Profesori_Catedre;


DELETE Discipline;
DELETE Grupe;
Delete Catedre;
DELETE Specialitate;
DELETE Discipline;
DELETE Grupe;
DELETE Prof_disc_grupa;
DELETE Profesori_Catedre;
DELETE Angajati;

DROP TABLE Prof_disc_grupa;
DROP TABLE Profesori_Catedre;
DROP TABLE Discipline;
DROP TABLE Catedre;
DROP TABLE Cabinete;
DROP TABLE Angajati;
DROP TABLE Elevi;
DROP TABLE Grupe;
DROP TABLE Specialitate;