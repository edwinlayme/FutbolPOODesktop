using Models;
using Newtonsoft.Json;

namespace Controllers
{
    public class EquipoController
    {

        private Equipo equipo;
        //public List<Equipo> equipos;
        //Directorio donde se Almacena el Archivo
        public static string path = @"\Equipos.json";
        public EquipoController()
        {
            equipo = new Equipo();
        }
        //Funcion del metodo Agregar Equipo
        public bool AgregarEquipo(string cod, string nomEquipo, string uniforme,
                                  int numtecnicos, string escudo, List<string> sedes)
        {
          equipo.cod_equipo = cod;
          equipo.nom_equipo = nomEquipo;
          equipo.uniforme = uniforme;
          equipo.num_tecnicos = numtecnicos;
          equipo.escudo = escudo;
          equipo.sedes_equipo = sedes;
            //string fileName = "WeatherForecast.json";
            try
            {
                string jsonString = JsonConvert.SerializeObject(equipo);
                File.WriteAllText(path, jsonString);
                return true;
            }
            catch
            {
                return false;
            }
        
  
        }
    }
}