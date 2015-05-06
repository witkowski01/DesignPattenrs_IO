using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattenrs_IO
{
    static class FactoryMethod
    {
        public static IFactoryMethod CookScrambledEggs(IngiedientEnum ingiedientEnum)
        {
            IFactoryMethod ingridient = null;
            switch (ingiedientEnum)
            {
                    case IngiedientEnum.Eggs:
                        ingridient = new Eggs();
                        break;
                    case IngiedientEnum.Ham:
                        ingridient = new Ham();
                        break;
                    case IngiedientEnum.Onion:
                        ingridient=new Onion();
                        break;
                    case IngiedientEnum.Salt:
                        ingridient=new Salt();
                        break;
                default:
                       throw new ArgumentOutOfRangeException("ingiedientEnum", "Incorrect Ingrediens");
            }
            return ingridient;
        }
    }

    enum IngiedientEnum // For better recognition our ingridients
    {
        Eggs, Ham, Salt, Onion
    }

    interface IFactoryMethod
    {
        void Ingredient();
    }

    class Eggs : IFactoryMethod
    {

        public void Ingredient()
        {
            Console.WriteLine("Eggs");
        }
    }

    class Onion : IFactoryMethod
    {

        public void Ingredient()
        {
            Console.WriteLine("Onion");
        }
    }

    class Ham : IFactoryMethod
    {

        public void Ingredient()
        {
            Console.WriteLine("Ham");
        }
    }

    class Salt : IFactoryMethod
    {

        public void Ingredient()
        {
            Console.WriteLine("Salt");
        }
    }
}
