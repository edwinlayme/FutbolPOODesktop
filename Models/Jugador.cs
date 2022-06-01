using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    public class Jugador
    {
        //Atributos
        public string cod_jugador { get; set; }
        public string nom_jugador { get; set; }
        public string ci_jugador { get; set; }
        public int num_camiseta { get; set; }
        public double sueldo_jugador { get; set; }
        //Constructor
       public Jugador()
        {
           
        }
    }
}
