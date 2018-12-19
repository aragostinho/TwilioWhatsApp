﻿using System;
using System.Collections.Generic;
using System.Text;

namespace TwilioWhats.Service
{
    public abstract class MessageContract
    {

        public virtual bool IsValid()
        {

            return true;
        }
        public IList<string> Errors = new List<string>();
    }
}
