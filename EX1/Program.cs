using static System.Console;
Clear();
Write("Введите номер четверти: ");
int num = Convert.ToInt32(ReadLine()!);
// if (num<1||num>4)
// {
//     WritekLine("error!");
//     return;
// }

// if (num==1)
// {
//     WritekLine("X>0 Y>0");
// }
// if (num==2)
// {
//     WritekLine("X<0 Y>0");
// }
// if (num==3)
// {
//     WritekLine("X<0 Y<0");
// }
// if (num==4)
// {
//     WritekLine("X>0 Y<0");
// }
switch (num)
{
    case 1:
        {
            WriteLine("X>0 Y>0");
            break;

        }
    case 2:
        {
            WriteLine("X<0 Y>0");
            break;
        }
    case 3:
        {
            WriteLine("X<0 Y<0");
            break;
        }
    case 4:
        {
            WriteLine("X>0 Y<0");
            break;
        }
    default:
        {
            WriteLine("Error!");
            break;
        }

}

