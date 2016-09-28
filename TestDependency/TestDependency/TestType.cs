using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LinqKit;

namespace TestDependency
{
    public class TestType
    {
        public string Test()
        {
            var testLinqKitFunc = Linq.Func(() => "Hello");
            return testLinqKitFunc();
        }
    }
}
