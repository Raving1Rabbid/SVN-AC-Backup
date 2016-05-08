using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Data;

namespace Lib
{
    public class ListManager
    {

        #region instances

        
        List<SVNUser> _LocalUsers;
        List<Student> _ExistingStudents;
        List<Student> _StudentsToDelete;
        List<Student> _StudentsToAdd;
        BatchMapper _Mapper;
        int _Class = 0;
        int _Lastname = 1;
        int _Firstname = 2;
        int _Birthday = 3;



        #endregion

        #region propperties

        public List<SVNUser> LocalUsers
        {
            get { return _LocalUsers; }
        }

        public List<Student> ExistingStudents
        {
            get
            {
                return _ExistingStudents;
            }

            set
            {
                _ExistingStudents = value;
            }
        }

        internal List<Student> StudentsToDelete
        {
            get
            {
                return _StudentsToDelete;
            }

            set
            {
                _StudentsToDelete = CreateStudentListToDelete();
            }
        }

        internal List<Student> StudentsToAdd
        {
            get
            {
                return _StudentsToAdd;
            }

            set
            {
                _StudentsToAdd = CreateStudentListToAdd();
            }
        }




        #endregion

        #region constructors

        #endregion

        #region methods

        private List<Student> CreateStudentListToAdd()
        {
            List<Student> studentsToAdd = new List<Student>();

            return studentsToAdd;

        }

        private List<Student> CreateStudentListToDelete()
        {
            List<Student> studentsToDelete = new List<Student>();

            return studentsToDelete;
        }

        private List<Student> EditExistingStudentList()
        {
            try
            {
                for (int i = 0; i < StudentsToAdd.Count; i++)
                {
                    ExistingStudents.Add(StudentsToAdd[i]);
                }
            }
            catch (Exception ex)
            {
                
            }

            try
            {
                for (int i = 0; i < StudentsToDelete.Count; i++)
                {
                    ExistingStudents.Remove(StudentsToDelete[i]);
                }
            }
            catch(Exception ex)
            {
                
            }

            return ExistingStudents;
        }
        /// <summary>
        /// Ruft die Methode GetGetExistingUsers auf, um in die Liste der Existierenden Nutzer alle Lokalen User zu sichern
        /// </summary>
        public void CreateExistingStudentList()
        {
            GetExistingUsers();
        }
        private void GetExistingUsers()
        {
            ReadLocalUsers reader = new ReadLocalUsers();
            _LocalUsers = reader.GetLocalUsers();
        }
        public void Save()
        {
            _Mapper.Save(StudentsToAdd.Cast<object>().ToList());
        }

        public void Load()
        {
            Student student;
            string[] ListOfUsers = new string[4];
            List<string> StudentList = new List<string>();
            StudentList = _Mapper.Load();

            foreach(string item in StudentList)
            {
                ListOfUsers = item.Split(';');
                student = new Student(ListOfUsers[_Class], ListOfUsers[_Lastname], ListOfUsers[_Firstname], DateTime.Parse(ListOfUsers[_Birthday]));
            }
        }

        #endregion
    }
}
