using StudentsProject.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StudentsProject.Views
{
    public partial class SpecialtiesForm : Form
    {
        public event Action RefreshData;
        public event Action<Specialty> ChangeData;
        
        public SpecialtiesForm()
        {
            InitializeComponent();
        }

        public void ShowData(List<Specialty> data)
        {
            specialtiesView.DataSource = data;
        }

        private void refreshButton_Click(object sender, EventArgs e)
        {
            RefreshData();
            Button senderB = (Button)sender;
            senderB.Text = "opappapa";
            senderB.Width = 400;
            Object senderO = (Object)senderB;
            Object obj = new Object();
            senderB.Text = obj.ToString();
        }

        private void changeButton_Click(
            object sender, 
            EventArgs e
        )
        {
            var spec = specialtiesView
                .SelectedRows[0]
                .DataBoundItem as Specialty;

            if (spec != null)
            ChangeData(spec);
        }
    }
}
