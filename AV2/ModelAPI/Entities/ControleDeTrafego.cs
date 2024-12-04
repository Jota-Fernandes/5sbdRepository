using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ModelAPI.Entities
{
    public class ControleDeTrafego
    {
        public int Id {get; set;}
        public List<Voo> Voo_ativos{get; set;}
        public ControleDeTrafego() 
        { 
            Voo_ativos = new List<Voo>(); 
        }
    }
    public class Voo { 
        public int Id { get; set; } 
        public string Origem { get; set; } 
        public string Destino { get; set; } 
    }
}