using Abp.Application.Services;
using Abp.Application.Services.Dto;
using Abp.Domain.Repositories;
using LibraryApplicationSystem.BookCategory.Dto;
using LibraryApplicationSystem.Entities;
using LibraryApplicationSystem.Students.Dto;
using Microsoft.EntityFrameworkCore;
using System.Linq;
using System.Threading.Tasks;

namespace LibraryApplicationSystem.BookCategory
{
    public class BookCategoryAppService : AsyncCrudAppService<BookCategories, BookCategoryDto, int, PagedBookCategoryResultRequestDto, CreateBookCategoryDto, BookCategoryDto>, IBookCategoryAppService
    {
        private readonly IRepository<BookCategories, int> _repository;

        public BookCategoryAppService(IRepository<BookCategories, int> repository) : base(repository)
        {
            _repository = repository;
        }

        public override Task<BookCategoryDto> CreateAsync(CreateBookCategoryDto input)
        {
            return base.CreateAsync(input);
        }

        public override Task DeleteAsync(EntityDto<int> input)
        {
            return base.DeleteAsync(input);
        }

        public override Task<PagedResultDto<BookCategoryDto>> GetAllAsync(PagedBookCategoryResultRequestDto input)
        {
            return base.GetAllAsync(input);
        }

        public override Task<BookCategoryDto> GetAsync(EntityDto<int> input)
        {
            return base.GetAsync(input);
        }

        public override Task<BookCategoryDto> UpdateAsync(BookCategoryDto input)
        {
            return base.UpdateAsync(input);
        }

        public async Task<PagedResultDto<BookCategoryDto>> GetAllBookCategoryWithDepartment(PagedResultRequestDto input)
        {
            var bookCategory = await _repository.GetAll()
                .Include(x => x.Department)
                .Select(x => ObjectMapper.Map<BookCategoryDto>(x))
                .ToListAsync();


            return new PagedResultDto<BookCategoryDto>(bookCategory.Count(), bookCategory);
        }
    }
}
