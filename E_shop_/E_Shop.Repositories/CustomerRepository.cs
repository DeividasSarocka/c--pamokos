﻿using E_Shop.Common;
using E_Shop.Repositories.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace E_Shop.Repositories
{
    public class CustomerRepository
    {
        public List<Customer> Customers { get; set; }
        public CustomerRepository()
        {
            FileReaderService reader = new FileReaderService();
            Customers = new List<Customer>();

            var csvPath = @"C:\Users\Win 10\Desktop\.NET_mokymai\C#\13_tema_egzaminas\bag's\Customers.csv";
            var data = reader.ReadFile(csvPath);
            {
                foreach (var value in data)
                {
                    Customers.Add(new Customer(value));
                }
            }

        }
        public List<Customer> GetByCustomerLoginName(string name)
        {
            return Customers.Where(x => x.LoginName == name).ToList();
        }
        public List<Customer> GetByCustomerLoginPasword(string pasword)
        {
            return Customers.Where(x => x.LoginPasword == pasword).ToList();
        }

        public void CustomerList()
        {
            foreach (var item in Customers)
            {
                Console.WriteLine($"{item.Name} {item.OrderId} {item.PhoneNumber} {item.Address} {item.ItemId} {item.Delivery} {item.Payment} {item.LoginName} {item.LoginPasword}");
            
            }
        }
    }
}
