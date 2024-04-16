Console.WriteLine("Hola, Bienvenido a FizzBuzz!");

for (int i = 1; i <= 100; i++)
{
    switch (i % 3)
    {
        case 0 when i % 5 == 0:
            Console.WriteLine("fizzbuzz");
            break;
        case 0:
            Console.WriteLine("fizz");
            break;
        default:
        {
            if (i % 5 == 0)
            {
                Console.WriteLine("buzz");
            }
            else
            {
                Console.WriteLine(i);
            }

            break;
        }
    }
}