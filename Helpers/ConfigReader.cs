using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutomationExamCodeSolvers.Helpers
{
    public static class ConfigReader
    {
        public static JObject GetConfig()
        {
            string fileName = "appsettings.json";
            bool isFileExisting = File.Exists(fileName);
            if (isFileExisting)
            {
                return JObject.Parse(File.ReadAllText(fileName));
            }
            else
            {
                throw new Exception("App settigns json file could not be located");
            }
        }
        public static int GetImplicitTimeout()
        {
            int timeout = int.Parse(GetConfig()[Constants.DefaultImplicitWait]!.ToString());
            return timeout;
        }
    }
}
