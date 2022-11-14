using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Exercise1
{
    internal class StopWatch
    {
        private DateTime _startTime;
        private DateTime _endTime;
        private TimeSpan _duration;
        private bool _hasAlreadyStarted = false;

        public double Duration
        {
            get
            {
                var timeSpan = _endTime - _startTime;
                double result = timeSpan.TotalSeconds;
                return result;
            }
        }

        public void Start()
        {
            Console.WriteLine("Please press enter to start the stopwatch:");
            Console.ReadLine();
            if (_hasAlreadyStarted == true)
            {
                throw new InvalidOperationException("the stop watch has already been started");
            }
            _startTime = DateTime.Now;
            _hasAlreadyStarted = true;
            Stop();
        }

        public void Stop()
        {
            Console.WriteLine("Please press enter to stop the stopwatch:");
            Console.ReadLine();
            _endTime = DateTime.Now;
            _hasAlreadyStarted = false;
            Console.WriteLine($"The time this stop watch took was {Duration} seconds.");
            Repeat();
        }

        public void Repeat()
        {
            Console.WriteLine("Would you like to run the stopwatch again ( Y / N )");
            var repeating = Console.ReadLine();
            switch (repeating)
            {
                case "Y" :
                    Start();
                    break;
                case "N" :
                    Console.WriteLine("The stopwatch program has ended, thank you.");
                    break;
                default:
                    Console.WriteLine("please enter either Y or N (must be a capital).");
                    Repeat();
                    break;
            }
        }
    }
}
