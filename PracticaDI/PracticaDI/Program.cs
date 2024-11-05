// See https://aka.ms/new-console-template for more information
using PracticaLCP;

FiguraGeometrica figura = new FiguraGeometrica { Base = 5, Altura = 3 };
Rectangulo rectangulo = new Rectangulo { Base = 5, Altura = 3 };
Cuadrado cuadrado = new Cuadrado { Base = 4, Altura = 4 }; // Aquí debería ser igual

Console.WriteLine($"Área de la figura: {figura.CalcularArea()}");
Console.WriteLine($"Área del rectángulo: {rectangulo.CalcularArea()}");
Console.WriteLine($"Área del cuadrado: {cuadrado.CalcularArea()}");

//Refactorizando
FiguraGeometricaR figuraR = new FiguraGeometricaR(); // no se debe instanciar directamente
RectanguloR rectanguloR = new RectanguloR { Base = 5, Altura = 3 };
CuadradoR cuadradoR = new CuadradoR { Lado = 4 };



Console.WriteLine($"Área del rectángulo: {rectanguloR.CalcularArea()}");
Console.WriteLine($"Área del cuadrado: {cuadradoR.CalcularArea()}");
