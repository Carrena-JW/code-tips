using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeTips.Linq;

internal class ReadableTallLinq
{
    private List<int> _sampleList = Enumerable.Range(1, 200).ToList();

    public void Example1()
    {
        // Before
        _sampleList.Where(x => x > 100).OrderBy(x => x).Select(x=> x).ToList();

        // After
        _sampleList
            .Where(x => x > 100)
            .OrderBy(x => x)
            .Select(x => x)
            .ToList();
    }
}
