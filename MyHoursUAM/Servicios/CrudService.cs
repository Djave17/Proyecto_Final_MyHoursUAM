using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;

namespace MyHours_UAMApp
{
    public class CrudService<T>
    {
        private readonly string filePath;
        public List<T> Data { get; private set; }

        public CrudService(string filePath)
        {
            this.filePath = filePath;
            Data = LoadData();
        }

        private List<T> LoadData()
        {
            if (File.Exists(filePath))
            {
                using (FileStream stream = File.Open(filePath, FileMode.Open))
                {
                    BinaryFormatter formatter = new BinaryFormatter();
                    return (List<T>)formatter.Deserialize(stream);
                }
            }
            return new List<T>();
        }

        public void SaveData()
        {
            using (FileStream stream = File.Create(filePath))
            {
                BinaryFormatter formatter = new BinaryFormatter();
                formatter.Serialize(stream, Data);
            }
        }

        public void Add(T item)
        {
            Data.Add(item);
            SaveData();
        }

        public void Update(Predicate<T> match, T updatedItem)
        {
            int index = Data.FindIndex(match);
            if (index != -1)
            {
                Data[index] = updatedItem;
                SaveData();
            }
        }

        public void Delete(Predicate<T> match)
        {
            Data.RemoveAll(match);
            SaveData();
        }

        public List<T> GetAll()
        {
            return Data;
        }
    }
}
