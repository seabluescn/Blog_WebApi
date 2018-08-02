using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace UseHangfire.Tasks
{
    public class TimedTaskService
    {
        [DisplayName("SendMessage")]
        public void SendMessage()
        {
            Console.WriteLine($"{DateTime.Now}:SendMessage working!");

            Thread.Sleep(new Random().Next(50) * 100);

        }

        public void DoSomeThing1()
        {
            Console.WriteLine("DoSomeThing1:我只执行一次,但时间比较长");

            int time = 10+new Random().Next(20);
            Console.WriteLine($"Time={time}S");

            Thread.Sleep(time * 1000);
        }

        public void DoSomeThing2()
        {
            Console.WriteLine("DoSomeThing2:我也只执行一次");

            int time = new Random().Next(20);
            Console.WriteLine($"Time= {time/10} S");

            if (time == 13)
            {
                throw new Exception("DoSomeThing2Exception");
            }

            for (var i = 0; i < time; i++)
            {
                Thread.Sleep(100);
            }
        }
    }
}
