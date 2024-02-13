// See https://aka.ms/new-console-template for more information

using DushinaEA_MainProgram;


ILogger logger = new Logger();
var users = InitUsers();
UserManager userManager = new UserManager(users, logger);

userManager.GiveStocksToUsers();
LogInUsers();

IUser[] InitUsers()
{

    IUser[] users = new IUser[] { };
    try
    {
        users = new IUser[]
        {
            new RegularUser(100, "Paulo", 20, logger),
            new RegularUser(200, "Maxim", 21, logger),
            new RegularUser(250, "Felix", 25, logger),
            new RegularUser(300, "Alexey", 26, logger),
            new PremiumUser(1000, "Alex", 30, logger),
            new PremiumUser(5000, "Michael", 35, logger),
            new PremiumUser(10000, "George", 40, logger)

        };
    }
    catch (ArgumentException ex)
    {
        logger.Log("Program failed");
        throw;

    }

    return users;
}

void LogInUsers()
{
    ConsoleKeyInfo key;
    do
    {
        logger.Log("Введите имя пользователя");
        userManager.LogInUser(Console.ReadLine());
        logger.Log("Для завершения программы нажмите ESC, для продолжения любую другую клавишу");
        key = Console.ReadKey();
    } while (key.Key != ConsoleKey.Escape);

}
