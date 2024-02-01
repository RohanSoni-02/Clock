using System;
using NUnit.Framework;
using ClockTasks;

namespace CounterTest
{
    [TestFixture]
    public class TestClockTimer
    {
        Clock sample;
        [SetUp]
        public void Setup()
        {
            sample = new Clock();
        }

        [Test]
        public void StartTimer()
        {
            Assert.AreEqual(sample.PrintTime, "0 :0: 0");
        }

        [Test]
        public void ResetTimer()
        {
            sample.TimeReset();
            Assert.AreEqual(sample.PrintTime, "0 :0: 0");
        }
        
        [Test]
        public void MinuteTest()
        {
            for (int i = 0; i < 60; i++)
            {
                sample.ClockTick();
            }

            Assert.AreEqual(sample.PrintTime, "0 :1: 0");
        }

        [Test]
        public void HourTest()
        {
            for (int i = 0; i < 3600; i++)
            {
                sample.ClockTick();
            }

            Assert.AreEqual(sample.PrintTime, "1 :0: 0");
        }

        [Test]
        public void Hour24_Test()
        {
            for (int i = 0; i < 86400; i++)
            {
                sample.ClockTick();
            }

            Assert.AreEqual(sample.PrintTime, "0 :0: 0");
        }

    }
}
