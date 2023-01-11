namespace Kursovoi
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
			this.label1 = new System.Windows.Forms.Label();
			this.textBox = new System.Windows.Forms.TextBox();
			this.analyzBtn = new System.Windows.Forms.Button();
			this.listBox1 = new System.Windows.Forms.ListBox();
			this.label2 = new System.Windows.Forms.Label();
			this.variablesList = new System.Windows.Forms.ListBox();
			this.label3 = new System.Windows.Forms.Label();
			this.listBox3 = new System.Windows.Forms.ListBox();
			this.label4 = new System.Windows.Forms.Label();
			this.addBtn = new System.Windows.Forms.Button();
			this.comboBox1 = new System.Windows.Forms.ComboBox();
			this.valueBox = new System.Windows.Forms.TextBox();
			this.valueLabel = new System.Windows.Forms.Label();
			this.nameLabel = new System.Windows.Forms.Label();
			this.nameBox = new System.Windows.Forms.TextBox();
			this.log = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
			this.label1.Location = new System.Drawing.Point(184, 20);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(84, 28);
			this.label1.TabIndex = 0;
			this.label1.Text = "Данные";
			// 
			// textBox
			// 
			this.textBox.BackColor = System.Drawing.Color.DarkGray;
			this.textBox.ForeColor = System.Drawing.Color.MidnightBlue;
			this.textBox.Location = new System.Drawing.Point(33, 51);
			this.textBox.Multiline = true;
			this.textBox.Name = "textBox";
			this.textBox.Size = new System.Drawing.Size(387, 205);
			this.textBox.TabIndex = 1;
			// 
			// analyzBtn
			// 
			this.analyzBtn.BackColor = System.Drawing.Color.SkyBlue;
			this.analyzBtn.Location = new System.Drawing.Point(352, 448);
			this.analyzBtn.Name = "analyzBtn";
			this.analyzBtn.Size = new System.Drawing.Size(235, 29);
			this.analyzBtn.TabIndex = 7;
			this.analyzBtn.Text = "Произвести парсинг";
			this.analyzBtn.UseVisualStyleBackColor = false;
			this.analyzBtn.Click += new System.EventHandler(this.analyzeBtn_Click);
			// 
			// listBox1
			// 
			this.listBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
			this.listBox1.FormattingEnabled = true;
			this.listBox1.ItemHeight = 20;
			this.listBox1.Location = new System.Drawing.Point(36, 287);
			this.listBox1.Name = "listBox1";
			this.listBox1.SelectionMode = System.Windows.Forms.SelectionMode.None;
			this.listBox1.Size = new System.Drawing.Size(199, 144);
			this.listBox1.TabIndex = 4;
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.label2.ForeColor = System.Drawing.Color.Red;
			this.label2.Location = new System.Drawing.Point(36, 259);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(93, 23);
			this.label2.TabIndex = 5;
			this.label2.Text = "Константы";
			// 
			// variablesList
			// 
			this.variablesList.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
			this.variablesList.FormattingEnabled = true;
			this.variablesList.ItemHeight = 20;
			this.variablesList.Location = new System.Drawing.Point(447, 287);
			this.variablesList.Name = "variablesList";
			this.variablesList.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended;
			this.variablesList.Size = new System.Drawing.Size(206, 144);
			this.variablesList.TabIndex = 6;
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.label3.ForeColor = System.Drawing.Color.Yellow;
			this.label3.Location = new System.Drawing.Point(447, 259);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(112, 23);
			this.label3.TabIndex = 7;
			this.label3.Text = "Переменные";
			// 
			// listBox3
			// 
			this.listBox3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
			this.listBox3.FormattingEnabled = true;
			this.listBox3.ItemHeight = 20;
			this.listBox3.Location = new System.Drawing.Point(241, 287);
			this.listBox3.Name = "listBox3";
			this.listBox3.SelectionMode = System.Windows.Forms.SelectionMode.None;
			this.listBox3.Size = new System.Drawing.Size(187, 144);
			this.listBox3.TabIndex = 8;
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.label4.ForeColor = System.Drawing.Color.Lime;
			this.label4.Location = new System.Drawing.Point(241, 259);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(57, 23);
			this.label4.TabIndex = 9;
			this.label4.Text = "Связи";
			// 
			// addBtn
			// 
			this.addBtn.Location = new System.Drawing.Point(515, 145);
			this.addBtn.Name = "addBtn";
			this.addBtn.Size = new System.Drawing.Size(138, 29);
			this.addBtn.TabIndex = 4;
			this.addBtn.Text = "Добавить";
			this.addBtn.UseVisualStyleBackColor = true;
			this.addBtn.Click += new System.EventHandler(this.addBtn_Click);
			// 
			// comboBox1
			// 
			this.comboBox1.FormattingEnabled = true;
			this.comboBox1.Items.AddRange(new object[] {
            "Константу",
            "Переменную",
            "Связи"});
			this.comboBox1.Location = new System.Drawing.Point(515, 201);
			this.comboBox1.Name = "comboBox1";
			this.comboBox1.Size = new System.Drawing.Size(138, 28);
			this.comboBox1.TabIndex = 5;
			this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
			// 
			// valueBox
			// 
			this.valueBox.Location = new System.Drawing.Point(515, 96);
			this.valueBox.Name = "valueBox";
			this.valueBox.Size = new System.Drawing.Size(137, 27);
			this.valueBox.TabIndex = 3;
			this.valueBox.Visible = false;
			// 
			// valueLabel
			// 
			this.valueLabel.AutoSize = true;
			this.valueLabel.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
			this.valueLabel.Location = new System.Drawing.Point(424, 96);
			this.valueLabel.Name = "valueLabel";
			this.valueLabel.Size = new System.Drawing.Size(79, 20);
			this.valueLabel.TabIndex = 13;
			this.valueLabel.Text = "Значение:";
			// 
			// nameLabel
			// 
			this.nameLabel.AutoSize = true;
			this.nameLabel.BackColor = System.Drawing.Color.Transparent;
			this.nameLabel.ForeColor = System.Drawing.Color.Transparent;
			this.nameLabel.Location = new System.Drawing.Point(435, 51);
			this.nameLabel.Name = "nameLabel";
			this.nameLabel.Size = new System.Drawing.Size(42, 20);
			this.nameLabel.TabIndex = 14;
			this.nameLabel.Text = "Имя:";
			this.nameLabel.Visible = false;
			// 
			// nameBox
			// 
			this.nameBox.Location = new System.Drawing.Point(515, 48);
			this.nameBox.Name = "nameBox";
			this.nameBox.Size = new System.Drawing.Size(137, 27);
			this.nameBox.TabIndex = 2;
			this.nameBox.Visible = false;
			// 
			// log
			// 
			this.log.BackColor = System.Drawing.Color.LightSkyBlue;
			this.log.Location = new System.Drawing.Point(184, 448);
			this.log.Name = "log";
			this.log.Size = new System.Drawing.Size(117, 29);
			this.log.TabIndex = 15;
			this.log.Text = "Логирование";
			this.log.UseVisualStyleBackColor = false;
			this.log.Click += new System.EventHandler(this.button1_Click);
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.DarkBlue;
			this.ClientSize = new System.Drawing.Size(697, 509);
			this.Controls.Add(this.log);
			this.Controls.Add(this.nameBox);
			this.Controls.Add(this.nameLabel);
			this.Controls.Add(this.valueLabel);
			this.Controls.Add(this.valueBox);
			this.Controls.Add(this.comboBox1);
			this.Controls.Add(this.addBtn);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.listBox3);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.variablesList);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.listBox1);
			this.Controls.Add(this.analyzBtn);
			this.Controls.Add(this.textBox);
			this.Controls.Add(this.label1);
			this.Name = "Form1";
			this.Text = "АППО";
			this.Load += new System.EventHandler(this.Form1_Load);
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion

        private Label label1;
        private TextBox textBox;
        private Button analyzBtn;
        private ListBox listBox1;
        private Label label2;
        public ListBox variablesList;
        private Label label3;
        private ListBox listBox3;
        private Label label4;
        private Button addBtn;
        private ComboBox comboBox1;
        private TextBox valueBox;
        private Label valueLabel;
        private Label nameLabel;
        private TextBox nameBox;
		private Button log;
	}
}