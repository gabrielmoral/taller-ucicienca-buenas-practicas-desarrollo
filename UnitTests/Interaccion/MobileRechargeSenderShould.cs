public class MobileRechargeSenderShould
{
    [Fact]
    public void SaveRechargeInTheDatabase()
    {
        //Preparar
        var recharge = new Recharge
        {
            Number = "34601123123",
            Amount = 10
        };

        var database = new FakeDatabase();

        //Actuar
        var mobileRechargeSender = new MobileRechargeSender(database);

        mobileRechargeSender.Send(recharge);

        //Afirmar
        Assert.True(database.HasBeenCalled);
    }
}

public class FakeDatabase : IDatabase
{
    public bool HasBeenCalled { get; private set; } = false;

    public void Save(Recharge recharge)
    {
        HasBeenCalled = true;
    }
}