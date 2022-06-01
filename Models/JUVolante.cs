using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    public class JUVolante : Jugador
    {
        public string habil { get; set; }
        public string buena_tecnica { get; set; }
        public string distribucion { get; set; }
        public JUVolante(string cod, string nombre, string ci, int num,
                         double sueldo, string hab, string tecnica, string distrib)
        {
            cod_jugador = cod;
            nom_jugador = nombre;
            ci_jugador = ci;
            num_camiseta = num;
            sueldo_jugador = sueldo;
            habil = hab;
            buena_tecnica = tecnica;
            distribucion = distrib;
        }
    }
}
