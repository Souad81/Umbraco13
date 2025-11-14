using Microsoft.AspNetCore.Mvc;
using Umbraco.Cms.Core.Cache;
using Umbraco.Cms.Core.Logging;
using Umbraco.Cms.Core.Routing;
using Umbraco.Cms.Core.Services;
using Umbraco.Cms.Core.Web;
using Umbraco.Cms.Infrastructure.Persistence;
using Umbraco.Cms.Web.Common.PublishedModels;
using Umbraco.Cms.Web.Website.Controllers;
using UmbracoCMS.ViewModels;

namespace UmbracoCMS.Controllers
{
    public class FormController(IUmbracoContextAccessor umbracoContextAccessor, IUmbracoDatabaseFactory databaseFactory, ServiceContext services, AppCaches appCaches, IProfilingLogger profilingLogger, IPublishedUrlProvider publishedUrlProvider, FormSubmissionsService formSubmissions) : SurfaceController(umbracoContextAccessor, databaseFactory, services, appCaches, profilingLogger, publishedUrlProvider)
    {

        private readonly FormSubmissionsService _formSubmissions = formSubmissions;
        public IActionResult HandleCallbackForm(CallbackFormViewModel model)
        {
            if (!ModelState.IsValid)
            {
                return CurrentUmbracoPage();
            }

            var result = _formSubmissions.SaveCallbackRequest(model);
            if (!result)
            {
             
                return RedirectToCurrentUmbracoPage();
            }

            // Work with form data here

            return RedirectToCurrentUmbracoPage();
        }
    }

    public class FormSubmissionsService
    {
        internal bool SaveCallbackRequest(CallbackFormViewModel model)
        {
            throw new NotImplementedException();
        }
    }
}
