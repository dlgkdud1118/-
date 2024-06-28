using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Security.Permissions;
using System.Text;
using System.Threading.Tasks;

namespace SraricMethod
{
    public class TestClass
    {
        private int id;
        private string product_name;
        public TestClass(int id, string product_name)
        {
            this.id = id;
            this.product_name = product_name;
        }

        public int Id
        {
            get { return id; }
        }
        public string Product_name
        {
            get { return product_name; }
        }
    }

    class Program
    {
        static void Main(string[] ars)
        {
            TestClass[] a = {new TestClass(10001,"public"),
                            new TestClass(10002,"private"),
                            new TestClass(10003, "protected")};
            foreach(TestClass tc in a)
            {
                Console.WriteLine(tc.Id + "=" + tc.Product_name);
            }
        }
    }
}
