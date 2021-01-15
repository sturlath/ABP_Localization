using test.test.Localization;
using Volo.Abp.AspNetCore.Mvc;

namespace test.test.Controllers
{
    /* Inherit your controllers from this class.
     */
    public abstract class testController : AbpController
    {
        protected testController()
        {
            LocalizationResource = typeof(testResource);
        }
    }
}