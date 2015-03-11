using System;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
using Topshelf;

namespace Sample.Service
{
    class Program
    {
        [STAThread]
        static void Main(string[] args)
        {
            Application.EnableVisualStyles();

            HostFactory.Run(x =>
            {
                //new PreviewForm()
                x.Service(settings => new SampleService(), s => { });
                x.RunAsLocalSystem();

                x.SetDescription("Sample Service");
                x.SetDisplayName("Sample");
                x.SetServiceName("Sample");
            });
        }
    }
}
