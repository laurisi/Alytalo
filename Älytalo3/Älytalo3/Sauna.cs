using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Älytalo3
{
    public class Sauna
    {
        public string päällä { get; set; }

        public string pois { get; set; }

        public bool on { get; set; }

        public void start()
        {
        on = true;
        }
        public void stop()
        {
            on = false;
        }

    }
}
