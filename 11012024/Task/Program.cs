using System;

namespace Task
{
    internal class Program
    {
        static void Main(string[] args)
        {
            TechStore store = new TechStore();
            string opt;
            do
            {
                Console.WriteLine("1. Notebook elave et");
                Console.WriteLine("2. Notebook sat");
                Console.WriteLine("3. Total amounta bax");
                Console.WriteLine("0. Cix");

                Console.WriteLine("Emeliyyat secin");
                opt = Console.ReadLine();


                switch (opt)
                {
                    case "1":
                        Console.WriteLine("Ad:");
                        string name = Console.ReadLine();
                        Console.WriteLine("Price: ");
                        double price = Convert.ToDouble(Console.ReadLine());

                        Notebook newNt = new Notebook(name, price);
                        store.Add(newNt);
                        break;
                    case "2":
                        Console.WriteLine("Notebooklar:");
                        for (int i = 0; i < store.Notebooks.Length; i++)
                        {
                            Console.WriteLine($"{store.Notebooks[i].Name}-{store.Notebooks[i].Price}");
                        }
                        Console.WriteLine("Mehsul adi:");
                        string ntName = Console.ReadLine();
                        Notebook nt = store.Find(ntName);

                        store.Sell(nt);

                        break;
                    case "3":
                        Console.WriteLine("Total amount:");
                        Console.WriteLine(store.TotalAmount);
                        break;
                    case "0":
                        Console.WriteLine("Proqram bitdi");
                        break;
                    default:
                        Console.WriteLine("Yanlis secim!");
                        break;
                }

            } while (opt!="0");
           

        }
    }
}
