
namespace ISERV1
{
    partial class DoctorsForm
    {

            /// <summary>
            /// Required designer variable.
            /// </summary>
            private System.ComponentModel.IContainer components = null;

            /// <summary>
            /// Clean up any resources being used.
            /// </summary>
            /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
            protected override void Dispose(bool disposing)
            {
                if (disposing && (components != null))
                {
                    components.Dispose();
                }
                base.Dispose(disposing);
            }

            #region Windows Form Designer generated code

            /// <summary>
            /// Required method for Designer support - do not modify
            /// the contents of this method with the code editor.
            /// </summary>
            private void InitializeComponent()
            {
            this.doctorsdDataGridView = new System.Windows.Forms.DataGridView();
            this.birhdatePicker = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.firstnameTextBox = new System.Windows.Forms.TextBox();
            this.lastnameTextBox = new System.Windows.Forms.TextBox();
            this.addDoctorButton = new System.Windows.Forms.Button();
            this.editDoctorButton = new System.Windows.Forms.Button();
            this.deleteDoctorButton = new System.Windows.Forms.Button();
            this.specialisationTextBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.doctorsdDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // Таблица докторов
            // 
            this.doctorsdDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.doctorsdDataGridView.Location = new System.Drawing.Point(35, 12);
            this.doctorsdDataGridView.Name = "doctorsdDataGridView";
            this.doctorsdDataGridView.Size = new System.Drawing.Size(668, 150);
            this.doctorsdDataGridView.TabIndex = 0;
            // 
            // Выбор даты рождения
            // 
            this.birhdatePicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.birhdatePicker.Location = new System.Drawing.Point(166, 300);
            this.birhdatePicker.Name = "birhdatePicker";
            this.birhdatePicker.Size = new System.Drawing.Size(200, 20);
            this.birhdatePicker.TabIndex = 17;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(54, 219);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(29, 13);
            this.label3.TabIndex = 15;
            this.label3.Text = "Имя";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(54, 179);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 13);
            this.label2.TabIndex = 14;
            this.label2.Text = "Фамилия";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(54, 300);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 13);
            this.label1.TabIndex = 13;
            this.label1.Text = "Дата рождения";
            // 
            // Ввод имени доктора
            // 
            this.firstnameTextBox.Location = new System.Drawing.Point(166, 179);
            this.firstnameTextBox.Name = "firstnameTextBox";
            this.firstnameTextBox.Size = new System.Drawing.Size(200, 20);
            this.firstnameTextBox.TabIndex = 20;
            // 
            // Ввод фамилии доктора
            // 
            this.lastnameTextBox.Location = new System.Drawing.Point(166, 219);
            this.lastnameTextBox.Name = "lastnameTextBox";
            this.lastnameTextBox.Size = new System.Drawing.Size(200, 20);
            this.lastnameTextBox.TabIndex = 21;
            // 
            // Кнопка добавления доктора
            // 
            this.addDoctorButton.Location = new System.Drawing.Point(56, 336);
            this.addDoctorButton.Name = "addDoctorButton";
            this.addDoctorButton.Size = new System.Drawing.Size(75, 23);
            this.addDoctorButton.TabIndex = 22;
            this.addDoctorButton.Text = "Добавить";
            this.addDoctorButton.UseVisualStyleBackColor = true;
            this.addDoctorButton.Click += new System.EventHandler(this.addDoctorButton_Click);
            // 
            // Кнопка изменения данных доктора
            // 
            this.editDoctorButton.Location = new System.Drawing.Point(154, 336);
            this.editDoctorButton.Name = "editDoctorButton";
            this.editDoctorButton.Size = new System.Drawing.Size(75, 23);
            this.editDoctorButton.TabIndex = 23;
            this.editDoctorButton.Text = "Изменить";
            this.editDoctorButton.UseVisualStyleBackColor = true;
            this.editDoctorButton.Click += new System.EventHandler(this.editDoctorButton_Click);
            // 
            // Кнопка удаления доктора
            // 
            this.deleteDoctorButton.Location = new System.Drawing.Point(412, 174);
            this.deleteDoctorButton.Name = "deleteDoctorButton";
            this.deleteDoctorButton.Size = new System.Drawing.Size(75, 23);
            this.deleteDoctorButton.TabIndex = 24;
            this.deleteDoctorButton.Text = "Удалить";
            this.deleteDoctorButton.UseVisualStyleBackColor = true;
            this.deleteDoctorButton.Click += new System.EventHandler(this.deleteDoctorButton_Click);
            // 
            // specialisationTextBox
            // 
            this.specialisationTextBox.Location = new System.Drawing.Point(166, 258);
            this.specialisationTextBox.Name = "specialisationTextBox";
            this.specialisationTextBox.Size = new System.Drawing.Size(200, 20);
            this.specialisationTextBox.TabIndex = 26;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(54, 258);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(86, 13);
            this.label4.TabIndex = 25;
            this.label4.Text = "Специализация";
            // 
            // DoctorsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(744, 394);
            this.Controls.Add(this.specialisationTextBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.deleteDoctorButton);
            this.Controls.Add(this.editDoctorButton);
            this.Controls.Add(this.addDoctorButton);
            this.Controls.Add(this.lastnameTextBox);
            this.Controls.Add(this.firstnameTextBox);
            this.Controls.Add(this.birhdatePicker);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.doctorsdDataGridView);
            this.Name = "DoctorsForm";
            this.Text = "Доктора";
            ((System.ComponentModel.ISupportInitialize)(this.doctorsdDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

            }

            #endregion

            private System.Windows.Forms.DataGridView doctorsdDataGridView;
            private System.Windows.Forms.DateTimePicker birhdatePicker;
            private System.Windows.Forms.Label label4;
            private System.Windows.Forms.Label label3;
            private System.Windows.Forms.Label label2;
            private System.Windows.Forms.Label label1;
            private System.Windows.Forms.TextBox firstnameTextBox;
            private System.Windows.Forms.TextBox lastnameTextBox;
            private System.Windows.Forms.Button addDoctorButton;
            private System.Windows.Forms.Button editDoctorButton;
            private System.Windows.Forms.Button deleteDoctorButton;
            private System.Windows.Forms.TextBox specialisationTextBox;    
            }
    }