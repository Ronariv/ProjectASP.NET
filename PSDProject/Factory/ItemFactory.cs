using PSDProject.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI.WebControls;

namespace PSDProject.Factory
{
    public class ItemFactory
    {
        public static Item CreateItem(string name, FileUpload imageFile, int type, string description, int Price, int userID)
        {
            var file = imageFile.PostedFile;
            var paths = "~/Image/" + DateTime.Now.ToString("yyyyMMdd_HHmmssffff") + "_" + file.FileName;
            var filePath = HttpContext.Current.Server.MapPath(paths);
            file.SaveAs(filePath);
            return new Item
            {
                ItemName = name,
                ItemPrice = Price,
                ItemTypeID = type,
                ItemDescription = description,
                ItemPicture = paths,
                UserID = userID
            };
        }

        public static ItemType CreateItemType(string typename)
        {
            return new ItemType
            {
                ItemTypeName = typename
            };
        }
    }
}