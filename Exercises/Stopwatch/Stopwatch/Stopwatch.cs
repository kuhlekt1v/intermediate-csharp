using System;

namespace Stopwatch
{
    public class Stopwatch
    {
        private DateTime _startTime;
        private DateTime _stopTime;
        private bool _running;

        public void Start()
        { 
            if (_running)
                throw new InvalidOperationException("Stopwatch is arleady running");
            

            _startTime = DateTime.Now;
            _running = true;
        }
        
        public void Stop()
        {
            if (!_running)
                throw new InvalidOperationException("Stopwatch is not running.");
            
            _stopTime = DateTime.Now;
            _running = false;
        }

        public TimeSpan Duration()
        {
            return _stopTime - _startTime;
        }
    }
}

