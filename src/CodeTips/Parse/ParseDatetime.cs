using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeTips.Parse;

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

    /// <summary>
    /// Parse 모든 날짜 형식 대응 가능
    /// </summary>
    /// <param name="input"></param>
    /// <returns></returns>
    public DateTime? Example2(string input)
    {
        //string dateString = "2/3/2024";

        // DateTime.Parse 사용
        try
        {
            var parsedDatetime = DateTime.Parse(input, CultureInfo.InvariantCulture);
            
            Console.WriteLine($"Parsed Date: {parsedDatetime}");
            
            return parsedDatetime;
        }
        catch (FormatException)
        {
            Console.WriteLine("The date format is invalid.");
            return null;
        }

    }

    /// <summary>
    /// TryParse 모든 날짜 형식 대응 가능
    /// </summary>
    /// <param name="input"></param>
    /// <returns></returns>
    public DateTime? Example3(string input)
    {

        // DateTime.TryParse 사용
        if (DateTime.TryParse(input, CultureInfo.InvariantCulture, DateTimeStyles.None, out DateTime result))
        {
            Console.WriteLine($"Parsed Date using TryParse: {result}");

            return result;
        }
        else
        {
            Console.WriteLine("The date format is invalid.");

            return null;
        }
    }


    /// <summary>
    /// 지정된 Format 으로 parse 하는 방법
    /// </summary>
    /// <param name="input"></param>
    /// <param name="format"></param>
    /// <returns></returns>
    public DateTime? Example4(string input, string format)
    {

        try
        {
            // DateTime.ParseExact 사용
            DateTime parsedDate = DateTime.ParseExact(input, format, CultureInfo.InvariantCulture);
            Console.WriteLine($"Parsed Date: {parsedDate}");
        }
        catch (FormatException)
        {
            Console.WriteLine("The date format is invalid.");
        }

        return DateTime.MinValue;
    }
}
