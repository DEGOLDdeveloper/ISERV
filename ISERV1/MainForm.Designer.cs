
namespace ISERV1
{
    partial class MainForm
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.backButton = new System.Windows.Forms.Button();
            this.nextButton = new System.Windows.Forms.Button();
            this.insertButton = new System.Windows.Forms.Button();
            this.editButton = new System.Windows.Forms.Button();
            this.deleteButton = new System.Windows.Forms.Button();
            this.openDoctorsForm = new System.Windows.Forms.Button();
            this.openClientsForm = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // Таблица записей
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(26, 28);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(563, 332);
            this.dataGridView1.TabIndex = 0;

            // 
            // кнопка "назад" для постраничной навигации
            // 
            this.backButton.Location = new System.Drawing.Point(26, 366);
            this.backButton.Name = "button1";
            this.backButton.Size = new System.Drawing.Size(75, 23);
            this.backButton.TabIndex = 1;
            this.backButton.Text = "Назад";
            this.backButton.UseVisualStyleBackColor = true;
            this.backButton.Click += new System.EventHandler(this.backButton_Click);
            // 
            // кнопка "вперед" для постраничной навигации
            // 
            this.nextButton.Location = new System.Drawing.Point(514, 366);
            this.nextButton.Name = "nextButton";
            this.nextButton.Size = new System.Drawing.Size(75, 23);
            this.nextButton.TabIndex = 2;
            this.nextButton.Text = "Вперед";
            this.nextButton.UseVisualStyleBackColor = true;
            this.nextButton.Click += new System.EventHandler(this.nextButton_Click);
            // 
            // кнопка добавления записи
            // 
            this.insertButton.Location = new System.Drawing.Point(628, 28);
            this.insertButton.Name = "insertButton";
            this.insertButton.Size = new System.Drawing.Size(151, 50);
            this.insertButton.TabIndex = 3;
            this.insertButton.Text = "Добавить запись";
            this.insertButton.UseVisualStyleBackColor = true;
            this.insertButton.Click += new System.EventHandler(this.insertButton_Click);
            // 
            // кнопка редактирования записи
            // 
            this.editButton.Location = new System.Drawing.Point(628, 84);
            this.editButton.Name = "editButton";
            this.editButton.Size = new System.Drawing.Size(151, 50);
            this.editButton.TabIndex = 4;
            this.editButton.Text = "Редактировать запись";
            this.editButton.UseVisualStyleBackColor = true;
            this.editButton.Click += new System.EventHandler(this.editButton_Click);
            // 
            // кнопка удаления записи
            // 
            this.deleteButton.Location = new System.Drawing.Point(628, 140);
            this.deleteButton.Name = "deleteButton";
            this.deleteButton.Size = new System.Drawing.Size(151, 50);
            this.deleteButton.TabIndex = 5;
            this.deleteButton.Text = "Удалить запись";
            this.deleteButton.UseVisualStyleBackColor = true;
            this.deleteButton.Click += new System.EventHandler(this.deleteButton_Click);
            // 
            //  Кнопка, открывающая форму докторов
            // 
            this.openDoctorsForm.Location = new System.Drawing.Point(628, 310);
            this.openDoctorsForm.Name = "openDoctorsForm";
            this.openDoctorsForm.Size = new System.Drawing.Size(151, 50);
            this.openDoctorsForm.TabIndex = 6;
            this.openDoctorsForm.Text = "Доктора";
            this.openDoctorsForm.UseVisualStyleBackColor = true;
            this.openDoctorsForm.Click += new System.EventHandler(this.openDoctorsForm_Click);
            // 
            // Кнопка, открывающая форму клиентов
            // 
            this.openClientsForm.Location = new System.Drawing.Point(628, 376);
            this.openClientsForm.Name = "openClientsForm";
            this.openClientsForm.Size = new System.Drawing.Size(151, 50);
            this.openClientsForm.TabIndex = 7;
            this.openClientsForm.Text = "Клиенты";
            this.openClientsForm.UseVisualStyleBackColor = true;
            this.openClientsForm.Click += new System.EventHandler(this.openClientsForm_Click);
            // 
            // MainFrom
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(806, 450);
            this.Controls.Add(this.openClientsForm);
            this.Controls.Add(this.openDoctorsForm);
            this.Controls.Add(this.deleteButton);
            this.Controls.Add(this.editButton);
            this.Controls.Add(this.insertButton);
            this.Controls.Add(this.nextButton);
            this.Controls.Add(this.backButton);
            this.Controls.Add(this.dataGridView1);
            this.Name = "MainFrom";
            this.Text = "Сервис записи к врачу";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button backButton;
        private System.Windows.Forms.Button nextButton;
        private System.Windows.Forms.Button insertButton;
        private System.Windows.Forms.Button editButton;
        private System.Windows.Forms.Button deleteButton;
        private System.Windows.Forms.Button openDoctorsForm;
        private System.Windows.Forms.Button openClientsForm;
    }
}

