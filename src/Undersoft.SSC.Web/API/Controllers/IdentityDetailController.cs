using Microsoft.AspNetCore.Authorization;
using Undersoft.SDK.Service.Application.Identity;

namespace Undersoft.SSC.Web.API.Controllers
{
    [AllowAnonymous]
    public class IdentityDetailController
        : IdentityControllerBase<IDataStore, IdentityAuthorizationService, IdentityDetail>
    {
        public IdentityDetailController(IServicer servicer) : base(servicer) { }
    }
}
