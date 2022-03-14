using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PACME.Common
{
    public static class LoggingService
    {
        public static void WriteToFIle(List<ILoggable> itemsToLog)
        {
            foreach (var item in itemsToLog)
            {
                Console.WriteLine(item.Log());
            }
        }
    }
}
