﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AWSCoreLogging
{
    public interface IAWSLoggerCore
    {
        void Close();

        void AddMessage(string message);

        void StartMonitor();

    }
}
