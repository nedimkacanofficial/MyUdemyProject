using System.ComponentModel.DataAnnotations;

namespace HotelProject.WebUI.Dtos.ServiceDto
{
    public class CreateServiceDto
    {
        [Required(ErrorMessage ="Hizmet icon linki zorunludur!")]
        public string? ServiceIcon { get; set; }
        [Required(ErrorMessage = "Hizmet başlığı zorunludur!")]
        [StringLength(100,ErrorMessage ="Hizmet bağlığı maksimum 100 karakter olabilir!")]
        public string? Title { get; set; }
        public string? Description { get; set; }
    }
}
