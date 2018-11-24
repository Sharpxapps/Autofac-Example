using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Autofac;
using DemoLibrary;
using DemoLibrary.Utilities;


namespace TestAutofac
{
    class Program
    {

        static void Main(string[] args)
        {
            //BusinessLogic businessLogic = new BusinessLogic();
            //businessLogic.ProcessData();



            ConsoleOutput co = new ConsoleOutput();
            co.Write("test");


            //var container = ContainerConfig.Configure();
            //using (var scope = container.BeginLifetimeScope())
            //{
            //    var app = scope.Resolve<IApplication>();
            //    app.Run();
            //}
            Console.ReadLine();


        }


    }

    public interface IOutput
    {
        void Write(string content);
    }

    public class ConsoleOutput : IOutput
    {
        public void Write(string content)
        {
            Console.WriteLine(content);
        }
    }



    public interface IDateWriter
    {
        void WriteDate();
    }

    public class TodayWriter : IDateWriter
    {
        private IOutput _output;
        public TodayWriter(IOutput output)
        {
            this._output = output;
        }

        public void WriteDate()
        {
            this._output.Write(DateTime.Today.ToShortDateString());
        }
    }






}
