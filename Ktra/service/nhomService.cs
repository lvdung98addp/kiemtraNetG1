using Ktra.model;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ktra.service
{
    class nhomService
    {
        public static List<nhom> Getnhom(string path)
        {
            var lines = File.ReadAllLines(path);
            List<nhom> listnhom = new List<nhom>();
            foreach (var line in lines)
            {
                var items = line.Split(new char[] { '#' });
                if (items.Length > 0)
                {
                    var nhom = new nhom
                    {
                        id=items[0],
                        tennhom=items[1]
                        //ID = items[0],
                        //LastName = items[1],
                        //FirstName = items[2],
                        //DateOfBirth = DateTime.ParseExact(items[3], "yyyy-MM-dd", CultureInfo.InvariantCulture),
                        //Gender =
                        //(items[4] == "Male" ? GENDER.Male : (items[4] == "Female" ?
                        //GENDER.Female : GENDER.Other)),
                        //PlaceOfBirth = items[5]
                    };
                    listnhom.Add(nhom);
                }
            }
            return listnhom;
        }
        public static void Remove(string path, nhom nhom)
        {
            if (File.Exists(path))
            {
                List<string> rs = new List<string>();
                var lines = File.ReadAllLines(path);
                foreach (var line in lines)
                {
                    var data =nhom.Parse(line);
                    if (data.id != nhom.id)
                        rs.Add(line);
                }
                File.WriteAllLines(path, rs);
                removelienlac(Utils.lienlacPathFile, nhom.id);
            }
            else
                throw new Exception("File dữ liệu không có tồn tại");
        }
        public static void Add(string path, nhom nhom)
        {
            if (File.Exists(path))
            {
                List<string> rs = new List<string>();
                var lines = File.ReadAllLines(path);
                foreach (var line in lines)
                {
                    var data = nhom.Parse(line);
                        rs.Add(line);
                }
                rs.Add(nhom.Parse(nhom));
                File.WriteAllLines(path, rs);
            }
            else
                throw new Exception("File dữ liệu không có tồn tại");
        }
        public static void removelienlac(string path,string id)
        {
            if (File.Exists(path))
            {
                List<string> rs = new List<string>();
                var lines = File.ReadAllLines(path);
                foreach (var line in lines)
                {
                    var data = lienlac.Parse(line);
                    if (data.idnhom != id)
                        rs.Add(line);
                }
                File.WriteAllLines(path, rs);
            }
            else
                throw new Exception("File dữ liệu không có tồn tại");
        }
    }
}
