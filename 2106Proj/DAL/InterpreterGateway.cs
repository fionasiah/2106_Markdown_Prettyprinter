using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using _2106Proj.Models;

namespace _2106Proj.DAL
{
    public class InterpreterGateway : iInterpreterGateway
    {
        public void JobReceiver(InterpreterJob job, DocumentGateway documentGateway)
        {
            job.Content += " Interpreted";
            job.flag = 1;
            documentGateway.DocumentReceiver(job);
        }
    }
}
