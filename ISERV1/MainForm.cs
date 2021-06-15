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
    public partial class MainForm : Form
    {
        int pageSize = 13;
        int pageNumber = 0;
        string conStr = ConfigurationManager.ConnectionStrings["constr"].ConnectionString;  //строка подключения
        SqlDataAdapter adapter;
        DataSet ds;

        public MainForm()
        {
            InitializeComponent();
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToResizeRows = false;
            FillDataGrid();
        }
        private void FillDataGrid()   //Метож заполнения таблицы записей из БД, он же метод, применяющийся для обновления таблиц в приложении
        {
            using (SqlConnection con = new SqlConnection(conStr))
            {
                adapter = new SqlDataAdapter(GetSql(), conStr);
                ds = new DataSet();
                adapter.Fill(ds, "Registrations");
                dataGridView1.DataSource = ds.Tables["Registrations"];

            }
        }
        // обработчик кнопки Назад для постраничной навигации
        private void backButton_Click(object sender, EventArgs e)
        {
            if (pageNumber == 0) return;
            pageNumber--;
            using (SqlConnection connection = new SqlConnection(conStr))
            {
                adapter = new SqlDataAdapter(GetSql(), connection);
                ds.Tables["Registrations"].Rows.Clear();
                adapter.Fill(ds, "Registrations");
            }
        }
        // обработчик кнопки Вперед для постраничной навигации
        private void nextButton_Click(object sender, EventArgs e)
        {
            if (ds.Tables["Registrations"].Rows.Count < pageSize) return;
            pageNumber++;
            using (SqlConnection connection = new SqlConnection(conStr))
            {
                adapter = new SqlDataAdapter(GetSql(), connection);
                ds.Tables["Registrations"].Rows.Clear();
                adapter.Fill(ds, "Registrations");
            }
        }
        private string GetSql()   //метод, возвращающий строку sql запроса для реализации постраничной навигации
        {
            return "SELECT idOfRegistration as ID,dateOfRegistration as 'Дата записи', Doctors.Fullname as Доктор, Clients.Fullname as Клиент, isVisited as Визит " +
                "FROM Registrations " +
                "JOIN Doctors ON Doctors.DoctorId = Registrations.DoctorId " +
                "JOIN Clients ON Clients.ClientId = Registrations.ClientId " +
                "ORDER BY dateOfRegistration " +
                "OFFSET ((" + pageNumber + ") * " + pageSize + ") " +
                "ROWS FETCH NEXT " + pageSize + "ROWS ONLY";
        }

        private void insertButton_Click(object sender, EventArgs e)   //открытие формы для добавления записи
        {
            InsertEditForm insertform = new InsertEditForm();
            insertform.ShowDialog();
            FillDataGrid();
        }

        private void editButton_Click(object sender, EventArgs e)  //открытие формы для изменения записи. В конструктор формы также передается выделенная в данный момент строка
        {
            if (dataGridView1.SelectedRows.Count==1)
            {
                DataGridViewRow data = dataGridView1.CurrentRow;
                InsertEditForm editForm = new InsertEditForm(data);
                editForm.ShowDialog();
                FillDataGrid();
            }
            else
            {
                MessageBox.Show("Выберите ОДНУ строку");
            }
        }

        private void deleteButton_Click(object sender, EventArgs e)  //удаление выбранной записи из таблицы
        {
            if (dataGridView1.SelectedRows.Count == 1)
            {
                using (SqlConnection con = new SqlConnection(conStr))
                {
                    string getClientId = 
                        $"DELETE FROM dbo.Registrations " +
                        $"WHERE idOfRegistration ='{dataGridView1.CurrentRow.Cells[0].Value}';";
                    var deleteCommand = new SqlCommand(getClientId, con);
                    con.Open();
                    deleteCommand.ExecuteScalar();
                    con.Close();
                    MessageBox.Show("Запись удалена!");
                    FillDataGrid();
                }
            }
            else
            {
                MessageBox.Show("Выберите ОДНУ строку");
            }
        }

        private void openDoctorsForm_Click(object sender, EventArgs e)  //открытие формы докторов
        {
            DoctorsForm df = new DoctorsForm();
            df.ShowDialog();
        }

        private void openClientsForm_Click(object sender, EventArgs e)  //открытие формы клиентов
        {
            ClientsForm cf = new ClientsForm();
            cf.ShowDialog();
        }
    }
}
