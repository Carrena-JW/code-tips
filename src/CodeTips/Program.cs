


//var zipExample = new Zip();
//zipExample.Exmaple1();


//var parseDatetime = new ParseDatetime();
//parseDatetime.Example1();



//new EmailAddressValidation().Example();

//var isNTFS = new NTFS().IsNTFS("D:\\workspace\\TestWatchFolder");

//isNTFS.Dump();



using CodeTips.TestSutff;
using System.Diagnostics;


#region [Parse Datetime any format]

var parser = new ParseDatetime();

var inputAnyFormat = new List<string>
{
    "2/3/2021",
    "2024-12-03",
    "20241203",
    "2024.12.03"
};

inputAnyFormat.ForEach(x =>
{
    parser.Example2(x);
    parser.Example3(x);
});





#endregion



return;

#region [Enum test]


((int)TestEnum.test).Dump();
((int)TestEnum.test1).Dump();
((int)TestEnum.test2).Dump();
((int)TestEnum.test3).Dump();
((int)TestEnum.test4).Dump();

Enum.Parse(typeof(TestEnum), "test").Dump();
Enum.Parse(typeof(TestEnum), "test1").Dump();
Enum.Parse(typeof(TestEnum), "test2").Dump();
Enum.Parse(typeof(TestEnum), "test3").Dump();


nameof(TestEnum.test).Dump();
nameof(TestEnum.test1).Dump();
nameof(TestEnum.test2).Dump();
nameof(TestEnum.test3).Dump();
nameof(TestEnum.test4).Dump();



nameof(TestEnum.test).Dump();
nameof(TestEnum.test1).Dump();
nameof(TestEnum.test2).Dump();
nameof(TestEnum.test3).Dump();
nameof(TestEnum.test4).Dump();


#endregion





return;


Func<(string, string)> createDummyFile = () =>
{
    var rootPath = "D:\\workspace\\TestWatchFolder";

    var id = Ulid.NewUlid();

    var fileName = $"{id}.pickup";

    var fileFullPath = Path.Combine(rootPath, fileName);

    File.WriteAllText(fileFullPath, string.Empty);

    return (id.ToString(), fileFullPath);
};



#region [NTFS with ADS]
var ntfs = new NTFS();


if (false)
{
    while (true)
    {

       var (createdId, createdFilePath) =  createDummyFile();

        ntfs.WriteToADS(createdFilePath, createdId);

        await Task.Delay(1);
    }
}




//var testFilePath = "D:\\workspace\\TestWatchFolder\\240919_133676291.pickup";

//var fileId = Ulid.NewUlid().ToString();

//ntfs.WriteToADS(testFilePath, fileId);

//fileId.Dump();
#endregion



var files = Directory.GetFiles("D:\\workspace\\TestWatchFolder").ToList();


var sw = new Stopwatch();
sw.Start();

files.ForEach(x => 
{
    $"FilePath: {x}".Dump();
    $"FileId: {ntfs.ReadFromADS(x)}".Dump();
});

sw.Stop();

sw.Elapsed.TotalMilliseconds.Dump();
// "01J84H4M57YH7EWJ3B5Q0DSENY"















Console.ReadKey();