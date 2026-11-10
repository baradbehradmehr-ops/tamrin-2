Console.Clear();
Console.Write("Radius: ");
var Radius=Convert.ToInt32(Console.ReadLine());
Console.WriteLine(@$"perimeter: {Radius*Math.PI*2} 
Area: {Radius*Radius*Math.PI}");
