using Autofac;
using INVENTORY_SYSTEM.Repository;
using System;
using System.Collections.Generic;
using System.Configuration;
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
            Container = Configure();
            Application.Run(new Parent_Form(Container.Resolve<IProductRepository>()));
        }

        static IContainer Configure()
        {
            var builder = new ContainerBuilder();
            builder.RegisterType<ProductRepository>().As<IProductRepository>();
            builder.RegisterType<Parent_Form>();

            return builder.Build();
        }
    }
}
