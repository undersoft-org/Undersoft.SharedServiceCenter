using Undersoft.SDK.Service.Application.Identity;

namespace Undersoft.SSC.Web.API.Services
{
    public class AccountIdentityService
    {
        private IServicer _servicer;
        private IAccountIdentityManager _accountManager;

        public AccountIdentityService(IServicer ultimatr, IAccountIdentityManager accountManager) : base()
        {
            _servicer = ultimatr;
            _accountManager = accountManager;
        }
    }
}
