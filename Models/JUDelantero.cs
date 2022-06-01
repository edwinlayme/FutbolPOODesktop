using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    public class JUDelantero : Jugador
    {
     public string agil { get; set; }
     public string rapido { get; set; }
     public string habil{ get; set; }
        // Herencia y Constructor
        public JUDelantero(string cod, string nombre, string ci, int num,
                         double sueldo, string ag, string rap, string hab)
        {
            cod_jugador = cod;
            nom_jugador = nombre;
            ci_jugador = ci;
            num_camiseta = num;
            sueldo_jugador = sueldo;
            agil = ag;
            rapido = rap;
            habil = hab;
        }
    }
}
