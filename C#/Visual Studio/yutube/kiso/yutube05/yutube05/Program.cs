// See https://aka.ms/new-console-template for more information
Console.WriteLine("身長を入力して下さい : ");
double height = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("体重を入力して下さい : ");
double weight = Convert.ToDouble(Console.ReadLine());
double bmi = weight / (height * height);

Console.WriteLine("<html><body>");
Console.WriteLine("<table border=\"02\">");
Console.WriteLine($"<tr><td>身長</td><td>{height}</td></tr>");
Console.WriteLine($"<tr><td>体重</td><td>{weight}</td></tr>");
Console.WriteLine($"<tr><td>BMI</td><td>{bmi}</td></tr>");
Console.WriteLine("</table>");
Console.WriteLine("</body></html>");