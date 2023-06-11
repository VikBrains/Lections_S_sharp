Console.Write("Input User Name: ");
string username = Console.ReadLine();

if(username.ToLower() == "mary")
{
    Console.WriteLine("Ура, это же МАША!");
}
else
{
    Console.Write("Hello, ");
    Console.WriteLine(username);
}