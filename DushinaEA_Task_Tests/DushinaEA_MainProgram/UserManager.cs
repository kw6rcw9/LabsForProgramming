namespace DushinaEA_MainProgram;

public class UserManager
{
    private readonly IUser[] _users;
    private readonly ILogger _logger;
    public UserManager(IUser[] usersArray, ILogger logger)
    {
        _users = usersArray;
        _logger = logger;
    }

    public void GiveStocksToUsers()
    {
        
        var regularUsers =  _users
            .OrderBy(x => x.Age)
            .Where(x => x.GetType() == typeof(RegularUser))
            .Take(3)
            .ToList();
        var premiumUsers = _users
            .OrderBy(x => x.DateOfRegister)
            .Where(x => x.GetType() == typeof(PremiumUser))
            .Take(5)
            .ToList();
        string[] regStocks = new string[] { "AlphaBank", "Gazprom", "Aeroflot", "Sberbank" };
        string[] premStocks = new string[] { "Premium AlphaBank", "Premium Gazprom", "Premium Aeroflot", "Premium Sberbank" };
        Random rnd = new Random();
        if (regularUsers.Count > 0)
        {
            foreach (var user in regularUsers)
            {
                
                user.Stocks = regStocks[rnd.Next(0,4)];
            }
            
        }

        if (premiumUsers.Count > 0)
        {
            foreach (var user in premiumUsers)
            {
                
                user.Stocks = premStocks[rnd.Next(0,4)];
            }
            
        }
        

    }

    public void LogInUser(string? userName)
    {
        var currentUser = _users.FirstOrDefault(x => x.Name == userName);
        try
        {
            if (currentUser == null)
                throw new ArgumentException();

        }
        catch (ArgumentException)
        {
            
            _logger.Log($"User {userName} does not exist");
            return;
        }
        currentUser.LogIn();
        currentUser.RunApp();
            
    }
}