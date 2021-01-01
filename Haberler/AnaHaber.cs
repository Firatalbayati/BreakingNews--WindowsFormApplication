using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Haberler
{
    abstract class AnaHaber
    {
        public override string ToString()
        {
            return this.GetType().Name;
        }

        public int Id { get; set; }

        public string Title { get; set; }

        public string Description { get; set; }

        public string Link { get; set; }

        public string Image { get; set; }
    }
}
