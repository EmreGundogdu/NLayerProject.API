using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace NLayerProject.Web.DTOs
{
    public class ProductDto
    { 
        public int Id { get; set; }
        [Required(ErrorMessage ="{0} alanı gereklidir.")]
        public string Name { get; set; }
        [Required(ErrorMessage = "{0} Sayısı girilmelidir.")]
        [Range(1,int.MaxValue,ErrorMessage ="{0} alanı 1'den büyük bir değer olmalıdır.")]
        public int Stock { get; set; }
        [Required(ErrorMessage = "{0} Alanını mutlaka giriniz.")]
        [Range(1,double.MaxValue,ErrorMessage = "{0} alanı 1'den büyük bir değer olmalıdır.")]
        public decimal Price { get; set; }
        public int CategoryId { get; set; }
    }
}
