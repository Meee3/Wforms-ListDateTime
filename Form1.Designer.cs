namespace WFAula19
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.btnCarregaList = new System.Windows.Forms.Button();
            this.btnComboBox = new System.Windows.Forms.Button();
            this.btnCheckedList = new System.Windows.Forms.Button();
            this.lblDataAtual = new System.Windows.Forms.Label();
            this.lblDia = new System.Windows.Forms.Label();
            this.lblMes = new System.Windows.Forms.Label();
            this.lblAno = new System.Windows.Forms.Label();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 15;
            this.listBox1.Location = new System.Drawing.Point(12, 177);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(120, 94);
            this.listBox1.TabIndex = 0;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(154, 177);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 23);
            this.comboBox1.TabIndex = 1;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // btnCarregaList
            // 
            this.btnCarregaList.Location = new System.Drawing.Point(12, 148);
            this.btnCarregaList.Name = "btnCarregaList";
            this.btnCarregaList.Size = new System.Drawing.Size(120, 23);
            this.btnCarregaList.TabIndex = 2;
            this.btnCarregaList.Text = "Carrega List";
            this.btnCarregaList.UseVisualStyleBackColor = true;
            this.btnCarregaList.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnComboBox
            // 
            this.btnComboBox.Location = new System.Drawing.Point(154, 148);
            this.btnComboBox.Name = "btnComboBox";
            this.btnComboBox.Size = new System.Drawing.Size(120, 23);
            this.btnComboBox.TabIndex = 2;
            this.btnComboBox.Text = "ComboBox";
            this.btnComboBox.UseVisualStyleBackColor = true;
            this.btnComboBox.Click += new System.EventHandler(this.btnComboBox_Click);
            // 
            // btnCheckedList
            // 
            this.btnCheckedList.Location = new System.Drawing.Point(296, 148);
            this.btnCheckedList.Name = "btnCheckedList";
            this.btnCheckedList.Size = new System.Drawing.Size(120, 23);
            this.btnCheckedList.TabIndex = 2;
            this.btnCheckedList.Text = "CheckedList";
            this.btnCheckedList.UseVisualStyleBackColor = true;
            this.btnCheckedList.Click += new System.EventHandler(this.button3_Click);
            // 
            // lblDataAtual
            // 
            this.lblDataAtual.AutoSize = true;
            this.lblDataAtual.Location = new System.Drawing.Point(12, 29);
            this.lblDataAtual.Name = "lblDataAtual";
            this.lblDataAtual.Size = new System.Drawing.Size(10, 15);
            this.lblDataAtual.TabIndex = 5;
            this.lblDataAtual.Text = " ";
            this.lblDataAtual.Click += new System.EventHandler(this.label1_Click);
            // 
            // lblDia
            // 
            this.lblDia.AutoSize = true;
            this.lblDia.Location = new System.Drawing.Point(12, 332);
            this.lblDia.Name = "lblDia";
            this.lblDia.Size = new System.Drawing.Size(30, 15);
            this.lblDia.TabIndex = 5;
            this.lblDia.Text = "Dia: ";
            this.lblDia.Click += new System.EventHandler(this.label2_Click);
            this.lblDia.MouseMove += new System.Windows.Forms.MouseEventHandler(this.lblDia_MouseMove);
            // 
            // lblMes
            // 
            this.lblMes.AutoSize = true;
            this.lblMes.Location = new System.Drawing.Point(12, 362);
            this.lblMes.Name = "lblMes";
            this.lblMes.Size = new System.Drawing.Size(35, 15);
            this.lblMes.TabIndex = 5;
            this.lblMes.Text = "Mês: ";
            this.lblMes.Click += new System.EventHandler(this.label3_Click);
            // 
            // lblAno
            // 
            this.lblAno.AutoSize = true;
            this.lblAno.Location = new System.Drawing.Point(12, 387);
            this.lblAno.Name = "lblAno";
            this.lblAno.Size = new System.Drawing.Size(35, 15);
            this.lblAno.TabIndex = 6;
            this.lblAno.Text = "Ano: ";
            this.lblAno.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(296, 181);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(83, 19);
            this.checkBox1.TabIndex = 7;
            this.checkBox1.Text = "checkBox1";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(481, 435);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.lblAno);
            this.Controls.Add(this.lblMes);
            this.Controls.Add(this.lblDia);
            this.Controls.Add(this.lblDataAtual);
            this.Controls.Add(this.btnCheckedList);
            this.Controls.Add(this.btnComboBox);
            this.Controls.Add(this.btnCarregaList);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.listBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Activated += new System.EventHandler(this.label1_Click);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button btnCarregaList;
        private System.Windows.Forms.Button btnComboBox;
        private System.Windows.Forms.Button btnCheckedList;
        private System.Windows.Forms.Label lblDataAtual;
        private System.Windows.Forms.Label lblDia;
        private System.Windows.Forms.Label lblMes;
        private System.Windows.Forms.Label lblAno;
        private System.Windows.Forms.CheckBox checkBox1;
    }
}
