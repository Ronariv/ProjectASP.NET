using PSDProject.Factory;
using PSDProject.Model;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.UI.WebControls;

namespace PSDProject.Repository
{
    
    public class ItemRepository
    {
        public static Database1Entities2 db = new Database1Entities2();

        public static void CreateItem(string name, FileUpload imageFile, int type, string description, int Price, int userID)
        {
            db.Items.Add(ItemFactory.CreateItem(name, imageFile, type, description, Price, userID));
            db.SaveChanges();
        }

        public static void CreateItemType(string typename)
        {
            db.ItemTypes.Add(ItemFactory.CreateItemType(typename));
            db.SaveChanges();
        }

        public static List<ItemType> GetAllItemType()
        {
            return db.ItemTypes.ToList();
        }

        public static Item GetOneItem(int idx)
        {
            return db.Items.Where(x => x.Id == idx).FirstOrDefault();
        }

        public static dynamic GetAllItems()
        {
            return db.Items.Join(db.ItemTypes,
                item => item.ItemTypeID,
                type => type.Id,
                (item, type) => new
                {
                    ItemId = item.Id,
                    ItemName = item.ItemName,
                    ItemPicture = item.ItemPicture,
                    ItemDescription = item.ItemDescription,
                    ItemType = type.ItemTypeName,
                    ItemPrice = item.ItemPrice
                }).ToList();
        }
        public static void UpdateItem(int ItemID, string name,
            FileUpload imageFile, string description,
            int type, int Price)
        {
            Item item = db.Items.Where(x => x.Id == ItemID).FirstOrDefault();
            if (item == null) return;
            


            var deletedFilePath = HttpContext.Current.Server.MapPath(item.ItemPicture);
            FileInfo files = new FileInfo(deletedFilePath);
            var img = System.Drawing.Image.FromFile(deletedFilePath);
            img.Dispose();
            if (files.Exists)
            {
                files.Delete();
            }


            var file = imageFile.PostedFile;
            var fileName = "~/Image/" +
                DateTime.Now.ToString("yyyyMMdd_HHmmssffff") + "_" + file.FileName;
            var filePath = HttpContext.Current.Server.MapPath(fileName);
            file.SaveAs(filePath);
            item.ItemName = name;
            item.ItemDescription = description;
            item.ItemTypeID = type;
            item.ItemPrice = Price;
            item.ItemPicture = fileName;

            db.SaveChanges();
        }


        public static bool DeleteItem(int idx)
        {
            Item item = db.Items.Where(x => x.Id == idx).FirstOrDefault();
            if (item == null) return false;

            var deletedFilePath = HttpContext.Current.Server.MapPath(item.ItemPicture);
            FileInfo files = new FileInfo(deletedFilePath);

            if (files.Exists)
            {
                var img = System.Drawing.Image.FromFile(deletedFilePath);
                img.Dispose();
                files.Delete();
            }
            db.Items.Remove(item);
            db.SaveChanges();
            return true;
        }

    }
}