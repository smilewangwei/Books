using System;
using System.Collections.Generic;
using System.Text;
using Abp.Domain.Entities.Auditing;

namespace BookList.BooklistManagement.Booklists
{
    /// <summary>
    /// 书单
    /// </summary>
    public class Booklist:CreationAuditedEntity<long>
    {
        /// <summary>
        /// 书单名
        /// </summary>
        public string BookListName { get; set; }

        /// <summary>
        /// 简介
        /// </summary>
        public string Intro { get; set; }
    }
}
