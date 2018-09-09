using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POS.Startup
{
   public class StartupConfig
    {
       private static StartupConfig _ConfigInstance = default(StartupConfig);

       public string AppMode
       {
           get;
           set;
       }



       private StartupConfig()
       {

       }
       public static StartupConfig CreateInstance()
       {
           if (_ConfigInstance == null)
           {
               _ConfigInstance = new StartupConfig();
           }
           return _ConfigInstance;
       }

    }
}
