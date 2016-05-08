using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lib
{
    public class Student
    {

        #region instances

        string _FirstName;
        string _LastName;
        string _Class;
        DateTime _Birthdate;

        #endregion

        #region propperties

        public string FirstName
        {
            get
            {
                return _FirstName;
            }

            set
            {
                _FirstName = value;
            }
        }

        public string LastName
        {
            get
            {
                return _LastName;
            }

            set
            {
                _LastName = value;
            }
        }

        public string Class
        {
            get
            {
                return _Class;
            }

            set
            {
                _Class = value;
            }
        }

        public DateTime Birthdate
        {
            get
            {
                return _Birthdate;
            }

            set
            {
                _Birthdate = value;
            }
        }

        #endregion

        #region Constructors

        public Student(string firstname, string lastname, string schoolclass, DateTime birthdate)
        {
            _FirstName = firstname;
            _LastName = lastname;
            _Class = schoolclass;
            _Birthdate = birthdate;
        }

        #endregion

        public string GetExportLine()
        {
            return _Class + " " + _LastName + " " + _FirstName + " " + _Birthdate.ToString();
        }
    }
}
