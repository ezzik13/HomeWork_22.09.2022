Console.Clear();
Console.Write("Пожалуйста, введите число от 1 до 7: ");
int numberDay = Convert.ToInt16( Console.ReadLine() );

switch (numberDay) 
{
    case 1: 
    {
        Console.WriteLine("Сегодня понедельник");
        break;
    }
    
    case 2: 
    {
        Console.WriteLine("Сегодня вторник");
        break;
    }
    case 3: 
    {
        Console.WriteLine("Сегодня среда");
        break;
    }
    case 4: 
    {
        Console.WriteLine("Сегодня четверг");
        break;
    }
    case 5: 
    {
        Console.WriteLine("Сегодня пятница");
        break;
    }
    case 6: 
    {
        Console.WriteLine("Сегодня суббота");
        break;
    }
    case 7: 
    {
        Console.WriteLine("Сегодня воскресение");
        break;
    }
    default: {
        Console.WriteLine("На этой планете не существует такой систем счичсления дней недели");
        break;
    }

}
