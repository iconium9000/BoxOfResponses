﻿using ResponseGenerator.Enumerations;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ResponseGenerator.Interfaces
{
    internal interface IResponder
    {
        string GetResponse( KEYWORDS keyword );

        RESPONSE_STYLES ResponseStyle { get; set; }
    }
}
