using System;
using App.Shared;
using Xunit;

namespace App.Tests
{
    public class MessengerServiceTests
    {
        [Fact]
        public void ConstructorNoArgumentTest()
        {
            var target = new MessengerService();

            string expected = "Hello, World!";
            string actual = target.GetMessage();

            Assert.Equal(expected, actual);
        }

        [Fact]
        public void ConstructorNullArgumentTest()
        {
            Assert.Throws<ArgumentNullException>(
                () => new MessengerService(null!)
            );
        }

        [Fact]
        public void ConstructorStringArgumentTest()
        {
            string payload = "Test";
            var target = new MessengerService(payload);
            
            string expected = "Hello, Test!";
            string actual = target.GetMessage();

            Assert.Equal(expected, actual);
        }
    }
}