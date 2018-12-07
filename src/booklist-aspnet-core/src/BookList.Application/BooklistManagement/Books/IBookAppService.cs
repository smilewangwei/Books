using Abp.Application.Services;
using Abp.Application.Services.Dto;
using BookList.BooklistManagement.Books.Dtos;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace BookList.BooklistManagement.Books
{
    /// <summary>
    /// 书籍的应用层服务
    /// </summary>
    public interface IBookAppService : IApplicationService
    {
        /// <summary>
        /// 分页获取查询书籍的功能接口
        /// </summary>
        /// <param name="input"></param>
        /// <returns></returns>
        Task<PagedResultDto<BookDto>> GetPagedBook(GetBookInput input);

        /// <summary>
        /// 添加或修改书籍信息的功能接口
        /// </summary>
        /// <param name="input"></param>
        /// <returns></returns>
        Task CreateOrUpdateBook(CreateOrUpdateBookInput input);


        /// <summary>
        /// 删除书籍信息的功能接口
        /// </summary>
        /// <param name="input"></param>
        /// <returns></returns>
        Task DeleteBook(EntityDto<long> input);

        /// <summary>
        /// 批量删除书籍信息的功能接口
        /// </summary>
        /// <param name="input"></param>
        /// <returns></returns>
        Task BatchDeleteBook(List<long> input);
        /// <summary>
        /// 获取编辑状态下的实体
        /// </summary>
        /// <param name="input"></param>
        /// <returns></returns>
        Task<GetBookForEditOutput> GetForEditBook(NullableIdDto<long> input);

    }
}