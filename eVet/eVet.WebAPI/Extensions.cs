using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.DependencyInjection.Extensions;
using Microsoft.Extensions.Options;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;

namespace eVet.WebAPI
{
    public static class Extensions
    {

        public static int GetUserId(this ClaimsPrincipal principal)
        {
            var claim = principal.Claims.FirstOrDefault(x => x.Type == ClaimTypes.NameIdentifier);

            if (claim != null)
                return int.Parse(claim.Value);

            throw new ArgumentNullException("userId");
        }

    }



}
