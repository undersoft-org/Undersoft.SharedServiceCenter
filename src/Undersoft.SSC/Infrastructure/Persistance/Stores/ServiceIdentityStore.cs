using Microsoft.EntityFrameworkCore;
using Undersoft.SDK.Service.Application.Identity;

namespace Undersoft.SSC.Infrastructure.Persistance.Stores
{
    public class ServiceIdentityStore : IdentityStore<IIdentityStore, ServiceIdentityStore>
    {
        public ServiceIdentityStore(DbContextOptions<ServiceIdentityStore> options) : base(options)
        {
        }
    }
}
