using System;
using Xunit;

namespace buenas_practicas_desarrollo
{
    public class MobileRechargeSenderShould
    {
        [Fact]
        public void SaveRechargeInTheDatabase()
        {
            //Arrange
            var recharge = new Recharge
            {
                Number = "34601123123",
                Amount = 10
            };

            var database = new FakeDatabase();

            //Act
            var mobileRechargeSender = new MobileRechargeSender(database);

            mobileRechargeSender.Send(recharge);

            //Assert
            Assert.True(database.HasBeenCalled);
        }
    }

    internal class FakeDatabase : IDatabase
    {
        public bool HasBeenCalled { get; private set; } = false;

        public void Save(Recharge recharge)
        {
            HasBeenCalled = true;
        }
    }
}
