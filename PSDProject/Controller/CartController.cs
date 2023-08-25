using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using PSDProject.Handler;
using PSDProject.Model;
namespace PSDProject.Controller
{
    public class CartController
    {
        public static void AddCart(int userid, int itemid, int quantity)
        {
            CartHandler.AddCart(userid, itemid, quantity);
        }

        public static dynamic GetCart(int userid)
        {
            return CartHandler.GetCart(userid);
        }

        public static List<Cart> Carts(int userid)
        {
            return CartHandler.Carts(userid);
        }

        public static void DeleteCart(int userid)
        {
            CartHandler.DeleteCart(userid);
        }
    }
}