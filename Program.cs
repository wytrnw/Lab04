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


int age5 = 14;
if (age5 < 13)
{
    Console.WriteLine("Ребёнок");
}
else if (age5 < 18)
{
    Console.WriteLine("Подросток");
}
else
{
    Console.WriteLine("Взрослый");
}


int age6 = 14;
if (age6 < 13) {
    Console.WriteLine("Ребёнок");
} else if (age6 < 18) {
    Console.WriteLine("Подросток");
} else if (age6 >= 60) {
    Console.WriteLine("Пенсионер");
} else {
    Console.WriteLine("Взрослый");
}


int age7 = 16;
double height = 1.55;
bool hasAdult = true;
if (age7 >= 14 && height >= 1.5) {
    Console.WriteLine("Можно кататься");
} else {
    Console.WriteLine("Пока нельзя");
}


int age = 16;
double height1 = 1.55;
bool hasAdult1 = true;
if (age >= 14 && height1 >= 1.5) {
    Console.WriteLine("Можно кататься");
} else if (height1 < 1.5 && hasAdult1) {
    Console.WriteLine("Можно кататься с сопровождением взрослого");
} else {
    Console.WriteLine("Пока нельзя");
}


Console.WriteLine();
Console.WriteLine("Задача А.");

Console.Write("Введите число: ");
int n = int.Parse(Console.ReadLine());
if (n % 2 == 0)
    Console.WriteLine("Чётное");
else
    Console.WriteLine("Нечётное");

Console.WriteLine();
Console.WriteLine("Задача Б.");

Console.Write("Введите оценку: ");
int grade = int.Parse(Console.ReadLine());
switch (grade)
{
    case 5:
        Console.WriteLine("Отлично");
        break;
    case 4:
        Console.WriteLine("Хорошо");
        break;
    case 3:
        Console.WriteLine("Удовлетворительно");
        break;
    case 2:
        Console.WriteLine("Неудовлетворительно");
        break;
    default:
        Console.WriteLine("Неверная оценка");
        break;
}







Console.Write("Введите ваш возраст (целое число): ");
string input = Console.ReadLine();

if (int.TryParse(input, out int age8))
{
    // Проверяем условие доступа
    if (age8 >= 18)
    {
        Console.WriteLine("Доступ разрешён");
    }
    else
    {
        Console.WriteLine("Доступ запрещён");
    }
}
else
{
    Console.WriteLine("Ошибка: пожалуйста, введите корректное целое число.");
}





Console.Write("Введите сумму покупки: ");
string input2 = Console.ReadLine();


if (double.TryParse(input2, out double amount))
{
double discountPercent = 0;


if (amount > 1000)
{
discountPercent = 10; // Скидка 10%
}
else if (amount > 500)
{
discountPercent = 5;  
}
double finalAmount = amount * (100 - discountPercent) / 100;

Console.WriteLine($"Сумма покупки: {amount:F2} руб.");

if (discountPercent > 0)
{
Console.WriteLine($"Применена скидка: {discountPercent}%");
Console.WriteLine($"Итого к оплате: {finalAmount:F2} руб.");
}
else
{
Console.WriteLine("Скидка не применяется");
Console.WriteLine($"Итого к оплате: {amount:F2} руб.");
}
}
else
{
Console.WriteLine("Ошибка: пожалуйста, введите корректное число.");
}
