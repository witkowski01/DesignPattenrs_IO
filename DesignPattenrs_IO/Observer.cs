using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattenrs_IO
{
    class Observer
    {
        //Yep its empty because i need interface not class
    }

    abstract class ItemToObserv
    {
        private ArrayList observerList = new ArrayList();

        public void Attach(ConcreateObserver item)
        {
            observerList.Add(item);
        }

        public void DeAttach(ConcreateObserver item)
        {
            observerList.Remove(item);
        }

        public void Notify(int SomeItemNumber)
        {
            foreach (ConcreateObserver i in observerList)
            {
                i.Update(SomeItemNumber);
            }
        }
    }

    class ConcreteItem : ItemToObserv
    {
        public void ChangeItemNumber(int SomeItemNumber)
        {
            Notify(SomeItemNumber);
        }
    }

    interface IObserver
    {
        void Update(int SomeItemNumber);
    }

    class ConcreateObserver : IObserver
    {
        private string name;
        private int someItemNumber = 1;

        public ConcreateObserver(string name)
        {
            this.name = name;
        }

        public void Update(int SomeItemNumber)
        {
            this.someItemNumber = SomeItemNumber;
            Console.WriteLine("ConcreateObserver tell : SomeItemNumber has hanged");
        }
    }
}
