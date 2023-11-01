using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;

namespace Jewlery.Model.Serialization
{
    public class DataSerializer
    {
        public static void SerializeData(string fileName, DataModel data)
        {
            var formatter = new DataContractSerializer(typeof(DataModel));
            var s = new FileStream(fileName, FileMode.Create);
            formatter.WriteObject(s, data);
            s.Close();
        }

        public static DataModel DesearializeItem(string fileName)
        {
            var s = new FileStream(fileName, FileMode.Open);
            var formatter = new BinaryFormatter();
            return (DataModel)formatter.Deserialize(s);
        }
    }
}
