﻿using Restaurant.BusinessLogic;
using Restaurant.Common;
using Restaurant.Repositories;
using System;

namespace Egzaminas_Restorano_sistema
{
    public class Program
    {
        public static void Main(string[] args)
        { 
            bool done = true;
            do
            {
                RestaurantMenu1();
                int choose_1 = OrdersCreator.InputIsNumber();
                switch (choose_1)
                {
                    case 0:
                        done = false;
                        break;
                    case 1:
                        var tableRepository = new TableRepository();
                        tableRepository.ItemsList();
                        ChooseTable();
                        Globals._TableNumber = OrdersCreator.InputIsNumber();
                        TableCheckIn.TableMenu();
                        break;
                    default:
                        OrdersCreator.BadInput();
                        break;
                }

            } while (done);

        }

        public static void RestaurantMenu1()
        {
            Console.Clear();
            Console.WriteLine("Sveiki čia Restorano užsakymų valdymo sistema \n [1] Staliukai (laisvi/užimti) \n [0] Išeiti iš sistemos ");
        }
        public static void ChooseTable()
        {
            Console.WriteLine("Pasirinkite norimą staliuką iš sąrašo:");
        }
    }
}
