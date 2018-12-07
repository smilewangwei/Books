using System;
using System.Collections.Generic;
using System.Text;

namespace BookList.BooklistManagement.Books.Authorization
{
    /// <summary>
    /// 对书籍权限的说明
    /// </summary>
   public static class BookPermissions
    {
        /// <summary>
		/// Book权限节点
		///</summary>
		public const string BookManager = "Pages.BookManager";

        /// <summary>
        /// Book查询授权
        ///</summary>
        public const string Query = "Pages.Book.Query";

        /// <summary>
        /// Book创建权限
        ///</summary>
        public const string Create = "Pages.Book.Create";

        /// <summary>
        /// Book修改权限
        ///</summary>
        public const string Edit = "Pages.Book.Edit";

        /// <summary>
        /// Book删除权限
        ///</summary>
        public const string Delete = "Pages.Book.Delete";

        /// <summary>
		/// Book批量删除权限
		///</summary>
		public const string BatchDelete = "Pages.Book.BatchDelete";

        /// <summary>
        /// Book导出Excel
        ///</summary>
        //public const string ExportExcel = "Pages.Book.ExportExcel";
    }
}
