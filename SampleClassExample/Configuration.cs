using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SampleClassExample
{
    public class Configuration
    {
        public static string applicationName;
        public string UserPreference;

        static Configuration() 
        {
            applicationName = "HP";
            Console.WriteLine("Application Name "+applicationName);
        }
        public Configuration(string UserPreferences) 
        {
            UserPreference = UserPreferences;
            Console.WriteLine("User preference " + UserPreference);
        
        }
    }
}
