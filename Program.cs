Console.WriteLine("\n------------------- Quadrado -------------------");

Quadrado q1 = new Quadrado(8.0);

Console.WriteLine($"Lado do Quadrado: {q1.Lado}");
Console.WriteLine($"Area do Quadrado: {q1.Area}");
Console.WriteLine($"Perimetro do Quadrado: {q1.Perimetro}");

q1.Lado = 5.0;

Console.WriteLine($"\nLado do Quadrado modificado: {q1.Lado}");
Console.WriteLine($"Área do Quadrado modificado: {q1.Area}");
Console.WriteLine($"Perimetro do Quadrado modificado: {q1.Perimetro}");


Console.WriteLine("\n------------------- Retângulo -------------------");

Retangulo r1 = new Retangulo(5.0, 20.0);

Console.WriteLine($"\nLado do Retângulo: {r1.Base}");
Console.WriteLine($"Altura do Retângulo: {r1.Altura}");
Console.WriteLine($"Perímetro do Retângulo: {r1.Perimetro}");
Console.WriteLine($"Área do Retângulo: {r1.Area}");

r1.Base = 10.0;
r1.Altura = 9.0;

Console.WriteLine($"\nLado do Retângulo modificado: {r1.Base}");
Console.WriteLine($"Altura do Retângulo modificado: {r1.Altura}");
Console.WriteLine($"Perímetro do Retângulo modificado: {r1.Perimetro}");
Console.WriteLine($"Área do Retângulo modificado: {r1.Area}");