// See https://aka.ms/new-console-template for more information
Console.WriteLine("身長を入力して下さい(m) : ");
double bodyHeight = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("体重を入力して下さい(kg) : ");
double bodyWeight = Convert.ToDouble(Console.ReadLine());
double bmi = bodyWeight / (bodyHeight * bodyHeight);
Console.WriteLine("BMI : " + bmi);
if (bmi < 18.5)
{
    Console.WriteLine("低体重です");
}
else if (bmi < 25)
{
    Console.WriteLine("標準体重です");
}
else
{
    Console.WriteLine("肥満です");
}

