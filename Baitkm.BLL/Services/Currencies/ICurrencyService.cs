using Baitkm.DTO.ViewModels;
using Baitkm.Enums;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Baitkm.BLL.Services.Currencies
{
    public interface ICurrencyService
    {
        Task<List<CurrencyListResponseModel>> List(Language language);
    }
}