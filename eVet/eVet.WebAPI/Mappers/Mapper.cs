using AutoMapper;
using eVet.Model.Request;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace eVet.WebAPI.Mappers
{
    public class Mapper:Profile
    {
        public Mapper()
        {


            CreateMap<Database.Ustanovljena, Model.Ustanovljena>();
            CreateMap<Database.LijekoviPregled, Model.LijekoviPregled>();
            CreateMap<Database.Dijagnoza, Model.Dijagnoza>();
            CreateMap<Database.Dijagnoza, DijagnozaUpsertRequest>();


            CreateMap<Database.KorisniciUloge, Model.KorisniciUloge>().ReverseMap();
            CreateMap<Database.Korisnik, Model.Korisnik>();
            CreateMap<Database.Racun, Model.Racun>();
            CreateMap<Database.Pregled, Model.Pregled>();
            CreateMap<Database.Rezervacije, Model.Rezervacije>();
            CreateMap<Database.Ljubimac, Model.Ljubimac>();
            CreateMap<Database.Termini, Model.Termini>();
            CreateMap<Database.Uloge, Model.Uloge>();
            CreateMap<Database.VrstaUsluge, Model.VrstaUsluge>();
            CreateMap<Database.Lijekovi, Model.Lijek>();

            CreateMap<Database.Korisnik, KorisniciInsertRequest>().ReverseMap();
       
            CreateMap<Database.Lijekovi, LijekUpsertRequest>().ReverseMap();
            CreateMap<Database.VrstaUsluge, VrstaUslugeUpsertRequest>().ReverseMap();
            CreateMap<Database.Termini, TerminUpsertRequest>().ReverseMap();
            CreateMap<Database.Ljubimac, LjubimacUpsertRequest>().ReverseMap();
            CreateMap<Database.Rezervacije, RezervacijeUpsertRequest>().ReverseMap();
            CreateMap<Database.Pregled, PreglediUpsertRequest>().ReverseMap();
            CreateMap<Database.Racun, RacuniInsertRequest>().ReverseMap();
            CreateMap<Database.Racun, RacunUpdateRequest>().ReverseMap();
        }
    }
}
