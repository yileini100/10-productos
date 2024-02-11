// See https://aka.ms/new-console-template for more information

Console.WriteLine("calculo de producto");
Console.WriteLine();

// Definir arrays para productos y precios
string[] productos = new string[10];
double[] precios = new double[10];

// ingrese productos y precios

for (int i = 0; i < 10; i++)
{
    Console.Write($"Ingrese el nombre del producto {i + 1}: ");
    productos[i] = Console.ReadLine();

    Console.Write($"Ingrese el precio del producto {i + 1}: ");
    
    while (!double.TryParse(Console.ReadLine(), out precios[i]))
    {
        Console.WriteLine("Ingrese un precio válido.");
        Console.Write($"Ingrese el precio del producto {i + 1}: ");
    }
}

// Calcular el total y el promedio
double total = 0;
for (int i = 0; i < 10; i++)
{
    total += precios[i];
}

double promedio = total / 10;

// Mostrar en pantalla los resultados
Console.WriteLine("\nResumen de Productos:");
for (int i = 0; i < 10; i++)
{
    Console.WriteLine($"{productos[i]} - Precio: ${precios[i]:F2}");
}

Console.WriteLine($"\nTotal de Precio de los Productos: ${total:F2}");
Console.WriteLine($"Promedio de Precio de los Productos: ${promedio:F2}");
   


