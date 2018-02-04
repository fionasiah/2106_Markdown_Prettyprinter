using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using _2106Proj.Models;

namespace _2106Proj.DAL
{
    public class DocumentGateway : IDocumentGateway
    {
        public string Preview = "No Preview Available";
        public string Edit = "Content Unavailable";

        public void DocumentReceiver(InterpreterJob job)
        {
            if(job.flag == 1)
            {
                Preview = job.Content;
            }
            else if(job.flag == 2)
            {
                Edit = job.Content;
            }
        }

        public string getPreview()
        {
            return Preview;
        }

        public string getEdit()
        {
            return Edit;
        }
    }
}
