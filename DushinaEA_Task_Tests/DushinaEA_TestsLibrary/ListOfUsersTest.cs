using DushinaEA_MainProgram;

namespace DushinaEA_TestsLibrary;

public class ListOfUsersTest
{

    private IUser[] _users = new IUser[]
    {
        new RegularUser(100, "Paulo", 20, new Logger()),
        new RegularUser(200, "Maxim", 21, new Logger()),
        new RegularUser(250, "Felix", 25, new Logger()),
        new RegularUser(300, "Alexey", 26, new Logger()),
        new PremiumUser(1000, "Alex", 30, new Logger()),
        new PremiumUser(5000, "Michael", 35, new Logger()),
        new PremiumUser(10000, "George", 40, new Logger()),
        new PremiumUser(100000, "Greg", 32, new Logger()),
        new PremiumUser(30000, "Antonio", 45, new Logger()),
        new PremiumUser(50000, "Eduarto", 50, new Logger())

    };
    
    [Fact]
    public void ArrayObject()
    {
        IUser[] users = new IUser[]
        {
            new RegularUser(100, "Paulo", 20, new Logger()),
            new RegularUser(200, "Maxim", 21, new Logger()),
            new PremiumUser(1000, "Alex", 30, new Logger()),
            new PremiumUser(5000, "Michael", 35, new Logger()),
            new PremiumUser(10000, "George", 40, new Logger()),
            new RegularUser(300, "Alexey", 26, new Logger()),
            new RegularUser(250, "Felix", 25, new Logger()),
            new PremiumUser(100000, "Greg", 32, new Logger()),
            new PremiumUser(30000, "Antonio", 45, new Logger()),
            new PremiumUser(50000, "Eduarto", 50, new Logger())

        };
        Assert.Equal(_users.GetType(), users.GetType());
        
    }
    
}