using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    public class JUDefensa : Jugador
    {
        public string rapido { get; set; }
        public string manejo_balon { get; set; }
        public string fuerza { get; set; }
        // Herencia y Constructor
        public JUDefensa(string cod, string nombre, string ci, int num, 
                         double sueldo, string rap,string man,string fuer )
        {
            cod_jugador = cod;
            nom_jugador = nombre;
            ci_jugador = ci;
            num_camiseta = num;
            sueldo_jugador = sueldo;
            rapido = rap;
            manejo_balon = man;
            fuerza = fuer;

        }
    }
}