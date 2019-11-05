using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ktra.model
{
    class nhom
    {
        public string id { get; set; }
        public string tennhom { get; set; }
        public virtual ICollection<lienlac> getlist { get; set; }
        public static nhom Parse(string dataString)
        {
            var items = dataString.Split(new char[] { '#' });
            nhom lienlac = new nhom
            {
                id = items[0],
                tennhom = items[1]
            };
            return lienlac;
        }
        public static string Parse(nhom nhom)
        {
            return string.Format("{0}#{1}",
                nhom.id,nhom.tennhom);
        }
    }
}
