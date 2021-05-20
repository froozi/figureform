namespace WindowsFormsApp4
{
    partial class Form1
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
            this.pnlmenu = new System.Windows.Forms.Panel();
            this.lbl_coordinate = new System.Windows.Forms.Label();
            this.lbl_selection = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.pnlDraw = new System.Windows.Forms.Panel();
            this.trackBar1 = new System.Windows.Forms.TrackBar();
            this.lbl_thickness = new System.Windows.Forms.Label();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.button3 = new System.Windows.Forms.Button();
            this.pnlmenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlmenu
            // 
            this.pnlmenu.BackColor = System.Drawing.SystemColors.Control;
            this.pnlmenu.Controls.Add(this.button3);
            this.pnlmenu.Controls.Add(this.lbl_thickness);
            this.pnlmenu.Controls.Add(this.trackBar1);
            this.pnlmenu.Controls.Add(this.lbl_coordinate);
            this.pnlmenu.Controls.Add(this.lbl_selection);
            this.pnlmenu.Controls.Add(this.textBox1);
            this.pnlmenu.Controls.Add(this.comboBox1);
            this.pnlmenu.Controls.Add(this.button2);
            this.pnlmenu.Controls.Add(this.button1);
            this.pnlmenu.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlmenu.Location = new System.Drawing.Point(0, 0);
            this.pnlmenu.Name = "pnlmenu";
            this.pnlmenu.Size = new System.Drawing.Size(800, 114);
            this.pnlmenu.TabIndex = 0;
            // 
            // lbl_coordinate
            // 
            this.lbl_coordinate.AutoSize = true;
            this.lbl_coordinate.Location = new System.Drawing.Point(308, 9);
            this.lbl_coordinate.Name = "lbl_coordinate";
            this.lbl_coordinate.Size = new System.Drawing.Size(95, 13);
            this.lbl_coordinate.TabIndex = 5;
            this.lbl_coordinate.Text = "выбор координат";
            // 
            // lbl_selection
            // 
            this.lbl_selection.AutoSize = true;
            this.lbl_selection.Location = new System.Drawing.Point(153, 9);
            this.lbl_selection.Name = "lbl_selection";
            this.lbl_selection.Size = new System.Drawing.Size(80, 13);
            this.lbl_selection.TabIndex = 4;
            this.lbl_selection.Text = "выбор фигуры";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(311, 31);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 3;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Треугольник",
            "Круг",
            "Прямоугольник",
            "Отрезок"});
            this.comboBox1.Location = new System.Drawing.Point(138, 31);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 2;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(30, 69);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(84, 23);
            this.button2.TabIndex = 1;
            this.button2.Text = "Очистить";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(30, 28);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(84, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "Нарисовать";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // pnlDraw
            // 
            this.pnlDraw.BackColor = System.Drawing.Color.Silver;
            this.pnlDraw.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlDraw.Location = new System.Drawing.Point(0, 114);
            this.pnlDraw.Name = "pnlDraw";
            this.pnlDraw.Size = new System.Drawing.Size(800, 336);
            this.pnlDraw.TabIndex = 1;
            // 
            // trackBar1
            // 
            this.trackBar1.Location = new System.Drawing.Point(476, 28);
            this.trackBar1.Name = "trackBar1";
            this.trackBar1.Size = new System.Drawing.Size(104, 45);
            this.trackBar1.TabIndex = 0;
            // 
            // lbl_thickness
            // 
            this.lbl_thickness.AutoSize = true;
            this.lbl_thickness.Location = new System.Drawing.Point(476, 9);
            this.lbl_thickness.Name = "lbl_thickness";
            this.lbl_thickness.Size = new System.Drawing.Size(114, 13);
            this.lbl_thickness.TabIndex = 6;
            this.lbl_thickness.Text = "Изменение толщины";
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(648, 28);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(96, 23);
            this.button3.TabIndex = 7;
            this.button3.Text = "Выбор цвета";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.pnlDraw);
            this.Controls.Add(this.pnlmenu);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.pnlmenu.ResumeLayout(false);
            this.pnlmenu.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlmenu;
        private System.Windows.Forms.Label lbl_selection;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label lbl_coordinate;
        private System.Windows.Forms.Panel pnlDraw;
        private System.Windows.Forms.TrackBar trackBar1;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label lbl_thickness;
        private System.Windows.Forms.ColorDialog colorDialog1;
    }
}

