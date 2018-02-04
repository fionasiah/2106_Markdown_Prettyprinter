using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using _2106Proj.Models;

namespace _2106Proj.DAL
{
    public class InterpreterGateway : iInterpreterGateway
    {
        public void JobReceiver(InterpreterJob job)
        {
            job.Content += " Interpreted";
            DocumentGateway gateway = new DocumentGateway();
            gateway.DocumentReceiver(job);
        }
    }
}
