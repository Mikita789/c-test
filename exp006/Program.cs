Console.WriteLine("Введите свое имя");
string userName = Console.ReadLine();
if(userName.ToLower() == "никита")
{
   Console.Write("Ну наконец ты вернулся!) Привет, ");
   Console.WriteLine(userName);
}
else
{
    Console.Write("Привет, ");
    Console.WriteLine(userName);
}