// See https://aka.ms/new-console-template for more information
using System.Globalization;

int[] numbers = new int[] { 10, 5, -8, 0, 1 };

Console.WriteLine("<html><body>");
Console.WriteLine("<table border=\"1\">");
int sum = 0;
for (int i = 0; i < numbers.Length; i++) 
{
    Console.WriteLine($"<tr><td>配列の{i}番目</td><td>{numbers[i]}</td></tr>");
    sum += numbers[i];
}
Console.WriteLine("</table>");
double average = (double)sum / numbers.Length;
Console.WriteLine($"<p>平均値は{average:F2}</p>");
Console.WriteLine("</body></html>");
