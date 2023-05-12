Console.WriteLine("Введите имя пользователя: ");
string name = Console.ReadLine();
    if(name.ToLower() == "маша"){
        Console.WriteLine("Ура, это же Маша!");
    } else{
        Console.WriteLine("Привет, " + name);
    }
