using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

using StudentsProject.Models;

namespace StudentsProject.Services
{
    public class StudentsProvider
    {
        private SqlConnection _connection;

        public StudentsProvider(SqlConnection connection)
        {
            _connection = connection;
        }

        public List<Student> GetAll()
        {
            return new List<Student>();
        }

        public bool Add(Student data)
        {
            return true;
        }

        public bool Update(int id, Student data)
        {
            return true;
        }

        public bool Delete(int id)
        {
            return true;
        }
    }
}
