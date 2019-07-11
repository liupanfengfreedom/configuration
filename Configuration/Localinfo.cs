using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using Newtonsoft.Json;
namespace Configuration
{
    struct FLocalinfo
    {
        public string MainUrl;
        public string ConfigFileName;
    }
    class Localinfo
    {
        public static void createinfo()
        {
            FLocalinfo infoinstance = new FLocalinfo();
            infoinstance.MainUrl = "http://api.life.coresnow.cn/assets";
            infoinstance.ConfigFileName = "/x.ini";

            infoinstance.MainUrl = "http://192.168.1.240";
            string str = JsonConvert.SerializeObject(infoinstance);
            using (FileStream fs = File.Create(@"D:\SVNprository\program\Project\InfiniteLife1_1\Content\Movies/config.ini"))
            {
                Byte[] info = new UTF8Encoding(true).GetBytes(str);
                // Add some information to the file.
                fs.Write(info, 0, info.Length);
            }
        }
    }
}
