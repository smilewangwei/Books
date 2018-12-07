    using AutoMapper;
using BookList.BooklistManagement.Books.Dtos;

namespace BookList.BooklistManagement.Books.Mapper
{
    internal class BookMapper
    {
        public static void CreateMappings(IMapperConfigurationExpression configuration)
        {
            configuration.CreateMap<Book, BookDto>();
            configuration.CreateMap<BookEditDto, Book>(); //创建时
            configuration.CreateMap<Book, BookEditDto>(); //更新时
        }
    }
}