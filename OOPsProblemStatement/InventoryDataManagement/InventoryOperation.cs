using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using OOPsProblemStatement.InventoryDataManagement;
using System.IO;
using Newtonsoft.Json;

namespace OOPsProblemStatement.InventoryDataManagement
{
    public class InventoryOperation
    {
        public void ReadJsonFile(string filepath)
        {
            var data=File.ReadAllText(filepath);
            var result=JsonConvert.DeserializeObject<List<InventoryData>>(data);
            //Deserialization ---> conversion of Json datatype into string datatype.
            //Serialization ---> conversion of string datatype inti Json datatype.
            foreach (var inventory in result)
            {
                Console.WriteLine(inventory.Name+"\t"+inventory.Weight+"\t"+inventory.PricePerKg+"\t"+ inventory.Weight* inventory.PricePerKg);
            }
        }
    }
}
