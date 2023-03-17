// See https://aka.ms/new-console-template for more information
using OOPsProblemStatement.InventoryDataManagement;
using OOPsProblemStatement.InventoryManagement;
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
                Console.WriteLine("1.InventoryOperation\n2.InventoryDM\n3.AddInventory");
                Console.WriteLine("select option to print");
                int option=Convert.ToInt32(Console.ReadLine()); 
                switch(option)
                {
                    case 1:
                        InventoryOperation inventory = new InventoryOperation();
                        inventory.ReadJsonFile(@"F:\OOPsProblemStatement\OOPsProblemStatement\InventoryDataManagement\Inventory.json");
                        break;
                    case 2:
                        InventoryDM inventoryDM = new InventoryDM();
                        inventoryDM.ReadJsonFile(@"F:\OOPsProblemStatement\OOPsProblemStatement\InventoryManagement\InventoryDetails.json");           
                        break;
                    case 3:
                        InventoryDM inventoryDM1 = new InventoryDM();
                        inventoryDM1.AddInventory();
                        break;
                }
            }
        }
    }
}