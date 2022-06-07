using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*Promedio de ventas de la semana*/
namespace ejercicioshipo
{
class Program
{
static void Main(string[] args)
{
//Definicion de variable
double l, m, mi, j, v, s, prom;
//Entrada
Console.Write("de la ganancia de lunes");
l = double.Parse(Console.ReadLine());
Console.Write("de la ganancia de martes");
m = double.Parse(Console.ReadLine());
Console.Write("de la ganancia de miercoles");
mi = double.Parse(Console.ReadLine());
Console.Write("de la ganancia de jueves");
j= double.Parse(Console.ReadLine());
Console.Write("de la ganancia de viernes");
v= double.Parse(Console.ReadLine());
Console.Write("de la ganancia de sabado");
s= double.Parse(Console.ReadLine());
//Proceso
prom = (l + m + mi + j + v + s) / 6;
//Salida
Console.WriteLine("promedio es  = {0}",
prom);
Console.ReadKey();
}
}
}