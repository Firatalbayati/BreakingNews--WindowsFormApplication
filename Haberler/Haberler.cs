using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Haberler
{
    class Haberler
    {
        public override string ToString()
        {
            return this.Title;
        }

        public int Id { get; set; }

        public string Title { get; set; }

        public string Description { get; set; }

        public string Link { get; set; }

        public string Image { get; set; }


    }
}
