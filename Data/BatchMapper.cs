using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Data
{
    public class BatchMapper
    {
        #region Instanzes

        string _Filename;

        #endregion

        #region Get/Set

        public string Filename
        {
            get
            {
                return _Filename;
            }

            set
            {
                _Filename = value;
            }
        }

        #endregion

        #region Constructor

        public BatchMapper(string file)
        {
            _Filename = file;
        }

        #endregion

        #region Methods

        public void Save(List<object> UserList)
        {
            StreamWriter sw = null;

            try
            {
                sw = new StreamWriter(Filename);

                foreach (object User in UserList)
                {
                    sw.WriteLine(User.ToString() + ".bat");
                }
            }

            catch (Exception)
            {
                //Fehler
            }

            finally
            {
                if (sw != null)
                {
                    sw.Close();
                }
            }

        }

        public List<string> Load()
        {
            List<string> List = new List<string>();
            StreamReader sr = null;

            try
            {
                sr = new StreamReader("Schueler_ganze_Schule.csv");

                while (!sr.EndOfStream)
                {
                    List.Add(sr.ReadLine());
                }
            }

            catch(Exception)
            {
                //KA
            }

            finally
            {
                sr.Close();
            }
            return List;
        }

        #endregion
    }
}
