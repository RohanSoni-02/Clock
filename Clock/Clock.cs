using System;
using System.Threading;
namespace ClockTasks
{
    public class Clock
    {
        private Counter _hours;
        private Counter _mins;
        private Counter _secs;

        public Clock()
        {
            _hours = new Counter("hour");
            _mins = new Counter("minutes");
            _secs = new Counter("seconds");
        }
        public void ClockTick()
        { 
           _secs.Increment();
            //To add 1 second timer we can use: Thread.Sleep(1000); but Nunit testing takes a lot of time then.
            
            if (_secs.Ticks == 60)
            {
                _mins.Increment();
                _secs.Reset();
                if (_mins.Ticks == 60)
                {
                    _hours.Increment();
                    _mins.Reset();
                    if(_hours.Ticks == 24)
                    {
                        TimeReset();
                    }
                }
            }
        }

        public string PrintTime
        {
            get
            {
                return $"{_hours.Ticks} :{_mins.Ticks}: {_secs.Ticks}";
            }
            
        }
        public void TimeReset()
        {
            _hours.Reset();
            _mins.Reset();
            _secs.Reset();
        }
        public Counter Hours
        {
            get
            {
                return _hours;
            }
        }
        public Counter Minutes
        {
            get
            {
                return _mins;
            }

        }
        public Counter Seconds
        {
            get
            {
                return _secs;
            }

        }
    }
}
