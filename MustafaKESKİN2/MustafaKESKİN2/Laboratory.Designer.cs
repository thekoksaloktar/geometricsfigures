namespace MustafaKESKİN2
{
    partial class Laboratory
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
            this.components = new System.ComponentModel.Container();
            this.btnBack = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.pbRysownica = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtN = new System.Windows.Forms.TextBox();
            this.btnStart = new System.Windows.Forms.Button();
            this.btnPrzesunDoNowegoXY = new System.Windows.Forms.Button();
            this.chlbFigury = new System.Windows.Forms.CheckedListBox();
            this.btnWłącz = new System.Windows.Forms.Button();
            this.btnWyłącz = new System.Windows.Forms.Button();
            this.gpbTrypPokazu = new System.Windows.Forms.GroupBox();
            this.rdbManual = new System.Windows.Forms.RadioButton();
            this.rdbAutomatyczny = new System.Windows.Forms.RadioButton();
            this.txtNumerFigury = new System.Windows.Forms.TextBox();
            this.btnNąstępna = new System.Windows.Forms.Button();
            this.btnPoprzednia = new System.Windows.Forms.Button();
            this.gpbNumerFigury = new System.Windows.Forms.GroupBox();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pbRysownica)).BeginInit();
            this.gpbTrypPokazu.SuspendLayout();
            this.gpbNumerFigury.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnBack
            // 
            this.btnBack.BackColor = System.Drawing.Color.Blue;
            this.btnBack.Location = new System.Drawing.Point(945, 487);
            this.btnBack.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(107, 45);
            this.btnBack.TabIndex = 0;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = false;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.Color.Red;
            this.btnExit.Location = new System.Drawing.Point(945, 536);
            this.btnExit.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(107, 43);
            this.btnExit.TabIndex = 1;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // pbRysownica
            // 
            this.pbRysownica.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.pbRysownica.Location = new System.Drawing.Point(11, 10);
            this.pbRysownica.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pbRysownica.Name = "pbRysownica";
            this.pbRysownica.Size = new System.Drawing.Size(909, 456);
            this.pbRysownica.TabIndex = 2;
            this.pbRysownica.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(953, 26);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 26);
            this.label1.TabIndex = 3;
            this.label1.Text = "Podaj liczbę figur\r\ngeometrycznych";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // txtN
            // 
            this.txtN.Location = new System.Drawing.Point(945, 64);
            this.txtN.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtN.Name = "txtN";
            this.txtN.Size = new System.Drawing.Size(107, 20);
            this.txtN.TabIndex = 4;
            this.txtN.TextChanged += new System.EventHandler(this.txtN_TextChanged);
            // 
            // btnStart
            // 
            this.btnStart.BackColor = System.Drawing.Color.Lime;
            this.btnStart.Location = new System.Drawing.Point(945, 86);
            this.btnStart.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(107, 48);
            this.btnStart.TabIndex = 5;
            this.btnStart.Text = "Start";
            this.btnStart.UseVisualStyleBackColor = false;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // btnPrzesunDoNowegoXY
            // 
            this.btnPrzesunDoNowegoXY.Location = new System.Drawing.Point(945, 138);
            this.btnPrzesunDoNowegoXY.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnPrzesunDoNowegoXY.Name = "btnPrzesunDoNowegoXY";
            this.btnPrzesunDoNowegoXY.Size = new System.Drawing.Size(107, 105);
            this.btnPrzesunDoNowegoXY.TabIndex = 6;
            this.btnPrzesunDoNowegoXY.Text = "Przesunięcie\r\nwszystkich\r\nfigur do\r\nnowego\r\npołożenia";
            this.btnPrzesunDoNowegoXY.UseVisualStyleBackColor = true;
            // 
            // chlbFigury
            // 
            this.chlbFigury.FormattingEnabled = true;
            this.chlbFigury.Items.AddRange(new object[] {
            "Punkt",
            "Linia",
            "Elipsa",
            "Okrąg",
            "Kwadrat",
            "Prostokąt"});
            this.chlbFigury.Location = new System.Drawing.Point(945, 254);
            this.chlbFigury.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.chlbFigury.Name = "chlbFigury";
            this.chlbFigury.Size = new System.Drawing.Size(107, 79);
            this.chlbFigury.TabIndex = 7;
            this.chlbFigury.SelectedIndexChanged += new System.EventHandler(this.chlbFigury_SelectedIndexChanged);
            // 
            // btnWłącz
            // 
            this.btnWłącz.Location = new System.Drawing.Point(200, 487);
            this.btnWłącz.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnWłącz.Name = "btnWłącz";
            this.btnWłącz.Size = new System.Drawing.Size(192, 92);
            this.btnWłącz.TabIndex = 8;
            this.btnWłącz.Text = "Włączenie pokazu figur geometrycznych";
            this.btnWłącz.UseVisualStyleBackColor = true;
            this.btnWłącz.Click += new System.EventHandler(this.btnWłącz_Click);
            // 
            // btnWyłącz
            // 
            this.btnWyłącz.Location = new System.Drawing.Point(828, 487);
            this.btnWyłącz.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnWyłącz.Name = "btnWyłącz";
            this.btnWyłącz.Size = new System.Drawing.Size(92, 92);
            this.btnWyłącz.TabIndex = 9;
            this.btnWyłącz.Text = "Wyłączenie pokazu figur geometrycznych";
            this.btnWyłącz.UseVisualStyleBackColor = true;
            this.btnWyłącz.Click += new System.EventHandler(this.btnWyłącz_Click);
            // 
            // gpbTrypPokazu
            // 
            this.gpbTrypPokazu.Controls.Add(this.rdbManual);
            this.gpbTrypPokazu.Controls.Add(this.rdbAutomatyczny);
            this.gpbTrypPokazu.Location = new System.Drawing.Point(422, 487);
            this.gpbTrypPokazu.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.gpbTrypPokazu.Name = "gpbTrypPokazu";
            this.gpbTrypPokazu.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.gpbTrypPokazu.Size = new System.Drawing.Size(155, 92);
            this.gpbTrypPokazu.TabIndex = 10;
            this.gpbTrypPokazu.TabStop = false;
            this.gpbTrypPokazu.Text = "Tryb pokazu figur geometrycznych";
            // 
            // rdbManual
            // 
            this.rdbManual.AutoSize = true;
            this.rdbManual.Location = new System.Drawing.Point(4, 47);
            this.rdbManual.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.rdbManual.Name = "rdbManual";
            this.rdbManual.Size = new System.Drawing.Size(137, 17);
            this.rdbManual.TabIndex = 1;
            this.rdbManual.TabStop = true;
            this.rdbManual.Text = "Manualny (przyciskowy)";
            this.rdbManual.UseVisualStyleBackColor = true;
            this.rdbManual.CheckedChanged += new System.EventHandler(this.rdbManual_CheckedChanged);
            // 
            // rdbAutomatyczny
            // 
            this.rdbAutomatyczny.AutoSize = true;
            this.rdbAutomatyczny.Location = new System.Drawing.Point(4, 26);
            this.rdbAutomatyczny.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.rdbAutomatyczny.Name = "rdbAutomatyczny";
            this.rdbAutomatyczny.Size = new System.Drawing.Size(145, 17);
            this.rdbAutomatyczny.TabIndex = 0;
            this.rdbAutomatyczny.TabStop = true;
            this.rdbAutomatyczny.Text = "Automatyczny (zegarowy)";
            this.rdbAutomatyczny.UseVisualStyleBackColor = true;
            // 
            // txtNumerFigury
            // 
            this.txtNumerFigury.Location = new System.Drawing.Point(4, 22);
            this.txtNumerFigury.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtNumerFigury.Name = "txtNumerFigury";
            this.txtNumerFigury.Size = new System.Drawing.Size(148, 20);
            this.txtNumerFigury.TabIndex = 12;
            this.txtNumerFigury.TextChanged += new System.EventHandler(this.txtNumerFigury_TextChanged);
            // 
            // btnNąstępna
            // 
            this.btnNąstępna.Location = new System.Drawing.Point(4, 45);
            this.btnNąstępna.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnNąstępna.Name = "btnNąstępna";
            this.btnNąstępna.Size = new System.Drawing.Size(71, 19);
            this.btnNąstępna.TabIndex = 13;
            this.btnNąstępna.Text = "Nąstępna";
            this.btnNąstępna.UseVisualStyleBackColor = true;
            this.btnNąstępna.Click += new System.EventHandler(this.btnNąstępna_Click);
            // 
            // btnPoprzednia
            // 
            this.btnPoprzednia.Location = new System.Drawing.Point(79, 45);
            this.btnPoprzednia.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnPoprzednia.Name = "btnPoprzednia";
            this.btnPoprzednia.Size = new System.Drawing.Size(71, 19);
            this.btnPoprzednia.TabIndex = 14;
            this.btnPoprzednia.Text = "Poprzednia";
            this.btnPoprzednia.UseVisualStyleBackColor = true;
            this.btnPoprzednia.Click += new System.EventHandler(this.btnPoprzednia_Click);
            // 
            // gpbNumerFigury
            // 
            this.gpbNumerFigury.Controls.Add(this.txtNumerFigury);
            this.gpbNumerFigury.Controls.Add(this.btnPoprzednia);
            this.gpbNumerFigury.Controls.Add(this.btnNąstępna);
            this.gpbNumerFigury.Location = new System.Drawing.Point(619, 487);
            this.gpbNumerFigury.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.gpbNumerFigury.Name = "gpbNumerFigury";
            this.gpbNumerFigury.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.gpbNumerFigury.Size = new System.Drawing.Size(151, 92);
            this.gpbNumerFigury.TabIndex = 15;
            this.gpbNumerFigury.TabStop = false;
            this.gpbNumerFigury.Text = "Index (numer) figury";
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Laboratory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1063, 590);
            this.Controls.Add(this.gpbNumerFigury);
            this.Controls.Add(this.gpbTrypPokazu);
            this.Controls.Add(this.btnWyłącz);
            this.Controls.Add(this.btnWłącz);
            this.Controls.Add(this.chlbFigury);
            this.Controls.Add(this.btnPrzesunDoNowegoXY);
            this.Controls.Add(this.btnStart);
            this.Controls.Add(this.txtN);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pbRysownica);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnBack);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.MaximizeBox = false;
            this.Name = "Laboratory";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Laboratory";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Laboratory_FormClosing);
            this.Load += new System.EventHandler(this.Laboratory_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbRysownica)).EndInit();
            this.gpbTrypPokazu.ResumeLayout(false);
            this.gpbTrypPokazu.PerformLayout();
            this.gpbNumerFigury.ResumeLayout(false);
            this.gpbNumerFigury.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.PictureBox pbRysownica;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtN;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.Button btnPrzesunDoNowegoXY;
        private System.Windows.Forms.CheckedListBox chlbFigury;
        private System.Windows.Forms.Button btnWłącz;
        private System.Windows.Forms.Button btnWyłącz;
        private System.Windows.Forms.GroupBox gpbTrypPokazu;
        private System.Windows.Forms.RadioButton rdbManual;
        private System.Windows.Forms.RadioButton rdbAutomatyczny;
        private System.Windows.Forms.TextBox txtNumerFigury;
        private System.Windows.Forms.Button btnNąstępna;
        private System.Windows.Forms.Button btnPoprzednia;
        private System.Windows.Forms.GroupBox gpbNumerFigury;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.Timer timer1;
    }
}