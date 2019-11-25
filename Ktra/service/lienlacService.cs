using Ktra.model;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ktra.service
{
    class lienlacService
    {
        public static List<lienlac> GetListlienlac(
            string path, string idnhom)
        {
            List<lienlac> rs = new List<lienlac>();
            if (File.Exists(path))
            {
                var lines = File.ReadAllLines(path);
                foreach (var line in lines)
                {
                    var lienlac1 = lienlac.Parse(line);
                    if (lienlac1.idnhom == idnhom)
                        rs.Add(lienlac1);
                }
                return rs;
            }
            else
                return null;
        }
        public static void Remove(string path, lienlac lienlac)
        {
            if (File.Exists(path))
            {
                List<string> rs = new List<string>();
                var lines = File.ReadAllLines(path);
                foreach (var line in lines)
                {
                    var data = lienlac.Parse(line);
                    if (data.id != lienlac.id)
                        rs.Add(line);
                }
                File.WriteAllLines(path, rs);
            }
            else
                throw new Exception("File dữ liệu không có tồn tại");
        }
        public static void Add(string path, lienlac lienlac)
        {
            if (File.Exists(path))
            {
                List<string> rs = new List<string>();
                var lines = File.ReadAllLines(path);
                foreach (var line in lines)
                {
                    var data = lienlac.Parse(line);
                        rs.Add(line);
                }
                var lienlacstring = lienlac.Parse(lienlac);
                rs.Add(lienlacstring);
                File.WriteAllLines(path, rs);
            }
            else
                throw new Exception("File dữ liệu không có tồn tại");
        }
    }
}
