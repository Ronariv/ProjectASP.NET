using PSDProject.Handler;
using PSDProject.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI.WebControls;

namespace PSDProject.Controller
{
    public class ItemController
    {
        public static dynamic GetAllItems()
        {
            return ItemHandler.GetAllItems();
        }

        public static string InsertItemType(string typename)
        {
            ItemHandler.CreateItemType(typename);
            if(typename == null || typename == "")
            {
                return "Item Type Name Must not be empty";
            }
            return null;
        }

        public static List<ItemType> GetAllItemType()
        {
            return ItemHandler.GetAllItemType();
        }

        public static string InsertItem(string name, FileUpload imageFile,
            string description, int type, int price, int userID)
        {
            string error = ItemValidation(name, imageFile, description, type, price);
            if (error == null)
            {
                ItemHandler.CreateItem(name, imageFile, description, type, price, userID);
            }
            return error;
        }

        private static string ItemValidation(string name, FileUpload imageFile, string description, int type, int price)
        {
            if (name.Length < 5)
            {
                return "Must be filled and minimal length is 5 characters";
            }
            if (!imageFile.HasFile)
            {
                return "You must input the Image";
            }
            else
            {
                if (!imageFile.FileName.EndsWith(".jpg") && !imageFile.FileName.EndsWith(".png"))
                {
                    return "Extention must ends with \".jpg\" and \".png\"";
                }
            }
            if (description.Length <= 10)
            {
                return "Description must be longer than 10 characters";
            }
            if (type == -1)
            {
                return "Item Type must be Filled";
            }
            return null;
        }

        public static string DeleteItem(string arg)
        {

            if (!int.TryParse(arg, out int idx))
            {
                return "Invalid Item index";
            }

            if (!ItemHandler.DeleteItem(idx))
            {
                return "Item not available";
            }
            return null;
        }

        public static Item GetOneItem(string idx)
        {
            if (!int.TryParse(idx, out int realIdx))
            {
                return null;
            }
            return ItemHandler.GetOneItem(int.Parse(idx));
        }

        public static string UpdateItem(int itemID, string name,
            FileUpload imageFile, string description,
            int type, int price)
        {
            string error = ItemValidation(name, imageFile, description, type, price);

            if (error == null)
            {
                ItemHandler.UpdateItem(itemID, name, imageFile, description, type, price);
            }
            return error;
        }
    }
}