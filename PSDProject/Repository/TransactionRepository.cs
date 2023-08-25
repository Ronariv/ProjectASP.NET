using PSDProject.Factory;
using PSDProject.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PSDProject.Repository
{
    public class TransactionRepository
    {
        public static Database1Entities2 db = new Database1Entities2();

        public static TrHeader CreateTrHeader(int UserID, DateTime transactionDate)
        {
            TrHeader data = db.TrHeaders.Add(TransactionFactory.CreateTrHeader(UserID, transactionDate));
            db.SaveChanges();
            return data;
        }

        public static TrDetail CreateTrDetail(int transactionID, int ItemID, int quantity)
        {
            TrDetail data = db.TrDetails.Add(TransactionFactory.CreateTrDetail(transactionID, ItemID, quantity));
            db.SaveChanges();
            return data;
        }

        public static List<TrHeader> GetAllTrHeader(int UserId)
        {
            return db.TrHeaders.Where(x => x.UserId == UserId).ToList();
        }

        public static List<TrDetail> GetAllTrDetail(int transactionId)
        {
            return db.TrDetails.Where(x => x.TrHeaderId == transactionId).ToList();
        }
    }
}