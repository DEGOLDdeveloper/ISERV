using System.Windows.Forms;
namespace ISERV1
{
    partial class InsertEditForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.isVisitedCheckBox = new System.Windows.Forms.CheckBox();
            this.registrationDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.SaveButton = new System.Windows.Forms.Button();
            this.chooseClientcb = new System.Windows.Forms.ComboBox();
            this.chooseDoctorcb = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Выберите дату";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 77);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(101, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Выберите клиента";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 117);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(101, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Выберите доктора";
            // 
            // Флажок визита клиента
            // 
            this.isVisitedCheckBox.AutoSize = true;
            this.isVisitedCheckBox.Location = new System.Drawing.Point(94, 159);
            this.isVisitedCheckBox.Name = "isVisitedCheckBox";
            this.isVisitedCheckBox.Size = new System.Drawing.Size(100, 17);
            this.isVisitedCheckBox.TabIndex = 8;
            this.isVisitedCheckBox.Text = "Визит клиента";
            this.isVisitedCheckBox.UseVisualStyleBackColor = true;
            // 
            // Выбор даты записи
            // 
            this.registrationDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.registrationDateTimePicker.Location = new System.Drawing.Point(118, 39);
            this.registrationDateTimePicker.Name = "registrationDateTimePicker";
            this.registrationDateTimePicker.Size = new System.Drawing.Size(200, 20);
            this.registrationDateTimePicker.TabIndex = 9;
            // 
            // Кнопка сохранения/изменения
            // 
            this.SaveButton.Location = new System.Drawing.Point(243, 221);
            this.SaveButton.Name = "SaveClickButton";
            this.SaveButton.Size = new System.Drawing.Size(75, 23);
            this.SaveButton.TabIndex = 10;
            this.SaveButton.Text = "Сохранить";
            this.SaveButton.UseVisualStyleBackColor = true;
            this.SaveButton.Click += new System.EventHandler(this.SaveButton_Click);
            // 
            //  Выбор клиента из списка для записи
            // 
            this.chooseClientcb.FormattingEnabled = true;
            this.chooseClientcb.Location = new System.Drawing.Point(118, 77);
            this.chooseClientcb.Name = "chooseClientcb";
            this.chooseClientcb.Size = new System.Drawing.Size(200, 21);
            this.chooseClientcb.TabIndex = 11;
            // 
            // Выбор доктора из списка для записи
            // 
            this.chooseDoctorcb.FormattingEnabled = true;
            this.chooseDoctorcb.Location = new System.Drawing.Point(118, 114);
            this.chooseDoctorcb.Name = "chooseDoctorcb";
            this.chooseDoctorcb.Size = new System.Drawing.Size(200, 21);
            this.chooseDoctorcb.TabIndex = 12;
            // 
            // Форма для добавления/изменения записи
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(440, 280);
            this.Controls.Add(this.chooseDoctorcb);
            this.Controls.Add(this.chooseClientcb);
            this.Controls.Add(this.SaveButton);
            this.Controls.Add(this.registrationDateTimePicker);
            this.Controls.Add(this.isVisitedCheckBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "InsertEditForm";
            this.Text = "Добавление/изменение записи";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.CheckBox isVisitedCheckBox;
        private System.Windows.Forms.DateTimePicker registrationDateTimePicker;
        private System.Windows.Forms.Button SaveButton;
        private System.Windows.Forms.ComboBox chooseClientcb;
        private System.Windows.Forms.ComboBox chooseDoctorcb;
    }
}