﻿using System;
using System.Collections.Generic;

namespace Edison.Core.Common.Models
{
    public class DeviceGeolocationUpdateResultModel
    {
        public bool Success { get; set; }
        public DeviceModel Device { get; set; }     
    }
}
