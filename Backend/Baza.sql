use master;
go

drop database if exists pcwebshop;
go

create database pcwebshop collate Croatian_CI_AS;
go

use pcwebshop;
go

create table kategorija(
sifra int not null primary key identity(1,1),
naziv varchar(50) not null
);

create table proizvodi(
sifra int not null primary key identity(1,1),
naziv varchar(50)not null,
cijena decimal(18,2),
kategorija int not null references kategorija(sifra)
);

create table korisnici(
sifra int not null primary key identity(1,1),
ime varchar(50)not null,
prezime varchar(50)not null,
email varchar(50),
lozinka varchar(100)
);

create table listazelja(
sifra int not null primary key identity(1,1),
naziv varchar(50),
korisnik int not null references korisnici(sifra),
placanje varchar(100)
);

create table stavke(
proizvod int not null references proizvodi(sifra),
lista int not null references listazelja(sifra)
);

insert into kategorija(naziv)
values 
-- procesori dobiva sifru broj 1 u kategorijama
('Procesori (CPU)'),
-- maticne sifra broj 2 itd
('Matične ploče (Motherboards)'),
-- 3
('Grafičke kartice (GPU)'),
-- 4
('RAM memorija (RAM)'),
-- 5
('Pohrana (SSD, HDD, NVMe)'),
-- 6
('Napajanja (PSU)'),
-- 7
('Kućišta (Cases)'),
-- 8
('Hlađenje');


insert into proizvodi(naziv,cijena,kategorija)

-- dodajem procesore 

values 
('Intel i7 9700K',200.00,1),
('AMD Ryzen 7 7800X3D', 440.00, 1),
('Intel Core i7-14700K', 380.00, 1),
('AMD Ryzen 9 7950X3D', 750.00, 1),
('Intel Core i9-14900K', 660.00, 1),
('AMD Ryzen 5 7600', 200.00, 1),
('Intel Core i5-13400F', 170.00, 1),
('AMD Ryzen 7 5800X3D', 340.00, 1),
('Intel Core i5-13600KF', 300.00, 1),
('AMD Ryzen 9 5950X',330.00,1),


-- dodajem matične ploče

('ASUS ROG Strix Z790-E Gaming WiFi',190,2),
('MSI MPG B550 Gaming Edge WiFi',220,2),
('Gigabyte AORUS X570 Master',230,2),
('ASRock B660 Steel Legend',240,2),
('ASUS TUF Gaming B450 Plus',250,2),
('MSI MAG Z690 Tomahawk WiFi',260,2),
('Gigabyte Z590 AORUS Elite',270,2),
('ASUS Prime Z690-A',280,2),
('ASRock Z590 Taichi',290,2),
('MSI MEG X570 Godlike',300,2),

-- dodajem grafičke kartice

('NVIDIA GeForce RTX 4090',100,3),
('AMD Radeon RX 7900 XTX',110,3),
('NVIDIA GeForce RTX 3080 Ti',120,3),
('AMD Radeon RX 6800 XT',130,3),
('NVIDIA GeForce GTX 1660 Super',140,3),
('AMD Radeon RX 6700 XT',150,3),
('NVIDIA GeForce RTX 3060',160,3),
('AMD Radeon RX 5600 XT',170,3),
('NVIDIA GeForce RTX 4070 Ti',180,3),
('MSI GeForce GTX 1050 Ti',180,3),

-- dodajem RAM memoriju

('Kingston Fury Beast 16GB DDR4 3200MHz', 99.00, 4),
('Corsair Vengeance LPX 16GB DDR4 3200MHz', 120, 4),
('G.SKILL Ripjaws V 16GB DDR4 3600MHz', 120, 4),
('Crucial Ballistix 16GB DDR4 3200MHz', 110, 4),
('ADATA XPG Spectrix D60G 16GB DDR4 3600MHz', 145.65, 4),
('TeamGroup T-Force Delta RGB 16GB DDR4 3200MHz', 120.75, 4),
('Patriot Viper Steel 16GB DDR4 3200MHz', 110.20, 4),
('Samsung Original 16GB DDR4 3200MHz', 119.95, 4),
('HyperX Predator 16GB DDR4 3600MHz', 99.00, 4),
('PNY XLR8 Gaming 16GB DDR4 3200MHz', 90.50, 4),

-- dodajem diskove za pohranu

('Samsung 970 EVO Plus 1TB NVMe SSD', 89.99, 5),
('WD Black SN850X 1TB NVMe SSD', 109.99, 5),
('Seagate Barracuda 2TB HDD 7200RPM', 49.99, 5),
('Crucial MX500 1TB SATA SSD', 69.95, 5),
('Kingston KC3000 1TB NVMe SSD', 94.99, 5),
('SanDisk Extreme Portable 1TB External SSD', 99.99, 5),
('Toshiba X300 4TB HDD 7200RPM', 119.00, 5),
('WD Blue SN570 1TB NVMe SSD', 59.99, 5),
('Seagate FireCuda 530 1TB NVMe SSD', 129.99, 5),
('WD Gold 12TB Enterprise HDD', 349.99, 5),


-- dodajem napajanja

('Corsair RM750e 750W 80+ Gold Modular', 84.99, 6),
('MSI MAG A850GL 850W 80+ Gold Modular', 109.99, 6),
('SilverStone ET750-HG 750W 80+ Gold Semi-Modular', 110.99, 6),
('NZXT C650 650W 80+ Bronze Semi-Modular', 94.99, 6),
('Seasonic FOCUS GM-850 850W 80+ Gold Semi-Modular', 149.99, 6),
('EVGA 600 BQ 600W 80+ Bronze Semi-Modular', 57.21, 6),
('Corsair RM1000x 1000W 80+ Gold Modular', 189.95, 6),
('Corsair HX850 850W 80+ Platinum Modular', 219.99, 6),
('Seasonic Prime TX-750 750W 80+ Titanium Modular', 239.99, 6),
('Corsair AX1600i 1600W 80+ Titanium Modular', 599.99, 6),


-- dodajem kućišta

('Corsair 7000D Airflow', 231.57, 7),
('Cooler Master NR200', 91.93, 7),
('Lian Li Lancool 205M', 73.47, 7),
('Razer Tomahawk ATX', 186.00, 7),
('MSI MAG Forge 100R', 64.17, 7),
('Thermaltake View 71', 166.47, 7),
('Montech XR Mesh', 65.10, 7),
('Fractal Design Torrent', 175.77, 7),
('Phanteks G400A', 93.00, 7),
('NZXT H5 Flow', 92.07, 7),

-- hlađenja

('Noctua NH-D15', 110.00, 8),
('DeepCool AK620', 80.00, 8),
('Cooler Master Hyper 212 Black Edition', 40.00, 8),
('be quiet! Dark Rock Pro 4', 95.00, 8),
('NZXT Kraken X63', 130.00, 8),
('Corsair iCUE H150i Elite Capellix', 170.00, 8),
('Arctic Liquid Freezer II 360', 120.00, 8),
('Thermalright Peerless Assassin 120 SE', 60.00, 8),
('DeepCool LT720', 145.00, 8),
('Noctua NH-D12L', 75.00, 8);

select * from kategorija;

insert into korisnici(ime,prezime,email,lozinka)
values 

-- dodajem korisnike i lozinke

('Ivan', 'Horvat', 'ivan.horvat@example.com', NULL),
('Ana', 'Kovačić', 'ana.kovacic@example.com', NULL),
('Marko', 'Marić', 'marko.maric@example.com', NULL),
('Lucija', 'Barišić', 'lucija.barisic@example.com', NULL),
('Petar', 'Novak', 'petar.novak@example.com', NULL),
('Marija', 'Jurić', 'marija.juric@example.com', NULL),
('Josip', 'Radić', 'josip.radic@example.com', NULL),
('Katarina', 'Bogdan', 'katarina.bogdan@example.com', NULL),
('Filip', 'Pavlović', 'filip.pavlovic@example.com', NULL),
('Matea', 'Lovrić', 'matea.lovric@example.com', NULL),
('Tomislav', 'Kralj', 'tomislav.kralj@example.com', NULL),
('Nikolina', 'Perić', 'nikolina.peric@example.com', NULL),
('Luka', 'Grgić', 'luka.grgic@example.com', NULL),
('Ivana', 'Matić', 'ivana.matic@example.com', NULL),
('Dario', 'Vidović', 'dario.vidovic@example.com', NULL),
('Sara', 'Milić', 'sara.milic@example.com', NULL),
('Matija', 'Šimić', 'matija.simic@example.com', NULL),
('Tina', 'Pavelić', 'tina.pavelic@example.com', NULL),
('Andrej', 'Krstanović', 'andrej.krstanovic@example.com', NULL),
('Martina', 'Kovač', 'martina.kovac@example.com', NULL);

-- kreiranje liste zelja korisnika 

insert into listazelja (naziv,korisnik,placanje)
values 
('Gaming Setup Ivana', 1, 'Gotovina'),
('High-End Gaming Lucije', 4, 'Kartica'),
('Budget Build Marka', 3, 'Online plaćanje'),
('Ana Setup', 2, 'Kartica'),
('Petrov Office Setup', 5, 'Gotovina'),
('Marijina Gaming Lista', 6, 'Online plaćanje'),
('Josipov Budget Build', 7, 'Gotovina'),
('Katarinin Setup', 8, 'Kartica'),
('Filipov Profesionalni PC', 9, 'Kartica'),
('Matein Radni PC', 10, 'Online plaćanje'),
('Tomislavov Gaming Rig', 11, 'Gotovina'),
('Nikolinin Minimalistički PC', 12, 'Kartica'),
('Lukin Setup za Grafiku', 13, 'Online plaćanje'),
('Ivanina Lista za Igre', 14, 'Kartica'),
('Dariov Entuzijast Build', 15, 'Gotovina'),
('Sarin Profesionalni Build', 16, 'Kartica'),
('Matijin Gaming PC', 17, 'Online plaćanje'),
('Tinin High-End Setup', 18, 'Kartica'),
('Andrejev Multimedijalni PC', 19, 'Gotovina'),
('Martinin Praktični Build', 20, 'Online plaćanje');


insert into stavke (proizvod,lista)
values
-- lista korisnika broj 1 ( Ivan )
-- ( broj artikla, broj sifra kategorije )
(1,1), -- intel i7 9700K
(21,1), -- NVIDIA GeForce RTX 4090
(11,1), -- ASUS ROG Strix Z790-E Gaming WiFi

-- Lucijina lista
(4, 2),  -- AMD Ryzen 9 7950X3D
(12, 2), -- MSI MPG B550 Gaming Edge WiFi
(21, 2), -- NVIDIA GeForce RTX 4090

-- Markova lista
(7, 3),  -- Intel Core i5-13400F
(14, 3), -- ASUS TUF Gaming B450 Plus
(25, 3), -- NVIDIA GeForce GTX 1660 Super

-- Anina lista
(8, 4),  -- AMD Ryzen 7 5800X3D
(15, 4), -- MSI MAG Z690 Tomahawk WiFi
(22, 4), -- AMD Radeon RX 7900 XTX

-- Petrova lista
(3, 5),  -- Intel Core i7-14700K
(13, 5), -- ASRock B660 Steel Legend
(20, 5), -- MSI GeForce GTX 1050 Ti

-- Josipova lista
(2, 7),  -- AMD Ryzen 7 7800X3D
(13, 7), -- MSI MEG X570 Godlike
(26, 7), -- AMD Radeon RX 6700 XT

-- Katarinina lista
(3, 8),  -- Intel Core i7-14700K
(14, 8), -- ASUS TUF Gaming B450 Plus
(27, 8), -- NVIDIA GeForce RTX 3080 Ti

-- Filipova lista
(9, 9),  -- Intel Core i5-13600KF
(16, 9), -- Gigabyte Z590 AORUS Elite
(28, 9), -- MSI GeForce GTX 1050 Ti

-- Mateina lista
(10, 10),  -- AMD Ryzen 9 5950X
(17, 10),  -- MSI MAG Z690 Tomahawk WiFi
(29, 10),  -- AMD Radeon RX 5600 XT

-- Tomislavova lista
(5, 11),  -- Intel Core i9-14900K
(12, 11),  -- ASUS Prime Z690-A
(30, 11),  -- NVIDIA GeForce RTX 4070 Ti

-- Nikolinina lista
(6, 12),  -- Intel Core i5-13400F
(18, 12),  -- ASUS Prime Z690-A
(31, 12),  -- NVIDIA GeForce GTX 1660 Super

-- Lukina lista
(11, 13), -- AMD Ryzen 7 7800X3D
(19, 13), -- Gigabyte Z590 AORUS Elite
(32, 13), -- AMD Radeon RX 7900 XTX

-- Ivanina lista
(12, 14), -- Intel Core i7-14700K
(20, 14), -- ASRock Z590 Taichi
(33, 14), -- NVIDIA GeForce RTX 3060

-- Dariova lista
(13, 15), -- Intel Core i7 9700K
(21, 15), -- MSI MAG Z690 Tomahawk WiFi
(34, 15), -- AMD Radeon RX 6800 XT

-- Sarina lista
(14, 16), -- Intel Core i9-14900K
(22, 16), -- Gigabyte AORUS X570 Master
(35, 16), -- NVIDIA GeForce GTX 1050 Ti

-- Matijina lista
(15, 17), -- AMD Ryzen 5 7600
(23, 17), -- ASUS Prime Z690-A
(36, 17), -- NVIDIA GeForce RTX 4070 Ti

-- Tinina lista
(16, 18), -- Intel Core i5-13600KF
(24, 18), -- MSI MEG X570 Godlike
(37, 18), -- NVIDIA GeForce RTX 4090

-- Andrejeva lista
(17, 19), -- AMD Ryzen 9 7950X3D
(25, 19), -- ASUS ROG Strix Z790-E Gaming WiFi
(38, 19), -- AMD Radeon RX 6700 XT

-- Martinina lista
(18, 20), -- Intel Core i7-14700K
(26, 20), -- Gigabyte Z590 AORUS Elite
(39, 20); -- MSI GeForce GTX 1050 Ti
