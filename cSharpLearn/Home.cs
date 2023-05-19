using System;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cSharpLearn
{
    public class Home
    {
        public static void Main()
        {


            var learn = new Learn();
            //learn.ActionM();
             
            //var test = new Test<int>(23);
            //test.Write();

            // Test2.BuildUp("mehrshad", 5);
            // Test2.BuildUp<int>(23, 5);

            // Python<DataTable> python = new Python<DataTable>();
            // Cpp<int> cpp = new Cpp<int>();
            // Java<Learn> Java = new Java<Learn>();
        }
    }


    public class Learn
    {
        #region Main Method
        public void ActionM()
        {
            // self
            Action<int> act1 = (int age) => Console.WriteLine($"Age-{age}");
            act1.Invoke(22);

            Action<string> actStr = (string name) => Console.WriteLine($"name:{name}");
            actStr.Invoke("mehrshad");

            // method
            Action<int> act2 = new Action<int>(Method1);
            act2.Invoke(22);

            // dict
            Dictionary<string, Action> dict = new Dictionary<string, Action>();
            dict["mehrshad"] = new Action(Name);
            dict["Aria"] = new Action(Name);
            dict["Berlin"] = new Action(City);

            dict["mehrshad"].Invoke();
            dict["Berlin"].Invoke();

        }

        #endregion
        

        #region Helper Method

        public void Name()
        {
            Console.WriteLine("name");
        }
        public void City()
        {
            Console.WriteLine("city");
        }
        public void Method1(int num)
        {
            Console.WriteLine(num * 2 );
        }



        #endregion
    }

    #region Generic
    public class Test<T>
    {
        T _value;

        public Test( T t )
        {
            _value = t;
        }

        public void Write()
        {
            Console.WriteLine(this._value);
        }
    }
    public class Test2
    {
        public static void BuildUp<T>(T value , int count)
        {
            var list = new List<T>();


            for(int i = 0; i < count; ++i )
                list.Add(value);

            for (int i = 0; i < count; ++i)
                Console.WriteLine(list[i]);

        }
    }

    public class Python<T> where T : IDisposable
    {

    }

    public class Cpp<T> where T : struct
    {

    }

    public class Java<T> where T : class , new()
    {

    }

    #endregion
}
