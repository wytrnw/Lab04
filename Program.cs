int age1 = 20;
if (age1 >= 18) {
    Console.WriteLine("Доступ разрешён");
}
    Console.WriteLine("Программа продолжает работу");


int age2 = 20;
if (age2 >= 21) {
    Console.WriteLine("Доступ разрешён");
}
    Console.WriteLine("Программа продолжает работу");


int age3 = 15;
if (age3 >= 18)
{
    Console.WriteLine("Доступ разрешён");
}
else
{
    Console.WriteLine("Доступ запрещён");
}


int age4 = 15;
if (age4 >= 18) {
    Console.WriteLine("Доступ разрешён");
} else {
    Console.WriteLine("Доступ запрещён");
    Console.WriteLine($"До совершеннолетия: {18 - age4} года");
}



