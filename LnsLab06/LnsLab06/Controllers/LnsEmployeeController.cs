using Microsoft.AspNetCore.Mvc;
using LnsLab06.Models;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq; // Added for LINQ methods like Any() and Max()

public class LnsEmployeeController : Controller
{
    // Static list to store employees (in-memory for simplicity)
    private static List<LnsEmployee> _accounts = new List<LnsEmployee>
    {
        new LnsEmployee
        {
            LnsID = 1,
            LnsName = "Nguyễn Quang Tâm",
            LnsEmail = "nguyenquangtam6666@gmail.com",
            LnsBirthDay = DateTime.ParseExact("2005/06/26", "yyyy/MM/dd", CultureInfo.InvariantCulture),
            LnsPhone = "0961138440",
            LnsSalary = 600000.0,
            LnsStatus = true
        },
        new LnsEmployee
        {
            LnsID = 2,
            LnsName = "Trần Thị Minh Anh",
            LnsEmail = "tranminhanh123@gmail.com",
            LnsBirthDay = DateTime.ParseExact("1998/03/15", "yyyy/MM/dd", CultureInfo.InvariantCulture),
            LnsPhone = "0912345678",
            LnsSalary = 750000.0,
            LnsStatus = true
        },
        new LnsEmployee
        {
            LnsID = 3,
            LnsName = "Lê Văn Hùng",
            LnsEmail = "levanhung456@gmail.com",
            LnsBirthDay = DateTime.ParseExact("2000/11/30", "yyyy/MM/dd", CultureInfo.InvariantCulture),
            LnsPhone = "0933456789",
            LnsSalary = 800000.0,
            LnsStatus = false
        },
        new LnsEmployee
        {
            LnsID = 4,
            LnsName = "Phạm Thị Ngọc",
            LnsEmail = "phamthingoc789@gmail.com",
            LnsBirthDay = DateTime.ParseExact("1995/07/22", "yyyy/MM/dd", CultureInfo.InvariantCulture),
            LnsPhone = "0987654321",
            LnsSalary = 900000.0,
            LnsStatus = true
        },
        new LnsEmployee
        {
            LnsID = 5,
            LnsName = "Hoàng Minh Tuấn",
            LnsEmail = "hoangminhtuan101@gmail.com",
            LnsBirthDay = DateTime.ParseExact("2002/09/10", "yyyy/MM/dd", CultureInfo.InvariantCulture),
            LnsPhone = "0901234567",
            LnsSalary = 650000.0,
            LnsStatus = false
        },
        new LnsEmployee
        {
            LnsID = 6,
            LnsName = "Vũ Thị Lan",
            LnsEmail = "vuthilan202@gmail.com",
            LnsBirthDay = DateTime.ParseExact("1997/12/05", "yyyy/MM/dd", CultureInfo.InvariantCulture),
            LnsPhone = "0945678901",
            LnsSalary = 700000.0,
            LnsStatus = true
        }
    };

    // GET: /LnsEmployee/LnsListEmployee
    public IActionResult LnsListEmployee()
    {
        return View(_accounts);
    }

    // GET: /LnsEmployee/LnsCreate
    public IActionResult LnsCreate()
    {
        return View();
    }

    // POST: /LnsEmployee/LnsCreate
    [HttpPost]
    [ValidateAntiForgeryToken]
    public IActionResult LnsCreate(LnsEmployee employee)
    {
        if (ModelState.IsValid)
        {
            employee.LnsID = _accounts.Any() ? _accounts.Max(e => e.LnsID) + 1 : 1;
            _accounts.Add(employee);
            return RedirectToAction("LnsListEmployee");
        }
        return View(employee);
    }
}