// See https://aka.ms/new-console-template for more information
using FartKontrol23;

Console.WriteLine("Hello, World!");


SpeedMeasurement h1 = new SpeedMeasurement(123);
string returnString = h1.ToString();
Console.WriteLine(h1);

SpeedMeasurementCatalog speedCatalog = new SpeedMeasurementCatalog("Maglegårdsvej 2", "By", 50);
speedCatalog.AddSpeedMeasurement(61);
speedCatalog.AddSpeedMeasurement(75);

//Udgangspunkt for sekvensdiagram
speedCatalog.AddSpeedMeasurement(90);

double average = speedCatalog.AvarageSpeed();
Console.WriteLine(average );

Console.WriteLine("Test af ToString i SpeedMeasurementCatalog");
Console.WriteLine(speedCatalog.ToString());

