using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

using StudentsProject.Models;

namespace StudentsProject.Services
{
    public class GroupsProvider
    {
        private SqlConnection _connection;

        public GroupsProvider(SqlConnection connection)
        {
            _connection = connection;
        }

        public List<StudentsGroup> GetAll()
        {
            return new List<StudentsGroup>();
        }

        public bool Add(StudentsGroup data)
        {
            return true;
        }

        public bool Update(int id, StudentsGroup data)
        {
            return true;
        }

        public bool Delete(int id)
        {
            return true;
        }
    }
}
