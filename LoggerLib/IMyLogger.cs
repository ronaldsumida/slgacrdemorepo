﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoggerLib
{
    public interface IMyLogger : IDisposable
    {
        void Log(string message);
    }
}
