


//var zipExample = new Zip();
//zipExample.Exmaple1();


//var parseDatetime = new ParseDatetime();
//parseDatetime.Example1();



//new EmailAddressValidation().Example();

//var isNTFS = new NTFS().IsNTFS("D:\\workspace\\TestWatchFolder");

//isNTFS.Dump();



using System.Diagnostics;

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