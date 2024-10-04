using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeTips.Convert;

internal class ConvertToEnum
{
    internal SomeStuffEnum Example()
    {
        var input = 1234;

        if (Enum.IsDefined(typeof(SomeStuffEnum), input))
        {
            return (SomeStuffEnum)input; // int 값을 SomeEnum으로 변환
        }
        else
        {
            throw new ArgumentException("유효하지 않은 enum 값입니다.", nameof(input));
        }
    }
}



enum SomeStuffEnum
{
    FirstValue = 1234
}