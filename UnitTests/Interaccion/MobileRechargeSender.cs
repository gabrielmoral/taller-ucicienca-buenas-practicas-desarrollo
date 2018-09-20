public class MobileRechargeSender
{
    private IDatabase _database;

    public MobileRechargeSender(IDatabase database)
    {
        _database = database;
    }

    public void Send(Recharge recharge)
    {
        _database.Save(recharge);

        //Code to send the mobile recharge;
    }
}
