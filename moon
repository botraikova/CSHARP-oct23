double averageSpeed = double.Parse(Console.ReadLine());
double litresNeededPer100 = double.Parse(Console.ReadLine());


double distanceToAndBack = 384_400 * 2;
double timeToAndBack = Math.Ceiling(distanceToAndBack / averageSpeed);
double timeTotal = timeToAndBack + 3;
double litresTotal = (litresNeededPer100 * distanceToAndBack) / 100;

Console.WriteLine(timeTotal);
Console.WriteLine(litresTotal);
