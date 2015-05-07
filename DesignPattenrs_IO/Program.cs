using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattenrs_IO
{
    class Program
    {
        static void Main(string[] args)
        {
            Singleton singleton = new Singleton();
            singleton.ConsoleWriteLineString("Singleton DesoignPatterns console writeline.");

            IFactoryMethod ingrediens = FactoryMethod.CookScrambledEggs(IngiedientEnum.Ham);
            ingrediens.Ingredient();
            IFactoryMethod ingrediens2 = FactoryMethod.CookScrambledEggs(IngiedientEnum.Onion);
            ingrediens2.Ingredient();
            IFactoryMethod ingrediens3 = FactoryMethod.CookScrambledEggs(IngiedientEnum.Eggs);
            ingrediens3.Ingredient();
            IFactoryMethod ingrediens4 = FactoryMethod.CookScrambledEggs(IngiedientEnum.Salt);
            ingrediens4.Ingredient();

            //Builder
            Client mClient = new Client();
            mClient.CreateProduct();

            //Observer
            ConcreteItem concreteItem = new ConcreteItem();

            ConcreateObserver cObserver1=new ConcreateObserver("Item 1");
            ConcreateObserver cObserver2=new ConcreateObserver("Item 2");

            concreteItem.Attach(cObserver1);
            concreteItem.Attach(cObserver2);
            concreteItem.ChangeItemNumber(2);
            concreteItem.DeAttach(cObserver2);
            concreteItem.ChangeItemNumber(5);

            Console.ReadKey();
        }
    }
}
