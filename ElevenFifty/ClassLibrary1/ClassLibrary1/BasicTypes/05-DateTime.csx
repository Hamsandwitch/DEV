using System;
using System.Threading.Tasks;
// the above are 'namespace' declarations that tell the code-space to import specific libraries from the System, to be used in this project.

//var d = new DateTimeOffset();
var d = new DateTime(2016, 7, 6); // (intYear, intMonth, intDay) - Intellisense informs of options.

var d2 = DateTime.Parse("2016-07-06T11:05:00");

var now = DateTime.Now;
var utcNow = DateTime.UtcNow;


var start = DateTime.Now;
Task.Delay(1000).Wait();
var end = DateTime.Now;
(end - start).TotalSeconds
    $"{end:r}"