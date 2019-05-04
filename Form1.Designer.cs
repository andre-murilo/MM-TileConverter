namespace MixMaster_Tile_Converter
{
    partial class Form1
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.BTNBuscarSaida = new System.Windows.Forms.Button();
            this.BTNBuscarTile = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.TBOutput = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.TBInput = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.BTNProcess = new System.Windows.Forms.Button();
            this.RBMode2 = new System.Windows.Forms.RadioButton();
            this.RBMode1 = new System.Windows.Forms.RadioButton();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.button3 = new System.Windows.Forms.Button();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.BTNBuscarSaida);
            this.groupBox1.Controls.Add(this.BTNBuscarTile);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.TBOutput);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.TBInput);
            this.groupBox1.ForeColor = System.Drawing.Color.White;
            this.groupBox1.Location = new System.Drawing.Point(17, 8);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(340, 87);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Arquivos";
            // 
            // BTNBuscarSaida
            // 
            this.BTNBuscarSaida.ForeColor = System.Drawing.Color.Black;
            this.BTNBuscarSaida.Location = new System.Drawing.Point(259, 47);
            this.BTNBuscarSaida.Name = "BTNBuscarSaida";
            this.BTNBuscarSaida.Size = new System.Drawing.Size(69, 23);
            this.BTNBuscarSaida.TabIndex = 5;
            this.BTNBuscarSaida.Text = "Buscar";
            this.BTNBuscarSaida.UseVisualStyleBackColor = true;
            this.BTNBuscarSaida.Click += new System.EventHandler(this.BTNBuscarSaida_Click);
            // 
            // BTNBuscarTile
            // 
            this.BTNBuscarTile.ForeColor = System.Drawing.Color.Black;
            this.BTNBuscarTile.Location = new System.Drawing.Point(259, 19);
            this.BTNBuscarTile.Name = "BTNBuscarTile";
            this.BTNBuscarTile.Size = new System.Drawing.Size(69, 23);
            this.BTNBuscarTile.TabIndex = 4;
            this.BTNBuscarTile.Text = "Buscar";
            this.BTNBuscarTile.UseVisualStyleBackColor = true;
            this.BTNBuscarTile.Click += new System.EventHandler(this.BTNBuscarTile_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(8, 49);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 16);
            this.label2.TabIndex = 3;
            this.label2.Text = "Saida:";
            // 
            // TBOutput
            // 
            this.TBOutput.AllowDrop = true;
            this.TBOutput.Location = new System.Drawing.Point(71, 47);
            this.TBOutput.Name = "TBOutput";
            this.TBOutput.Size = new System.Drawing.Size(182, 20);
            this.TBOutput.TabIndex = 2;
            this.TBOutput.DragDrop += new System.Windows.Forms.DragEventHandler(this.TBOutput_DragDrop);
            this.TBOutput.DragEnter += new System.Windows.Forms.DragEventHandler(this.TBOutput_DragEnter);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(6, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "Entrada";
            // 
            // TBInput
            // 
            this.TBInput.AllowDrop = true;
            this.TBInput.Location = new System.Drawing.Point(71, 21);
            this.TBInput.Name = "TBInput";
            this.TBInput.Size = new System.Drawing.Size(182, 20);
            this.TBInput.TabIndex = 0;
            this.TBInput.DragDrop += new System.Windows.Forms.DragEventHandler(this.TBInput_DragDrop);
            this.TBInput.DragEnter += new System.Windows.Forms.DragEventHandler(this.TBInput_DragEnter);
            this.TBInput.DragOver += new System.Windows.Forms.DragEventHandler(this.TBInput_DragOver);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.BTNProcess);
            this.groupBox2.Controls.Add(this.RBMode2);
            this.groupBox2.Controls.Add(this.RBMode1);
            this.groupBox2.Location = new System.Drawing.Point(79, 110);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(221, 124);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Metodo";
            // 
            // BTNProcess
            // 
            this.BTNProcess.Location = new System.Drawing.Point(45, 74);
            this.BTNProcess.Name = "BTNProcess";
            this.BTNProcess.Size = new System.Drawing.Size(106, 35);
            this.BTNProcess.TabIndex = 2;
            this.BTNProcess.Text = "Processar";
            this.BTNProcess.UseVisualStyleBackColor = true;
            this.BTNProcess.Click += new System.EventHandler(this.BTNProcess_Click);
            // 
            // RBMode2
            // 
            this.RBMode2.AutoSize = true;
            this.RBMode2.Checked = true;
            this.RBMode2.Location = new System.Drawing.Point(19, 42);
            this.RBMode2.Name = "RBMode2";
            this.RBMode2.Size = new System.Drawing.Size(78, 17);
            this.RBMode2.TabIndex = 1;
            this.RBMode2.TabStop = true;
            this.RBMode2.Text = "All One File";
            this.RBMode2.UseVisualStyleBackColor = true;
            // 
            // RBMode1
            // 
            this.RBMode1.AutoSize = true;
            this.RBMode1.Enabled = false;
            this.RBMode1.Location = new System.Drawing.Point(19, 19);
            this.RBMode1.Name = "RBMode1";
            this.RBMode1.Size = new System.Drawing.Size(57, 17);
            this.RBMode1.TabIndex = 0;
            this.RBMode1.Text = "Splited";
            this.RBMode1.UseVisualStyleBackColor = true;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(380, 278);
            this.tabControl1.TabIndex = 2;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.CornflowerBlue;
            this.tabPage1.Controls.Add(this.groupBox1);
            this.tabPage1.Controls.Add(this.groupBox2);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(372, 252);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "TileToAn";
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.Color.CornflowerBlue;
            this.tabPage2.Controls.Add(this.groupBox4);
            this.tabPage2.Controls.Add(this.groupBox3);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(372, 252);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "AnToTile";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.button1);
            this.groupBox3.Controls.Add(this.button2);
            this.groupBox3.Controls.Add(this.textBox2);
            this.groupBox3.Controls.Add(this.label3);
            this.groupBox3.Controls.Add(this.textBox1);
            this.groupBox3.Controls.Add(this.label4);
            this.groupBox3.ForeColor = System.Drawing.Color.White;
            this.groupBox3.Location = new System.Drawing.Point(8, 16);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(340, 87);
            this.groupBox3.TabIndex = 1;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Arquivos";
            // 
            // button1
            // 
            this.button1.ForeColor = System.Drawing.Color.Black;
            this.button1.Location = new System.Drawing.Point(259, 47);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(69, 23);
            this.button1.TabIndex = 5;
            this.button1.Text = "Buscar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.ForeColor = System.Drawing.Color.Black;
            this.button2.Location = new System.Drawing.Point(259, 19);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(69, 23);
            this.button2.TabIndex = 4;
            this.button2.Text = "Buscar";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(8, 49);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 16);
            this.label3.TabIndex = 3;
            this.label3.Text = "Saida:";
            // 
            // textBox1
            // 
            this.textBox1.AllowDrop = true;
            this.textBox1.Location = new System.Drawing.Point(71, 22);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(182, 20);
            this.textBox1.TabIndex = 2;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(6, 22);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(55, 16);
            this.label4.TabIndex = 1;
            this.label4.Text = "Entrada";
            // 
            // textBox2
            // 
            this.textBox2.AllowDrop = true;
            this.textBox2.Location = new System.Drawing.Point(71, 49);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(182, 20);
            this.textBox2.TabIndex = 0;
            this.textBox2.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.button3);
            this.groupBox4.Controls.Add(this.radioButton1);
            this.groupBox4.Controls.Add(this.radioButton2);
            this.groupBox4.Location = new System.Drawing.Point(59, 109);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(221, 124);
            this.groupBox4.TabIndex = 2;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Metodo";
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(45, 74);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(106, 35);
            this.button3.TabIndex = 2;
            this.button3.Text = "Processar";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Checked = true;
            this.radioButton1.Location = new System.Drawing.Point(19, 42);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(78, 17);
            this.radioButton1.TabIndex = 1;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "All One File";
            this.radioButton1.UseVisualStyleBackColor = true;
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Enabled = false;
            this.radioButton2.Location = new System.Drawing.Point(19, 19);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(57, 17);
            this.radioButton2.TabIndex = 0;
            this.radioButton2.Text = "Splited";
            this.radioButton2.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(380, 278);
            this.Controls.Add(this.tabControl1);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MixMaster Tile Converter";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button BTNBuscarSaida;
        private System.Windows.Forms.Button BTNBuscarTile;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox TBOutput;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TBInput;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button BTNProcess;
        private System.Windows.Forms.RadioButton RBMode2;
        private System.Windows.Forms.RadioButton RBMode1;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBox2;
    }
}

