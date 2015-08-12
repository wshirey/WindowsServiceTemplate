using System;
using Topshelf;

namespace WindowServiceTemplate
{
    class Service : ServiceControl
    {
        bool ServiceControl.Start(HostControl hostControl)
        {
            System.Console.WriteLine("Service started");
            return true;
        }

        bool ServiceControl.Stop(HostControl hostControl)
        {
            System.Console.WriteLine("Service stopped");
            return true;
        }
    }
}