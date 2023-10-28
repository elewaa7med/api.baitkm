using Baitkm.BLL.Services;
using Baitkm.BLL.Services.Currencies;
using Baitkm.DTO.ViewModels;
using Baitkm.Infrastructure.Helpers.ResponseModels;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Net.Http;
using System.Threading.Tasks;

namespace Baitkm.Controllers
{
    [AllowAnonymous]
    public class CurrnecyController : BaseController
    {
        private readonly IHttpClientFactory clientFactory;
        private readonly ICurrencyService currencyService;

        public CurrnecyController(IHttpClientFactory clientFactory,
            ICurrencyService currencyService)
		{
            this.clientFactory = clientFactory;
            this.currencyService = currencyService;
        }

        [HttpGet]
        public async  Task<ServiceResult> Get()
        {
            var client = clientFactory.CreateClient();
            var request = new HttpRequestMessage(HttpMethod.Get, "http://free.currencyconverterapi.com/api/v5/convert?q=SAR_USD&compact=y&apiKey=57c20cad0a7bc35f14b1");
            var response = await client.SendAsync(request);
            CurrencyResponseModel responseModel = new CurrencyResponseModel();


            if (response.IsSuccessStatusCode)
            {
                var result = await response.Content.ReadAsStringAsync();
                var res = result.Split('"', ',', ':','}','{');

                return new ServiceResult
                {
                    Data = new CurrencyResponseModel
                    {
                        Amount = res[8]
                    },
                    Success = true,
                };
            };

            return new ServiceResult();
        }

        [HttpGet]
        public async Task<IActionResult> List()
        {
            return await MakeActionCallAsync(async () => await currencyService.List(GetLanguage()));
        }
    }
}