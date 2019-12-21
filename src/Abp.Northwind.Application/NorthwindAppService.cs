using System;
using System.Collections.Generic;
using System.Text;
using Abp.Northwind.Localization;
using Volo.Abp.Application.Services;

namespace Abp.Northwind
{
    /* Inherit your application services from this class.
     */
    public abstract class NorthwindAppService : ApplicationService
    {
        protected NorthwindAppService()
        {
            LocalizationResource = typeof(NorthwindResource);
        }
    }
}
