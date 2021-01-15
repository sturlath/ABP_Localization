using System;
using System.Collections.Generic;
using System.Text;
using test.test.Localization;
using Volo.Abp.Application.Services;

namespace test.test
{
    /* Inherit your application services from this class.
     */
    public abstract class testAppService : ApplicationService
    {
        protected testAppService()
        {
            LocalizationResource = typeof(testResource);
        }
    }
}
