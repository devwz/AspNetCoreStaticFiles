using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AspNetCoreStaticFiles.Models
{
    public class RootClients
    {
        public Client[] Clients { get; set; }
    }

    public class Client
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Email { get; set; }
    }
}
