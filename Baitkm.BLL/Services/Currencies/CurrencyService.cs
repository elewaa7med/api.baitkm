using Baitkm.DAL.Repository.Entities;
using Baitkm.DTO.ViewModels;
using Baitkm.Entities;
using Baitkm.Enums;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Baitkm.BLL.Services.Currencies
{
    public class CurrencyService : ICurrencyService
    {
        private readonly IEntityRepository repository;

        public CurrencyService(IEntityRepository repository)
        {
            this.repository = repository;
        }

        public async Task<List<CurrencyListResponseModel>> List(Language language)
        {
            return await repository
                .FilterAsNoTracking<Currency>(c => !c.IsDeleted)
                .Select(c => new CurrencyListResponseModel
                {
                    Id = c.Id,
                    Code = language == Language.English ? c.Code : c.CodeAr,
                    Symbol = c.Symbol
                }).ToListAsync();
        }
    }
}