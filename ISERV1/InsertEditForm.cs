using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ISERV1
{
    public partial class InsertEditForm : Form
    {
        string conStr = ConfigurationManager.ConnectionStrings["constr"].ConnectionString;
        bool isEdit;   // если форма открыта для редактирования данных, то в соответствующем конструкторе переменной присваивается true
        int idEditRegistration;


        public InsertEditForm()                                     //конструктор, вызываемый для добавления данных
        {
            InitializeComponent();
            InitializeFormFields();
        }
        public InsertEditForm(DataGridViewRow r)                    //конструктор, вызываемый для изменения данных
        {
            isEdit = true;                        
            InitializeComponent();
            InitializeFormFields();
            idEditRegistration = (int)r.Cells[0].Value;
            registrationDateTimePicker.Value = (DateTime)r.Cells[1].Value;
            chooseClientcb.Text = (string)r.Cells[3].Value;
            chooseDoctorcb.Text = (string)r.Cells[2].Value;
        }
        private void SaveButton_Click(object sender, EventArgs e)
        {
            using (SqlConnection con = new SqlConnection(conStr))
            {
                if (isEdit==true)                                       //проверка, чтобы обработчик кнопки выполнил правильное действие(добавление/изменение)
            {                                                           // в данной ситуации выполняется изменение данных
                    con.Open();
                    string getClientId =                                //получаем айди клиента по его полному имени
                        $"SELECT ClientId " +
                        $"FROM dbo.Clients " +
                        $"WHERE Fullname ='{chooseClientcb.Text}';";
                    var getClientIdCommand = new SqlCommand(getClientId, con);
                    int clientId = (int)getClientIdCommand.ExecuteScalar();
                    string getDoctorId =                                   //получаем айди доктора по его полному имени
                        $"SELECT DoctorId " +
                        $"FROM dbo.Doctors " +
                        $"WHERE Fullname ='{chooseDoctorcb.Text}';";
                    var getDoctorIdCommand = new SqlCommand(getDoctorId, con);
                    int doctorId = (int)getDoctorIdCommand.ExecuteScalar();
                    SqlCommand editCommand = new SqlCommand(                //команда на изменение записи
                        $"UPDATE dbo.Registrations " +
                        $"SET dateOfRegistration ='{registrationDateTimePicker.Value}'," +
                        $"ClientId='{clientId}', " +
                        $"DoctorId='{doctorId}', " +
                        $"isVisited='{isVisitedCheckBox.Checked}' " +
                        $"WHERE idOfRegistration='{idEditRegistration}'", con);
                    editCommand.ExecuteNonQuery();
                    con.Close();
                    this.Close();
            }
            else                                                        //в этом случае обработчик выполняет добавление записи
            {
                    con.Open();
                    string getClientId =                                //получаем айди клиента по его полному имени
                        $"SELECT ClientId " +
                        $"FROM dbo.Clients " +
                        $"WHERE Fullname ='{chooseClientcb.Text}';";
                    var getClientIdCommand = new SqlCommand(getClientId, con);
                    int clientId = (int)getClientIdCommand.ExecuteScalar();
                    string getDoctorId =                                   //получаем айди доктора по его полному имени
                        $"SELECT DoctorId " +
                        $"FROM dbo.Doctors " +
                        $"WHERE Fullname ='{chooseDoctorcb.Text}';";
                    var getDoctorIdCommand = new SqlCommand(getDoctorId, con);
                    int doctorId = (int)getDoctorIdCommand.ExecuteScalar();
                    SqlCommand insertCommand = new SqlCommand(              //команда на добавление записи в таблицу
                        $"INSERT dbo.Registrations " +
                        $"SELECT '{registrationDateTimePicker.Value}', '{clientId}', '{doctorId}', '{isVisitedCheckBox.Checked}'", con);
                    insertCommand.ExecuteNonQuery();
                    con.Close();
                }
                this.Close();
            }
        }
        private void InitializeFormFields()                 //метод заполнения выпадающих списков на форме - списков клиентов и докторов
        {
            using (SqlConnection con = new SqlConnection(conStr))
            {
                var adapter = new SqlDataAdapter("SELECT * FROM dbo.Clients;", con);
                var dt = new DataTable();
                adapter.Fill(dt);
                chooseClientcb.DataSource = dt;
                chooseClientcb.DisplayMember = "FullName";
                var adaapter = new SqlDataAdapter("SELECT * FROM dbo.Doctors;", con);
                var dta = new DataTable();
                adaapter.Fill(dta);
                chooseDoctorcb.DataSource = dta;
                chooseDoctorcb.DisplayMember = "FullName";
            }
        }
    }
}
