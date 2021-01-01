using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Haberler
{
    class Cnn : AnaHaber
    {
        public Cnn()
        {
            this.Link = "https://www.cnnturk.com/feed/rss/all/news";
        }
    }
}
