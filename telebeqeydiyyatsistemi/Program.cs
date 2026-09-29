//2ci sual       
//Console.WriteLine(" Daire");
//        Console.WriteLine(" Duzbucaqlı");
//        Console.WriteLine(" ucbucaq");

//        Console.Write("Seciminiz ");
//        int secim;
//        int.TryParse(Console.ReadLine(), out secim);

//switch (secim)
//{
//    case 1:
//        Console.Write("radius: ");
//        double r;
//        double.TryParse(Console.ReadLine(), out r);
//        double sahe1 = Math.PI * Math.Pow(r, 2);
//        Console.WriteLine("sahe: " + Math.Round(sahe1, 2));
//        break;

//    case 2:
//        Console.Write("Uzunluq: ");
//        double a;
//        double.TryParse(Console.ReadLine(), out a);

//        Console.Write("En: ");
//        double b;
//        double.TryParse(Console.ReadLine(), out b);

//        double sahe2 = a * b;

//        Console.WriteLine("Sahə: " + Math.Round(sahe2, 2));
//        break;

//    case 3:
//        Console.Write("Əsas: ");
//        double c;
//        double.TryParse(Console.ReadLine(), out c);

//        Console.Write("Hündürlük: ");
//        double h;
//        double.TryParse(Console.ReadLine(), out h);

//        double sahe3 = (c * h) / 2;

//        Console.WriteLine("Sahə: " + Math.Round(sahe3, 2));
//        break;

//}
//3cu sual
//List<int> numbers = new List<int>();
//for (int i = 0; i < 10; i++)
//{
//    Console.Write("  eded daxil edin: ");

//    int number;
//    int.TryParse(Console.ReadLine(), out number);

//    numbers.Add(number);
//}

//int max = numbers[0];
//int min = numbers[0];

//int cut = 0;
//int tek = 0;

//foreach (int number in numbers)
//{
//    if (number > max)
//        max = number;

//    if (number < min)
//        min = number;

//    if (number % 2 == 0)
//        cut++;
//    else
//        tek++;
//}

//Console.WriteLine("en boyuk " + max);
//Console.WriteLine("en kicik" + min);
//Console.WriteLine("cut sayi" + cut);
//Console.WriteLine("tek sayi " + tek);

//4-cu tapsirig
//Random random = new Random();
//int randomNumber = random.Next(0, 101);

//int guess;
//do
//{
//    Console.Write("Ədədi tapın: ");
//    int.TryParse(Console.ReadLine(), out guess);

//    if (guess > randomNumber)
//    {
//        Console.WriteLine("Daha kiçik ədəd cəhd edin");
//    }
//    else if (guess < randomNumber)
//    {
//        Console.WriteLine("Daha böyük ədəd cəhd edin");
//    }
//    else
//    {
//        Console.WriteLine("Təbriklər!");
//    }

//} while (guess != randomNumber);
    