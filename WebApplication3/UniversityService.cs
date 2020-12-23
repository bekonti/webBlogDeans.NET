using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;
using WebApplication3.Models;

namespace WebApplication3
{
    public class UniversityService
    {
        private readonly UniversityRepo _universityRepo;
        public UniversityService()
        {
            _universityRepo = new UniversityRepo();
        }

        public List<University> GetUniversities()
        {
            return _universityRepo.GetUniversities();
        }
    }
}