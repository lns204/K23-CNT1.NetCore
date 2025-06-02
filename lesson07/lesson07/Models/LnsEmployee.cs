using Microsoft.AspNetCore.Mvc;
using System.ComponentModel.DataAnnotations;

namespace lesson07.Models
{
    public class LnsEmployee
    {
        public int LnsID { get; set; }

        [Required(ErrorMessage = "Họ và tên là bắt buộc")]
        [StringLength(100, ErrorMessage = "Họ và tên không được vượt quá 100 ký tự")]
        public string LnsName { get; set; }

        [Required(ErrorMessage = "Email là bắt buộc")]
        [EmailAddress(ErrorMessage = "Email không hợp lệ")]
        public string LnsEmail { get; set; }

        [Required(ErrorMessage = "Ngày sinh là bắt buộc")]
        [DataType(DataType.Date)]
        public DateTime LnsBirthDay { get; set; }

        [Required(ErrorMessage = "Số điện thoại là bắt buộc")]
        [Phone(ErrorMessage = "Số điện thoại không hợp lệ")]
        public string LnsPhone { get; set; }

        [Required(ErrorMessage = "Lương là bắt buộc")]
        [Range(0, double.MaxValue, ErrorMessage = "Lương phải là số không âm")]
        public double LnsSalary { get; set; }

        public bool LnsStatus { get; set; }
    }
}
