namespace gmreburn.Tests
{
    using System;
    using System.Threading;
    using Microsoft.VisualStudio.TestTools.UnitTesting;

    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void NowIsNotNull()
        {
            // Arrange

            // Act

            // Assert
            Assert.IsNotNull(SystemTime.Now);
        }

        [TestMethod]
        public void NowIsSettable()
        {
            // Arrange
            var expected = DateTime.Now;
            Thread.Sleep(1);

            // Act
            SystemTime.Now = expected;

            // Assert
            Assert.AreEqual(expected, SystemTime.Now);
        }

        [TestMethod]
        public void NowIsNotNullWhenSetToNull()
        {
            // Arrange

            // Act
            SystemTime.Now = null;

            // Assert
            Assert.IsNotNull(SystemTime.Now);
        }

        [TestMethod]
        public void UtcNowIsNotNull()
        {
            // Arrange

            // Act

            // Assert
            Assert.IsNotNull(SystemTime.UtcNow);
        }

        [TestMethod]
        public void UtcNowIsSettable()
        {
            // Arrange
            var expected = DateTime.UtcNow;
            Thread.Sleep(1);

            // Act
            SystemTime.UtcNow = expected;

            // Assert
            Assert.AreEqual(expected, SystemTime.UtcNow);
        }

        [TestMethod]
        public void UtcNowIsNotNullWhenSetToNull()
        {
            // Arrange

            // Act
            SystemTime.Now = null;

            // Assert
            Assert.IsNotNull(SystemTime.UtcNow);
        }
    }
}