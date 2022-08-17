/*
Console.Write("Введите имя пользователя: ");
string username = Console.ReadLine();

if (username == "Олеся")
{
    Console.WriteLine("Ура, это же ОЛЕСЯ!");
}
else
{
    Console.Write("Привет, ");
    Console.WriteLine(username);
}
*/
Console.Write("Введите имя пользователя: ");
string username = Console.ReadLine();

if (username.ToLower() == "олеся")
{
    Console.WriteLine("Ура, это же ОЛЕСЯ!");
}
else
{
    Console.Write("Привет, ");
    Console.WriteLine(username);
}
