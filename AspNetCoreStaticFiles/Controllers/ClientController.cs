using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AspNetCoreStaticFiles.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.FileProviders;
using Newtonsoft.Json;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace AspNetCoreStaticFiles.Controllers
{
    [Route("api/[controller]")]
    public class ClientController : Controller
    {
        readonly IFileProvider fileProvider;

        public ClientController(IFileProvider fileProvider)
        {
            this.fileProvider = fileProvider;
        }

        // GET: api/<controller>
        [HttpGet]
        public RootClients Get()
        {
            var file = fileProvider.GetFileInfo("wwwroot/data/Client.json");
            RootClients clients = JsonConvert.DeserializeObject<RootClients>(System.IO.File.ReadAllText(file.PhysicalPath));
            return clients;
        }

        // GET api/<controller>/5
        [HttpGet("{id}")]
        public Client Get(int id)
        {
            var file = fileProvider.GetFileInfo("wwwroot/data/Client.json");
            RootClients clients = JsonConvert.DeserializeObject<RootClients>(System.IO.File.ReadAllText(file.PhysicalPath));
            Client client = clients.Clients.Where(x => x.Id == id).SingleOrDefault();
            return client ?? null;
        }

        // POST api/<controller>
        [HttpPost]
        public void Post([FromBody]string value)
        {
        }

        // PUT api/<controller>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE api/<controller>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
