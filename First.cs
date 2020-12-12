using System;

namespace ConsoleApp1.First
{
    class Tovar
    {
        public string Name { get; set; }
        public int Price { get; set; }

        Tovar(string name, int price)
        {            
            Name = name;
            Price = price;
        }

        public void Show()
        {
            Console.WriteLine($"Товар: {Name}\t цена: {Price}");
        }


        public static void Main()
        {
            Random rndprice = new Random();

            Tovar[] tovari = new Tovar[2];
            tovari[0] = new Tovar("Чехол", rndprice.Next(100, 500));
            tovari[1] = new Tovar("Блок питания", rndprice.Next(100, 500));

            int maxPrice = Math.Max(tovari[0].Price, tovari[1].Price);
            int minPrice = Math.Min(tovari[0].Price, tovari[1].Price);
            int diff = maxPrice - minPrice;

            foreach (var tovar in tovari)
            {
                tovar.Show();
            }

            Console.WriteLine("Ценовая разница между товарами: {0}", diff);
        }
        
    }
}
