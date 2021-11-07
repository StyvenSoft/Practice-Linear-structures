using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Fase3HugoEcheverri.World.Lists;

namespace Fase3HugoEcheverri.Interface
{
    public partial class ScreenFormList : Form
    {
        List<World.Lists.Student> listsStudent = new List<World.Lists.Student>();

        public ScreenFormList()
        {
            InitializeComponent();
            btnSearch.Enabled = false;
            btnDelete.Enabled = false;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            int idStudent = Convert.ToInt32(txtIdStudent.Text);
            String nameStudent = txtNameStudent.Text;
            int age = Convert.ToInt32(txtAge.Text);
            int stratum = Convert.ToInt32(cmbStratum.Text);
            String programAcademic = cmbProgramAcademic.Text;
            String nameUniversity = cmbNameUniversity.Text;
            String dateRegister = dtpDateRegister.Text;

            World.Lists.Student theStudent = new World.Lists.Student(
                    idStudent,
                    nameStudent,
                    age,
                    stratum,
                    programAcademic,
                    nameUniversity,
                    dateRegister
                );
            listsStudent.Add(theStudent);
            dgvStudents.DataSource = null;
            dgvStudents.DataSource = listsStudent.ToArray();
            cleanControls();
            btnSearch.Enabled = true;
        }

        private void cleanControls()
        {
            txtIdStudent.Clear();
            txtNameStudent.Clear();
            txtAge.Clear();
            cmbStratum.ResetText();
            cmbProgramAcademic.ResetText();
            cmbNameUniversity.ResetText();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            if (txtIdStudent.Text != "")
            {
                int searchStudent = Convert.ToInt32(txtIdStudent.Text);
                World.Lists.Student itemStudent = getStudent(searchStudent);

                if (itemStudent != null)
                {
                    txtNameStudent.Text = itemStudent.NameStudent;
                    txtAge.Text = Convert.ToString(itemStudent.Age);
                    cmbStratum.Text = Convert.ToString(itemStudent.Stratum);
                    cmbProgramAcademic.Text = itemStudent.ProgramAcademic;
                    cmbNameUniversity.Text = itemStudent.NameUniversity;
                    dtpDateRegister.Text = itemStudent.DateRegister;
                    btnDelete.Enabled = true;
                    MessageBox.Show("Estudiante registrado!", "Atención");
                }
                else
                {
                    MessageBox.Show("No se encontro el registro!", "Atención");
                }
            }
            else
            {
                MessageBox.Show("Debe ingresar una Identificación Estudiante!", "Advertencia");
            }
        }

        private Student getStudent(int idstudent)
        {
            return listsStudent.Find(student => student.IdStudent.Equals(idstudent));
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (txtIdStudent.Text != "")
            {
                if (MessageBox.Show("Desea eliminar el registro ingresado? " + txtIdStudent.Text, "Atención",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                {
                    int position = Convert.ToInt32(txtIdStudent.Text);
                    foreach (World.Lists.Student itemStudent in listsStudent)
                    {
                        if (itemStudent.IdStudent == position)
                        {
                            listsStudent.Remove(itemStudent);
                            MessageBox.Show("Se elimino el registro!", "Atención");
                            cleanControls();
                            break;
                        }
                        else
                        {
                            MessageBox.Show("No se encontro el registro!", "Atención");
                        }
                    }
                    dgvStudents.DataSource = listsStudent.ToArray();
                }
            }
            else
            {
                MessageBox.Show("Debe ingresar una Identificación Estudiante!", "Advertencia");
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            ScreenOptions optionsScreen = new ScreenOptions();
            optionsScreen.Show();
            Hide();
        }
    }
}
