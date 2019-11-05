using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ktra.model
{
    class lienlac
    {
        public string id { get; set; }
        public string name { get; set; }
        public string emali { get; set; }
        public string sdt { get; set; }
        public string diachi { get; set; }
        public string idnhom { get; set; }
        public virtual nhom nhom { get; set; }
        public static lienlac Parse(string dataString)
        {
            var items = dataString.Split(new char[] { '#' });
            lienlac lienlac = new lienlac
            {
                id = items[0],
                name = items[1],
                emali = items[2],
                sdt = items[3],
                diachi=items[4],
                idnhom = items[5]
            };
            return lienlac;
        }
        public static string Parse(lienlac lienlac)
        {
            return string.Format("{0}#{1}#{2}#{3}#{4}#{5}",
                lienlac.id,
                lienlac.name,
                lienlac.emali,
                lienlac.sdt,
                lienlac.diachi,
                lienlac.idnhom);
        }
    }

    

    //public string Parse()
    //{
    //    return string.Format("{0}#{1}#{2}#{3}",
    //       this.id,
    //       this.name,
    //       this.emali,
    //       this.sdt);
    //}
}
