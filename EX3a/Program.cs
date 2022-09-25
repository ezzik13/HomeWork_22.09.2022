Console.Clear();
Console.Write("Пожалуйста, введите значение: ");
int number = Convert.ToInt32( Console.ReadLine() );
int count = 1;
// string totalString = "";

while (count <= number) {
    //totalString += Math.Pow(count, 2) + " ";
    Console.Write($"{Math.Pow(count, 2)} ");
    count++;
}

/* Console.WriteLine(totalString); */
