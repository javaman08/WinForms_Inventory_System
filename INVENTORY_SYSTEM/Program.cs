using Autofac;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace INVENTORY_SYSTEM
{
    internal static class Program
    {
        public static IContainer Container;
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Parent_Form());
        }

        //static IContainer Configure()
        //{
        //    var builder = new ContainerBuilder();
        //    builder.RegisterType<DatabaseConnectionProvider>().As<IDatabaseConnectionProvider>();
        //    builder.RegisterType<Parent_Form>();

        //    return builder.Build();
        //}
    }
}
