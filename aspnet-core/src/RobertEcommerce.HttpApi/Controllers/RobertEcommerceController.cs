using RobertEcommerce.Localization;
using Volo.Abp.AspNetCore.Mvc;

namespace RobertEcommerce.Controllers;

/* Inherit your controllers from this class.
 */
public abstract class RobertEcommerceController : AbpControllerBase
{
    protected RobertEcommerceController()
    {
        LocalizationResource = typeof(RobertEcommerceResource);
    }
}
