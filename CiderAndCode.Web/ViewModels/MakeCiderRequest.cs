using System.ComponentModel.DataAnnotations;

namespace CiderAndCode.Web.ViewModels
{
    public class MakeCiderRequest
    {
        [Required]
        [Display(Name = "Select Bushel")]
        public int BushelId { get; set; }
    }
}