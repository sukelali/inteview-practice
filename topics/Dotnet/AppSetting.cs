using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace interview_practice.topics.Dotnet
{
    public sealed class AppSetting
    {

        private static AppSetting _instance = null;
        
        private static readonly object threadLock = new object();

        private AppSetting() { }

        public static AppSetting GetInstance()
        {

            lock(threadLock)
            {
                if (_instance == null)
                {
                    Console.WriteLine("Initilize Successfully");

                    _instance = new AppSetting();
                }
                else
                {
                    Console.WriteLine("Returning Previously created instance");
                }

                return _instance;
            }

        }

    }
}
