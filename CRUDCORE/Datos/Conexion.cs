//Añado la referencia SQLClient que es el paquete que se instala en .net core para poder generar la conexión con la bd
using System.Data.SqlClient;


namespace CRUDCORE.Datos
{
    public class Conexion
    {
        
        private string cadenaSQL=string.Empty;

        //Creo el constructor con el mismo nombre que la clase Conexion. El constructor es lo primero que se ejecuta
        //una vez que se le hace una instancia a la clase de Conexión.
        public Conexion()
        {
            //obtengo en builder la cadena de conexión que está en mi archivo appsetings.json 
            var builder = new ConfigurationBuilder().SetBasePath(Directory.GetCurrentDirectory()).AddJsonFile("appsettings.json").Build();

            //obtengo en mi variable privada cadenasql una sección particular dentro de mi archivo appsettings.json que es el string de conexion 
            cadenaSQL = builder.GetSection("ConnectionStrings:CadenaSQL").Value;
        }

        //Creo un metodo que me devuelve la cadena SQL que obtuvimos
        public string getCadenaSQL()
        {
            return cadenaSQL;
        }
    }
}
