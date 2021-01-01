using CodeHollow.FeedReader;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Haberler
{
    class Haberturk : AnaHaber
    {
        public Haberturk()
        {
            this.Link = "https://www.haberturk.com/rss/manset.xml";
        }
    }
}
