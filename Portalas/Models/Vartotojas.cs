using Portalas.Contract;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Portalas.Models
{
    public class Vartotojas  
    {
        [Key]
        public string Id { get; set; }
        public string Vardas { get; set; }    
        public string Elpastas { get; set; }

        public Vartotojas()
        {

        }
        public Vartotojas(string id, string vardas, string elpastas)
        {
            Id = id;
            Vardas = vardas;
            Elpastas = elpastas;
        }
    }
    
}
