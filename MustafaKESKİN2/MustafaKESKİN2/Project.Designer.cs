namespace MustafaKESKİN2
{
    partial class Project
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
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.pbRysownica = new System.Windows.Forms.PictureBox();
            this.rdbFillPie = new System.Windows.Forms.RadioButton();
            this.rdbDrawPie = new System.Windows.Forms.RadioButton();
            this.rdbDrawArc = new System.Windows.Forms.RadioButton();
            this.btnExit = new System.Windows.Forms.Button();
            this.rdbFillClosedCurve = new System.Windows.Forms.RadioButton();
            this.lblY = new System.Windows.Forms.Label();
            this.btnBack = new System.Windows.Forms.Button();
            this.rdbDrawClosedCurve = new System.Windows.Forms.RadioButton();
            this.rdbKrzywaKardynalna = new System.Windows.Forms.RadioButton();
            this.rdbKrzywaBeziera = new System.Windows.Forms.RadioButton();
            this.rdbProstokWyp = new System.Windows.Forms.RadioButton();
            this.btnReset = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rdbLiniaCiągła = new System.Windows.Forms.RadioButton();
            this.rdbWielokatForemny = new System.Windows.Forms.RadioButton();
            this.rdbLinia = new System.Windows.Forms.RadioButton();
            this.rdbPunkt = new System.Windows.Forms.RadioButton();
            this.rdbWielokatWyp = new System.Windows.Forms.RadioButton();
            this.txtLiczbaKątów = new System.Windows.Forms.Label();
            this.NumLiczbaKątów = new System.Windows.Forms.NumericUpDown();
            this.rdbKoło = new System.Windows.Forms.RadioButton();
            this.rdbFillElipse = new System.Windows.Forms.RadioButton();
            this.rdbOkrąg = new System.Windows.Forms.RadioButton();
            this.rdbElipsa = new System.Windows.Forms.RadioButton();
            this.rdbFillRect = new System.Windows.Forms.RadioButton();
            this.rdbKwadrat = new System.Windows.Forms.RadioButton();
            this.rdbProstokąt = new System.Windows.Forms.RadioButton();
            this.btnKolorWyp = new System.Windows.Forms.Button();
            this.lblX = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.cmbStylLinii = new System.Windows.Forms.ComboBox();
            this.btnKolorLinii = new System.Windows.Forms.Button();
            this.trackBar1 = new System.Windows.Forms.TrackBar();
            this.btnReplace = new System.Windows.Forms.Button();
            this.btnWczytaj = new System.Windows.Forms.Button();
            this.btnZapisz = new System.Windows.Forms.Button();
            this.gpbNumerFigury = new System.Windows.Forms.GroupBox();
            this.txtNumerFigury = new System.Windows.Forms.TextBox();
            this.btnPoprzedni = new System.Windows.Forms.Button();
            this.btnNastępny = new System.Windows.Forms.Button();
            this.gpbTrypPokazu = new System.Windows.Forms.GroupBox();
            this.rdbManualny = new System.Windows.Forms.RadioButton();
            this.rdbAutomatyczny = new System.Windows.Forms.RadioButton();
            this.btnWylaczPokazFigur = new System.Windows.Forms.Button();
            this.btnPokazFigur = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbRysownica)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NumLiczbaKątów)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).BeginInit();
            this.gpbNumerFigury.SuspendLayout();
            this.gpbTrypPokazu.SuspendLayout();
            this.SuspendLayout();
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // pbRysownica
            // 
            this.pbRysownica.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.pbRysownica.Location = new System.Drawing.Point(9, 31);
            this.pbRysownica.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pbRysownica.Name = "pbRysownica";
            this.pbRysownica.Size = new System.Drawing.Size(864, 610);
            this.pbRysownica.TabIndex = 31;
            this.pbRysownica.TabStop = false;
            this.pbRysownica.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pbRysownica_MouseDown);
            this.pbRysownica.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pbRysownica_MouseMove);
            this.pbRysownica.MouseUp += new System.Windows.Forms.MouseEventHandler(this.pbRysownica_MouseUp);
            // 
            // rdbFillPie
            // 
            this.rdbFillPie.AutoSize = true;
            this.rdbFillPie.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.rdbFillPie.Location = new System.Drawing.Point(4, 359);
            this.rdbFillPie.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.rdbFillPie.Name = "rdbFillPie";
            this.rdbFillPie.Size = new System.Drawing.Size(236, 25);
            this.rdbFillPie.TabIndex = 22;
            this.rdbFillPie.TabStop = true;
            this.rdbFillPie.Text = "Wypewniony wycinek elpsy";
            this.rdbFillPie.UseVisualStyleBackColor = true;
            // 
            // rdbDrawPie
            // 
            this.rdbDrawPie.AutoSize = true;
            this.rdbDrawPie.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.rdbDrawPie.Location = new System.Drawing.Point(4, 332);
            this.rdbDrawPie.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.rdbDrawPie.Name = "rdbDrawPie";
            this.rdbDrawPie.Size = new System.Drawing.Size(137, 25);
            this.rdbDrawPie.TabIndex = 20;
            this.rdbDrawPie.TabStop = true;
            this.rdbDrawPie.Text = "Wycinek elpsy";
            this.rdbDrawPie.UseVisualStyleBackColor = true;
            // 
            // rdbDrawArc
            // 
            this.rdbDrawArc.AutoSize = true;
            this.rdbDrawArc.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.rdbDrawArc.Location = new System.Drawing.Point(4, 304);
            this.rdbDrawArc.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.rdbDrawArc.Name = "rdbDrawArc";
            this.rdbDrawArc.Size = new System.Drawing.Size(102, 25);
            this.rdbDrawArc.TabIndex = 19;
            this.rdbDrawArc.TabStop = true;
            this.rdbDrawArc.Text = "Łuk elpsy";
            this.rdbDrawArc.UseVisualStyleBackColor = true;
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.Color.Red;
            this.btnExit.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnExit.Location = new System.Drawing.Point(1070, 707);
            this.btnExit.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(92, 27);
            this.btnExit.TabIndex = 25;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // rdbFillClosedCurve
            // 
            this.rdbFillClosedCurve.AutoSize = true;
            this.rdbFillClosedCurve.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.rdbFillClosedCurve.Location = new System.Drawing.Point(4, 255);
            this.rdbFillClosedCurve.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.rdbFillClosedCurve.Name = "rdbFillClosedCurve";
            this.rdbFillClosedCurve.Size = new System.Drawing.Size(199, 46);
            this.rdbFillClosedCurve.TabIndex = 18;
            this.rdbFillClosedCurve.TabStop = true;
            this.rdbFillClosedCurve.Text = "Wypełniona, zamknięta\r\nkrzywa kardynalna";
            this.rdbFillClosedCurve.UseVisualStyleBackColor = true;
            this.rdbFillClosedCurve.CheckedChanged += new System.EventHandler(this.rdbFillClosedCurve_CheckedChanged);
            // 
            // lblY
            // 
            this.lblY.AutoSize = true;
            this.lblY.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblY.Location = new System.Drawing.Point(349, 7);
            this.lblY.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblY.Name = "lblY";
            this.lblY.Size = new System.Drawing.Size(53, 21);
            this.lblY.TabIndex = 29;
            this.lblY.Text = "label3";
            // 
            // btnBack
            // 
            this.btnBack.BackColor = System.Drawing.Color.Blue;
            this.btnBack.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnBack.Location = new System.Drawing.Point(1070, 675);
            this.btnBack.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(92, 27);
            this.btnBack.TabIndex = 24;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = false;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // rdbDrawClosedCurve
            // 
            this.rdbDrawClosedCurve.AutoSize = true;
            this.rdbDrawClosedCurve.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.rdbDrawClosedCurve.Location = new System.Drawing.Point(4, 228);
            this.rdbDrawClosedCurve.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.rdbDrawClosedCurve.Name = "rdbDrawClosedCurve";
            this.rdbDrawClosedCurve.Size = new System.Drawing.Size(252, 25);
            this.rdbDrawClosedCurve.TabIndex = 17;
            this.rdbDrawClosedCurve.TabStop = true;
            this.rdbDrawClosedCurve.Text = "Zamkmięta krzywa kardynalna";
            this.rdbDrawClosedCurve.UseVisualStyleBackColor = true;
            this.rdbDrawClosedCurve.CheckedChanged += new System.EventHandler(this.rdbDrawClosedCurve_CheckedChanged);
            // 
            // rdbKrzywaKardynalna
            // 
            this.rdbKrzywaKardynalna.AutoSize = true;
            this.rdbKrzywaKardynalna.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.rdbKrzywaKardynalna.Location = new System.Drawing.Point(4, 200);
            this.rdbKrzywaKardynalna.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.rdbKrzywaKardynalna.Name = "rdbKrzywaKardynalna";
            this.rdbKrzywaKardynalna.Size = new System.Drawing.Size(170, 25);
            this.rdbKrzywaKardynalna.TabIndex = 16;
            this.rdbKrzywaKardynalna.TabStop = true;
            this.rdbKrzywaKardynalna.Text = "Krzywa kardynalna";
            this.rdbKrzywaKardynalna.UseVisualStyleBackColor = true;
            this.rdbKrzywaKardynalna.CheckedChanged += new System.EventHandler(this.rdbKrzywaKardynalna_CheckedChanged);
            // 
            // rdbKrzywaBeziera
            // 
            this.rdbKrzywaBeziera.AutoSize = true;
            this.rdbKrzywaBeziera.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.rdbKrzywaBeziera.Location = new System.Drawing.Point(4, 172);
            this.rdbKrzywaBeziera.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.rdbKrzywaBeziera.Name = "rdbKrzywaBeziera";
            this.rdbKrzywaBeziera.Size = new System.Drawing.Size(144, 25);
            this.rdbKrzywaBeziera.TabIndex = 15;
            this.rdbKrzywaBeziera.TabStop = true;
            this.rdbKrzywaBeziera.Text = "Krzywa Beziera";
            this.rdbKrzywaBeziera.UseVisualStyleBackColor = true;
            this.rdbKrzywaBeziera.CheckedChanged += new System.EventHandler(this.rdbKrzywaBeziera_CheckedChanged);
            // 
            // rdbProstokWyp
            // 
            this.rdbProstokWyp.AutoSize = true;
            this.rdbProstokWyp.Location = new System.Drawing.Point(100, 56);
            this.rdbProstokWyp.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.rdbProstokWyp.Name = "rdbProstokWyp";
            this.rdbProstokWyp.Size = new System.Drawing.Size(190, 25);
            this.rdbProstokWyp.TabIndex = 5;
            this.rdbProstokWyp.TabStop = true;
            this.rdbProstokWyp.Text = "Prostokąt wypełniony";
            this.rdbProstokWyp.UseVisualStyleBackColor = true;
            // 
            // btnReset
            // 
            this.btnReset.BackColor = System.Drawing.Color.Lime;
            this.btnReset.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnReset.Location = new System.Drawing.Point(1070, 644);
            this.btnReset.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(92, 27);
            this.btnReset.TabIndex = 30;
            this.btnReset.Text = "Reset";
            this.btnReset.UseVisualStyleBackColor = false;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(9, 7);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(287, 21);
            this.label1.TabIndex = 27;
            this.label1.Text = "Współrzędne (x, y) położenia myśzy:";
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.groupBox1.Controls.Add(this.rdbLiniaCiągła);
            this.groupBox1.Controls.Add(this.rdbWielokatForemny);
            this.groupBox1.Controls.Add(this.rdbLinia);
            this.groupBox1.Controls.Add(this.rdbPunkt);
            this.groupBox1.Controls.Add(this.rdbWielokatWyp);
            this.groupBox1.Controls.Add(this.txtLiczbaKątów);
            this.groupBox1.Controls.Add(this.NumLiczbaKątów);
            this.groupBox1.Controls.Add(this.rdbFillPie);
            this.groupBox1.Controls.Add(this.rdbDrawPie);
            this.groupBox1.Controls.Add(this.rdbDrawArc);
            this.groupBox1.Controls.Add(this.rdbFillClosedCurve);
            this.groupBox1.Controls.Add(this.rdbDrawClosedCurve);
            this.groupBox1.Controls.Add(this.rdbKrzywaKardynalna);
            this.groupBox1.Controls.Add(this.rdbKrzywaBeziera);
            this.groupBox1.Controls.Add(this.rdbKoło);
            this.groupBox1.Controls.Add(this.rdbFillElipse);
            this.groupBox1.Controls.Add(this.rdbProstokWyp);
            this.groupBox1.Controls.Add(this.rdbOkrąg);
            this.groupBox1.Controls.Add(this.rdbElipsa);
            this.groupBox1.Controls.Add(this.rdbFillRect);
            this.groupBox1.Controls.Add(this.rdbKwadrat);
            this.groupBox1.Controls.Add(this.rdbProstokąt);
            this.groupBox1.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.groupBox1.Location = new System.Drawing.Point(878, 10);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox1.Size = new System.Drawing.Size(284, 508);
            this.groupBox1.TabIndex = 26;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Wybierz figurę lub linię geomet.:";
            // 
            // rdbLiniaCiągła
            // 
            this.rdbLiniaCiągła.AutoSize = true;
            this.rdbLiniaCiągła.Location = new System.Drawing.Point(4, 446);
            this.rdbLiniaCiągła.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.rdbLiniaCiągła.Name = "rdbLiniaCiągła";
            this.rdbLiniaCiągła.Size = new System.Drawing.Size(230, 25);
            this.rdbLiniaCiągła.TabIndex = 29;
            this.rdbLiniaCiągła.TabStop = true;
            this.rdbLiniaCiągła.Text = "Linia ciągła kreślona myszą";
            this.rdbLiniaCiągła.UseVisualStyleBackColor = true;
            // 
            // rdbWielokatForemny
            // 
            this.rdbWielokatForemny.AutoSize = true;
            this.rdbWielokatForemny.Location = new System.Drawing.Point(4, 388);
            this.rdbWielokatForemny.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.rdbWielokatForemny.Name = "rdbWielokatForemny";
            this.rdbWielokatForemny.Size = new System.Drawing.Size(160, 25);
            this.rdbWielokatForemny.TabIndex = 28;
            this.rdbWielokatForemny.TabStop = true;
            this.rdbWielokatForemny.Text = "Wielokąt foremny";
            this.rdbWielokatForemny.UseVisualStyleBackColor = true;
            this.rdbWielokatForemny.CheckedChanged += new System.EventHandler(this.rdbWielokatForemny_CheckedChanged);
            // 
            // rdbLinia
            // 
            this.rdbLinia.AutoSize = true;
            this.rdbLinia.Location = new System.Drawing.Point(100, 27);
            this.rdbLinia.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.rdbLinia.Name = "rdbLinia";
            this.rdbLinia.Size = new System.Drawing.Size(116, 25);
            this.rdbLinia.TabIndex = 27;
            this.rdbLinia.TabStop = true;
            this.rdbLinia.Text = "Linia prosta";
            this.rdbLinia.UseVisualStyleBackColor = true;
            // 
            // rdbPunkt
            // 
            this.rdbPunkt.AutoSize = true;
            this.rdbPunkt.Location = new System.Drawing.Point(4, 27);
            this.rdbPunkt.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.rdbPunkt.Name = "rdbPunkt";
            this.rdbPunkt.Size = new System.Drawing.Size(71, 25);
            this.rdbPunkt.TabIndex = 25;
            this.rdbPunkt.TabStop = true;
            this.rdbPunkt.Text = "Punkt";
            this.rdbPunkt.UseVisualStyleBackColor = true;
            // 
            // rdbWielokatWyp
            // 
            this.rdbWielokatWyp.AutoSize = true;
            this.rdbWielokatWyp.Location = new System.Drawing.Point(4, 417);
            this.rdbWielokatWyp.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.rdbWielokatWyp.Name = "rdbWielokatWyp";
            this.rdbWielokatWyp.Size = new System.Drawing.Size(188, 25);
            this.rdbWielokatWyp.TabIndex = 26;
            this.rdbWielokatWyp.TabStop = true;
            this.rdbWielokatWyp.Text = "Wielokąt wypełniony ";
            this.rdbWielokatWyp.UseVisualStyleBackColor = true;
            this.rdbWielokatWyp.CheckedChanged += new System.EventHandler(this.rdbWielokatWyp_CheckedChanged);
            // 
            // txtLiczbaKątów
            // 
            this.txtLiczbaKątów.AutoSize = true;
            this.txtLiczbaKątów.Location = new System.Drawing.Point(4, 477);
            this.txtLiczbaKątów.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.txtLiczbaKątów.Name = "txtLiczbaKątów";
            this.txtLiczbaKątów.Size = new System.Drawing.Size(114, 21);
            this.txtLiczbaKątów.TabIndex = 24;
            this.txtLiczbaKątów.Text = "Liczba kątów:";
            this.txtLiczbaKątów.Visible = false;
            // 
            // NumLiczbaKątów
            // 
            this.NumLiczbaKątów.Location = new System.Drawing.Point(115, 475);
            this.NumLiczbaKątów.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.NumLiczbaKątów.Maximum = new decimal(new int[] {
            15,
            0,
            0,
            0});
            this.NumLiczbaKątów.Name = "NumLiczbaKątów";
            this.NumLiczbaKątów.Size = new System.Drawing.Size(67, 29);
            this.NumLiczbaKątów.TabIndex = 23;
            this.NumLiczbaKątów.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.NumLiczbaKątów.Value = new decimal(new int[] {
            3,
            0,
            0,
            0});
            this.NumLiczbaKątów.Visible = false;
            // 
            // rdbKoło
            // 
            this.rdbKoło.AutoSize = true;
            this.rdbKoło.Location = new System.Drawing.Point(100, 144);
            this.rdbKoło.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.rdbKoło.Name = "rdbKoło";
            this.rdbKoło.Size = new System.Drawing.Size(154, 25);
            this.rdbKoło.TabIndex = 14;
            this.rdbKoło.TabStop = true;
            this.rdbKoło.Text = "Koło wypełnione";
            this.rdbKoło.UseVisualStyleBackColor = true;
            // 
            // rdbFillElipse
            // 
            this.rdbFillElipse.AutoSize = true;
            this.rdbFillElipse.Location = new System.Drawing.Point(100, 115);
            this.rdbFillElipse.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.rdbFillElipse.Name = "rdbFillElipse";
            this.rdbFillElipse.Size = new System.Drawing.Size(162, 25);
            this.rdbFillElipse.TabIndex = 13;
            this.rdbFillElipse.TabStop = true;
            this.rdbFillElipse.Text = "Elipsa wypełniona";
            this.rdbFillElipse.UseVisualStyleBackColor = true;
            // 
            // rdbOkrąg
            // 
            this.rdbOkrąg.AutoSize = true;
            this.rdbOkrąg.Location = new System.Drawing.Point(4, 144);
            this.rdbOkrąg.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.rdbOkrąg.Name = "rdbOkrąg";
            this.rdbOkrąg.Size = new System.Drawing.Size(74, 25);
            this.rdbOkrąg.TabIndex = 4;
            this.rdbOkrąg.TabStop = true;
            this.rdbOkrąg.Text = "Okrag";
            this.rdbOkrąg.UseVisualStyleBackColor = true;
            // 
            // rdbElipsa
            // 
            this.rdbElipsa.AutoSize = true;
            this.rdbElipsa.Location = new System.Drawing.Point(4, 115);
            this.rdbElipsa.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.rdbElipsa.Name = "rdbElipsa";
            this.rdbElipsa.Size = new System.Drawing.Size(73, 25);
            this.rdbElipsa.TabIndex = 3;
            this.rdbElipsa.Text = "Elipsa";
            this.rdbElipsa.UseVisualStyleBackColor = true;
            // 
            // rdbFillRect
            // 
            this.rdbFillRect.AutoSize = true;
            this.rdbFillRect.Location = new System.Drawing.Point(100, 85);
            this.rdbFillRect.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.rdbFillRect.Name = "rdbFillRect";
            this.rdbFillRect.Size = new System.Drawing.Size(181, 25);
            this.rdbFillRect.TabIndex = 9;
            this.rdbFillRect.TabStop = true;
            this.rdbFillRect.Text = "Kwadrat wypełniony";
            this.rdbFillRect.UseVisualStyleBackColor = true;
            // 
            // rdbKwadrat
            // 
            this.rdbKwadrat.AutoSize = true;
            this.rdbKwadrat.Location = new System.Drawing.Point(4, 85);
            this.rdbKwadrat.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.rdbKwadrat.Name = "rdbKwadrat";
            this.rdbKwadrat.Size = new System.Drawing.Size(91, 25);
            this.rdbKwadrat.TabIndex = 2;
            this.rdbKwadrat.Text = "Kwadrat";
            this.rdbKwadrat.UseVisualStyleBackColor = true;
            // 
            // rdbProstokąt
            // 
            this.rdbProstokąt.AutoSize = true;
            this.rdbProstokąt.Location = new System.Drawing.Point(4, 56);
            this.rdbProstokąt.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.rdbProstokąt.Name = "rdbProstokąt";
            this.rdbProstokąt.Size = new System.Drawing.Size(100, 25);
            this.rdbProstokąt.TabIndex = 1;
            this.rdbProstokąt.Text = "Prostokąt";
            this.rdbProstokąt.UseVisualStyleBackColor = true;
            // 
            // btnKolorWyp
            // 
            this.btnKolorWyp.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnKolorWyp.Location = new System.Drawing.Point(4, 58);
            this.btnKolorWyp.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnKolorWyp.Name = "btnKolorWyp";
            this.btnKolorWyp.Size = new System.Drawing.Size(104, 53);
            this.btnKolorWyp.TabIndex = 12;
            this.btnKolorWyp.Text = "Kolor wypełnienia";
            this.btnKolorWyp.UseVisualStyleBackColor = true;
            this.btnKolorWyp.Click += new System.EventHandler(this.btnKolorWyp_Click);
            // 
            // lblX
            // 
            this.lblX.AutoSize = true;
            this.lblX.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblX.Location = new System.Drawing.Point(294, 7);
            this.lblX.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblX.Name = "lblX";
            this.lblX.Size = new System.Drawing.Size(53, 21);
            this.lblX.TabIndex = 28;
            this.lblX.Text = "label2";
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.groupBox2.Controls.Add(this.cmbStylLinii);
            this.groupBox2.Controls.Add(this.btnKolorLinii);
            this.groupBox2.Controls.Add(this.trackBar1);
            this.groupBox2.Controls.Add(this.btnKolorWyp);
            this.groupBox2.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(878, 522);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox2.Size = new System.Drawing.Size(284, 116);
            this.groupBox2.TabIndex = 32;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Atrybuty graficzne";
            // 
            // cmbStylLinii
            // 
            this.cmbStylLinii.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.cmbStylLinii.FormattingEnabled = true;
            this.cmbStylLinii.Items.AddRange(new object[] {
            "Solid",
            "Dash",
            "Dot",
            "DashDot ",
            "DashDotDot"});
            this.cmbStylLinii.Location = new System.Drawing.Point(112, 27);
            this.cmbStylLinii.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cmbStylLinii.Name = "cmbStylLinii";
            this.cmbStylLinii.Size = new System.Drawing.Size(146, 28);
            this.cmbStylLinii.TabIndex = 6;
            this.cmbStylLinii.Text = "Wybierz styl linii";
            // 
            // btnKolorLinii
            // 
            this.btnKolorLinii.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnKolorLinii.Location = new System.Drawing.Point(4, 27);
            this.btnKolorLinii.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnKolorLinii.Name = "btnKolorLinii";
            this.btnKolorLinii.Size = new System.Drawing.Size(104, 27);
            this.btnKolorLinii.TabIndex = 4;
            this.btnKolorLinii.Text = "Kolor Linii";
            this.btnKolorLinii.UseVisualStyleBackColor = true;
            this.btnKolorLinii.Click += new System.EventHandler(this.btnKolorLinii_Click);
            // 
            // trackBar1
            // 
            this.trackBar1.Location = new System.Drawing.Point(112, 66);
            this.trackBar1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.trackBar1.Minimum = 1;
            this.trackBar1.Name = "trackBar1";
            this.trackBar1.Size = new System.Drawing.Size(145, 45);
            this.trackBar1.SmallChange = 3;
            this.trackBar1.TabIndex = 3;
            this.trackBar1.Value = 1;
            // 
            // btnReplace
            // 
            this.btnReplace.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnReplace.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnReplace.Location = new System.Drawing.Point(878, 644);
            this.btnReplace.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnReplace.Name = "btnReplace";
            this.btnReplace.Size = new System.Drawing.Size(188, 27);
            this.btnReplace.TabIndex = 33;
            this.btnReplace.Text = "Przesuń figury geometryczne \r\ndo nowej lokalizacji";
            this.btnReplace.UseVisualStyleBackColor = false;
            this.btnReplace.Click += new System.EventHandler(this.btnReplace_Click);
            // 
            // btnWczytaj
            // 
            this.btnWczytaj.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnWczytaj.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnWczytaj.Location = new System.Drawing.Point(878, 707);
            this.btnWczytaj.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnWczytaj.Name = "btnWczytaj";
            this.btnWczytaj.Size = new System.Drawing.Size(188, 27);
            this.btnWczytaj.TabIndex = 35;
            this.btnWczytaj.Text = "Wczytaj bitmapę w pliku";
            this.btnWczytaj.UseVisualStyleBackColor = false;
            this.btnWczytaj.Click += new System.EventHandler(this.btnWczytaj_Click);
            // 
            // btnZapisz
            // 
            this.btnZapisz.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnZapisz.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnZapisz.Location = new System.Drawing.Point(878, 675);
            this.btnZapisz.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnZapisz.Name = "btnZapisz";
            this.btnZapisz.Size = new System.Drawing.Size(188, 27);
            this.btnZapisz.TabIndex = 34;
            this.btnZapisz.Text = "Zapisz bitmapę w pliku";
            this.btnZapisz.UseVisualStyleBackColor = false;
            this.btnZapisz.Click += new System.EventHandler(this.btnZapisz_Click);
            // 
            // gpbNumerFigury
            // 
            this.gpbNumerFigury.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.gpbNumerFigury.Controls.Add(this.txtNumerFigury);
            this.gpbNumerFigury.Controls.Add(this.btnPoprzedni);
            this.gpbNumerFigury.Controls.Add(this.btnNastępny);
            this.gpbNumerFigury.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gpbNumerFigury.Location = new System.Drawing.Point(482, 646);
            this.gpbNumerFigury.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.gpbNumerFigury.Name = "gpbNumerFigury";
            this.gpbNumerFigury.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.gpbNumerFigury.Size = new System.Drawing.Size(208, 88);
            this.gpbNumerFigury.TabIndex = 39;
            this.gpbNumerFigury.TabStop = false;
            this.gpbNumerFigury.Text = "Index (numer) figury";
            // 
            // txtNumerFigury
            // 
            this.txtNumerFigury.Location = new System.Drawing.Point(4, 26);
            this.txtNumerFigury.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtNumerFigury.Name = "txtNumerFigury";
            this.txtNumerFigury.Size = new System.Drawing.Size(200, 29);
            this.txtNumerFigury.TabIndex = 12;
            this.txtNumerFigury.TextChanged += new System.EventHandler(this.txtNumerFigury_TextChanged);
            // 
            // btnPoprzedni
            // 
            this.btnPoprzedni.Location = new System.Drawing.Point(106, 58);
            this.btnPoprzedni.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnPoprzedni.Name = "btnPoprzedni";
            this.btnPoprzedni.Size = new System.Drawing.Size(98, 27);
            this.btnPoprzedni.TabIndex = 14;
            this.btnPoprzedni.Text = "Poprzednia";
            this.btnPoprzedni.UseVisualStyleBackColor = true;
            this.btnPoprzedni.Click += new System.EventHandler(this.btnPoprzedni_Click);
            // 
            // btnNastępny
            // 
            this.btnNastępny.Location = new System.Drawing.Point(4, 58);
            this.btnNastępny.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnNastępny.Name = "btnNastępny";
            this.btnNastępny.Size = new System.Drawing.Size(98, 27);
            this.btnNastępny.TabIndex = 13;
            this.btnNastępny.Text = "Nąstępna";
            this.btnNastępny.UseVisualStyleBackColor = true;
            this.btnNastępny.Click += new System.EventHandler(this.btnNastępny_Click);
            // 
            // gpbTrypPokazu
            // 
            this.gpbTrypPokazu.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.gpbTrypPokazu.Controls.Add(this.rdbManualny);
            this.gpbTrypPokazu.Controls.Add(this.rdbAutomatyczny);
            this.gpbTrypPokazu.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.gpbTrypPokazu.Location = new System.Drawing.Point(194, 646);
            this.gpbTrypPokazu.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.gpbTrypPokazu.Name = "gpbTrypPokazu";
            this.gpbTrypPokazu.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.gpbTrypPokazu.Size = new System.Drawing.Size(288, 88);
            this.gpbTrypPokazu.TabIndex = 38;
            this.gpbTrypPokazu.TabStop = false;
            this.gpbTrypPokazu.Text = "Tryb pokazu figur geometrycznych";
            // 
            // rdbManualny
            // 
            this.rdbManualny.AutoSize = true;
            this.rdbManualny.Location = new System.Drawing.Point(4, 56);
            this.rdbManualny.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.rdbManualny.Name = "rdbManualny";
            this.rdbManualny.Size = new System.Drawing.Size(212, 25);
            this.rdbManualny.TabIndex = 1;
            this.rdbManualny.TabStop = true;
            this.rdbManualny.Text = "Manualny (przyciskowy)";
            this.rdbManualny.UseVisualStyleBackColor = true;
            this.rdbManualny.CheckedChanged += new System.EventHandler(this.rdbManualny_CheckedChanged);
            // 
            // rdbAutomatyczny
            // 
            this.rdbAutomatyczny.AutoSize = true;
            this.rdbAutomatyczny.Location = new System.Drawing.Point(4, 27);
            this.rdbAutomatyczny.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.rdbAutomatyczny.Name = "rdbAutomatyczny";
            this.rdbAutomatyczny.Size = new System.Drawing.Size(224, 25);
            this.rdbAutomatyczny.TabIndex = 0;
            this.rdbAutomatyczny.TabStop = true;
            this.rdbAutomatyczny.Text = "Automatyczny (zegarowy)";
            this.rdbAutomatyczny.UseVisualStyleBackColor = true;
            // 
            // btnWylaczPokazFigur
            // 
            this.btnWylaczPokazFigur.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnWylaczPokazFigur.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnWylaczPokazFigur.Location = new System.Drawing.Point(694, 646);
            this.btnWylaczPokazFigur.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnWylaczPokazFigur.Name = "btnWylaczPokazFigur";
            this.btnWylaczPokazFigur.Size = new System.Drawing.Size(179, 88);
            this.btnWylaczPokazFigur.TabIndex = 37;
            this.btnWylaczPokazFigur.Text = "Wyłączenie pokazu figur geometrycznych";
            this.btnWylaczPokazFigur.UseVisualStyleBackColor = false;
            this.btnWylaczPokazFigur.Click += new System.EventHandler(this.btnWylaczPokazFigur_Click);
            // 
            // btnPokazFigur
            // 
            this.btnPokazFigur.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnPokazFigur.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnPokazFigur.Location = new System.Drawing.Point(10, 646);
            this.btnPokazFigur.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnPokazFigur.Name = "btnPokazFigur";
            this.btnPokazFigur.Size = new System.Drawing.Size(179, 88);
            this.btnPokazFigur.TabIndex = 36;
            this.btnPokazFigur.Text = "Włączenie pokazu figur geometrycznych";
            this.btnPokazFigur.UseVisualStyleBackColor = false;
            this.btnPokazFigur.Click += new System.EventHandler(this.btnPokazFigur_Click);
            // 
            // Project
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1171, 743);
            this.Controls.Add(this.gpbNumerFigury);
            this.Controls.Add(this.gpbTrypPokazu);
            this.Controls.Add(this.btnWylaczPokazFigur);
            this.Controls.Add(this.btnPokazFigur);
            this.Controls.Add(this.btnWczytaj);
            this.Controls.Add(this.btnZapisz);
            this.Controls.Add(this.btnReplace);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.pbRysownica);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.lblY);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.lblX);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.MaximizeBox = false;
            this.Name = "Project";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Mustafa_Keskin_64481";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Project_FormClosing);
            this.Load += new System.EventHandler(this.Project_Load);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbRysownica)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NumLiczbaKątów)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).EndInit();
            this.gpbNumerFigury.ResumeLayout(false);
            this.gpbNumerFigury.PerformLayout();
            this.gpbTrypPokazu.ResumeLayout(false);
            this.gpbTrypPokazu.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button btnWczytaj;
        private System.Windows.Forms.Button btnZapisz;
        private System.Windows.Forms.Button btnReplace;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ComboBox cmbStylLinii;
        private System.Windows.Forms.Button btnKolorLinii;
        private System.Windows.Forms.TrackBar trackBar1;
        private System.Windows.Forms.PictureBox pbRysownica;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Label lblY;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rdbFillPie;
        private System.Windows.Forms.RadioButton rdbDrawPie;
        private System.Windows.Forms.RadioButton rdbDrawArc;
        private System.Windows.Forms.RadioButton rdbFillClosedCurve;
        private System.Windows.Forms.RadioButton rdbDrawClosedCurve;
        private System.Windows.Forms.RadioButton rdbKrzywaKardynalna;
        private System.Windows.Forms.RadioButton rdbKrzywaBeziera;
        private System.Windows.Forms.RadioButton rdbKoło;
        private System.Windows.Forms.Button btnKolorWyp;
        private System.Windows.Forms.RadioButton rdbFillElipse;
        private System.Windows.Forms.RadioButton rdbProstokWyp;
        private System.Windows.Forms.RadioButton rdbOkrąg;
        private System.Windows.Forms.RadioButton rdbElipsa;
        private System.Windows.Forms.RadioButton rdbFillRect;
        private System.Windows.Forms.RadioButton rdbKwadrat;
        private System.Windows.Forms.RadioButton rdbProstokąt;
        private System.Windows.Forms.Label lblX;
        private System.Windows.Forms.GroupBox gpbNumerFigury;
        private System.Windows.Forms.TextBox txtNumerFigury;
        private System.Windows.Forms.Button btnPoprzedni;
        private System.Windows.Forms.Button btnNastępny;
        private System.Windows.Forms.GroupBox gpbTrypPokazu;
        private System.Windows.Forms.RadioButton rdbManualny;
        private System.Windows.Forms.RadioButton rdbAutomatyczny;
        private System.Windows.Forms.Button btnWylaczPokazFigur;
        private System.Windows.Forms.Button btnPokazFigur;
        private System.Windows.Forms.Label txtLiczbaKątów;
        private System.Windows.Forms.NumericUpDown NumLiczbaKątów;
        private System.Windows.Forms.RadioButton rdbLiniaCiągła;
        private System.Windows.Forms.RadioButton rdbWielokatForemny;
        private System.Windows.Forms.RadioButton rdbLinia;
        private System.Windows.Forms.RadioButton rdbPunkt;
        private System.Windows.Forms.RadioButton rdbWielokatWyp;
    }
}