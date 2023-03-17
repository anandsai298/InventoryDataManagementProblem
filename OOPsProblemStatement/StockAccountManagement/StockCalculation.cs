using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using System.Collections;

namespace OOPsProblemStatement.StockAccountManagement
{
    public class StockCalculation
    {
        public void ReadJsonfile(string filePath)
        {
            var data=File.ReadAllText(filePath);
            var result=JsonConvert.DeserializeObject<List<StockData>>(data);
            foreach (var Stock in result)
            {
                Console.WriteLine(Stock.StockName+ "\t" + Stock.NumberOfShares + "\t" + Stock.SharePrice + "\t" + Stock.NumberOfShares * Stock.SharePrice);
            }
        }
    }
}
