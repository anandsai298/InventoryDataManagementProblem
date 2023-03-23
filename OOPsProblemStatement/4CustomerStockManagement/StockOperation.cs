using Newtonsoft.Json;
using OOPsProblemStatement.StockAccountManagement;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPsProblemStatement._4CustomerStockManagement
{
    public class StockOperation
    {
        int amount = 10000;
        List<StockData> CompanyList;
        List<StockData> stocks;
        public void ReadStockFile(string StockFilePath)
        {
            var data=File.ReadAllText(StockFilePath);
            var result= JsonConvert.DeserializeObject<List<StockData>>(data);
            CompanyList = result;
            Display(result);
        }
        public void ReadUserFile(string UserFilePath)
        {
            var data = File.ReadAllText(UserFilePath);
            var result = JsonConvert.DeserializeObject<List<StockData>>(data);
            stocks= result;
            Display(result);
        }
        public void BuyShares()
        {
            Console.WriteLine("Enter name of the company to Buy Shares");
            string name=Console.ReadLine();
            StockData stock = new StockData();
            foreach(var data in stocks)
            {
                if (data.StockName == name)
                    stock = data;
            }
            if (stock == null)
                Console.WriteLine(name + " " + "with stocks not available");
            else
            {
                Console.WriteLine("Enter no of shares need to buy");
                int shares=Convert.ToInt32(Console.ReadLine());
                if(shares <= stock.NumberOfShares)
                {
                    if(amount >= shares*stock.SharePrice)
                    {
                        foreach(var data in CompanyList)
                        {
                            if(data.StockName==(name))
                                stock= data;
                        }
                        if (stock == null)
                            CompanyList.Add(stock);
                        else
                        {
                            foreach (var data in CompanyList)
                            {
                                if (data.StockName == name)
                                    data.NumberOfShares += shares/2;
                            }
                        }
                        foreach (var data in stocks)
                        {
                            if (data.StockName == name)
                                data.NumberOfShares -= shares/2;
                        }
                    }
                }
            }
            Console.WriteLine("stock account details \n ");
            SaveFileStock(stocks);
            Console.WriteLine("companies details \n ");
            SaveFileUser(CompanyList);
        }
        public void SellShares()
        {
            Console.WriteLine("Enter name of the company to sell Shares");
            string name = Console.ReadLine();
            StockData stock = new StockData();
            foreach (var data in stocks)
            {
                if (data.StockName == name)
                    stock = data;
            }
            if (stock == null)
                Console.WriteLine(name + " " + "with stocks not available");
            else
            {
                Console.WriteLine("Enter no of shares need to sell");
                int shares = Convert.ToInt32(Console.ReadLine());
                foreach(var Stock in stocks)
                {
                    if (shares <= stock.NumberOfShares)
                    {
                        if (amount >= shares * stock.SharePrice)
                        {
                            foreach (var data in CompanyList)
                            {
                                if (data.StockName == (name))
                                    stock = data;
                            }
                            if (stock == null)
                                CompanyList.Add(stock);
                            else
                            {
                                foreach (var data in CompanyList)
                                {
                                    if (data.StockName == name)
                                        data.NumberOfShares -= shares / 2;
                                }
                            }
                            foreach (var data in stocks)
                            {
                                if (data.StockName == name)
                                    data.NumberOfShares += shares / 2;
                            }
                        }
                    }
                }
            }
            Console.WriteLine("stock account details \n ");
            SaveFileStock(stocks);
            Console.WriteLine("companies details \n ");
            SaveFileUser(CompanyList);
        }
        public void SaveFileStock(List<StockData> list)
        {
            string str=JsonConvert.SerializeObject(list);
            File.WriteAllText(@"F:\InventoryDataManagementProblem\OOPsProblemStatement\3StockAccountManagement\Stock.json", str);
            ReadStockFile(@"F:\InventoryDataManagementProblem\OOPsProblemStatement\3StockAccountManagement\Stock.json");
        }
        public void SaveFileUser(List<StockData> list)
        {
            string str = JsonConvert.SerializeObject(list);
            File.WriteAllText(@"F:\InventoryDataManagementProblem\OOPsProblemStatement\4CustomerStockManagement\UserShare.json", str);
            ReadUserFile(@"F:\InventoryDataManagementProblem\OOPsProblemStatement\4CustomerStockManagement\UserShare.json");
        }
        public void Display(List<StockData> list)
        {
            foreach (var stock in list)
            {
                Console.WriteLine(stock.StockName + "\t" + stock.NumberOfShares + "\t" + stock.SharePrice);
            }
        }
    }
}
