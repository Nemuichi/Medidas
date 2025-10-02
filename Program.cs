double kmMedida, metroMedida, cmMedida;


Console.Write("Entre com a medida em metros: ");
metroMedida = Convert.ToDouble(Console.ReadLine()!);

kmMedida = metroMedida / 1000;
cmMedida = metroMedida * 100;


Console.WriteLine("Conversão em:");

Console.WriteLine($"Centímetros: {cmMedida}");
Console.WriteLine($"Metro: {metroMedida}");
Console.WriteLine($"Quilômetro: {kmMedida}");
