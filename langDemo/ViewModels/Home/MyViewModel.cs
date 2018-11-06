using System.ComponentModel.DataAnnotations;

namespace demoApp.ViewModels.Home
{
    public class MyViewModel
    {
        [Required(ErrorMessage = "RequiredName")]
        [Display(Name = "Name")]
        public string Name { get; set; }
    }
}
