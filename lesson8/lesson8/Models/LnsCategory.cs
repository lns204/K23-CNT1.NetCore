using System.ComponentModel.DataAnnotations;

namespace lesson8.Models
{
    public class LnsCategory
    {
        public class LnsCategory
        {
            public int LnsId { get; set; }

            [Required(ErrorMessage = "Tên danh mục là bắt buộc.")]
            [StringLength(150, MinimumLength = 6, ErrorMessage = "Tên danh mục phải từ 6 đến 150 ký tự.")]
            public string LnsName { get; set; }
        }

    }
}
