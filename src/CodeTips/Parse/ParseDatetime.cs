using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeTips.Parse
{
    internal class ParseDatetime
    {

        
        public void Example1()
        {
            var input = "1";
            DateTime dateTime;

            // "yyyyMMdd" 형식으로 파싱
            if (DateTime.TryParseExact(input, "yyyyMMdd", CultureInfo.InvariantCulture, DateTimeStyles.None, out dateTime))
            {
                Console.WriteLine($"Parsed DateTime: {dateTime}");
            }
            else
            {
                Console.WriteLine("Invalid date format.");
            }

        }
    }
}
