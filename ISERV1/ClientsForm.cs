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
    public partial class ClientsForm : Form
    {
        string conStr = ConfigurationManager.ConnectionStrings["constr"].ConnectionString;        
        public ClientsForm()
        {
            InitializeComponent();
            clientsdDataGridView.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            clientsdDataGridView.AllowUserToAddRows = false;
            clientsdDataGridView.AllowUserToResizeRows = false;
            FillDataGrid();
        }
        private void FillDataGrid()
        {
            using (SqlConnection con = new SqlConnection(conStr))
            {
                SqlDataAdapter adapter = new SqlDataAdapter(GetSql(), conStr);
                DataSet ds = new DataSet();
                adapter.Fill(ds, "Clients");
                clientsdDataGridView.DataSource = ds.Tables["Clients"];
            }
        }
        private string GetSql()
        {
            return "SELECT ClientId as ID, Firstname as Имя, Lastname as Фамилия, DateOfBirth as 'Дата рождения', Age as Возраст  FROM Clients ";
        }

        private void addClientButton_Click(object sender, EventArgs e)              //обработчик кнопки добавления клиента
        {
            if (firstnameTextBox.Text== String.Empty || lastnameTextBox.Text== String.Empty)    // проверка на пустые поля
            {
                MessageBox.Show("Заполните недостающие поля");
            }
            else
            {
                using (SqlConnection con = new SqlConnection(conStr))
                {
                    con.Open();
                    string insertClient = $"INSERT dbo.Clients SELECT '{firstnameTextBox.Text}', '{lastnameTextBox.Text}',CONVERT(date, '{birhdatePicker.Value}')";
                    SqlCommand insertCommand = new SqlCommand(insertClient, con);
                    insertCommand.ExecuteNonQuery();
                    con.Close();
                }
                firstnameTextBox.Text = String.Empty;     //очищение полей после удачного добавления клиента
                lastnameTextBox.Text = String.Empty;
                MessageBox.Show("Клиент добавлен!");
                FillDataGrid();
            }
        }

        private void editClientButton_Click(object sender, EventArgs e)
        {
            int editClientId = (int)clientsdDataGridView.CurrentRow.Cells[0].Value;         //получение айди клиента из таблицы
            if (clientsdDataGridView.SelectedRows.Count == 1)                               //проверка на количество выделенных записей (нужна строго одна)
            {
                if (firstnameTextBox.Text == String.Empty || lastnameTextBox.Text == String.Empty)              //проверка на пустые поля
                {
                    MessageBox.Show("Заполните недостающие поля");
                }
                else
                {
                    using (SqlConnection con = new SqlConnection(conStr))
                    {
                        con.Open();
                        string editClient = $"UPDATE dbo.Clients " +
                            $"SET Firstname='{firstnameTextBox.Text}', " +
                            $"Lastname='{lastnameTextBox.Text}'," +
                            $"DateOfBirth =CONVERT(date, '{birhdatePicker.Value}') " +
                            $"WHERE ClientId='{editClientId}'";
                        SqlCommand editCommand = new SqlCommand(editClient, con);           //команда на изменение данных клиента
                        editCommand.ExecuteNonQuery();
                        con.Close();
                    }
                    firstnameTextBox.Text = String.Empty;                   //очищение полей после успешного изменения
                    lastnameTextBox.Text = String.Empty;
                    MessageBox.Show("Данные клиента изменены!");
                    FillDataGrid();
                }
            }
            else
            {
                MessageBox.Show("Выберите ОДНОГО клиента");
            }
        }

        private void deleteClientButton_Click(object sender, EventArgs e)           //обработчик кнопки удаления клиента
        {
            int deleteClientId = (int)clientsdDataGridView.CurrentRow.Cells[0].Value;        //получение айди удаляемого клиента из таблицы
            if (clientsdDataGridView.SelectedRows.Count == 1)                                //проверка на количество выделенных строк в таблице(нужна строго одна)
            {
                using (SqlConnection con = new SqlConnection(conStr))
                {
                    string getClientId = $"DELETE FROM dbo.Clients WHERE ClientId ='{deleteClientId}';";
                    var deleteCommand = new SqlCommand(getClientId, con);                   //команда на удаление клиента
                    con.Open();
                    deleteCommand.ExecuteScalar();
                    con.Close();
                }
                FillDataGrid();
            }
            else
            {
                MessageBox.Show("Выберите ОДНУ строку");
            }
        }
    }
}
