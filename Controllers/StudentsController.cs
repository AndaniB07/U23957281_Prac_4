using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace U23957281_Prac_4.Controllers
{
    public class StudentsController : Controller
    {
        // GET: Students
        public ActionResult StudentGroup()
        {
            List<Models.StudyGroup> students = new List<Models.StudyGroup>();
            students.Add(new Models.StudyGroup { StudentNo = "u12345678", FirstName = "Jane", LastName = "Doe", EmailAddress = "jane.doe@tuks.co.za", myLink = "~/HTML/Jane.html", Delete = true });
            students.Add(new Models.StudyGroup { StudentNo = "u01234567", FirstName = "John", LastName = "Doe", EmailAddress = "john.doe@tuks.co.za", myLink = "~/HTML/John.html", Delete = true });
            students.Add(new Models.StudyGroup { StudentNo = "u23957281", FirstName = "Andani", LastName = "Bologo", EmailAddress = "u23957281@tuks.co.za", myLink = "~/HTML/Andani.html", Delete = true });
            students.Add(new Models.StudyGroup { StudentNo = "u23619270", FirstName = "Vhuthuhawe", LastName = "Negondeni", EmailAddress = "u23619270@tuks.co.za", myLink = "~/HTML/Vhuthuhawe.html", Delete = true });
            students.Add(new Models.StudyGroup { StudentNo = "u23854830", FirstName = "Dakalo", LastName = "Nemamilwe", EmailAddress = "u23854830@tuks.co.za", myLink = "~/HTML/Dakalo.html", Delete = true });

            return View(students);
        }
    }
}