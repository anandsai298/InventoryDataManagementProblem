// See https://aka.ms/new-console-template for more information
using OOPsProblemStatement._4CustomerStockManagement;
using OOPsProblemStatement.InventoryDataManagement;
using OOPsProblemStatement.InventoryManagement;
using OOPsProblemStatement.StockAccountManagement;
using System;
using System.Collections.Generic;

namespace OOPsProblemStatement
{
    class program
    {
        public static void Main(String[] args)
        {
            bool flag = true;
            while (flag)
            {
                Console.WriteLine("1.InventoryOperation\n2.InventoryDM\n3.AddInventory\n4.EditInventory\n5.DeleteInventory\n6.StockCalculation\n7.StockBuyShares\n8.StockSellShares");
                Console.WriteLine("select option to print");
                int option=Convert.ToInt32(Console.ReadLine()); 
                switch(option)
                {
                    case 1:
                        InventoryOperation inventory = new InventoryOperation();
                        inventory.ReadJsonFile(@"F:\InventoryDataManagementProblem\OOPsProblemStatement\InventoryDataManagement\Inventory.json");
                        break;
                    case 2:
                        InventoryDM inventoryDM = new InventoryDM();
                        inventoryDM.ReadJsonFile(@"F:\InventoryDataManagementProblem\OOPsProblemStatement\InventoryManagement\InventoryDetails.json");
                        break;
                    case 3:
                        InventoryDM inventoryDM1 = new InventoryDM();
                        inventoryDM1.ReadJsonFile(@"F:\InventoryDataManagementProblem\OOPsProblemStatement\InventoryManagement\InventoryDetails.json");
                        inventoryDM1.AddInventory();
                        break;
                    case 4:
                        InventoryDM inventoryDM2 = new InventoryDM();
                        inventoryDM2.ReadJsonFile(@"F:\InventoryDataManagementProblem\OOPsProblemStatement\InventoryManagement\InventoryDetails.json");
                        inventoryDM2.EditInventory();
                        break;
                    case 5:
                        InventoryDM inventoryDM3 = new InventoryDM();
                        inventoryDM3.ReadJsonFile(@"F:\InventoryDataManagementProblem\OOPsProblemStatement\InventoryManagement\InventoryDetails.json");
                        inventoryDM3.DeleteInventory();
                        break;
                    case 6:
                        StockCalculation stock=new StockCalculation();
                        stock.ReadStockfile(@"F:\InventoryDataManagementProblem\OOPsProblemStatement\3StockAccountManagement\Stock.json");
                        break;
                    case 7:
                        StockOperation stockOperation=new StockOperation();
                        stockOperation.ReadStockFile(@"F:\InventoryDataManagementProblem\OOPsProblemStatement\3StockAccountManagement\Stock.json");
                        stockOperation.ReadUserFile(@"F:\InventoryDataManagementProblem\OOPsProblemStatement\4CustomerStockManagement\UserShare.json");
                        stockOperation.BuyShares();
                        break;
                    case 8:
                        StockOperation stockOperation1 = new StockOperation();
                        stockOperation1.ReadStockFile(@"F:\InventoryDataManagementProblem\OOPsProblemStatement\3StockAccountManagement\Stock.json");
                        stockOperation1.ReadUserFile(@"F:\InventoryDataManagementProblem\OOPsProblemStatement\4CustomerStockManagement\UserShare.json");
                        stockOperation1.SellShares();
                        break;
                }
            }
        }
    }
}