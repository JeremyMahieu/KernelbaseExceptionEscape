using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace KernelbaseExceptionEscape
{
    public class ExceptionMaker
    {
        public void Start()
        {
            try
            {
                throw new Exception();
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
            }
        }
    }
}
