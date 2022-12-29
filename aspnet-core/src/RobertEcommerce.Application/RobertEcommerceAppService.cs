using System;
using System.Collections.Generic;
using System.Text;
using RobertEcommerce.Localization;
using Volo.Abp.Application.Services;

namespace RobertEcommerce;

/* Inherit your application services from this class.
 */
public abstract class RobertEcommerceAppService : ApplicationService
{
    protected RobertEcommerceAppService()
    {
        LocalizationResource = typeof(RobertEcommerceResource);
    }
}
