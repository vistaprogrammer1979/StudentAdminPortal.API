﻿using Microsoft.EntityFrameworkCore;
using StudentAdminPortal.API.DataModels;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StudentAdminPortal.API.Repositories
{
    public class SqlStudentRepository : IStudentRepository
    {
        private readonly StudentAdminContext _context;
        public SqlStudentRepository(StudentAdminContext context)
        {
           this._context = context;

        }
        public async Task<List<Student>> GetAllStudentsAsync()
        {
            return await _context.Student.Include(nameof(Gender)).Include(nameof(Address)).ToListAsync();
        }
    }
}
