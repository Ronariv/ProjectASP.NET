using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using PSDProject.Repository;
using PSDProject.Model;
namespace PSDProject.Handler
{
    public class CartHandler
    {
        public static void AddCart(int userid, int itemid, int quantity)
        {
            CartRepository.AddToCart(userid, itemid, quantity);
        }

        public static dynamic GetCart(int userid)
        {
            return CartRepository.GetCart(userid);
        }

        public static List<Cart> Carts(int userid)
        {
            return CartRepository.Carts(userid);
        }

        public static void DeleteCart(int userid)
        {
            CartRepository.DeleteCart(userid);
        }
    }
}