using PSDProject.Model;
using PSDProject.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI.WebControls;

namespace PSDProject.Handler
{
    public class ItemHandler
    {
        public static dynamic GetAllItems()
        {
            return ItemRepository.GetAllItems();
        }

        public static List<ItemType> GetAllItemType()
        {
            return ItemRepository.GetAllItemType();
        }

        public static void CreateItem(string name, FileUpload imageFile, string description, int type, int Price, int userID)
        {
            ItemRepository.CreateItem(name, imageFile, type, description, Price, userID);
        }
        
        public static void CreateItemType(string typename)
        {
            ItemRepository.CreateItemType(typename);
        }

        public static Item GetOneItem(int idx)
        {
            return ItemRepository.GetOneItem(idx);
        }

        public static void UpdateItem(int itemID, string name, FileUpload imageFile, string description, int type, int Price)
        {
            ItemRepository.UpdateItem(itemID,
                name, imageFile, description, type, Price);
        }

        public static bool DeleteItem(int idx)
        {
            return ItemRepository.DeleteItem(idx);
        }
    }
}