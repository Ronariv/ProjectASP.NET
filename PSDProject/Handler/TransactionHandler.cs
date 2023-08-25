using PSDProject.Model;
using PSDProject.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PSDProject.Handler
{
    public class TransactionHandler
    {
        public static TrHeader CreateTrHeader(int UserID, DateTime transactionDate)
        {
            return TransactionRepository.CreateTrHeader(UserID, transactionDate);
        }

        public static void CreateTrDetail(int transactionID, int ItemID, int quantity)
        {
            TransactionRepository.CreateTrDetail(transactionID, ItemID, quantity);
        }

        public static List<TrHeader> GetAllTransaction(int UserID)
        {
            return TransactionRepository.GetAllTrHeader(UserID);
        }

        public static List<TrDetail> GetAllTransactionDetail(int TransactionID)
        {
            return TransactionRepository.GetAllTrDetail(TransactionID);
        }
    }
}