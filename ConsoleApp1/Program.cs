Console.Clear();
Console.Write("number(1/2)");
var number1=Convert.ToInt32(Console.ReadLine());
Console.Write("number(2/2)");
var number2=Convert.ToInt32(Console.ReadLine());
Console.WriteLine(@$"perimeter {(number1+number2)*2} 
Area: {number1*number2}");
