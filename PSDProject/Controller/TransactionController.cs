using PSDProject.Handler;
using PSDProject.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PSDProject.Controller
{
    public class TransactionController
    {
        public static int InsertTransaction(int UserID)
        {
            TrHeader header = TransactionHandler.CreateTrHeader(UserID, DateTime.Now);
            return header.Id;
        }

        public static void InsertTransactionDetail(int headerid, int ItemID, int quantity)
        {
            TransactionHandler.CreateTrDetail(headerid, ItemID, quantity);
        }

        public static List<TrHeader> GetAllTransaction(int UserID)
        {
            return TransactionHandler.GetAllTransaction(UserID);
        }

        public static List<TrDetail> GetAllTransactionDetail(int TransactionID)
        {
            return TransactionHandler.GetAllTransactionDetail(TransactionID);
        }
    }
}