using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using Newtonsoft.Json;
namespace CS_2_4
{
    // бесполезно, зато по тз
    internal class JsonWorking
    {
        public static void Serializing<T>(string path, T Valuev) 
        {
            string converted = JsonConvert.SerializeObject(Valuev);
            File.WriteAllText(path, converted);
        }
        public static T Deserializing<T>(string path)
        {
            string file = "";
            file = File.ReadAllText(path);
            T result = JsonConvert.DeserializeObject<T>(file);
            return result;
        }
    }
    // в тз написано разбивать методы на файлы - я разбил целые 2 метода в отдельный
}
