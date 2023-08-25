using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using PSDProject.Model;
namespace PSDProject.Factory
{
    public class CartFactory
    {
        public static Cart AddCart(int userid, int itemid, int quantity)
        {
            return new Cart
            {
                UserID = userid,
                ItemID = itemid,
                Quantity = quantity
            };
        }
    }
}