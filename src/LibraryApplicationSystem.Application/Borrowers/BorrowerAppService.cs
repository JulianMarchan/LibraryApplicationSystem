using Abp.Application.Services;
using Abp.Application.Services.Dto;
using Abp.Domain.Repositories;
using LibraryApplicationSystem.BookCategory.Dto;
using LibraryApplicationSystem.Borrowers.Dto;
using LibraryApplicationSystem.Entities;
using Microsoft.EntityFrameworkCore;
using System.Linq;
using System.Threading.Tasks;

namespace LibraryApplicationSystem.Borrowers
{
    public class BorrowerAppService : AsyncCrudAppService<Borrower, BorrowerDto, int, PagedBorrowerResultRequestDto, CreateBorrowerDto, BorrowerDto>, IBorrowerAppService
    {
        private readonly IRepository<Borrower, int> _repository;

        public BorrowerAppService(IRepository<Borrower, int> repository) : base(repository)
        {
            _repository = repository;
        }

        public override Task<BorrowerDto> CreateAsync(CreateBorrowerDto input)
        {
            return base.CreateAsync(input);
        }

        public override Task DeleteAsync(EntityDto<int> input)
        {
            return base.DeleteAsync(input);
        }

        public override Task<PagedResultDto<BorrowerDto>> GetAllAsync(PagedBorrowerResultRequestDto input)
        {
            return base.GetAllAsync(input);
        }

        public override Task<BorrowerDto> GetAsync(EntityDto<int> input)
        {
            return base.GetAsync(input);
        }

        public override Task<BorrowerDto> UpdateAsync(BorrowerDto input)
        {
            return base.UpdateAsync(input);
        }

        public async Task<PagedResultDto<BorrowerDto>> GetAllBorrowerWithStudentBook(PagedResultRequestDto input)
        {
            var borrowers = await _repository.GetAll()
                .Include(x => x.Book)
                .Include(x => x.Student)
                .Where(x => x.Book.isBorrowed == false) // sa is borrow lalabas dapat lahat ng borrowers and binorrow 
                .Select(x => ObjectMapper.Map<BorrowerDto>(x))
                .ToListAsync();


            return new PagedResultDto<BorrowerDto>(borrowers.Count(), borrowers);
        }
    }
}
