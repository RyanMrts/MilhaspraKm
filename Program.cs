double milhas, kilometros;

Console.Write("digte a medida desejada em milhas: ");
milhas = Convert.ToDouble(Console.ReadLine());

kilometros = milhas * 1.609;
Console.WriteLine($"em Km:  {kilometros}" );