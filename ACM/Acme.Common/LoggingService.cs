using System;
using System.Collections.Generic;
using System.Text;

namespace Acme.Common
{
    public class LoggingService
    {
        public static void WriteToFile(List<ILoggable> changedItems) {
            foreach (var item in changedItems)
            {
                Console.WriteLine(item.Log());
            }
        }
    }
}
