using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fiskeprojekt
{
    internal class Menu
    {
        List<Fish> fishListSaltCarn = new();
        List<Fish> fishListFreshCarn = new();

        List<Fish> fishListSaltHerb = new();

        List<Fish> fishListFreshHerb = new();

        

        public Menu()
        {
            while (true)
            {
                MainMenu();
            }
        }
        public void MainMenu()
        {
            Console.WriteLine("Main Menu\n\n(1) Add new fish\n(2) Show Fish \n(3) Exit \n");
            var v = Console.ReadKey(true);

            // Select Menu
            switch (v.KeyChar)
            {
                case '1':
                    CreateItem();
                    break;
                case '2':
                    ShowList();
                    break;
                case '3':
                    Environment.Exit(0);
                    break;
                default:
                    break;
            }
        }
        void ShowList()
        {

            Console.WriteLine("What list do you want?: \n(1) Saltwater herbivore \n(2) Saltwater carnivore " +
                "\n(3) Freshwater herbivore \n(4) Freshwater carnivore \n");

            var v = Console.ReadKey(true);
            switch (v.KeyChar)
            {
                case '1':
                    foreach (Fish? fish in fishListSaltHerb)
                    {
                        ShowItem(fish);
                    }
                    break;
                case '2':
                    foreach (Fish? fish in fishListSaltCarn)
                    {
                        ShowItem(fish);
                    }
                    break;
                case '3':
                    foreach (Fish? fish in fishListFreshHerb)
                    {
                        ShowItem(fish);
                    }
                    break;
                case '4':
                    foreach (Fish? fish in fishListFreshCarn)
                    {
                        ShowItem(fish);
                    }
                    break;
                default:
                    break;

            }

        }
        //Show Fish name
        private void ShowItem(Fish showFish)
        {
            Console.WriteLine($"Name: {showFish.Name}\n");
            Console.ReadKey();
            Console.Clear();
        }
        //Adding New Fish
        public void CreateItem()
        {
            Fish newFish = new Fish();

            Console.WriteLine("What is the name of your fish?: ");
            newFish.Name = Console.ReadLine();
            //press Y if the fish is fresh or salt water
            Console.WriteLine("Is the fish freshwater? Press: Y Is the fish Saltwater press: N");
            newFish.IsFreshwater = Console.ReadKey(true).Key == ConsoleKey.Y ? true : false;
            //press Y if the fish is carnivore
            Console.WriteLine("Is the fish carnivore? Press: Y Is the fish herbivore press: N");
            newFish.IsCarnivore = Console.ReadKey(true).Key == ConsoleKey.Y ? true : false;

            //
            if (newFish.IsFreshwater == true)
            {
                if (newFish.IsCarnivore == true)
                {
                    fishListFreshCarn.Add(newFish);
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("\n The fish was added to the Fresh Carnivore list! \n");
                    Console.ResetColor();

                    Console.ReadKey();
                    Console.Clear();
                }
                else
                {
                    fishListFreshHerb.Add(newFish);
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("\n The fish was added to the Fresh Herbivore list! \n");
                    Console.ResetColor();

                    Console.ReadKey();
                    Console.Clear();
                }

            }
            else
            {
                if (newFish.IsCarnivore == true)
                {
                    fishListSaltCarn.Add(newFish);
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("\n The fish was added to the Salt Carnivore list! \n");
                    Console.ResetColor();

                    Console.ReadKey();
                    Console.Clear();
                }
                else
                {
                    fishListSaltHerb.Add(newFish);
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("\n The fish was added to the Salt Herbivore list! \n");
                    Console.ResetColor();

                    Console.ReadKey();
                    Console.Clear();
                }
            }
            
        }

    }

}