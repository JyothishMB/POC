using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using StudentAdmissionManagement.Models;

namespace StudentAdmissionManagement.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class StudentAdmissionController : ControllerBase
    {
        [HttpGet]
        public IEnumerable<StudentAdmissionDetails> Get()
        {
            StudentAdmissionDetails admissionobj1 = new StudentAdmissionDetails();
            StudentAdmissionDetails admissionobj2 = new StudentAdmissionDetails();
            admissionobj1.StudentID = 1;
            admissionobj1.StudentName = "Adam";
            admissionobj1.StudentClass = "X";
            admissionobj1.DateofJoining = DateTime.Now;
            admissionobj2.StudentID = 2;
            admissionobj2.StudentName = "Brad";
            admissionobj2.StudentClass = "IX";
            admissionobj2.DateofJoining = DateTime.Now;
            List<StudentAdmissionDetails> listofobj = new List<StudentAdmissionDetails>
            {
                admissionobj1,
                admissionobj2
            };
            return listofobj;
        }       
    }
}