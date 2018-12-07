using Abp.Application.Services.Dto;
using Abp.Authorization;
using Abp.AutoMapper;
using Abp.Domain.Repositories;
using Abp.Extensions;
using Abp.Linq.Extensions;
using BookList.BooklistManagement.Books.Authorization;
using BookList.BooklistManagement.Books.Dtos;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq.Dynamic.Core;
using System.Threading.Tasks;

namespace BookList.BooklistManagement.Books
{
    /// <summary>
    /// 权限
    /// </summary>
    [AbpAuthorize(BookPermissions.BookManager)]
    public class BookAppService : BookListAppServiceBase, IBookAppService
    {
        private readonly IRepository<Book, long> _bookRepository;

        public BookAppService(IRepository<Book, long> bookRepository)
        {
            _bookRepository = bookRepository;
        }
        /// <summary>
        /// 实现分页获取查询书籍的功能
        /// </summary>
        /// <param name="input"></param>
        /// <returns></returns>
        [AbpAuthorize(BookPermissions.Query)]
        public async Task<PagedResultDto<BookDto>> GetPagedBook(GetBookInput input)
        {
            var query = _bookRepository.GetAll().AsNoTracking().WhereIf(!input.FilterText.IsNullOrWhiteSpace(),
                a => a.BookName.Contains(input.FilterText));

            var count = await query.CountAsync();

            var entityListBook = await query.OrderBy(input.Sorting).PageBy(input).ToListAsync();

            var entityBookDtos = entityListBook.MapTo<List<BookDto>>();

            return new PagedResultDto<BookDto>(count, entityBookDtos);
        }
        /// <summary>
        /// 添加或修改书籍信息
        /// </summary>
        /// <param name="input"></param>
        /// <returns></returns>
        /// AbpAuthorize权限
        [AbpAuthorize(BookPermissions.Create,BookPermissions.Edit)]
        public async Task CreateOrUpdateBook(CreateOrUpdateBookInput input)
        {
            if (input.Book.Id.HasValue)
            {
                //Update
                await UpdateBook(input.Book);
            }
            else
            {
                //Create
                await CreateBook(input.Book);
            }
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="input"></param>
        /// <returns></returns>
        [AbpAuthorize(BookPermissions.Delete)]
        public async Task DeleteBook(EntityDto<long> input)
        {
            var entity = await _bookRepository.GetAsync(input.Id);
            if (entity != null)
            {
                await _bookRepository.DeleteAsync(input.Id);
            }
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="input"></param>
        /// <returns></returns>
        [AbpAuthorize(BookPermissions.BatchDelete)]
        public async Task BatchDeleteBook(List<long> input)
        {
            await _bookRepository.DeleteAsync(a => input.Contains(a.Id));
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="input"></param>
        /// <returns></returns>
        [AbpAuthorize(BookPermissions.Create)]
        protected virtual async Task<BookEditDto> CreateBook(BookEditDto input)
        {
            //var model = ObjectMapper.Map<Book>(input);
            var entity = input.MapTo<Book>();
            await _bookRepository.InsertAsync(entity);

            var dto = entity.MapTo<BookEditDto>();
            return dto;
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="input"></param>
        /// <returns></returns>
        [AbpAuthorize(BookPermissions.Edit)]
        protected virtual async Task UpdateBook(BookEditDto input)
        {
            Debug.Assert(input.Id != null, "input.Id != null");
            var entity = await _bookRepository.GetAsync(input.Id.Value);

            input.MapTo(entity);

            await _bookRepository.UpdateAsync(entity);
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="input"></param>
        /// <returns></returns>
        [AbpAuthorize(BookPermissions.Edit)]
        public async Task<GetBookForEditOutput> GetForEditBook(NullableIdDto<long> input)
        {
            var output = new GetBookForEditOutput();
            BookEditDto editDto;
            if (input.Id.HasValue)
            {
                var entity = await _bookRepository.GetAsync(input.Id.Value);
                editDto = entity.MapTo<BookEditDto>();
            }
            else
            {
                editDto = new BookEditDto();
            }
            output.Book = editDto;
            return output;
        }
    }
}