using Microsoft.AspNetCore.Mvc;
using lesson07.Models;
using System;
using System.Collections.Generic;
using lesson07.Models;

namespace LnsLesson07.Controllers
{
    public class LnsEmployeeController : Controller
    {
        private static List<LnsEmployee> LnsEmployees = new List<LnsEmployee>
        {
            new LnsEmployee
            {
                LnsID = 231090089,
                LnsName = "Lê Ngọc Sơn",
                LnsEmail = "LeNGgocSon1003@gmail.com",
                LnsBirthDay = new DateTime(2004, 3, 10),
                LnsPhone = "0343288214",
                LnsSalary = 12000000,
                LnsStatus = true
            },
            new LnsEmployee
            {
                LnsID = 2,
                LnsName = "Trần Thị B",
                LnsEmail = "b.tran@example.com",
                LnsBirthDay = new DateTime(1992, 3, 10),
                LnsPhone = "0912345678",
                LnsSalary = 10000000,
                LnsStatus = true
            },
            new LnsEmployee
            {
                LnsID = 3,
                LnsName = "Lê Văn C",
                LnsEmail = "c.le@example.com",
                LnsBirthDay = new DateTime(1988, 7, 22),
                LnsPhone = "0987654321",
                LnsSalary = 15000000,
                LnsStatus = false
            },
            new LnsEmployee
            {
                LnsID = 4,
                LnsName = "Phạm Thị D",
                LnsEmail = "d.pham@example.com",
                LnsBirthDay = new DateTime(1995, 11, 5),
                LnsPhone = "0934567890",
                LnsSalary = 13000000,
                LnsStatus = true
            },
            new LnsEmployee
            {
                LnsID = 5,
                LnsName = "Đỗ Văn E",
                LnsEmail = "e.do@example.com",
                LnsBirthDay = new DateTime(1985, 9, 30),
                LnsPhone = "0976543210",
                LnsSalary = 11000000,
                LnsStatus = false
            },
            new LnsEmployee
            {
                LnsID = 6,
                LnsName = "Hoàng Thị F",
                LnsEmail = "f.hoang@example.com",
                LnsBirthDay = new DateTime(1998, 4, 25),
                LnsPhone = "0961234567",
                LnsSalary = 9500000,
                LnsStatus = true
            }
        };

        public IActionResult LnsIndex()
        {
            return View(LnsEmployees); // truyền danh sách ra view
        }
        // GET: Hiển thị form tạo mới
        public IActionResult LnsCreate()
        {
            return View();
        }

        // POST: Xử lý form tạo mới
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult LnsCreate(LnsEmployee employee)
        {
            if (ModelState.IsValid)
            {
                LnsEmployees.Add(employee);
                return RedirectToAction("LnsIndex");
            }
            return View(employee);
        }

        public IActionResult LnsEdit(int id)
        {
            var model = LnsEmployees.Find(x => x.LnsID == id);
            if (model == null)
            {
                return NotFound();
            }
            return View(model);
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult LnsEdit(LnsEmployee updated)
        {
            var existing = LnsEmployees.Find(x => x.LnsID == updated.LnsID);
            if (existing == null)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                existing.LnsName = updated.LnsName;
                existing.LnsEmail = updated.LnsEmail;
                existing.LnsBirthDay = updated.LnsBirthDay;
                existing.LnsPhone = updated.LnsPhone;
                existing.LnsSalary = updated.LnsSalary;
                existing.LnsStatus = updated.LnsStatus;

                return RedirectToAction("LnsIndex");
            }

            return View(updated);
        }
        // GET: Lns/LnsDetails/5
        public IActionResult LnsDetail(int? id)
        {
            if (id == null)
            {
                return BadRequest();
            }

            var employee = LnsEmployees.FirstOrDefault(x => x.LnsID == id);
            if (employee == null)
            {
                return NotFound();
            }

            return View(employee);
        }
        public IActionResult LnsDelete(int? id)
        {
            if (id == null)
            {
                return BadRequest();
            }

            var employee = LnsEmployees.FirstOrDefault(x => x.LnsID == id);
            if (employee == null)
            {
                return NotFound();
            }

            LnsEmployees.Remove(employee);
            TempData["Message"] = $"Xóa nhân viên {employee.LnsName} thành công!";
            return RedirectToAction("LnsIndex");
        }

    }
}
