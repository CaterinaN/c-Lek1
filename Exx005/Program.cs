Console.Write("Введите имя пользователя: ");
string username = Console.ReadLine();

if (username.ToLower() == "kate")
{
  Console.WriteLine("Ура ,это же Катяя");
}
else
{ 
    Console.Write("Привет, ");
    Console.Write(username);
}