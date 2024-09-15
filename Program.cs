// string[] names = { "Alex", "Eddie", "David", "Michael" };


// // for (int i = names.Length - 1; i >= 0; i--)
// // {
// //     Console.WriteLine(names[i]);


// // }

// // foreach (var name in names)
// // {
// //     if (name == "David") name = "Sammy";
// // }

// for (int i = 0; i < names.Length; i++)
// {
//     if (names[i] == "David")
//     {
//         names[i] = "Sammy";
//     }
// }

// foreach (var name in names)
// {
//     Console.WriteLine(name);
// }

// for (int i = 1; i <= 100; i++)
// {
//     if (i % 3 == 0 && i % 5 == 0)
//     {
//         Console.WriteLine("FizzBuzz");
//     }
//     else if (i % 3 == 0)
//     {
//         Console.WriteLine("Fizz");

//     }

//     else if (i % 5 == 0)
//     {
//         Console.WriteLine("Buzz");

//     }

//     else
//     {
//         Console.WriteLine(i);
//     }


// }


Random random = new Random();
int current = random.Next(1, 11);

// do
// {
//     current = random.Next(1, 11);
//     Console.WriteLine(current);

// } while (current != 7);

// while (current >= 3)
// {
//     Console.WriteLine(current);
//     current = random.Next(1, 11);
// }

// Console.WriteLine($"Last number: {current}");

do
{
    current = random.Next(1, 11);
    if (current >= 8) continue;

    Console.WriteLine(current);
} while (current != 7);