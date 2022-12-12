// // Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.
//Точки для уравнений пользователь вводит с клавиатуры, можно через несколько ReadLine
//b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)


Console.WriteLine("Введите коэффициенты точек в порядке k1,b1,k2,b2");

double[] points = new double[4];
for(int i =0; i<points.Length; i++)
{
    points[i] = Convert.ToDouble(Console.ReadLine());
}
Console.WriteLine(string.Join(",", points));

Console.WriteLine(string.Join(",", (Coordinates(points))));

double[] Coordinates(double[] array)
{
double[] coord = new double[2];
if (array[0] == array[2])
Console.WriteLine("Прямые не пересекаются");
else
    {
        
        double x = (array[3]-array[1])/(array[0]-array[2]);
        double y = (array[0]*x+array[1]);
        coord[0]=x;
        coord[1]=y;
    }   
return coord; 
}