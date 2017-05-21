#define WILLIAM_AIDEN

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharp_base
{
    namespace ns1
    {
        namespace ns2 {
            class Test {
                public string getNs() {
                    return this.GetType().Namespace;
                }
            }
        }
    }
    class Program
    {
        /// <summary>
        /// @William Aiden
        /// </summary>
        public enum Name { 
            zhangsan,
            lisi,
            wanger
        }
        static void Main(string[] args)
        {
            sbyte b1 = -127;  //8bit 有符号
            byte b2 = 127;    //8bit 

            short s1 = -256;  //16bit 有符号
            ushort s2 = 256;  //16bit

            int a = -1234;   //32bit 有符号
            uint ui = 1234U;  //32bit 

            long lo = 1234L;  //64bit 有符号
            ulong ul = 1234UL;//64bit 

            float f1 = 12.3F;
            double f2 = 123.4;

            decimal d1 = 123.4M;

            bool b3 = true;

            char c1 = 'A';   //16bit, no 8bit

            object obj;
            string str;

            int[] arr = {1,2,3,4,5};

            foreach (int t in arr){
                //t++;  error
                Console.WriteLine(t);
            }
            Console.WriteLine(Name.zhangsan);//zhangsan
            Console.WriteLine((int)Name.zhangsan);//0

            string n = arr.GetType().Namespace;
            Console.WriteLine(n);

            Console.WriteLine(new ns1.ns2.Test().getNs());

            Console.WriteLine(args);

            //Console.WriteLine(args[1]);

            int n1 = 12345;
            int n2 = 12;

            Console.WriteLine(" {0,6}\n+{1,6}\n ------\n {2,6}",n1,n2,n1+n2);


#if WILLIAM_AIDEN1
            Console.WriteLine("if define");
#error "this is error.";
#endif

#warning "this is warning.";

//#error "this is error.";
        }
    }
}
