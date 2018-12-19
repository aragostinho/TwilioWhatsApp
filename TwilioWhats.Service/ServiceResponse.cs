﻿using System;
using System.Collections.Generic;
using System.Text;

namespace TwilioWhats.Service
{
    public class ServiceResponse
    {
        public bool IsValid { get; set; }
        public IList<string> Errors = new List<string>();
    }
}
