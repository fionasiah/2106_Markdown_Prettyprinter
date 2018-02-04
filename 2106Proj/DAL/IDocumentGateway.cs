using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using _2106Proj.Models;

namespace _2106Proj.DAL
{
    interface IDocumentGateway
    {
        void DocumentReceiver(InterpreterJob job);
    }
}
