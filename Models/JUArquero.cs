using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    public class JUArquero: Jugador
    {
        public string agil { get; set; }
        public string rapido { get; set; }
        public string seguro { get; set; }
        // Herencia y Constructor
        public JUArquero(string cod, string nombre, string ci, int num,
                         double sueldo, string ag, string rap, string seg)
        {
            cod_jugador = cod;
            nom_jugador = nombre;
            ci_jugador = ci;
            num_camiseta = num;
            sueldo_jugador = sueldo;
            agil = ag;
            rapido = rap;
            seguro = seg;
        }
    }
}
