using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;
using System.Data.SqlClient;

namespace ISERV1
{
    public partial class DoctorsForm : Form
    {
        string conStr = ConfigurationManager.ConnectionStrings["constr"].ConnectionString;
        public DoctorsForm()
        {
            InitializeComponent();
            doctorsdDataGridView.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            doctorsdDataGridView.AllowUserToAddRows = false;
            doctorsdDataGridView.AllowUserToResizeRows = false;
            FillDataGrid();
        }
        private void FillDataGrid()
        {
            using (SqlConnection con = new SqlConnection(conStr))
            {
                SqlDataAdapter adapter = new SqlDataAdapter(GetSql(), conStr);
                DataSet ds = new DataSet();
                adapter.Fill(ds, "Doctors");
                doctorsdDataGridView.DataSource = ds.Tables["Doctors"];
            }
        }
        private string GetSql()
        {
            return "SELECT DoctorId as ID,Firstname as Имя, Lastname as Фамилия, DateOfBirth as 'Дата рождения', Age as Возраст, Specialization as Специализация FROM Doctors ";
        }

        private void addDoctorButton_Click(object sender, EventArgs e)          //обработчик кнопки добавления доктора
        {
            if (firstnameTextBox.Text == String.Empty || lastnameTextBox.Text == String.Empty || specialisationTextBox.Text == String.Empty) //  проверка на пустые поля
            {
                MessageBox.Show("Заполнитее недостающие поля");
            }
            else
            {
                using (SqlConnection con = new SqlConnection(conStr))
                {
                    con.Open();
                    string insertDoctor = $"INSERT dbo.Doctors SELECT '{firstnameTextBox.Text}', '{lastnameTextBox.Text}',CONVERT(date, '{birhdatePicker.Value}'),'{specialisationTextBox.Text}'";
                    SqlCommand insertCommand = new SqlCommand(insertDoctor, con);
                    insertCommand.ExecuteNonQuery();
                    con.Close();
                }
                firstnameTextBox.Text = String.Empty;       //очищение полей после удачного добавления доктора
                lastnameTextBox.Text = String.Empty;
                MessageBox.Show("Доктор добавлен!");
                FillDataGrid();
            }
        }

        private void editDoctorButton_Click(object sender, EventArgs e)
        {
            int editDoctortId = (int)doctorsdDataGridView.CurrentRow.Cells[0].Value;    //получение айди доктора из таблицы
            if (doctorsdDataGridView.SelectedRows.Count == 1)                           //проверка на количество выделенных записей (нужна строго одна)
            {
                if (firstnameTextBox.Text == String.Empty || lastnameTextBox.Text == String.Empty || specialisationTextBox.Text == String.Empty)  //проверка на пустые поля
                {
                    MessageBox.Show("Заполните недостающие поля");
                }
                else
                {
                    using (SqlConnection con = new SqlConnection(conStr))
                    {
                        con.Open();
                        string editClient = $"UPDATE dbo.Doctors " +
                            $"SET Firstname='{firstnameTextBox.Text}', " +
                            $"Lastname='{lastnameTextBox.Text}'," +
                            $"DateOfBirth =CONVERT(date, '{birhdatePicker.Value}')," +
                            $"Specialization='{specialisationTextBox.Text}'" +
                            $"WHERE DoctorId='{editDoctortId}'";
                        SqlCommand editCommand = new SqlCommand(editClient, con);       //команда на изменение данных доктора
                        editCommand.ExecuteNonQuery();
                        con.Close();
                    }
                    firstnameTextBox.Text = String.Empty;           //очищение полей после успешного изменения
                    lastnameTextBox.Text = String.Empty;
                    MessageBox.Show("Данные доктора изменены!");
                    FillDataGrid();
                }
            }
            else
            {
                MessageBox.Show("Выберите ОДНОГО доктора");
            }
        }

        private void deleteDoctorButton_Click(object sender, EventArgs e)   //обработчик кнопки удаления доктора
        {
            int deleteDoctorId = (int)doctorsdDataGridView.CurrentRow.Cells[0].Value;  //получение айди удаляемого доктора из таблицы
            if (doctorsdDataGridView.SelectedRows.Count == 1)                          //проверка на количество выделенных строк в таблице(нужна строго одна)
            {
                using (SqlConnection con = new SqlConnection(conStr))
                {
                    string getDoctorId = $"DELETE FROM dbo.Doctors WHERE DoctorId ='{deleteDoctorId}';";
                    var deleteCommand = new SqlCommand(getDoctorId, con);               //команда на удаление доктора
                    con.Open();
                    deleteCommand.ExecuteScalar();
                    con.Close();
                    MessageBox.Show("Доктор удален!");
                    FillDataGrid();
                }
            }
            else
            {
                MessageBox.Show("Выберите ОДНУ строку");
            }
        }

    }
}
