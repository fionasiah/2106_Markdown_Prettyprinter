﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using _2106Proj.Models;

namespace _2106Proj.DAL
{
    interface iInterpreterGateway
    {
        void JobReceiver(InterpreterJob job, DocumentGateway documentGateway);
    }
}
