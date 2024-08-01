using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace interview_practice.topics.Dotnet
{
    public sealed class Singleton
    {

        private static Singleton _instance = null; 

        private Singleton() { }

        public static Singleton GetInstance()
        {

            if(_instance == null)
            {
                Console.WriteLine("Initilize Successfully");

                _instance = new Singleton();
            } 
            else
            {
                Console.WriteLine("Returning Previously created instance");
            }

            return _instance;

        }

    }
}
