//Crea un programa que solicite al usuario la base y la altura de
//un triángulo. El programa debe incluir una función llamada
//calcular_area_triangulo que reciba como parámetros la base y
//la altura, y devuelva el área del triángulo. La fórmula para
//calcular el área es:
//Area = (base * altura) / 2
using System;
using System.Collections.Generic;

class Program
{
    // Función para calcular el área de un triángulo
    static double CalcularAreaTriangulo(double baseTriangulo, double altura)
    {
        // Fórmula para calcular el área: (base * altura) / 2
        return (baseTriangulo * altura) / 2;
    }

    static void Main(string[] args)
    {
        // Lista para almacenar los triángulos como tuplas (base, altura)
        List<(double baseTriangulo, double altura)> triangulos = new List<(double, double)>();

        // Solicitar al usuario la cantidad de triángulos a procesar
        Console.Write("Ingrese la cantidad de triángulos que desea calcular: ");
        if (int.TryParse(Console.ReadLine(), out int cantidadTriangulos))
        {
            // Ciclo para solicitar la base y altura de cada triángulo
            for (int i = 1; i <= cantidadTriangulos; i++)
            {
                Console.WriteLine($"\nTriángulo #{i}:");
                Console.Write("Ingrese la base: ");
                double baseTriangulo = Convert.ToDouble(Console.ReadLine());

                Console.Write("Ingrese la altura: ");
                double altura = Convert.ToDouble(Console.ReadLine());

                // Agregar la base y la altura a la lista como una tupla
                triangulos.Add((baseTriangulo, altura));
            }

            // Calcular y mostrar el área de cada triángulo
            Console.WriteLine("\nÁreas de los triángulos:");
            for (int i = 0; i < triangulos.Count; i++)
            {
                var triangulo = triangulos[i];
                double area = CalcularAreaTriangulo(triangulo.baseTriangulo, triangulo.altura);
                Console.WriteLine($"====== Área del triángulo #{i + 1} =======");
                Console.WriteLine($"Base: {triangulo.baseTriangulo}");
                Console.WriteLine($"Altura: {triangulo.altura}");
                Console.WriteLine($"Área: {area}\n");
            }
        }
        else
        {
            Console.WriteLine("Por favor, ingrese un número válido.");
        }

        Console.ReadKey();
    }
}

