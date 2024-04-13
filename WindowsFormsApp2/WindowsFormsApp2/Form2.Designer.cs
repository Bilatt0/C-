
namespace WindowsFormsApp2
{
    partial class Form2
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
            this.monthCalendar1 = new System.Windows.Forms.MonthCalendar();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.h01 = new System.Windows.Forms.Label();
            this.h02 = new System.Windows.Forms.Label();
            this.h03 = new System.Windows.Forms.Label();
            this.h04 = new System.Windows.Forms.Label();
            this.h05 = new System.Windows.Forms.Label();
            this.d01 = new System.Windows.Forms.Label();
            this.d02 = new System.Windows.Forms.Label();
            this.d03 = new System.Windows.Forms.Label();
            this.d04 = new System.Windows.Forms.Label();
            this.d05 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // monthCalendar1
            // 
            this.monthCalendar1.Location = new System.Drawing.Point(18, 47);
            this.monthCalendar1.Name = "monthCalendar1";
            this.monthCalendar1.TabIndex = 0;
            this.monthCalendar1.DateChanged += new System.Windows.Forms.DateRangeEventHandler(this.monthCalendar1_DateChanged);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(254, 12);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(321, 20);
            this.textBox1.TabIndex = 1;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(295, 38);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(280, 20);
            this.textBox2.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(257, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Nome:";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.OutsetDouble;
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 24.92212F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 75.07788F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Controls.Add(this.h01, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.h02, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.h03, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.h04, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.h05, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.d01, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.d02, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.d03, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.d04, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.d05, 1, 4);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(254, 64);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 5;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 26F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 24F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(321, 145);
            this.tableLayoutPanel1.TabIndex = 4;
            this.tableLayoutPanel1.Paint += new System.Windows.Forms.PaintEventHandler(this.tableLayoutPanel1_Paint);
            // 
            // h01
            // 
            this.h01.AutoSize = true;
            this.h01.Dock = System.Windows.Forms.DockStyle.Fill;
            this.h01.Location = new System.Drawing.Point(6, 3);
            this.h01.Name = "h01";
            this.h01.Size = new System.Drawing.Size(71, 26);
            this.h01.TabIndex = 0;
            this.h01.Text = "08:00";
            this.h01.Click += new System.EventHandler(this.d01_Click);
            // 
            // h02
            // 
            this.h02.AutoSize = true;
            this.h02.Dock = System.Windows.Forms.DockStyle.Fill;
            this.h02.Location = new System.Drawing.Point(6, 32);
            this.h02.Name = "h02";
            this.h02.Size = new System.Drawing.Size(71, 26);
            this.h02.TabIndex = 1;
            this.h02.Text = "09:00";
            // 
            // h03
            // 
            this.h03.AutoSize = true;
            this.h03.Dock = System.Windows.Forms.DockStyle.Fill;
            this.h03.Location = new System.Drawing.Point(6, 61);
            this.h03.Name = "h03";
            this.h03.Size = new System.Drawing.Size(71, 26);
            this.h03.TabIndex = 2;
            this.h03.Text = "10:00";
            // 
            // h04
            // 
            this.h04.AutoSize = true;
            this.h04.Dock = System.Windows.Forms.DockStyle.Fill;
            this.h04.Location = new System.Drawing.Point(6, 90);
            this.h04.Name = "h04";
            this.h04.Size = new System.Drawing.Size(71, 25);
            this.h04.TabIndex = 3;
            this.h04.Text = "11:00";
            // 
            // h05
            // 
            this.h05.AutoSize = true;
            this.h05.Dock = System.Windows.Forms.DockStyle.Fill;
            this.h05.Location = new System.Drawing.Point(6, 118);
            this.h05.Name = "h05";
            this.h05.Size = new System.Drawing.Size(71, 24);
            this.h05.TabIndex = 4;
            this.h05.Text = "12:00";
            // 
            // d01
            // 
            this.d01.AutoSize = true;
            this.d01.Dock = System.Windows.Forms.DockStyle.Fill;
            this.d01.Location = new System.Drawing.Point(86, 3);
            this.d01.Name = "d01";
            this.d01.Size = new System.Drawing.Size(229, 26);
            this.d01.TabIndex = 5;
            this.d01.Text = "Disponivel";
            this.d01.Click += new System.EventHandler(this.d01_Click);
            // 
            // d02
            // 
            this.d02.AutoSize = true;
            this.d02.Dock = System.Windows.Forms.DockStyle.Fill;
            this.d02.Location = new System.Drawing.Point(86, 32);
            this.d02.Name = "d02";
            this.d02.Size = new System.Drawing.Size(229, 26);
            this.d02.TabIndex = 6;
            this.d02.Text = "Disponivel";
            this.d02.Click += new System.EventHandler(this.d02_Click);
            // 
            // d03
            // 
            this.d03.AutoSize = true;
            this.d03.Dock = System.Windows.Forms.DockStyle.Fill;
            this.d03.Location = new System.Drawing.Point(86, 61);
            this.d03.Name = "d03";
            this.d03.Size = new System.Drawing.Size(229, 26);
            this.d03.TabIndex = 7;
            this.d03.Text = "Disponivel";
            this.d03.Click += new System.EventHandler(this.d03_Click);
            // 
            // d04
            // 
            this.d04.AutoSize = true;
            this.d04.Dock = System.Windows.Forms.DockStyle.Fill;
            this.d04.Location = new System.Drawing.Point(86, 90);
            this.d04.Name = "d04";
            this.d04.Size = new System.Drawing.Size(229, 25);
            this.d04.TabIndex = 8;
            this.d04.Text = "Disponivel";
            this.d04.Click += new System.EventHandler(this.d04_Click);
            // 
            // d05
            // 
            this.d05.AutoSize = true;
            this.d05.Dock = System.Windows.Forms.DockStyle.Fill;
            this.d05.Location = new System.Drawing.Point(86, 118);
            this.d05.Name = "d05";
            this.d05.Size = new System.Drawing.Size(229, 24);
            this.d05.TabIndex = 9;
            this.d05.Text = "Disponivel";
            this.d05.Click += new System.EventHandler(this.d05_Click);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(18, 221);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(227, 35);
            this.button1.TabIndex = 5;
            this.button1.Text = "Gerar Arquivo";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(254, 221);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(322, 35);
            this.button2.TabIndex = 6;
            this.button2.Text = "Agendar";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(588, 267);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.monthCalendar1);
            this.Name = "Form2";
            this.Text = "Form2";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MonthCalendar monthCalendar1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label h01;
        private System.Windows.Forms.Label h02;
        private System.Windows.Forms.Label h03;
        private System.Windows.Forms.Label h04;
        private System.Windows.Forms.Label h05;
        private System.Windows.Forms.Label d01;
        private System.Windows.Forms.Label d02;
        private System.Windows.Forms.Label d03;
        private System.Windows.Forms.Label d04;
        private System.Windows.Forms.Label d05;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}