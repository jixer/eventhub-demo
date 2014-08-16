using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UTruck.Offsite.Consumer
{
    public class SiteState
    {
        public string Offset { get; set; }

        public SiteState()
        {

        }

        public SiteState(string offset)
        {
            Offset = offset;
        }
    }
}
