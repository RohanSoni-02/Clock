using NUnit.Framework;
using ClockTasks;
namespace CounterTest
{
    [TestFixture]
    public class Tests
    {
        Counter sample;
        [SetUp]
        public void Setup()
        {
            sample = new Counter("Hi");
        }

        [Test]
        public void CounterStart()
        {
            Assert.AreEqual(sample.Ticks,0);
        }

        [Test]
        public void CounterSingleIncrement()
        {
            sample.Increment();
            Assert.AreEqual(sample.Ticks, 1);
        }

        [Test]
        public void CounterMultipleIncrement()
        {
            sample.Increment();
            sample.Increment();
            sample.Increment();
            sample.Increment();
            Assert.AreEqual(sample.Ticks, 4);
        }


        [Test]
        public void ResetCounter()
        {
            sample.Reset();
            Assert.AreEqual(sample.Ticks, 0);
        }

    }
}
