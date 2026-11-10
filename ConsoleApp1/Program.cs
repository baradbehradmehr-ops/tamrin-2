Console.Clear();
Console.Write("number(1/3): ");
var number1=Convert.ToInt32(Console.ReadLine());
Console.Write("number(2/3): ");
var number2=Convert.ToInt32(Console.ReadLine());
Console.Write("number(3/3): ");
var number3=Convert.ToInt32(Console.ReadLine());
Console.WriteLine(@$"avg: {(number1+number2+number3)/3D}");