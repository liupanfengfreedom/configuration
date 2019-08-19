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

    struct FMakeUpinfo
    {
        public string bodyanimationclass;
        public string clothupanimationclass;
        public string clothdownanimationclass;
        public string hairanimationclass;
        public string bodyskeletalmesh;
        public string clothupskeletalmesh;
        public string clothdownskeletalmesh;
        public string Shoesskeletalmesh;
        public string hairskeletalmesh;
        public string hairsocketname;
    }
    struct FMakeUpArrayinfo
    {
       public List<FMakeUpinfo> makeupinfoarray;
       public FMakeUpArrayinfo(string s)
        {
            makeupinfoarray = new List<FMakeUpinfo>();
        }
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
            using (FileStream fs = File.Create(@"D:\SVNprository\program\Project\InfiniteLife1_1\Content\Movies/makeup.ini"))
            {
                Byte[] info = new UTF8Encoding(true).GetBytes(str);
                // Add some information to the file.
                fs.Write(info, 0, info.Length);
            }
        }
        public static void createmakeupinfo()
        {
            FMakeUpArrayinfo infoarrayinstance = new FMakeUpArrayinfo(null);
            FMakeUpinfo infoinstance ;
            infoinstance.bodyanimationclass = "AnimBlueprint'/MakeUp/Character/Meshv1/BP_PAnim.BP_PAnim_C'";
            infoinstance.clothupanimationclass = "";
            infoinstance.clothdownanimationclass = "";
            infoinstance.hairanimationclass = "";

            infoinstance.bodyskeletalmesh = "/MakeUp/Character/Meshv1/Female_LM1_skin";
            infoinstance.clothupskeletalmesh = "/MakeUp/InterflowFile/Model/DressMesh/skirtv1/Female_TZ2_YF_skin";
            infoinstance.clothdownskeletalmesh = "/MakeUp/InterflowFile/Model/DressMesh/pants/pants001/Female_TZ1_KZ_skin";
            infoinstance.Shoesskeletalmesh = "/MakeUp/InterflowFile/Model/DressMesh/shosev1/shose002/Female_TZ2_XZ_skin";
            infoinstance.hairskeletalmesh = "/MakeUp/InterflowFile/Model/DressMesh/Hairv1/Hair003/Female_TZ3_TF_skin";
            infoinstance.hairsocketname = "Bip001-HeadSocket";
            //infoarrayinstance.makeupinfoarray.Add(infoinstance);
            /////////////////////////////////////////////////////////////////////////////////////////////////////
            /////AnimBlueprint'/MakeUp/v1/female/blueprints/femalanim_bp.femalanim_bp'
            infoinstance.bodyanimationclass = "AnimBlueprint'/MakeUp/v1/female/blueprints/femalanim_bp.femalanim_bp_C'";
            infoinstance.clothupanimationclass = "";
            infoinstance.clothdownanimationclass = "";
            infoinstance.hairanimationclass = "";
            //SkeletalMesh'/MakeUp/v1/female/blueprints/SK_F_skin_Body_001_qie.SK_F_skin_Body_001_qie'
            infoinstance.bodyskeletalmesh = "/MakeUp/v1/female/blueprints/SK_F_skin_Body_001_qie";
            //SkeletalMesh'/MakeUp/v1/cloth/shirt/SK_F_skin_Shirt_001.SK_F_skin_Shirt_001'
            infoinstance.clothupskeletalmesh = "/MakeUp/v1/cloth/shirt/SK_F_skin_Shirt_001";
            //SkeletalMesh'/MakeUp/v1/cloth/pants/SK_F_skin_Pants_001.SK_F_skin_Pants_001'
            infoinstance.clothdownskeletalmesh = "/MakeUp/v1/cloth/pants/SK_F_skin_Pants_001";
            //SkeletalMesh'/MakeUp/v1/cloth/shoes/SK_F_skin_Shoes_001.SK_F_skin_Shoes_001'
            infoinstance.Shoesskeletalmesh = "/MakeUp/v1/cloth/shoes/SK_F_skin_Shoes_001";
            //SkeletalMesh'/MakeUp/v1/female/hair/SK_F_skin_Hair_001.SK_F_skin_Hair_001'
            infoinstance.hairskeletalmesh = "/MakeUp/v1/female/hair/SK_F_skin_Hair_001";
            infoinstance.hairsocketname = "hair_socket";
            infoarrayinstance.makeupinfoarray.Add(infoinstance);
            /////////////////////////////////////////////////////////////////////////////////////////////////////
            /////AnimBlueprint'/MakeUp/v1/man/blueprints/MainAnimBp.MainAnimBp'
            infoinstance.bodyanimationclass = "AnimBlueprint'/MakeUp/v1/man/blueprints/MainAnimBp.MainAnimBp_C'";
            infoinstance.clothupanimationclass = "";
            infoinstance.clothdownanimationclass = "";
            infoinstance.hairanimationclass = "";
            //SkeletalMesh'/MakeUp/v1/man/blueprints/malemode.malemode'
            infoinstance.bodyskeletalmesh = "/MakeUp/v1/man/blueprints/malemode";
            //SkeletalMesh'/MakeUp/v1/cloth/shirt/SK_F_skin_Shirt_001.SK_F_skin_Shirt_001'
            infoinstance.clothupskeletalmesh = "";
            //SkeletalMesh'/MakeUp/v1/cloth/pants/SK_F_skin_Pants_001.SK_F_skin_Pants_001'
            infoinstance.clothdownskeletalmesh = "";
            //SkeletalMesh'/MakeUp/v1/cloth/shoes/SK_F_skin_Shoes_001.SK_F_skin_Shoes_001'
            infoinstance.Shoesskeletalmesh = "";
            //SkeletalMesh'/MakeUp/v1/female/hair/SK_F_skin_Hair_001.SK_F_skin_Hair_001'
            infoinstance.hairskeletalmesh = "";
            infoinstance.hairsocketname = "hair_socket";
            infoarrayinstance.makeupinfoarray.Add(infoinstance);

            string str = JsonConvert.SerializeObject(infoarrayinstance);
            using (FileStream fs = File.Create(@"D:\SVNprository\program\Project\InfiniteLife1_1\Content\Movies/makeup.ini"))
            {
                Byte[] info = new UTF8Encoding(true).GetBytes(str);
                // Add some information to the file.
                fs.Write(info, 0, info.Length);
            }
        }
    }
}
