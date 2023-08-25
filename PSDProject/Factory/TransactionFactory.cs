using PSDProject.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PSDProject.Factory
{
    public class TransactionFactory
    {
        public static TrHeader CreateTrHeader(int UserID, DateTime transactionDate)
        {
            return new TrHeader
            {
                UserId = UserID,
                TransactionDate = transactionDate
            };
        }

        public static TrDetail CreateTrDetail(int transactionID, int itemID, int quantity)
        {
            return new TrDetail
            {
                TrHeaderId = transactionID,
                ItemID = itemID,
                Quantity = quantity
            };
        }
    }
}