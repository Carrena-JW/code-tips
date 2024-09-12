using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace CodeTips.Regexs;

internal class EmailAddressValidation
{
    internal void Example()
    {
        Func<string, bool> isValidateEmailAddress = (input) =>
        {
            string pattern = @"^[^@\s]+@[^@\s]+\.[^@\s]+$";
            return Regex.IsMatch(input, pattern);
        };

        var input = "carrena@gmail.com";

        Console.WriteLine(isValidateEmailAddress(input));
    }
}
