using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelProject.DtoLayer.Dtos.RoomDto
{
    public class RoomAddDto
    {
        [Required(ErrorMessage ="Oda numarası girilmesi zorunludur!")]
        public string? RoomNumber { get; set; }
        public string? RoomCoverImage { get; set; }
        [Required(ErrorMessage = "Fiyat bilgisi girilmesi zorunludur!")]
        public int Price { get; set; }
        [Required(ErrorMessage = "Başlık girilmesi zorunludur!")]
        public string? Title { get; set; }
        [Required(ErrorMessage = "Yatak sayısı girilmesi zorunludur!")]
        public string? BadCount { get; set; }
        [Required(ErrorMessage = "Banyo sayısı girilmesi zorunludur!")]
        public string? BathCount { get; set; }
        public string? Wifi { get; set; }
        public string? Description { get; set; }
    }
}
