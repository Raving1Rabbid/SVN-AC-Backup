using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Lib;


namespace UI
{
    public partial class frSVNACTeam40f5 : Form
    {
        public frSVNACTeam40f5()
        {
            InitializeComponent();
            _Lists.CreateExistingStudentList();
            ShowExistingStudents();
        }

        ListManager _Lists = new ListManager();
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Sind Sie sicher, dass Sie diese Elemente unwiderruflich entfernen wollen?", "Warnung!", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                //CallDeleteMethod
            }
            else if (dialogResult == DialogResult.No)
            {
                
            }
        }

        /// <summary>
        /// zeigt alle Benutzer aus der Liste ListManager._LocalUsers an
        /// </summary>
        private void ShowExistingStudents()
        {
            foreach(SVNUser user in _Lists.LocalUsers)
            {
                if(user.Name!=null)
                lbxLocalUsers.Items.Add(user.Name);
            }
                    
        }

        private void btnshow_Click(object sender, EventArgs e)
        {

            _Lists.Load();
            DisplayUsers();
        }

        private void DisplayUsers()
        {
            lbxSchueler.Items.Clear();

            foreach (Student item in _Lists.ExistingStudents)
            {
                if (item != null)
                {
                    lbxSchueler.Items.Add(item.GetExportLine());
                }
            }
        }


        private void btnshow_DragDrop(object sender, DragEventArgs e)
        {
            string[] fileList = e.Data.GetData(DataFormats.FileDrop) as string[];
            MessageBox.Show(fileList[0]);
        }

        private void btnshow_DragLeave(object sender, EventArgs e)
        {
            
        }

        private void btnshow_DragEnter(object sender, DragEventArgs e)
        {
            string[] fileList = e.Data.GetData(DataFormats.FileDrop) as string[];
            MessageBox.Show(fileList[0]);
        }

        private void pbxGrapeplus_DragEnter(object sender, DragEventArgs e)
        {
            string[] fileList = e.Data.GetData(DataFormats.FileDrop) as string[];
            MessageBox.Show(fileList[0]);
        }

        private void pbxGrapeplus_DragDrop(object sender, DragEventArgs e)
        {
            string[] fileList = e.Data.GetData(DataFormats.FileDrop) as string[];
            MessageBox.Show(fileList[0]);
        }

        private void pnlDragAndDrop_DragDrop(object sender, DragEventArgs e)
        {
            string[] fileList = e.Data.GetData(DataFormats.FileDrop) as string[];
            MessageBox.Show(fileList[0]);
        }

        private void pnlDragAndDrop_DragEnter(object sender, DragEventArgs e)
        {
            string[] fileList = e.Data.GetData(DataFormats.FileDrop) as string[];
            MessageBox.Show(fileList[0]);
        }
    }
}
