using Microsoft.Extensions.Hosting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KernelbaseExceptionEscape
{
    public class Worker : BackgroundService
    {
        private Dictionary<int, object> MyInstances = new Dictionary<int, object>();

        public Worker()
        {
            MyInstances[0] = new ExceptionMaker();
        }
        protected override async Task ExecuteAsync(CancellationToken stoppingToken)
        {
            while (true)
            {
                try
                {
                    ((ExceptionMaker)MyInstances[0]).Start();
                }
                catch (Exception e)
                {
                    Console.WriteLine(e);
                }
                await Task.Delay(1000);
            }
        }
    }
}
