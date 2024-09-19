


using CodeTips.Linq;
using CodeTips.Parse;
using CodeTips.Regexs;
using CodeTips.Windows;
using Dumpify;

//var zipExample = new Zip();
//zipExample.Exmaple1();


//var parseDatetime = new ParseDatetime();
//parseDatetime.Example1();



//new EmailAddressValidation().Example();

var isNTFS = new NTFS().IsNTFS("D:\\workspace\\TestWatchFolder");

isNTFS.Dump();

Console.ReadKey();