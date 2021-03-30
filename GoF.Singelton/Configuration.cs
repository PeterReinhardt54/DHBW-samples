using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GoF.Singelton
{
    public class Configuration
    {
        // Java :       private HashMap<String, String> keyValuePairs;
        private Dictionary<String, String> keyValuePairs;

        private Configuration() // privater Konstruktor verhindert instanziieren der Klasse
        {
            // Java : keyValuePairs.put(key, value)
            Load(); 

        }

        private void Load()
        {
            keyValuePairs = new Dictionary<string, string>();

            try
            {
                var appSettings = ConfigurationManager.AppSettings;

                if (appSettings.Count == 0)
                {
                    Console.WriteLine("AppSettings is empty.");
                }
                else
                {
                    foreach (var key in appSettings.AllKeys)
                    {
                        keyValuePairs[key] = appSettings[key];
                    }
                }
            }
            catch (ConfigurationErrorsException)
            {
                Console.WriteLine("Error reading app settings");
            }
        }

        public void Save()
        {
            try
            {
                var configFile = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
                var appSettings = configFile.AppSettings.Settings;

                foreach (var Pair in keyValuePairs)
                {
                    if (appSettings[Pair.Key] == null)
                    {
                        appSettings.Add(Pair.Key, Pair.Value);
                    }
                    else
                    {
                        appSettings[Pair.Key].Value = Pair.Value;
                    }
                }
                configFile.Save(ConfigurationSaveMode.Full);
                ConfigurationManager.RefreshSection("appSettings");
            }
            catch (ConfigurationErrorsException)
            {
                Console.WriteLine("Error writing app settings");
            }
        }

        private static Configuration _instance;
        //        private static Configuration instance = new Configuration();
        // oder
        public static Configuration Instance
        {
            get
            {
                // lazy loading
                if (_instance == null)
                    _instance = new Configuration();
                // lazy loading

                return _instance;
            }
        }

        public Dictionary<String, String> Values()
        {
            return keyValuePairs;
        }

        public String this[string key]
        {
            get
            {
                if (key == null)
                {
                    return null;
                }
                return keyValuePairs[key];
            }
            set
            {
                if (key == null)
                {
                }
                else
                {
                    keyValuePairs[key] = value;
                }
            }
        }
    }
}
