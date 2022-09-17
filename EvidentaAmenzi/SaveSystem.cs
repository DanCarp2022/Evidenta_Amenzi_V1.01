using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization.Formatters.Binary;
using System.IO;

namespace EvidentaAmenzi
{
    internal class SaveSystem
    {
        public static void SaveData(string filePath) 
        {
            BoxedData bData = new BoxedData();
            FileStream fileStream;
            BinaryFormatter formatter = new BinaryFormatter();
            if (File.Exists(filePath)) File.Delete(filePath); //checks if the file already exists.
            fileStream = File.Create(filePath);
            formatter.Serialize(fileStream, bData);
            fileStream.Close();
            Console.WriteLine("Datele au fost salvate cu succes");
        }
        public static BoxedData LoadData(string filePath) 
        {
            BoxedData bData = new BoxedData();
            FileStream fileStream;
            BinaryFormatter formatter = new BinaryFormatter();
            if (File.Exists(filePath))
            {
                fileStream = File.OpenRead(filePath);
                bData = formatter.Deserialize(fileStream) as BoxedData;
                fileStream.Close();
            }
            return bData;

        }
    }
}
