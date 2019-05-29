using Microsoft.AspNetCore.Mvc;
using view_component_ajax.Models;

namespace view_component_ajax.Views.Shared.Components.Form
{
    public class FormViewComponent : ViewComponent
    {
        public FormViewComponent() { }

        public IViewComponentResult Invoke(FormModel model)
        {
            return View("Default", model);
        }
    }
}
