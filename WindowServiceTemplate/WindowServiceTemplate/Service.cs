using Serilog;
using System;
using Topshelf;

namespace WindowServiceTemplate
{
    class Service : ServiceControl
    {
        public string ServiceName { get; set; } = "Windows Service Name";
        bool ServiceControl.Start(HostControl hostControl)
        {
            Log.Logger.Information("{ServiceName} has {event}", ServiceName, "started");
            return true;
        }

        bool ServiceControl.Stop(HostControl hostControl)
        {
            Log.Logger.Information("{ServiceName} has {event}", ServiceName, "stopped");
            return true;
        }
    }
}