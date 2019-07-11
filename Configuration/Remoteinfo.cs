using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using Newtonsoft.Json;
namespace Configuration
{
    enum AssetType
    {
        PRIMARY,
        TEXTURE,
	    MATERIAL,
	    MODEL,//
	    BLUEPRINT,
	    LEVEL,
    }
    enum ItemType
    {
        HairStyle = 0,
        Upcloth,
        Downcloth,//
        Sock,
        Shose,
        Accessory,
        Image,
        Suit,
        Action,
    }
   // class FObjectInforV1
    struct FObjectInforV1
    {

        public bool redownload;

        public AssetType type;

        public string filename;

        public string filemd5;

        public string filepathonserver;

        public string filepathonlocal;

        public string assetpathonue;

        public string animationpathonue;
        //////////////////////////////////////////////
        public string picturename;

        public string picturepathonserver;

        public string picturemd5;

        public string picture0name;

        public string picture0pathonserver;

        public string picture0md5;

        public float price;

        public string authorname;

        public string worksname;

        public string authorwebsit;

        public ItemType itemtype;
        public FObjectInforV1(bool b = false)
        {
            redownload = false;
            type = AssetType.BLUEPRINT;
            filename = null;
            filemd5 = null;
            filepathonserver = null;
            filepathonlocal = null;
            assetpathonue = null;
            animationpathonue = null;
            /////////////////////////////////
            picturename = null;
            picturepathonserver = null;
            picturemd5 = null;

            picture0name = null;
            picture0pathonserver = null;
            picture0md5 = null;

            price = 0;
            authorname = null;
            worksname = null;
            authorwebsit = null;
            itemtype = ItemType.Upcloth;

        }
    }
    struct FObjectList
    //class FObjectList
    {
        public string MainUrl;

        public List<FObjectInforV1> objs;
        public FObjectList(string s)
        {
            MainUrl = s;
            objs = new List<FObjectInforV1>();
        }
    }
    class Remoteinfo
    {
        public static void creatinfo()
        {
            FObjectList objlist = new FObjectList(null);
            FObjectInforV1 obj = new FObjectInforV1(false);
            #region material
            obj.redownload = true;
            obj.type = AssetType.PRIMARY;
            obj.filename = "material-Android_ETC1.pak";
            obj.filemd5 = "761397478281EE068B3D8D8944F900D0";
            obj.filepathonserver = "/";
            obj.filepathonlocal = "/DLCPaks/";
            obj.assetpathonue = null;
            obj.animationpathonue = null;
            obj.picturepathonserver = null;
            obj.price = 1;
            obj.authorname = null;
            obj.authorwebsit = null;
            objlist.objs.Add(obj);
            #endregion
            #region hair1-Android_ETC1.pak
            obj.redownload = true;
            obj.type = AssetType.MODEL;
            obj.filename = "hair1-Android_ETC1.pak";
            obj.filemd5 = "8D3B7ECA45D76F6CE234045F490ACD22";
            obj.filepathonserver = "/";
            obj.filepathonlocal = "/DLCPaks/";
            obj.assetpathonue = "/Game/InterflowFile/Model/DressMesh/Hair/Hair001/Female_TZ1_TF_skin";
            obj.animationpathonue = null;
            obj.picturename = "Snipaste_2019-05-28_17-14-39.png";
            obj.picturepathonserver = "/image/hair/";
            obj.picturemd5 = "4405D150423C10F1A4F5751A2D27607C";
            obj.price = 1;
            obj.authorname = null;
            obj.authorwebsit = null;
            obj.itemtype = ItemType.HairStyle;
            objlist.objs.Add(obj);
            #endregion
            for (int i = 0; i < 10; i++)
            {
                objlist.objs.Add(obj);
            }
            #region hair2-Android_ETC1.pak
            obj.redownload = true;
            obj.type = AssetType.MODEL;
            obj.filename = "hair2-Android_ETC1.pak";
            obj.filemd5 = "3BDF386A9226FC3FF4D0EE865F2E3BD1";
            obj.filepathonserver = "/";
            obj.filepathonlocal = "/DLCPaks/";
            ///                  Game/InterflowFile/Model/DressMesh/Hair/Hair002/hair_01
            obj.assetpathonue = "/Game/InterflowFile/Model/DressMesh/Hair/Hair002/hair_01";
            // obj.animationpathonue = "";
            obj.picturename = "Snipaste_2019-05-28_17-15-04.png";
            obj.picturepathonserver = "/image/hair/";
            obj.picturemd5 = "E7473388BC1AA46771EAD1A6BDB8BCB8";
            obj.price = 1;
            // obj.authorname = "";
            // obj.authorwebsit = "";
            obj.itemtype = ItemType.HairStyle;
            objlist.objs.Add(obj);
            #endregion
            for (int i = 0; i < 10; i++)
            {
                objlist.objs.Add(obj);
            }
            #region hair3-Android_ETC1.pak
            obj.redownload = true;
            obj.type = AssetType.MODEL;
            obj.filename = "hair3-Android_ETC1.pak";
            obj.filemd5 = "D687BB7E39D96F2FE13DB4961BE189BB";
            obj.filepathonserver = "/";
            obj.filepathonlocal = "/DLCPaks/";
            obj.assetpathonue = "/Game/InterflowFile/Model/DressMesh/Hair/Hair003/Female_TZ3_TF_skin";
            //obj.animationpathonue = "";
            obj.picturename = "Snipaste_2019-05-28_17-16-04.png";
            obj.picturepathonserver = "/image/hair/";
            obj.picturemd5 = "AB0C3AE9D2FB19A9540143F074693C94";
            obj.price = 1;
            //obj.authorname = "";
            //obj.authorwebsit = "";
            obj.itemtype = ItemType.HairStyle;
            objlist.objs.Add(obj);
            #endregion        
            for (int i = 0; i < 10; i++)
            {
                objlist.objs.Add(obj);
            }







            #region pant1-Android_ETC1.pak
            obj.redownload = true;
            obj.type = AssetType.MODEL;
            obj.filename = "pant1-Android_ETC1.pak";
            obj.filemd5 = "A08611DEAB893AA547BF713CA7BD1A6D";
            obj.filepathonserver = "/";
            obj.filepathonlocal = "/DLCPaks/";
            obj.assetpathonue = "/Game/InterflowFile/Model/DressMesh/pants/pants001/Female_TZ1_KZ_skin";
            //obj.animationpathonue = "";
            obj.picturepathonserver = "/Game/InterflowFile/Model/DressMesh/pants/pants001/Snipaste_2019-05-28_17-14-39";
            obj.price = 1;
            //obj.authorname = "";
           // obj.authorwebsit = "";
            obj.itemtype = ItemType.Downcloth;
            objlist.objs.Add(obj);
            #endregion
            #region pant2-Android_ETC1.pak
            obj.redownload = true;
            obj.type = AssetType.MODEL;
            obj.filename = "pant2-Android_ETC1.pak";
            obj.filemd5 = "3FA9A46E2465D570F7C965502263819F";
            obj.filepathonserver = "/";
            obj.filepathonlocal = "/DLCPaks/";
            obj.assetpathonue = "/Game/InterflowFile/Model/DressMesh/pants/pants002/Female_TZ2_KZ_skin";
            //obj.animationpathonue = "";
            obj.picturepathonserver = "/Game/InterflowFile/Model/DressMesh/pants/pants002/Snipaste_2019-05-28_17-16-04";
            obj.price = 1;
            //obj.authorname = "";
            //obj.authorwebsit = "";
            obj.itemtype = ItemType.Downcloth;
            objlist.objs.Add(obj);
            #endregion
            #region shoes1-Android_ETC1.pak
            obj.redownload = true;
            obj.type = AssetType.MODEL;
            obj.filename = "shoes1-Android_ETC1.pak";
            obj.filemd5 = "CECDAC1BF23D404105EE0DC5AF461A33";
            obj.filepathonserver = "/";
            obj.filepathonlocal = "/DLCPaks/";
            obj.assetpathonue = "/Game/InterflowFile/Model/DressMesh/shoes/shose001/Female_TZ1_XZ_skin";
            obj.animationpathonue = "AnimBlueprint'/MakeUp/Character/Meshv1/BP_PAnim.BP_PAnim_C'";
            obj.picturepathonserver = "/Game/InterflowFile/Model/DressMesh/shoes/shose001/Snipaste_2019-05-28_17-16-27";
            obj.price = 1;
            //obj.authorname = "";
            //obj.authorwebsit = "";
            obj.itemtype = ItemType.Shose;
            objlist.objs.Add(obj);
            #endregion
            #region shoes2-Android_ETC1.pak
            obj.redownload = true;
            obj.type = AssetType.MODEL;
            obj.filename = "shoes2-Android_ETC1.pak";
            obj.filemd5 = "96D8B9F1318003882B79846F25A33ECF";
            obj.filepathonserver = "/";
            obj.filepathonlocal = "/DLCPaks/";
            obj.assetpathonue = "/Game/InterflowFile/Model/DressMesh/shoes/shose002/Female_TZ2_XZ_skin";
            obj.animationpathonue = "AnimBlueprint'/MakeUp/Character/Meshv1/BP_PAnim.BP_PAnim_C'";
            obj.picturepathonserver = "/Game/InterflowFile/Model/DressMesh/shoes/shose002/Snipaste_2019-05-28_17-16-40";
            obj.price = 1;
           // obj.authorname = "";
           // obj.authorwebsit = "";
            obj.itemtype = ItemType.Shose;
            objlist.objs.Add(obj);
            #endregion
            #region shoes3-Android_ETC1.pak
            obj.redownload = true;
            obj.type = AssetType.MODEL;
            obj.filename = "shoes3-Android_ETC1.pak";
            obj.filemd5 = "C197F4880E0E35FD705630D4D64FA891";
            obj.filepathonserver = "/";
            obj.filepathonlocal = "/DLCPaks/";
            obj.assetpathonue = "/Game/InterflowFile/Model/DressMesh/shoes/shose003/Female_TZ3_XZ_skin";
            obj.animationpathonue = "AnimBlueprint'/MakeUp/Character/Meshv1/BP_Femalanimation.BP_Femalanimation_C'";
            obj.picturepathonserver = "/Game/InterflowFile/Model/DressMesh/shoes/shose003/Snipaste_2019-05-28_17-16-50";
            obj.price = 1;
            //obj.authorname = "";
            //obj.authorwebsit = "";
            obj.itemtype = ItemType.Shose;
            objlist.objs.Add(obj);
            #endregion
            #region upcloth1-Android_ETC1.pak
            obj.redownload = true;
            obj.type = AssetType.MODEL;
            obj.filename = "upcloth1-Android_ETC1.pak";
            obj.filemd5 = "E0CBBB8A7FDDF7F20A2D5E2DA545E174";
            obj.filepathonserver = "/";
            obj.filepathonlocal = "/DLCPaks/";
            obj.assetpathonue = "/Game/InterflowFile/Model/DressMesh/upcloth/upcloth001/Female_TZ1_YF_skin";
            //obj.animationpathonue = "AnimBlueprint'/MakeUp/Character/Meshv1/BP_Femalanimation.BP_Femalanimation_C'";
            obj.picturepathonserver = "/Game/InterflowFile/Model/DressMesh/upcloth/upcloth001/Snipaste_2019-05-28_17-17-04";
            obj.price = 1;
           // obj.authorname = "";
            //obj.authorwebsit = "";
            obj.itemtype = ItemType.Upcloth;
            objlist.objs.Add(obj);
            #endregion
            #region upcloth2-Android_ETC1.pak
            obj.redownload = true;
            obj.type = AssetType.MODEL;
            obj.filename = "upcloth2-Android_ETC1.pak";
            obj.filemd5 = "0DD3F8AC400BB1852E9F7761FFCEA937";
            obj.filepathonserver = "/";
            obj.filepathonlocal = "/DLCPaks/";
            obj.assetpathonue = "/Game/InterflowFile/Model/DressMesh/upcloth/upcloth002/Female_TZ2_YF_skin";
            //obj.animationpathonue = "AnimBlueprint'/MakeUp/Character/Meshv1/BP_Femalanimation.BP_Femalanimation_C'";
            obj.picturepathonserver = "/Game/InterflowFile/Model/DressMesh/upcloth/upcloth002/Snipaste_2019-05-28_17-17-14";
            obj.price = 1;
           // obj.authorname = "";
           // obj.authorwebsit = "";
            obj.itemtype = ItemType.Upcloth;
            objlist.objs.Add(obj);
            #endregion
            #region upcloth3-Android_ETC1.pak
            obj.redownload = true;
            obj.type = AssetType.MODEL;
            obj.filename = "upcloth3-Android_ETC1.pak";
            obj.filemd5 = "CC9D5D45FCABD5A774CFE4F1475C2089";
            obj.filepathonserver = "/";
            obj.filepathonlocal = "/DLCPaks/";
            obj.assetpathonue = "/Game/InterflowFile/Model/DressMesh/upcloth/upcloth003/Female_TZ3_YF_skin";
            //obj.animationpathonue = "AnimBlueprint'/MakeUp/Character/Meshv1/BP_Femalanimation.BP_Femalanimation_C'";
            obj.picturepathonserver = "/Game/InterflowFile/Model/DressMesh/upcloth/upcloth003/Snipaste_2019-05-28_17-17-24";
            obj.price = 1;
            //obj.authorname = "";
            //obj.authorwebsit = "";
            obj.itemtype = ItemType.Upcloth;
            objlist.objs.Add(obj);
            #endregion
            string str = JsonConvert.SerializeObject(objlist);
            string md5 = Utility.MD5Hash(str);
            using (FileStream fs = File.Create(@"F:\netbox/x.ini"))
            {
                Byte[] info = new UTF8Encoding(true).GetBytes(str);
                // Add some information to the file.
                fs.Write(info, 0, info.Length);
            }
        }
    }
}
