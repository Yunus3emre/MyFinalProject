using Core.Entities.Concrete;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text;

namespace Business.Constants
{
    public static class Messages
    {
        public static string ProductAdded = "Ürün Eklendi";
        public static string ProductNameInvalid = "Ürün ismi geçersiz";
        public static string MaintenanceTime="Sistem Bakımda";
        public static string ProductListed="Ürünler Listelendi";
        public static string ProductCountOfCategoryId = "Ürün kategorisinde 10 eleman var";
        public static string ProductNameAlredyExists = "Ürün ismidaha önce kayıt edilmiş";
        public static string CategoryLimitExceded = "Kategori limiti aşıldı";
        public static string AuthorizationDenied = "Yetkiniz Yok";
        internal static User UserNotFound;
        internal static string UserRegistered;
        internal static User PasswordError;
        internal static string SuccessfulLogin;
        internal static string UserAlreadyExists;
        internal static string AccessTokenCreated;
    }
}
