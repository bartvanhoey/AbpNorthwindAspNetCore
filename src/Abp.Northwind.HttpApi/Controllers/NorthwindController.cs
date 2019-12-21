using Abp.Northwind.Localization;
using Volo.Abp.AspNetCore.Mvc;

namespace Abp.Northwind.Controllers
{
    /* Inherit your controllers from this class.
     */
    public abstract class NorthwindController : AbpController
    {
        protected NorthwindController()
        {
            LocalizationResource = typeof(NorthwindResource);
        }
    }
}