using System;
using System.Collections.Generic;
using System.Linq;


namespace Take_Home_Assignment_W13
{
    class Program
    {
        static void Main(string[] args)
        {
            var scrolls = new List<string> { "Book of Peace", "Scroll of Swords", "Silence Guide Book" };
            while (true)
            {
                Console.Write("1. My scroll list \n2. Add scroll \n3. Search scroll \n4. Remove scroll \nChoose what to do: ");
                int Pilihan = Convert.ToInt32(Console.ReadLine());
                var nomorScroll = 1;
                Console.WriteLine();
                Console.Clear();
                if (Pilihan == 1)
                {
                    Console.WriteLine("Scroll to learn list:");
                    foreach (var scroll in scrolls)
                    {
                        Console.WriteLine($"Scroll {nomorScroll}: {scroll}");
                        nomorScroll += 1;
                    }
                }
                else if (Pilihan == 2)
                {
                    Console.Clear();
                    Console.WriteLine("How many scroll to add:");
                    int jumlahScroll = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("In what number of queue?");
                    int index = Convert.ToInt32(Console.ReadLine());
                    if (index < 1)
                    {
                        index = 1;
                    }
                    else if (index > scrolls.Count)
                    {
                        index = scrolls.Count + 1;
                    }
                    for (int i = 0; i < jumlahScroll; i++)
                    {
                        Console.WriteLine($"Scroll {i + 1} name:");
                        string tambahan = Convert.ToString(Console.ReadLine());
                        scrolls.Insert((index) - 1, tambahan);
                        index += 1;
                    }
                }
                else if (Pilihan == 3)
                {
                    Console.WriteLine("Insert scroll name:");
                    string tambahanScroll = Convert.ToString(Console.ReadLine());
                    if (scrolls.Contains(tambahanScroll, StringComparer.OrdinalIgnoreCase))
                    {
                        Console.Write($"Book found. Queue number: {scrolls.FindIndex(x => x.Equals(tambahanScroll, StringComparison.OrdinalIgnoreCase))+1}");
                    }
                    else 
                    {
                        Console.Write("Book not found");
                    }
                }
                else if (Pilihan == 4)
                {
                    Console.Clear();
                    Console.WriteLine("Remove from list by scroll name? Y/N:");
                    string pilihanRemove = Convert.ToString(Console.ReadLine().ToLower());
                    while (pilihanRemove != "y" && pilihanRemove != "n")
                    {
                        Console.WriteLine("Wrong selection. Choose again:\nRemove from scroll list by scroll name? Y/N:");
                        string pilihanRemove2 = Convert.ToString(Console.ReadLine().ToLower());
                        pilihanRemove = pilihanRemove2;
                    }
                    if (pilihanRemove == "y")
                    {
                        Console.WriteLine("input scroll name:");
                        var scrollDihapus = Convert.ToString(Console.ReadLine());
                        if (scrolls.Contains(scrollDihapus, StringComparer.OrdinalIgnoreCase))
                        {
                            scrolls.RemoveAll(o => o.Equals(scrollDihapus, StringComparison.OrdinalIgnoreCase));
                            Console.Write("Book removed!");
                        }
                        else
                        {
                            Console.Write("Book not found");
                        }
                    }
                    else
                    {
                        Console.WriteLine("input scroll queue:");
                        int queueDihapus = Convert.ToInt32(Console.ReadLine());
                        while (queueDihapus<=0 || queueDihapus>scrolls.Count)
                        {
                            Console.WriteLine("Queue not found. insert scroll queue:");
                            int queueDihapus1 = Convert.ToInt32(Console.ReadLine());
                            queueDihapus = queueDihapus1;
                        }
                        scrolls.RemoveAt(queueDihapus-1);
                        Console.Write("Book removed!");
                    }
                }
                Console.WriteLine();
            }
        }
    }
}

