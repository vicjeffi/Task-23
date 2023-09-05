using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.IO;
using System.Xml.Linq;

namespace ПрактическаяРабота23.Saves
{
    internal class DataWriter<T>
    {
        private string _path = "";
        public string Path { get { return _path; } }
        public DataWriter(string path) 
        {
            path = _path;
            if(!File.Exists(path))
                File.Create(path);
        }
        public void SaveData(T data)
        {
            string json = JsonSerializer.Serialize(data);
            File.WriteAllText(_path, json);
        }
    }
}
