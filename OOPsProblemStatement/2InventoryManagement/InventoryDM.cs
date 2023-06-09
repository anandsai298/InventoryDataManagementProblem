﻿using Newtonsoft.Json;
using OOPsProblemStatement.InventoryDataManagement;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPsProblemStatement.InventoryManagement
{
    public class InventoryDM
    {
        List<InventoryData> riceList;//global declaration to access any method
        List<InventoryData> wheatList;
        List<InventoryData> pulsesList;
        public void ReadJsonFile(string filepath)
        {
            var data = File.ReadAllText(filepath);
            var result = JsonConvert.DeserializeObject<InventoryList>(data);
            riceList = result.RiceList;
            Display(riceList);
            wheatList = result.WheatList;
            Display(wheatList);
            pulsesList = result.PulsesList;
            Display(pulsesList);
        }
        public void AddInventory()
        {
            Console.WriteLine("Enter in which list new inventory need to be added");
            string name=Console.ReadLine();
            Console.WriteLine("Enter Inventory data");
            InventoryData data = new InventoryData();
            data.Name = Console.ReadLine();
            data.Weight=Convert.ToDouble(Console.ReadLine());
            data.PricePerKg = Convert.ToDouble(Console.ReadLine()); 
            if (name.ToLower().Equals("rice"))
            {
                riceList.Add(data);
                Display(riceList);
            }
            if (name.ToLower().Equals("wheat"))
            {
                wheatList.Add(data);
                Display(wheatList);
            }
            if (name.ToLower().Equals("pulses"))
            {
                pulsesList.Add(data);
                Display(pulsesList);
            }
        }
        public void EditInventory()
        {
            Console.WriteLine("edit using name");
            string name= Console.ReadLine();
            Console.WriteLine("Edit Inventory data");
            InventoryData data = new InventoryData();
            data.Name = Console.ReadLine();
            data.Weight = Convert.ToDouble(Console.ReadLine());
            data.PricePerKg = Convert.ToDouble(Console.ReadLine());
            if (name.Equals(data.Name))
            {
                data.Name = Console.ReadLine();
                data.Weight = Convert.ToDouble(Console.ReadLine());
                data.PricePerKg= Convert.ToDouble(Console.ReadLine());
            }
        }
        public void DeleteInventory()
        {
            Console.WriteLine("Delete using name");
            string name = Console.ReadLine();
            Console.WriteLine("Delete Inventory data");
            InventoryData data = new InventoryData();
            data.Name = Console.ReadLine();
            foreach (var inventory in riceList)
            {
                if (name.Equals(data.Name))
                {
                    data = inventory;
                }
            }
            riceList.Remove(data);
            Display(riceList);
            foreach (var inventory in wheatList)
            {
                if (name.Equals(data.Name))
                {
                    data = inventory;
                }
            }
            wheatList.Remove(data);
            Display(wheatList);
            foreach (var inventory in pulsesList)
            {
                if (name.Equals(data.Name))
                {
                    data = inventory;
                }
            }
            pulsesList.Remove(data);
            Display(pulsesList);
        }
        public void Display(List<InventoryData> list)
        {
            foreach (var inventory in list)
            {
                Console.WriteLine(inventory.Name + "\t" + inventory.Weight + "\t" + inventory.PricePerKg + "\t" + inventory.Weight * inventory.PricePerKg);
            }
        }
    }
}
