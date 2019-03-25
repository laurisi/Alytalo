using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Älytalo3
{
    public class Lights
    {
        public string pois { get; set; }
        public string hämärä { get; set; }
        public string puolivalot { get; set; }
        public string kirkas { get; set; }

        public bool on { get; set; }

        public void start()
        {
            on = true;
        }

        public void stop()
        {
            on = false;
        }
       public void hamara()
        {
            on = true;
        }
        public void puoli()
        {
            on = true;
        }

        public void bright()
        {
            on = true;
        }
        
        }
}
