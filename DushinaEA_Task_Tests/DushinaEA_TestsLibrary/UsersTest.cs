using DushinaEA_MainProgram;

namespace DushinaEA_TestsLibrary;

public class UsersTest
{
    private readonly IUser _regularUser = new RegularUser(100, "John", 18, new Logger());
    private readonly IUser _premUser = new PremiumUser(1000, "Alex", 30, new Logger());
    
    [Fact]
    public void UserObjectInit()
    {
        

        Assert.NotNull(_regularUser);
        Assert.IsType<RegularUser>(_regularUser);
        Assert.NotNull(_premUser);
        Assert.IsType<PremiumUser>(_premUser);
    }
    [Fact]
    public void UserParams()
    {
        
        

        Assert.True(_regularUser.Balance >= 0);
        Assert.True(_regularUser.Age >= 0);
        Assert.True(_regularUser.Name.Length > 3);
        
        Assert.True(_premUser.Balance >= 0);
        Assert.True(_premUser.Age >= 0);
        Assert.True(_premUser.Name.Length > 3);
        
    }
    [Fact]
    public void UserParamsFail()
    {
        Assert.Throws<ArgumentException>(() => new RegularUser(100, "John", -1, new Logger()));
        Assert.Throws<ArgumentException>(() => new RegularUser(-1, "John", 10, new Logger()));
        Assert.Throws<ArgumentException>(() => new PremiumUser(-1, "Alex", 10, new Logger()));
        Assert.Throws<ArgumentException>(() => new RegularUser(-1, "Jo", 10, new Logger()));
        Assert.Throws<ArgumentException>(() => new PremiumUser(1000, "Alex", -1, new Logger()));
        Assert.Throws<ArgumentException>(() => new PremiumUser(-1, "Al", 10, new Logger()));

    }
    
    
}