// See https://aka.ms/new-console-template for more information
Console.WriteLine("名前を入力して下さい : ");
string? name = Console.ReadLine();
Console.Write("年齢を入力して下さい : ");
int age = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("<html>");
Console.WriteLine("<body>");
Console.WriteLine("<p>" + name + "さん、こんにちは！</p>");
Console.WriteLine("<p>" + name + "さんは" + Convert.ToString(age) + "歳です</p>");
Console.WriteLine("</body>");
Console.WriteLine("/html");
