using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoClases.Helpers
{
    public class HelperFiles
    {
        //necesitamos dos metodos
        //uno para leer y otro para escribir 

        //cuando utilizamos async/await con metodos
        //personalizados, se usa la clase Task
        //si es void: Task
        //si es return: Task<clase>
        public static async Task<string> ReadFileAsync(string path)
        {
            FileInfo file = new FileInfo(path);
            using (TextReader reader = file.OpenText())
            {
                string data = await reader.ReadToEndAsync();    
                reader.Close();
                return data;
            }

        }

        //como es void le ponemos Task
        public static async Task WriteFileAsync(string path, string data)
        {
            FileInfo file = new FileInfo(path);
            using (TextWriter writer = file.CreateText())
            {
                await writer.WriteAsync(data);
                await writer.FlushAsync();
                writer.Close();

            }
        }
    }
}
