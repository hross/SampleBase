using System;
using System.Drawing;
using System.IO;
using Sample.Common;
using Sample.Common.Framework;
using Topshelf;
using System.Configuration;
using System.Timers;
using System.Windows.Forms;

namespace Sample.Service
{
    public class SampleService : ServiceControl
    {
        #region log4net
        private static readonly log4net.ILog log = log4net.LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);
        #endregion

        #region Timer and Sync Stuff

        public const double OneSecond = 1000;
        readonly System.Timers.Timer _timer;
        
        #endregion

        private DatabaseContext _context;

        public SampleService()
        {
           
            _context = AppConfig.DbContext();

            int intervalSeconds = int.Parse(ConfigurationManager.AppSettings["IntervalSeconds"] ?? "120");
            _timer = new System.Timers.Timer(OneSecond * intervalSeconds) { AutoReset = true };
            _timer.Elapsed += (sender, eventArgs) => this.OnTimer();

        }

        #region Start and Stop

        public bool Start(HostControl hostControl)
        {
            log.Info("Service starting...");

            _timer.Start();

            return true;
        }

        public bool Stop(HostControl hostControl)
        {
            log.Info("Service stopping...");

            _timer.Stop();

            if (null != _context)
            {
                _context.Dispose();
            }

            return true;
        }

        #endregion

        #region Synchronized Variables

        private object _sync = new object();

        #endregion

        ///<summary>Handle timer callbacks for checking.</summary>
        public void OnTimer() {
            lock (_sync)
            {
                // do stuff in here
            }
        }
    }
}
