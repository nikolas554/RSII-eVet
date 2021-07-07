using eVet.WebAPI.Helpers;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace eVet.WebAPI.Database
{
    public partial class VeterinarskaStanicaContext
    {
        partial void OnModelCreatingPartial(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Lijekovi>().HasData(new Database.Lijekovi()
            {

                LijekId = 1,
                Naziv = "Amoksiciliin",
                Cijena = 22

            });
            modelBuilder.Entity<Lijekovi>().HasData(new Database.Lijekovi()
            {

                LijekId = 2,
                Naziv = "Eritromicin",
                Cijena = 15

            });
            modelBuilder.Entity<Lijekovi>().HasData(new Database.Lijekovi()
            {

                LijekId = 3,
                Naziv = "Ablacin",
                Cijena = 23

            });

            modelBuilder.Entity<Lijekovi>().HasData(new Database.Lijekovi()
            {

                LijekId = 4,
                Cijena = 28,
                Naziv = "Cormicin"

            });


            modelBuilder.Entity<Lijekovi>().HasData(new Database.Lijekovi()
            {

                LijekId = 5,
                Cijena = 33,
                Naziv = "Repen"

            });



            modelBuilder.Entity<Dijagnoza>().HasData(new Database.Dijagnoza()
            {

                DijagnozaId = 1,
                Naziv = "Gastritis"


            });
            modelBuilder.Entity<Dijagnoza>().HasData(new Database.Dijagnoza()
            {

                DijagnozaId = 2,
                Naziv = "Tajlerioza"


            });
            modelBuilder.Entity<Dijagnoza>().HasData(new Database.Dijagnoza()
            {

                DijagnozaId = 3,
                Naziv = "Artritis"


            });
            modelBuilder.Entity<Dijagnoza>().HasData(new Database.Dijagnoza()
            {

                DijagnozaId = 4,
                Naziv = "Bronhitis"


            });
            modelBuilder.Entity<Dijagnoza>().HasData(new Database.Dijagnoza()
            {

                DijagnozaId = 5,
                Naziv = "Boginje"


            });
            modelBuilder.Entity<Dijagnoza>().HasData(new Database.Dijagnoza()
            {

                DijagnozaId = 6,
                Naziv = "Tuberkuloza"


            });
            modelBuilder.Entity<Dijagnoza>().HasData(new Database.Dijagnoza()
            {

                DijagnozaId = 7,
                Naziv = "Mikroplazmoza"


            });
            Korisnik a1 = new Korisnik()
            {
                KorisnikId = 1,
                Ime = "Desktop",
                Prezime = "Korisnik",
                Mobilni = "061-222-333",
                DatumRodjenja = new DateTime(1994, 05, 23),
                Adresa = "Adresa BB",
                KorisnickoIme = "desktop",
                Status = true

            };
            a1.LozinkaSalt = HashGenerator.GenerateSalt();
            a1.LozinkaHash = HashGenerator.GenerateHash(a1.LozinkaSalt, "test");
            modelBuilder.Entity<Korisnik>().HasData(a1);


            Korisnik a2 = new Korisnik()
            {
                KorisnikId = 2,
                Ime = "Veterinar",
                Prezime = "Korisnik",
                Mobilni = "061-111-222",
                DatumRodjenja = new DateTime(1993, 12, 12),
                Adresa = "Adresa BB",
                KorisnickoIme = "veterinar",
                Status = true
            };
            a2.LozinkaSalt = HashGenerator.GenerateSalt();
            a2.LozinkaHash = HashGenerator.GenerateHash(a2.LozinkaSalt, "test");
            modelBuilder.Entity<Korisnik>().HasData(a2);



            Korisnik a3 = new Korisnik()
            {
                KorisnikId = 3,
                Ime = "Veterinar1",
                Prezime = "Korisnik1",
                Mobilni = "061-111-333",
                DatumRodjenja = new DateTime(1996, 01, 07),
                Adresa = "Adresa BB",
                KorisnickoIme = "veterinar1",
                Status = true

            };
            a3.LozinkaSalt = HashGenerator.GenerateSalt();
            a3.LozinkaHash = HashGenerator.GenerateHash(a3.LozinkaSalt, "test");
            modelBuilder.Entity<Korisnik>().HasData(a3);


            Korisnik a4 = new Korisnik()
            {
                KorisnikId = 4,
                Ime = "Veterinar2",
                Prezime = "Korisnik2",
                Mobilni = "061-333-444",
                DatumRodjenja = new DateTime(1996, 04, 07),
                Adresa = "Adresa BB",
                KorisnickoIme = "veterinar2",
                Status = true

            };
            a4.LozinkaSalt = HashGenerator.GenerateSalt();
            a4.LozinkaHash = HashGenerator.GenerateHash(a4.LozinkaSalt, "test");
            modelBuilder.Entity<Korisnik>().HasData(a4);

            Korisnik a5 = new Korisnik()
            {
                KorisnikId = 5,
                Ime = "Veterinar3",
                Prezime = "Korisnik3",
                Mobilni = "061-444-555",
                DatumRodjenja = new DateTime(1989, 04, 07),
                Adresa = "Adresa BB",
                KorisnickoIme = "veterinar3",
                Status = true

            };
            a5.LozinkaSalt = HashGenerator.GenerateSalt();
            a5.LozinkaHash = HashGenerator.GenerateHash(a5.LozinkaSalt, "test");
            modelBuilder.Entity<Korisnik>().HasData(a5);

            Korisnik a6 = new Korisnik()
            {
                KorisnikId = 6,
                Ime = "Mobile",
                Prezime = "Korisnik",
                Mobilni = "061-555-666",
                DatumRodjenja = new DateTime(1989, 11, 07),
                Adresa = "Adresa BB",
                KorisnickoIme = "mobile",
                Status = true,
                Slika = File.ReadAllBytes("Img/mobile.png")
            };
            a6.LozinkaSalt = HashGenerator.GenerateSalt();
            a6.LozinkaHash = HashGenerator.GenerateHash(a6.LozinkaSalt, "test");
            modelBuilder.Entity<Korisnik>().HasData(a6);





            Korisnik a7 = new Korisnik()
            {
                KorisnikId = 7,
                Ime = "Mobile1",
                Prezime = "Korisnik1",
                Mobilni = "061-666-777",
                DatumRodjenja = new DateTime(1991, 11, 07),
                Adresa = "Adresa BB",
                KorisnickoIme = "mobile1",
                Status = true,
                Slika = File.ReadAllBytes("Img/mobile1.png")

            };
            a7.LozinkaSalt = HashGenerator.GenerateSalt();
            a7.LozinkaHash = HashGenerator.GenerateHash(a7.LozinkaSalt, "test");
            modelBuilder.Entity<Korisnik>().HasData(a7);



            Korisnik a8 = new Korisnik()
            {
                KorisnikId = 8,
                Ime = "Mobile2",
                Prezime = "Korisnik2",
                Mobilni = "061-777-888",
                DatumRodjenja = new DateTime(1991, 05, 07),
                Adresa = "Adresa BB",
                KorisnickoIme = "mobile2",
                Status = true,
                Slika = File.ReadAllBytes("Img/mobile2.png")

            };
            a8.LozinkaSalt = HashGenerator.GenerateSalt();
            a8.LozinkaHash = HashGenerator.GenerateHash(a8.LozinkaSalt, "test");
            modelBuilder.Entity<Korisnik>().HasData(a8);



            Korisnik a9 = new Korisnik()
            {
                KorisnikId = 9,
                Ime = "Mobile3",
                Prezime = "Korisnik3",
                Mobilni = "061-888-999",
                DatumRodjenja = new DateTime(1991, 05, 01),
                Adresa = "Adresa BB",
                KorisnickoIme = "mobile3",
                Status = true

            };
            a9.LozinkaSalt = HashGenerator.GenerateSalt();
            a9.LozinkaHash = HashGenerator.GenerateHash(a9.LozinkaSalt, "test");
            modelBuilder.Entity<Korisnik>().HasData(a9);



            Uloge ul1 = new Uloge()
            {
                UlogaId = 1,
                Naziv = "Administrator"
            };
            modelBuilder.Entity<Uloge>().HasData(ul1);
            Uloge ul2 = new Uloge()
            {
                UlogaId = 2,
                Naziv = "Veterinar"
            };

            modelBuilder.Entity<Uloge>().HasData(ul2);

            KorisniciUloge ku1 = new KorisniciUloge()
            {
                KorisnikUlogaId = 1,
                KorisnikId = 1,
                UlogaId = 1,
                DatumIzmjene=DateTime.Now
            };

            modelBuilder.Entity<KorisniciUloge>().HasData(ku1);

            KorisniciUloge ku2 = new KorisniciUloge()
            {
                KorisnikUlogaId = 2,
                KorisnikId = 2,
                UlogaId = 2,
                DatumIzmjene=DateTime.Now
            };

            modelBuilder.Entity<KorisniciUloge>().HasData(ku2);


            KorisniciUloge ku3 = new KorisniciUloge()
            {
                KorisnikUlogaId = 3,
                KorisnikId = 3,
                UlogaId = 2,
                DatumIzmjene=DateTime.Now
            };

            modelBuilder.Entity<KorisniciUloge>().HasData(ku3);


            KorisniciUloge ku4 = new KorisniciUloge()
            {
                KorisnikUlogaId = 4,
                KorisnikId = 4,
                UlogaId = 2,
                DatumIzmjene=DateTime.Now
            };

            modelBuilder.Entity<KorisniciUloge>().HasData(ku4);

            Ljubimac lj1 = new Ljubimac()
            {
                LjubimacId = 1,
                DatumRodjenja = new DateTime(2005, 09, 09),
                Boja = "Žuta",
                Ime = "Bella",
                Mikrocip = "9001330000382",
                Rasa = "Zlatni retriver",
                Slika = File.ReadAllBytes("Img/Bella.png"),
                KorisnikId = 6



            };
            modelBuilder.Entity<Ljubimac>().HasData(lj1);



            Ljubimac lj2 = new Ljubimac()
            {
                LjubimacId = 2,
                DatumRodjenja = new DateTime(2009, 04, 05),
                Boja = "Žuta",
                Ime = "Harley",
                Mikrocip = "9001312300382",
                Rasa = "Nemački ovčar",
                Slika = File.ReadAllBytes("Img/Harley.jpg"),
                KorisnikId = 6



            };

            modelBuilder.Entity<Ljubimac>().HasData(lj2);


            Ljubimac lj3 = new Ljubimac()
            {
                LjubimacId = 3,
                DatumRodjenja = new DateTime(2015, 02, 05),
                Boja = "Siva",
                Ime = "Dona",
                Mikrocip = "900131231232",
                Rasa = "Ruska plava",
                Slika = File.ReadAllBytes("Img/Dona.jpg"),
                KorisnikId = 7



            };

            modelBuilder.Entity<Ljubimac>().HasData(lj3);





            Ljubimac lj4 = new Ljubimac()
            {
                LjubimacId = 4,
                DatumRodjenja = new DateTime(2017, 02, 05),
                Boja = "Siva",
                Ime = "Dea",
                Mikrocip = "900131231232",
                Rasa = "Britanska kratkodlaka",
                Slika = File.ReadAllBytes("Img/Dea.jpg"),
                KorisnikId = 8



            };

            modelBuilder.Entity<Ljubimac>().HasData(lj4);




            Ljubimac lj5 = new Ljubimac()
            {
                LjubimacId = 5,
                DatumRodjenja = new DateTime(2017, 02, 05),
                Boja = "Siva",
                Ime = "Dea",
                Mikrocip = "900138881232",
                Rasa = "Šarplaninac",
                Slika = File.ReadAllBytes("Img/Dora.jpg"),
                KorisnikId = 9



            };

            modelBuilder.Entity<Ljubimac>().HasData(lj5);



            VrstaUsluge vu1 = new VrstaUsluge()
            {
                VrstaUslugeId = 1,
                Naziv = "Specijalistički pregled",
                Opis = "Vršimo specijalističke preglede oka, uha, kože te svih unutrašnjih organa u svrhu otkrivanja ranih metaboličkih bolesti. Pregledi se izvode sa puno iskustva i najsavremenijom opremom",
                Cijena = 21
            };
            modelBuilder.Entity<VrstaUsluge>().HasData(vu1);

            VrstaUsluge vu2 = new VrstaUsluge()
            {
                VrstaUslugeId = 2,
                Naziv = "Vakcinacija",
                Opis = "Vakcinacija podrazumijeva pravovremenu zaštitu životinje od virusnih i bakterijskih oboljenja. Bez adekvatne preventive liječenje može da bude dugotrajno i skupo, a često i veoma neizvjesno. Zakažite termin, informišite se blagovremeno i pratite datume vakcinacija.",
                Cijena = 40
            };
            modelBuilder.Entity<VrstaUsluge>().HasData(vu2);


            VrstaUsluge vu3 = new VrstaUsluge()
            {
                VrstaUslugeId = 3,
                Naziv = "Ultrazvuk",
                Opis = "Ultrazvučna dijagnostika je neinvazivna, izrazito informativna metoda koja omogućava tačan uvid u strukturu organa životinja. Tehnika pregleda se zasniva na zvučnim talasima visoke frekvence koji prolaze kroz tkiva i organe, odbijaju se različitim brzinama, vraćaju se ka sondi i vizuelizuju na ekranu.",
                Cijena = 30
            };
            modelBuilder.Entity<VrstaUsluge>().HasData(vu3);



            VrstaUsluge vu4 = new VrstaUsluge()
            {
                VrstaUslugeId = 4,
                Naziv = "Laboratorija",
                Opis = "Informacije koje nam pružaju laboratorijski rezultati, kao i njihova tačna interpretacija, su dragocjene jer pomažu otkrivanju procesa u organizmu koji su u početnoj fazi te se na taj način mogu brže i lakše sanirati",
                Cijena = 50
            };
            modelBuilder.Entity<VrstaUsluge>().HasData(vu4);


            VrstaUsluge vu5 = new VrstaUsluge()
            {
                VrstaUslugeId = 5,
                Naziv = "Stomatološki pregled",
                Opis = "Vrlo je bitno voditi računa o stanju zuba vašeg ljubimca. Nudimo uskuge skidanja kamenca, popravke, te vađenje zuba",
                Cijena = 30
            };
            modelBuilder.Entity<VrstaUsluge>().HasData(vu5);

            Termini t1 = new Termini()
            {
                TerminId = 1,
                Naziv = "bilo kada"
            };
            modelBuilder.Entity<Termini>().HasData(t1);


            Termini t2 = new Termini()
            {
                TerminId = 2,
                Naziv = "rano ujutro"
            };
            modelBuilder.Entity<Termini>().HasData(t2);


            Termini t3 = new Termini()
            {
                TerminId = 3,
                Naziv = "kasno ujutro"
            };
            modelBuilder.Entity<Termini>().HasData(t3);


            Termini t4 = new Termini()
            {
                TerminId = 4,
                Naziv = "rano popodne"
            };
            modelBuilder.Entity<Termini>().HasData(t4);




            Termini t5 = new Termini()
            {
                TerminId = 5,
                Naziv = "kasno popodne"
            };
            modelBuilder.Entity<Termini>().HasData(t5);

     
            Rezervacije rez1 = new Rezervacije()
            {
                RezervacijaId = 1,
                Datum = new DateTime(2021, 04, 04),
                LjubimacId = 1,
                Odgovor = "Rezervacija je uspješno prihvaćena",
                Prihvacena = true,
                TerminId = 1,
                VrstaUslugeId = 1

            };
            modelBuilder.Entity<Rezervacije>().HasData(rez1);

            Pregled p1 = new Pregled()
            {
                PregledId = 1,
                Datum = new DateTime(2021, 04, 04, 14,14,12),
                LjubimacId = 1,
                VrstaUslugeId = 1,
                KorisnikId = 2,
                Napomena = "Kontrola za godinu dana",
                Popust = 0

            };

            modelBuilder.Entity<Pregled>().HasData(p1);


            LijekoviPregled lp1 = new LijekoviPregled()
            {
                LijekoviPregledId=1,
                PregledId=1,
                LijekId=1
            };
            modelBuilder.Entity<LijekoviPregled>().HasData(lp1);



            LijekoviPregled lp2 = new LijekoviPregled()
            {
                LijekoviPregledId = 2,
                PregledId = 1,
                LijekId = 2
            };
            modelBuilder.Entity<LijekoviPregled>().HasData(lp2);

            Ustanovljena u1 = new Ustanovljena()
            {
                PregledId = 1,
                DijagnozaId = 1
            };
            modelBuilder.Entity<Ustanovljena>().HasData(u1);

            Racun rac1 = new Racun()
            {
                RacunId = 1,
                DatumIzdavanja = new DateTime(2021, 04, 04, 14, 14, 12),
                IsPlacen = true,
                Iznos = 21,
                PregledId = 1
            };

            modelBuilder.Entity<Racun>().HasData(rac1);








            Rezervacije rez2 = new Rezervacije()
            {
                RezervacijaId = 2,
                Datum = new DateTime(2021, 05, 05,11,11,12),
                LjubimacId = 1,
                Odgovor = "Rezervacija je uspješno prihvaćena",
                Prihvacena = true,
                TerminId = 3,
                VrstaUslugeId = 2

            };
            modelBuilder.Entity<Rezervacije>().HasData(rez2);

            Pregled p2 = new Pregled()
            {
                PregledId = 2,
                Datum = new DateTime(2021, 05, 05,11,11,12),
                LjubimacId = 1,
                VrstaUslugeId = 2,
                KorisnikId = 3,
                Napomena = "Vakcinacija protiv bjesnila obavljena. Vakcinaciju ponoviti 05.05.2022",
                Popust = 0

            };

            modelBuilder.Entity<Pregled>().HasData(p2);




            LijekoviPregled lp3 = new LijekoviPregled()
            {
                LijekoviPregledId = 3,
                PregledId = 2,
                LijekId = 1
            };
            modelBuilder.Entity<LijekoviPregled>().HasData(lp3);

            Racun rac2 = new Racun()
            {
                RacunId = 2,
                DatumIzdavanja = new DateTime(2021, 05, 05),
                IsPlacen = false,
                Iznos = 40,
                PregledId = 2
            };

            modelBuilder.Entity<Racun>().HasData(rac2);



            Rezervacije rez3 = new Rezervacije()
            {
                RezervacijaId = 3,
                Datum = new DateTime(2021, 07, 05),
                LjubimacId = 1,
                Prihvacena = null,
                TerminId = 3,
                VrstaUslugeId = 2

            };
            modelBuilder.Entity<Rezervacije>().HasData(rez3);



            Rezervacije rez4 = new Rezervacije()
            {
                RezervacijaId = 4,
                Datum = new DateTime(2021, 05, 09),
                LjubimacId = 2,
                Prihvacena = true,
                TerminId = 4,
                VrstaUslugeId = 1

            };
            modelBuilder.Entity<Rezervacije>().HasData(rez4);



            Pregled p3 = new Pregled()
            {
                PregledId = 3,
                Datum = new DateTime(2021, 05, 09, 12, 15, 12),
                LjubimacId = 2,
                VrstaUslugeId = 1,
                KorisnikId = 4,
                Napomena = "Kontrola za 6 mjeseci",
                Popust = 0

            };

            modelBuilder.Entity<Pregled>().HasData(p3);


            Racun rac3 = new Racun()
            {
                RacunId = 3,
                DatumIzdavanja = new DateTime(2021, 05, 09, 12, 15, 12),
                IsPlacen = false,
                Iznos = 40,
                PregledId = 3
            };

            modelBuilder.Entity<Racun>().HasData(rac3);




            Rezervacije rez5 = new Rezervacije()
            {
                RezervacijaId = 5,
                Datum = new DateTime(2021, 05, 11),
                LjubimacId = 2,
                Prihvacena = true,
                TerminId = 4,
                VrstaUslugeId = 4

            };
            modelBuilder.Entity<Rezervacije>().HasData(rez5);



            Pregled p4 = new Pregled()
            {
                PregledId = 4,
                Datum = new DateTime(2021, 05, 11, 10, 15, 10),
                LjubimacId = 2,
                VrstaUslugeId = 4,
                KorisnikId = 4,
                Napomena = "Nalazi uredni",
                Popust = 50

            };

            modelBuilder.Entity<Pregled>().HasData(p4);


            Racun rac4 = new Racun()
            {
                RacunId = 4,
                DatumIzdavanja = new DateTime(2021, 05, 11, 10, 15, 10),
                IsPlacen = true,
                Iznos = 25,
                PregledId = 4
            };

            modelBuilder.Entity<Racun>().HasData(rac4);



     



            Rezervacije rez6 = new Rezervacije()
            {
                RezervacijaId = 6,
                Datum = new DateTime(2021, 05, 13),
                LjubimacId = 3,
                Prihvacena = true,
                TerminId = 4,
                VrstaUslugeId = 1

            };
            modelBuilder.Entity<Rezervacije>().HasData(rez6);



            Pregled p5 = new Pregled()
            {
                PregledId = 5,
                Datum = new DateTime(2021, 05, 13, 09, 15, 10),
                LjubimacId = 3,
                VrstaUslugeId = 1,
                KorisnikId = 4,
                Napomena = "Kontrola za 6 mjeseci",
                Popust = 0

            };

            modelBuilder.Entity<Pregled>().HasData(p5);


            Racun rac5 = new Racun()
            {
                RacunId = 5,
                DatumIzdavanja = new DateTime(2021, 05, 13, 09, 15, 10),
                IsPlacen = false,
                Iznos = 40,
                PregledId = 5
            };

            modelBuilder.Entity<Racun>().HasData(rac5);




            Rezervacije rez7 = new Rezervacije()
            {
                RezervacijaId = 7,
                Datum = new DateTime(2021, 05, 16),
                LjubimacId = 3,
                Prihvacena = true,
                TerminId = 4,
                VrstaUslugeId = 4

            };
            modelBuilder.Entity<Rezervacije>().HasData(rez7);



            Pregled p6 = new Pregled()
            {
                PregledId = 6,
                Datum = new DateTime(2021, 05, 16, 11, 15, 10),
                LjubimacId = 3,
                VrstaUslugeId = 4,
                KorisnikId = 4,
                Napomena = "Nalazi uredni",
                Popust = 50

            };

            modelBuilder.Entity<Pregled>().HasData(p6);


            Racun rac6 = new Racun()
            {
                RacunId = 6,
                DatumIzdavanja = new DateTime(2021, 05, 16, 11, 15, 10),
                IsPlacen = true,
                Iznos = 25,
                PregledId = 6
            };

            modelBuilder.Entity<Racun>().HasData(rac6);






            Rezervacije rez8 = new Rezervacije()
            {
                RezervacijaId = 8,
                Datum = new DateTime(2021, 05, 17),
                LjubimacId = 4,
                Prihvacena = true,
                TerminId = 2,
                VrstaUslugeId = 4

            };
            modelBuilder.Entity<Rezervacije>().HasData(rez8);



            Pregled p7 = new Pregled()
            {
                PregledId = 7,
                Datum = new DateTime(2021, 05, 17, 14, 15, 11),
                LjubimacId = 4,
                VrstaUslugeId = 4,
                KorisnikId = 3,
                Napomena = "Nalazi uredni",
                Popust = 0

            };

            modelBuilder.Entity<Pregled>().HasData(p7);


            Racun rac7 = new Racun()
            {
                RacunId = 7,
                DatumIzdavanja = new DateTime(2021, 05, 17, 14, 15, 11),
                IsPlacen = true,
                Iznos = 50,
                PregledId = 7
            };

            modelBuilder.Entity<Racun>().HasData(rac7);


            Rezervacije rez9 = new Rezervacije()
            {
                RezervacijaId = 9,
                Datum = new DateTime(2021, 05, 20),
                LjubimacId = 4,
                Prihvacena = null,
                TerminId = 2,
                VrstaUslugeId = 4

            };
            modelBuilder.Entity<Rezervacije>().HasData(rez9);

            Rezervacije rez10 = new Rezervacije()
            {
                RezervacijaId = 10,
                Datum = new DateTime(2021, 05, 22),
                LjubimacId = 4,
                Prihvacena = false,
                TerminId = 2,
                VrstaUslugeId = 3

            };

            modelBuilder.Entity<Rezervacije>().HasData(rez10);
        }
    }
}
