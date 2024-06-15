using System;

    static void OnOptionalFilledHandler(int? value)
    {
        Console.WriteLine($"Optional filled with value: {value}");
    }

    static void OnOptionalEmptiedHandler()
    {
        Console.WriteLine("Optional emptied.");
    }

   
        int numOptionals;
        Console.WriteLine("Enter the number of Optional objects: ");
        if (!int.TryParse(Console.ReadLine(), out numOptionals) || numOptionals < 1)
        {
            Console.WriteLine("Invalid input. Exiting program.");
            return;
        }

        Optional<int>[] optionals = new Optional<int>[numOptionals];

        for (int i = 0; i < numOptionals; i++)
        {
            Console.WriteLine($"Enter value for Optional {i + 1}: ");
            if (int.TryParse(Console.ReadLine(), out int value))
            {
                optionals[i] = new Optional<int>(value);
            }
            else
            {
                optionals[i] = new Optional<int>();
            }
        }

        ExtendedOptional<int?> extendedOptional = new ExtendedOptional<int?>();
        extendedOptional.OnOptionalFilled += OnOptionalFilledHandler;
        extendedOptional.OnOptionalEmptied += OnOptionalEmptiedHandler;

        extendedOptional.SetValue(42);
        Console.WriteLine("ExtendedOptional set to 42.");
        extendedOptional.SetValue(null);
        Console.WriteLine("ExtendedOptional set to null.");

        foreach (var o in optionals)
        {
            Console.WriteLine(o);
        }
        Console.WriteLine(extendedOptional);
    


