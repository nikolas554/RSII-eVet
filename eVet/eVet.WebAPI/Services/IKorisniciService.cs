using eVet.Model.Request;
using eVet.WebAPI.Database;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace eVet.WebAPI.Services
{
    public interface IKorisniciService
    {
        List<Model.Korisnik> Get(KorisniciSearchRequest request);
        List<Model.Korisnik> GetTopKorisnici();
        Model.Korisnik GetById(int id);
        Model.Korisnik Insert(KorisniciInsertRequest request);
        Model.Korisnik Update(int id, KorisniciInsertRequest request);
        Model.Korisnik Authenticiraj(string username, string password);
    }
}
