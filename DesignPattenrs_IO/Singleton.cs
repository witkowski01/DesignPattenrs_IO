using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattenrs_IO
{
    
    class Singleton
    {
        private static Singleton mInstation_1 = null;

        private static readonly object mLock = new object();

        public static Singleton mInstation_0
        {
            get
            {
                lock (mLock) // Because of multithread, we need to secure our instantion for multiple acces from different threads
                {
                    if (mInstation_1==null)
                    {
                        mInstation_1=new Singleton();
                    }
                    return mInstation_1;
                }
            }
        }

        public void ConsoleWriteLineString(string Text)
        {
            Console.WriteLine(Text);
        }

    }
}
