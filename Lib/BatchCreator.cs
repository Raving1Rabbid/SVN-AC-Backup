using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Lib
{
    public class CreateBatch
    {
        ListManager _Manager;
        public CreateBatch(ListManager lm)
        {
            _Manager = lm;
        }

        /// <summary>
        /// Adds a User
        /// </summary>
        public void Create()
        {
            for (int i = 0; i < _Manager.StudentsToAdd.Count; i++)
            {
                string Dudse = "net user" + _Manager.StudentsToAdd[i].LastName + _Manager.StudentsToAdd[i].FirstName[0] + "nrt /fullname:\"" + _Manager.StudentsToAdd[i].FirstName + " " + _Manager.StudentsToAdd[i].LastName + "\" /passwordchg:no /add";
                StreamWriter sw = new StreamWriter("test.bat");
                sw.WriteLine("@ECHO Creating a new user");
                sw.WriteLine(Dudse);
                sw.WriteLine("@PAUSE");
                sw.Flush();
                sw.Close();
            }
        }

        public void Delete()
        {
            string query = "";
            StreamWriter sw = new StreamWriter("thatest.bat");
            sw.WriteLine(query);
            sw.WriteLine("@pause");
            sw.Close();
        }

        /// <summary>
        /// Adds A List Of Students
        /// </summary>
        /// <param name="ListOfStudents"></param>
        public void DeleteUser(List<Student> ListOfStudents)
        {
            for (int i = 0; i < ListOfStudents.Count; i++)
            {
                StreamWriter sw = new StreamWriter("test.bat");
                sw.WriteLine("NET USER {0}/DEL", ListOfStudents[i]);
                sw.Flush();
                sw.Close();
            }
        }

        /// <summary>
        /// Deletes A List Of Students
        /// </summary>
        /// <param name="ListOfStudents"></param>
        public void AddGroup(List<Student> ListOfStudents)
        {
            for (int i = 0; i < ListOfStudents.Count; i++)
            {
                StreamWriter sw = new StreamWriter("test.bat");
                sw.WriteLine("NET USER {0}/ADD", ListOfStudents[i]);
                sw.Flush();
                sw.Close();
            }
        }
    }
}
