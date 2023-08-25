using PSDProject.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using PSDProject.Factory;
namespace PSDProject.Repository
{
    public class CartRepository
    {
        public static Database1Entities2 db = new Database1Entities2();
        public static void AddToCart(int userid, int itemid, int quantity)
        {
            db.Carts.Add(CartFactory.AddCart(userid, itemid, quantity));
            db.SaveChanges();
        }

        public static dynamic GetCart(int userid)
        {
            return db.Carts.Join(db.Items,
                cart => cart.ItemID,
                item => item.Id,
                (cart, item) => new
                {
                    UserID = cart.UserID,
                    ItemId = item.Id,
                    ItemName = item.ItemName,
                    ItemPicture = item.ItemPicture,
                    ItemDescription = item.ItemDescription,
                    ItemPrice = item.ItemPrice,
                    Quantity = cart.Quantity,
                    ItemTypeName = item.ItemType.ItemTypeName
                }).Where(u => u.UserID == userid).ToList();
        }

        public static List<Cart> Carts(int userid)
        {
            return db.Carts.Where(x => x.UserID == userid).ToList();
        }

        public static void DeleteCart(int userid)
        {
            db.Carts.RemoveRange(db.Carts.Where(x => x.UserID == userid));
            db.SaveChanges();
        }
    }
}