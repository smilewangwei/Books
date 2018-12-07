using System.ComponentModel.DataAnnotations;
using Abp.Application.Services.Dto;
using BookList;

namespace BookList.Dtos
{
    public class PagedInputDto : IPagedResultRequest
    {
        [Range(1,AppConsts.MaxPageSize)]
        public int MaxResultCount { get; set; }

        [Range(1,int.MaxValue)]
        public int SkipCount { get; set; }

        public PagedInputDto()
        {
            //设置默认值
            MaxResultCount = AppConsts.DefaultPageSize;
        }
    }
}