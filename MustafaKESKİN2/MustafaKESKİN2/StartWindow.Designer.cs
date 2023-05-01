namespace MustafaKESKİN2
{
    partial class StartWindow
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
            this.btnLaboratory = new System.Windows.Forms.Button();
            this.btnProject = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnLaboratory
            // 
            this.btnLaboratory.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnLaboratory.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnLaboratory.Location = new System.Drawing.Point(9, 156);
            this.btnLaboratory.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnLaboratory.Name = "btnLaboratory";
            this.btnLaboratory.Size = new System.Drawing.Size(290, 54);
            this.btnLaboratory.TabIndex = 0;
            this.btnLaboratory.Text = "Laboratorium  Nr 2\r\n(prezentacja losowo wybranych figur geometrycznych)\r\n";
            this.btnLaboratory.UseVisualStyleBackColor = false;
            this.btnLaboratory.Click += new System.EventHandler(this.btnLaboratory_Click);
            // 
            // btnProject
            // 
            this.btnProject.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnProject.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnProject.Location = new System.Drawing.Point(302, 156);
            this.btnProject.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnProject.Name = "btnProject";
            this.btnProject.Size = new System.Drawing.Size(290, 54);
            this.btnProject.TabIndex = 1;
            this.btnProject.Text = "Projekt Nr 2\r\n(prezentacja figur geometrycznych kreślonych myszą)";
            this.btnProject.UseVisualStyleBackColor = false;
            this.btnProject.Click += new System.EventHandler(this.btnProject_Click);
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.Color.Red;
            this.btnExit.Location = new System.Drawing.Point(9, 215);
            this.btnExit.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(582, 19);
            this.btnExit.TabIndex = 2;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // StartWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(600, 366);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnProject);
            this.Controls.Add(this.btnLaboratory);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.MaximizeBox = false;
            this.Name = "StartWindow";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "StartWindow";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.StartWindow_FormClosing);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnLaboratory;
        private System.Windows.Forms.Button btnProject;
        private System.Windows.Forms.Button btnExit;
    }
}

