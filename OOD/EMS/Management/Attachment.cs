using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOD.EMS.Management
{
    public class Attachment
    {
        public String Filename { get; set; }
        public String Title { get; set; }
        private String path;


        public Attachment(String filename, String title)
        {
            Filename = filename;
            Title = title;
        }

        public void save()
        {
            //save on system
        }

        public void download(String dlPath)
        {
            if (path == null)
            {
                //error
            }
            else
            {
                //dl to dlPath
            }
        }
    }
}
