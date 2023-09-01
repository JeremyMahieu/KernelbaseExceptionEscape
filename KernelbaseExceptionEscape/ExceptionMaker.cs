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
                JsonElement jsonElement = JsonDocument.Parse("false").RootElement;
                var res = (object)(Int64)(jsonElement).GetDouble();
                Console.WriteLine(res);
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
            }
        }
    }
}
