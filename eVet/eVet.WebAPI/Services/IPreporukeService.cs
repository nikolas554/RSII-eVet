using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace eVet.WebAPI.Services
{
    public interface IPreporukeService
    {
        List<Model.VrstaUsluge> Get(int id);
    }
}
