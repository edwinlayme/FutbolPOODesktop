using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    public class Equipo
    {
        //Atributos
       public string cod_equipo { get; set; }
       public string nom_equipo { get; set; }
       public string uniforme { get; set; }
       public int num_tecnicos { get; set; }
       public string escudo { get; set; }
       public List<string> sedes_equipo { get; set; }
        //Constructor
       public Equipo()
        {
        }
        public void Competir()
        {

        }
    }
}
