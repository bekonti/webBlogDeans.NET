using WebApplication3.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;

namespace WebApplication3
{
    public class UniversityRepo
    {
        private static List<University> _universities;

        public UniversityRepo()
        {
            _universities = new List<University> { new University { Id = 1, Name = "IITU", Founded = "2009", Address = "Almaty, Manas st. 36a" } };
        }
        public  List<University> GetUniversities()
        {
            return _universities;
        }

        public University GetUniversity(int id)
        {
            return _universities.FirstOrDefault(f => f.Id == id);  
        }

    }
}