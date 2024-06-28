// See https://aka.ms/new-console-template for more information
Console.WriteLine("身長を入力して下さい : ");
double height = Convert.ToDouble(Console.ReadLine());
Console.Write("体重を入力して下さい : ");
double weight = Convert.ToDouble(Console.ReadLine());
double bmi = weight / (height * height);
Console.WriteLine("<html><body>");
Console.WriteLine($"<p>あなたのBMIは{bmi:F2}</p>");
if(bmi < 18.5)
{
    Console.WriteLine("<p><strong>低体重</strong>です</p>");
}
else if (bmi < 25)
{
    Console.WriteLine("<p>標準体重です</p>");
}
else
{
    Console.WriteLine("<p>肥満体重です</p>");
}
