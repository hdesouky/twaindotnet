﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TwainDotNet.TwainNative
{
    public enum Capabilities : short
    {
        XferCount = 0x0001,
        ICompression = 0x0100,
        IPixelType = 0x0101,
        IUnits = 0x0102,
        IXferMech = 0x0103,
        FeederEnabled = 0x1002,
        FeederLoaded = 0x1003,
        AutoFeed = 0x1007,
        FeedPage = 0x1009, 
        Duplex = 0x1012,
        DuplexEnabled = 0x1013,
        XResolution = 0x1118,
        YResolution = 0x1119,
        BitDepth = 0x112b
    }
}
