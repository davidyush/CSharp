using System;
using System.Collections.Generic;

namespace exep2
{
    //иксепшен с перегруженым месеждем
    class IsDomesticProductException : Exception
    {
        public IsDomesticProductException() { }
        public override string Message
        {
            get
            {
                return "That's impossible to put domestic products into the basket.";
            }
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            //продукты..
            Product ball = new SportProduct("ball");
            Product cheese = new GroceryProduct("cheese");
            Product simulator = new SportProduct("simulator");
            Product kitty = new DomesticProduct("kitty");
            try
            {
                //аккуратно кладем в корзинку
                Basket basket = new Basket(ball, cheese, simulator, kitty);
            }
            catch (IsDomesticProductException e)
            {
                Console.WriteLine(e.Message);
            }

            Console.ReadKey();
        }
    }

    abstract class Product
    {
        private string _designation;
        public Product(string designation)
        {
            _designation = designation;
        }

        public string Designation
        {
            get { return _designation; }
        }
    }
    //классы всевозможных благ
    class GroceryProduct : Product
    {
        public GroceryProduct(string designation) : base(designation) { }
    }
    class DomesticProduct : Product
    {
        public DomesticProduct(string designation) : base(designation) { }
    }
    class SportProduct : Product
    {
        public SportProduct(string designation) : base(designation) { }
    }

    class Basket
    {
        //карзинка если что выкинет иксепшен
        public Basket(params Product[] allProducts)
        {
            foreach (Product item in allProducts)
            {
                if (item is DomesticProduct)
                    throw new IsDomesticProductException();
            }
        }
    }
}
