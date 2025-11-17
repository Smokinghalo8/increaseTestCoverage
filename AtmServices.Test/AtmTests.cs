namespace AtmServices.Test;

using AtmServices;

public class AtmTests

{

    Atm testAtm;

    int initialBalance = 100;

    public AtmTests() {

        testAtm = new Atm(initialBalance);

    }

 

    [Fact]
    public void Test_Withdraw()
    {

        var result = testAtm.withdraw(25);

        Assert.True(result);

        Assert.Equal(75, testAtm.getBalance());
    }


    [Fact]
    public void Test_Insufficient_Funds()
    {
        var result = testAtm.withdraw(500);
        Assert.False(result);
        Assert.Equal(100, testAtm.getBalance());
    }

    [Fact]
    public void TestDepsotite()
    {
        var result = testAtm.deposit(500);
        Assert.True(result);
        Assert.Equal(600, testAtm.getBalance());
    }

    [Fact]
    public void TestDepoLessThanMin()
    {
        var result = testAtm.deposit(-100);
        Assert.False(result);
        Assert.Equal(100, testAtm.getBalance());
    }

}