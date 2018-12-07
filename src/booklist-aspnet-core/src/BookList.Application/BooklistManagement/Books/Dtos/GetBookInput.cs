using Abp.Runtime.Validation;
using BookList.Dtos;

namespace BookList.BooklistManagement.Books.Dtos
{
    public class GetBookInput:PagedAndFilteredInputDto,IShouldNormalize
    {
        /// <summary>
        /// 默认排序
        /// </summary>
        public void Normalize()
        {
            Sorting = "Id";
        }
    }
}