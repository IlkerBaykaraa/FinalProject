using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Constants
{
    public static class Messages
    {
        public static readonly string ProductAdded = "Ürün eklendi";
        public static readonly string ProductNameInvalid= "Geçersiz isim";
        public static readonly string ProductsGet = "Ürünler listelendi";
        public static readonly string MaintenanceTime = "Sistemde bakım var";

        public static string ProductCountOfCategoryId = "Bir categoride max 10 ürün olabilir";

        public static string ProductNameAlreadyExist = "Bu isimde bir ürün var";
        internal static string CategoryLimitExceded = "Kategori limiti aşıldı, ekleme yapılamaz";
    }
}
