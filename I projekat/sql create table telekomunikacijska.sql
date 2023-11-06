CREATE TABLE Broj_Telefona(
    id INTEGER NOT NULL PRIMARY KEY,
    potroseni_minuti INTEGER NOT NULL,
    telefonija INTEGER NOT NULL,
    FOREIGN KEY (telefonija) REFERENCES Telefonija(id_usluge)
);

CREATE TABLE Uredjaj(
    serijski_broj INTEGER NOT NULL PRIMARY KEY,
    proizvodjac VARCHAR(30) NOT NULL,
    datum_pocetka_upotrebe DATE,
    razlog_poslednjeg_servisa VARCHAR(80) NOT NULL,
    tip_uredjaja varchar(20) NOT NULL 
);

CREATE TABLE Glavna_stanica(
    serijski_broj_uredjaja INTEGER PRIMARY KEY REFERENCES Uredjaj(serijski_broj),
    Flag_Hub NUMBER(1) NOT NULL CONSTRAINT flag_hub_check CHECK(Flag_Hub=1 or Flag_Hub=0), 
    hub_glavna_stanica INTEGER NOT NULL,
    region VARCHAR(20),
    FOREIGN KEY (hub_glavna_stanica) REFERENCES Glavna_stanica(serijski_broj_uredjaja)
);

CREATE TABLE Komunikacioni_cvor(
    serijski_broj_uredjaja INTEGER PRIMARY KEY REFERENCES Uredjaj(serijski_broj),
    opis VARCHAR(30),
    broj_lokacije INTEGER NOT NULL,
    adresa VARCHAR(13) NOT NULL,
    glavna_stanica_kom_cvora INTEGER NOT NULL,
    FOREIGN KEY (glavna_stanica_kom_cvora) REFERENCES Glavna_stanica(serijski_broj_uredjaja)
);

CREATE TABLE Korisnik(
    JMBG DECIMAL(13,0) NOT NULL PRIMARY KEY,
    ime VARCHAR(15) NOT NULL,
    prezime VARCHAR(20) NOT NULL,
    adresa VARCHAR(20) NOT NULL,
    broj VARCHAR(10) NOT NULL,
    grad VARCHAR(15) NOT NULL,
    tip_korisnika VARCHAR(12) NOT NULL,
    kom_cvor INTEGER NOT NULL,
    FOREIGN KEY (kom_cvor) REFERENCES Komunikacioni_cvor(serijski_broj_uredjaja)
);

CREATE TABLE Pravna_lica(
    JMBG DECIMAL(13,0) PRIMARY KEY REFERENCES Korisnik(JMBG),
    ime_kontakt_osobe VARCHAR(15) NOT NULL,
    broj_faksa INTEGER,
    poreski_identifikacioni_broj INTEGER NOT NULL
);

CREATE TABLE Fizicka_lica(
    JMBG DECIMAL(13,0) PRIMARY KEY REFERENCES Korisnik(JMBG)
);

CREATE TABLE Usluga(
    id INTEGER NOT NULL PRIMARY KEY,
    tip_usluge VARCHAR(11) NOT NULL
);

CREATE TABLE Telefonija(
    id_usluge INTEGER PRIMARY KEY REFERENCES Usluga(id)
);

CREATE TABLE Televizija(
    id_usluge INTEGER PRIMARY KEY REFERENCES Usluga(id)
);

CREATE TABLE Internet(
    id_usluge INTEGER PRIMARY KEY REFERENCES Usluga(id),
    tip_interneta VARCHAR(8) NOT NULL,
    flag_prepaid NUMBER(1) NOT NULL CONSTRAINT flag_prepaid_check CHECK(flag_prepaid=1 or flag_prepaid=0),
    datum_poslednje_uplate DATE,
    stanje_racuna INTEGER,
    flag_postpaid NUMBER(1) NOT NULL CONSTRAINT flag_postpaid_check CHECK(flag_postpaid=1 or flag_postpaid=0),
    placanje_interneta INTEGER NOT NULL,
    FOREIGN KEY (placanje_interneta) REFERENCES Placanje(id)
);

CREATE TABLE Placanje(
    id INTEGER NOT NULL PRIMARY KEY,
    tip_placanja VARCHAR(18) NOT NULL
);

CREATE TABLE Ostvaren_protok(
    id_placanja INTEGER NOT NULL PRIMARY KEY REFERENCES Placanje(id)
);

CREATE TABLE Flat_rate(
    id_placanja INTEGER NOT NULL PRIMARY KEY REFERENCES Placanje(id)
);

CREATE TABLE Koristi(
    JMBG_korisnika INTEGER NOT NULL,
    id_usluge INTEGER,
    FOREIGN KEY (JMBG_korisnika) REFERENCES Korisnik(JMBG),
    FOREIGN KEY (id_usluge) REFERENCES Usluga(id)
);

CREATE TABLE Telefon(
    JMBG_korisnika INTEGER NOT NULL,
    telefon INTEGER NOT NULL,
    PRIMARY KEY(JMBG_korisnika, telefon)
);

CREATE TABLE Dodatni_paket_kanala(
    televizija INTEGER NOT NULL,
    dodatni_paket_kanala VARCHAR(20) NOT NULL,
    PRIMARY KEY (televizija, dodatni_paket_kanala)
);

CREATE TABLE Staticka_adresa(
    flat_rate INTEGER NOT NULL,
    staticka_adresa VARCHAR(13) NOT NULL,
    PRIMARY KEY (flat_rate, staticka_adresa)
);


