using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using GUSRestAPI.Services;

namespace GUSRestAPI.Controllers
{
    public class GusController : ApiController
    {
        private readonly GusService _gusService;

        public GusController()
        {
            _gusService = new GusService();
        }

        public string Get(string id)
        {
            return _gusService.Get(id);
        }
    }
}
