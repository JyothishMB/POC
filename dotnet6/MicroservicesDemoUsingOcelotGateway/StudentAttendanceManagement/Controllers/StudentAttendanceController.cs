using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using StudentAttendanceManagement.Models;

namespace StudentAttendanceManagement.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class StudentAttendanceController : ControllerBase
    {
        [HttpGet]
        public IEnumerable<StudentAttendanceDetails> Get()
        {
            StudentAttendanceDetails attendanceObj1 = new StudentAttendanceDetails();
            StudentAttendanceDetails attendanceObj2 = new StudentAttendanceDetails();
            attendanceObj1.StudentID = 1;
            attendanceObj1.StudentName = "Adam";
            attendanceObj1.AttendencePercentage = 83.02;
            attendanceObj2.StudentID = 2;
            attendanceObj2.StudentName = "Brad";
            attendanceObj2.AttendencePercentage = 71.02;
            List<StudentAttendanceDetails> listObj = new List<StudentAttendanceDetails>
            {
                attendanceObj1,
                attendanceObj2
            };
            return listObj;
        }

    }
}