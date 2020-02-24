using NUnit.Framework;
using NSubstitute;
using FlowerShop;

namespace Tests
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void Test1()
        {
            //Assign
            IOrder o = Substitute.For<Order>();
            IClient c = Substitute.For<Client>();
            //Act
            
            
            //Assert
            o.Received();
        }
    }
}