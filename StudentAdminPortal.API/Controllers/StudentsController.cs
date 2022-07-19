using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using StudentAdminPortal.API.DomainModels;
using StudentAdminPortal.API.Repositories;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace StudentAdminPortal.API.Controllers
{
    [ApiController]
    public class StudentsController : Controller
    {
        private readonly IStudentRepository studentRepositoy;
        private readonly IMapper mapper;

        public StudentsController(IStudentRepository studentRepositoy, IMapper mapper)
        {
            this.studentRepositoy = studentRepositoy;
            this.mapper = mapper;
        }
        [HttpGet]
        [Route("[controller]")]
        public async Task<IActionResult> GetAllStudentsAsync()
        {
            var students = await studentRepositoy.GetAllStudentsAsync();

            //var domainModelStudents = new List<Student>();
            //foreach (var student in students)
            //{
            //    domainModelStudents.Add(new Student()
            //    {

            //        Id = student.Id,
            //        FirstName = student.FirstName,
            //        LastName = student.LastName,
            //        DateOfBirth = student.DateOfBirth,
            //        Email = student.Email,
            //        Mobile = student.Mobile,
            //        ProfileImageUrl = student.ProfileImageUrl,
            //        GenderId = student.GenderId,
            //        Gender = new Gender()
            //        {
            //            Description = student.Gender.Description,
            //            Id = student.Gender.Id
            //        },
            //        Address = new Address()
            //        {
            //            Id = student.Address.Id,
            //            PhysicalAddress = student.Address.PhysicalAddress,
            //            PostalAddress = student.Address.PostalAddress
            //        }

            //    });
            //}
            // return Ok(domainModelStudents);
            return Ok(mapper.Map<List<Student>>(students));

        }
    }
}
