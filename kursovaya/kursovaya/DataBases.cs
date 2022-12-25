using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using Newtonsoft.Json;

namespace kursovaya
{
    internal class DataBases
    {
        public string filePath = "C:\\Users\\Анна\\Desktop\\RegPassengers";
        public void SavingToDatabase<T>(Object obj)
        {
            List<T> listObjects = ReadingFromDatabase<T>();

            listObjects.Add((T)obj);

            string serializedObject = JsonConvert.SerializeObject(listObjects);
            File.WriteAllText(filePath, serializedObject);
        }

        public void SavingToDatabase<T>(List<T> obj)
        {
            string serializedObject = JsonConvert.SerializeObject(obj);

            File.WriteAllText(filePath, serializedObject);
        }

        public void OpenOrCreatFile(string pathToFile)
        {
            filePath = pathToFile;
            if (File.Exists(filePath) == false)
            {
                var file = File.Create(filePath);
                file.Close();
            }
        }

        public bool DeletingFromDatabase<T>(int id)
        {
            List<T> listObjects = ReadingFromDatabase<T>();
            listObjects.Sort();
            try
            {
                listObjects.RemoveAt(id);
                SavingToDatabase<T>(listObjects);
                return true;
            }
            catch
            {
                return false;
            }
        }

        public List<T> ReadingFromDatabase<T>()
        {
            string json = File.ReadAllText(filePath);
            List<T> listObjects = JsonConvert.DeserializeObject<List<T>>(json);
            return listObjects ?? new List<T>();
        }
    }
}
