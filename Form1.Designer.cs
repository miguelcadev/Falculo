namespace AC_1
{
    partial class frm1
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm1));
            this.cboFuncao = new System.Windows.Forms.ComboBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnCalcular = new System.Windows.Forms.Button();
            this.nudX = new System.Windows.Forms.NumericUpDown();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblcoords = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.nudC = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.nudB = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.nudA = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lblGrafico = new System.Windows.Forms.Label();
            this.btnGrafico = new System.Windows.Forms.Button();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudX)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudC)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudB)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudA)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // cboFuncao
            // 
            this.cboFuncao.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(159)))), ((int)(((byte)(170)))), ((int)(((byte)(199)))));
            this.cboFuncao.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboFuncao.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.cboFuncao.FormattingEnabled = true;
            this.cboFuncao.Items.AddRange(new object[] {
            "Função Afim",
            "Função Exponencial",
            "Função Quadrática"});
            this.cboFuncao.Location = new System.Drawing.Point(7, 25);
            this.cboFuncao.Name = "cboFuncao";
            this.cboFuncao.Size = new System.Drawing.Size(177, 28);
            this.cboFuncao.TabIndex = 0;
            this.cboFuncao.SelectedIndexChanged += new System.EventHandler(this.cboFuncao_SelectedIndexChanged);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(132)))), ((int)(((byte)(141)))), ((int)(((byte)(165)))));
            this.pictureBox1.Location = new System.Drawing.Point(429, 17);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(620, 620);
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // btnCalcular
            // 
            this.btnCalcular.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(159)))), ((int)(((byte)(170)))), ((int)(((byte)(199)))));
            this.btnCalcular.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnCalcular.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCalcular.Location = new System.Drawing.Point(273, 536);
            this.btnCalcular.Name = "btnCalcular";
            this.btnCalcular.Size = new System.Drawing.Size(88, 74);
            this.btnCalcular.TabIndex = 3;
            this.btnCalcular.Text = "Calcular Y";
            this.btnCalcular.UseVisualStyleBackColor = false;
            this.btnCalcular.Click += new System.EventHandler(this.btnCalcular_Click);
            // 
            // nudX
            // 
            this.nudX.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(159)))), ((int)(((byte)(170)))), ((int)(((byte)(199)))));
            this.nudX.DecimalPlaces = 2;
            this.nudX.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.nudX.Increment = new decimal(new int[] {
            5,
            0,
            0,
            65536});
            this.nudX.Location = new System.Drawing.Point(19, 462);
            this.nudX.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.nudX.Minimum = new decimal(new int[] {
            1000,
            0,
            0,
            -2147483648});
            this.nudX.Name = "nudX";
            this.nudX.Size = new System.Drawing.Size(120, 26);
            this.nudX.TabIndex = 4;
            this.nudX.ValueChanged += new System.EventHandler(this.nudX_ValueChanged);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(159)))), ((int)(((byte)(170)))), ((int)(((byte)(199)))));
            this.panel1.Controls.Add(this.lblcoords);
            this.panel1.Location = new System.Drawing.Point(12, 509);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(255, 123);
            this.panel1.TabIndex = 5;
            // 
            // lblcoords
            // 
            this.lblcoords.AutoSize = true;
            this.lblcoords.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblcoords.Location = new System.Drawing.Point(4, 13);
            this.lblcoords.Name = "lblcoords";
            this.lblcoords.Size = new System.Drawing.Size(74, 20);
            this.lblcoords.TabIndex = 0;
            this.lblcoords.Text = "Função:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(20, 428);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(119, 25);
            this.label1.TabIndex = 6;
            this.label1.Text = "Valor de x";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // nudC
            // 
            this.nudC.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(159)))), ((int)(((byte)(170)))), ((int)(((byte)(199)))));
            this.nudC.DecimalPlaces = 2;
            this.nudC.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.nudC.Increment = new decimal(new int[] {
            5,
            0,
            0,
            65536});
            this.nudC.Location = new System.Drawing.Point(12, 294);
            this.nudC.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.nudC.Minimum = new decimal(new int[] {
            1000,
            0,
            0,
            -2147483648});
            this.nudC.Name = "nudC";
            this.nudC.Size = new System.Drawing.Size(120, 26);
            this.nudC.TabIndex = 7;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(2, 266);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(123, 25);
            this.label2.TabIndex = 8;
            this.label2.Text = "Valor de C";
            // 
            // nudB
            // 
            this.nudB.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(159)))), ((int)(((byte)(170)))), ((int)(((byte)(199)))));
            this.nudB.Cursor = System.Windows.Forms.Cursors.Default;
            this.nudB.DecimalPlaces = 2;
            this.nudB.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.nudB.Increment = new decimal(new int[] {
            5,
            0,
            0,
            65536});
            this.nudB.Location = new System.Drawing.Point(9, 200);
            this.nudB.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.nudB.Minimum = new decimal(new int[] {
            1000,
            0,
            0,
            -2147483648});
            this.nudB.Name = "nudB";
            this.nudB.Size = new System.Drawing.Size(120, 26);
            this.nudB.TabIndex = 9;
            this.nudB.ValueChanged += new System.EventHandler(this.nudB_ValueChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold);
            this.label3.Location = new System.Drawing.Point(2, 172);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(122, 25);
            this.label3.TabIndex = 10;
            this.label3.Text = "Valor de B";
            // 
            // nudA
            // 
            this.nudA.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(159)))), ((int)(((byte)(170)))), ((int)(((byte)(199)))));
            this.nudA.DecimalPlaces = 2;
            this.nudA.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nudA.Increment = new decimal(new int[] {
            5,
            0,
            0,
            65536});
            this.nudA.Location = new System.Drawing.Point(9, 106);
            this.nudA.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.nudA.Minimum = new decimal(new int[] {
            1000,
            0,
            0,
            -2147483648});
            this.nudA.Name = "nudA";
            this.nudA.Size = new System.Drawing.Size(120, 26);
            this.nudA.TabIndex = 11;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold);
            this.label4.Location = new System.Drawing.Point(2, 78);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(122, 25);
            this.label4.TabIndex = 12;
            this.label4.Text = "Valor de A";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(159)))), ((int)(((byte)(170)))), ((int)(((byte)(199)))));
            this.panel2.Controls.Add(this.lblGrafico);
            this.panel2.Location = new System.Drawing.Point(190, 12);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(211, 410);
            this.panel2.TabIndex = 6;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // lblGrafico
            // 
            this.lblGrafico.AutoSize = true;
            this.lblGrafico.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGrafico.Location = new System.Drawing.Point(4, 13);
            this.lblGrafico.Name = "lblGrafico";
            this.lblGrafico.Size = new System.Drawing.Size(62, 16);
            this.lblGrafico.TabIndex = 0;
            this.lblGrafico.Text = "Função:";
            // 
            // btnGrafico
            // 
            this.btnGrafico.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(159)))), ((int)(((byte)(170)))), ((int)(((byte)(199)))));
            this.btnGrafico.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnGrafico.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGrafico.Location = new System.Drawing.Point(221, 428);
            this.btnGrafico.Name = "btnGrafico";
            this.btnGrafico.Size = new System.Drawing.Size(140, 60);
            this.btnGrafico.TabIndex = 13;
            this.btnGrafico.Text = "Calcular Gráficos";
            this.btnGrafico.UseVisualStyleBackColor = false;
            this.btnGrafico.Click += new System.EventHandler(this.btnGrafico_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(159)))), ((int)(((byte)(170)))), ((int)(((byte)(199)))));
            this.pictureBox2.Location = new System.Drawing.Point(416, 5);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(645, 645);
            this.pictureBox2.TabIndex = 14;
            this.pictureBox2.TabStop = false;
            // 
            // frm1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(186)))), ((int)(((byte)(200)))), ((int)(((byte)(233)))));
            this.ClientSize = new System.Drawing.Size(1118, 656);
            this.Controls.Add(this.btnGrafico);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.nudA);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.nudB);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.nudC);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.nudX);
            this.Controls.Add(this.btnCalcular);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.cboFuncao);
            this.Controls.Add(this.pictureBox2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frm1";
            this.Text = "Falculo";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudX)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudC)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudB)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudA)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cboFuncao;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnCalcular;
        private System.Windows.Forms.NumericUpDown nudX;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblcoords;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown nudC;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown nudB;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown nudA;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label lblGrafico;
        private System.Windows.Forms.Button btnGrafico;
        private System.Windows.Forms.PictureBox pictureBox2;
    }
}

