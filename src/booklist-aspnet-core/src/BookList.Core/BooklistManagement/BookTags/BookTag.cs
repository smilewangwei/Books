using Abp.Domain.Entities.Auditing;

namespace BookList.BooklistManagement.BookTags
{
    /// <summary>
    /// 书籍标签
    /// </summary>
    public class BookTag: CreationAuditedEntity<long>
    {
        /// <summary>
        /// 标签名称
        /// </summary>
        public string TagName { get; set; }
    }
}