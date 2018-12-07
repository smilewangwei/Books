using Abp.Application.Services.Dto;

namespace BookList.Dtos
{
    public class PagedAndFilteredInputDto:PagedAndSortedResultRequestDto
    {
        /// <summary>
        /// 过滤文本，用于实现全局模糊搜索
        /// </summary>
        public string FilterText { get; set; }
    }
}