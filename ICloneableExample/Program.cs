using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ICloneableExample {
    class Program {
        static void Main(string[] args) {
            myNumber obj1, obj2;

            obj1 = new myNumber(1);
            obj2 = (myNumber)obj1.Clone();

            obj1.number = 90;

            Console.WriteLine("obj1 number: " + obj1.number.ToString());
            Console.WriteLine("obj2 number: " + obj2.number.ToString());

            Console.ReadKey();
        }
    }

    class myNumber : ICloneable {

        private int _number = 0;

        public int number { get { return _number; } set { _number = value; } }

        public myNumber(int inNumber) {
            _number = inNumber;
        }

        public object Clone() {
            return new myNumber(_number);
        }
    }
}
