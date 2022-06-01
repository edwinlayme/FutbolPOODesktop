using Models;
using Newtonsoft.Json;

namespace Controllers
{
    public class JugadorController<T>
    {
        public List<T> lista = new List<T>();
        public string path;

        public JugadorController(string r)
        {
            path = r;
        }
        //Funcion para guardar en un archivo
        public void Guardar()
        {
            string convert = JsonConvert.SerializeObject(lista, Formatting.Indented);
            File.WriteAllText(path, convert);
        }
        //Funcion para cargar lista de Jugadores
        public void Cargar()
        {
            try
            {
                string archivo = File.ReadAllText(path);
                lista = JsonConvert.DeserializeObject<List<T>>(archivo);
            }
            catch (Exception) { }
        }
        public void Adicionar(T nuevo)
        {
            lista.Add(nuevo);
            Guardar();
        }
        public List<T> Buscar(Func<T, bool> elemento)
        {
            return lista.Where(elemento).ToList();
        }
        public void Eliminar(Func<T, bool> elemento)
        {
            lista = lista.Where(x => !elemento(x)).ToList();
        }
        public void Actualizar(Func<T, bool> elemento, T nuevo)
        {
            lista = lista.Select(x =>
            {
                if (elemento(x))
                    x = nuevo;
                return x;
            }).ToList();
        }
    }
}