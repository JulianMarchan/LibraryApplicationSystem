using Abp.Application.Services;
using Abp.Application.Services.Dto;
using Abp.Domain.Repositories;
using LibraryApplicationSystem.Entities;
using System.Threading.Tasks;
using LibraryApplicationSystem.Books.Dto;
using Microsoft.EntityFrameworkCore;
using System.Linq;
using System.Collections.Generic;
using LibraryApplicationSystem.Authors.Dto;

namespace LibraryApplicationSystem.Books
{

    public class BookAppService : AsyncCrudAppService<Book, BookDto, int, PagedBookResultRequestDto, CreateBookDto, BookDto>, IBookAppService

    {
        private readonly IRepository<Book, int> _repository;
        public BookAppService(IRepository<Book, int> repository) : base(repository)
        {
            _repository = repository;
        }

        public override Task<BookDto> CreateAsync(CreateBookDto input)
        {
           return base.CreateAsync(input);
        }

        public override Task DeleteAsync(EntityDto<int> input)
        {
            return base.DeleteAsync(input);
        }

        public override Task<PagedResultDto<BookDto>> GetAllAsync(PagedBookResultRequestDto input)
        {
            return base.GetAllAsync(input);
        }

        public override Task<BookDto> GetAsync(EntityDto<int> input)
        {
            return base.GetAsync(input);
        }

        public override Task<BookDto> UpdateAsync(BookDto input)
        {

            return base.UpdateAsync(input);
        }
        public async Task<PagedResultDto<BookDto>> GetAllBookWithCategory(PagedResultRequestDto input)
        {
            var book = await _repository.GetAll()
                .Include(x => x.Author)
                .Include(x => x.BookCategories)
                .Select(x => ObjectMapper.Map<BookDto>(x))
                .ToListAsync();

            return new PagedResultDto<BookDto>(book.Count(), book);
        }
        public async Task<List<BookDto>> GetAllBorrowersbook()
        {
            var borrowers = await _repository.GetAll()
                .Where(m => m.isBorrowed == false)
                .Select(x => ObjectMapper.Map<BookDto>(x))
                .ToListAsync();

            return borrowers;

        }


      
    }
}
