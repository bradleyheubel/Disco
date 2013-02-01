﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Disco.ClientBootstrapper
{
    class NullStatus : IStatus
    {
        public void UpdateStatus(string Heading, string SubHeading, string Message, bool? ShowProgress = null, int? Progress = null)
        {
            // Do Nothing
        }
    }
}
