namespace ProcessManagement
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.labelproc = new System.Windows.Forms.Label();
            this.textBoxname = new System.Windows.Forms.TextBox();
            this.buttonSearch = new System.Windows.Forms.Button();
            this.labelnumeric = new System.Windows.Forms.Label();
            this.numericTimer = new System.Windows.Forms.NumericUpDown();
            this.buttonUpdate = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericTimer)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(38, 42);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(422, 342);
            this.dataGridView1.TabIndex = 0;
            // 
            // labelproc
            // 
            this.labelproc.AutoSize = true;
            this.labelproc.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelproc.Location = new System.Drawing.Point(478, 51);
            this.labelproc.Name = "labelproc";
            this.labelproc.Size = new System.Drawing.Size(248, 20);
            this.labelproc.TabIndex = 1;
            this.labelproc.Text = "введите название процесса";
            // 
            // textBoxname
            // 
            this.textBoxname.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxname.Location = new System.Drawing.Point(482, 74);
            this.textBoxname.Multiline = true;
            this.textBoxname.Name = "textBoxname";
            this.textBoxname.Size = new System.Drawing.Size(244, 29);
            this.textBoxname.TabIndex = 2;
            this.textBoxname.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // buttonSearch
            // 
            this.buttonSearch.Location = new System.Drawing.Point(554, 149);
            this.buttonSearch.Name = "buttonSearch";
            this.buttonSearch.Size = new System.Drawing.Size(94, 29);
            this.buttonSearch.TabIndex = 3;
            this.buttonSearch.Text = "ПУСК";
            this.buttonSearch.UseVisualStyleBackColor = true;
            this.buttonSearch.Click += new System.EventHandler(this.buttonSearch_Click);
            // 
            // labelnumeric
            // 
            this.labelnumeric.AutoSize = true;
            this.labelnumeric.Location = new System.Drawing.Point(35, 419);
            this.labelnumeric.Name = "labelnumeric";
            this.labelnumeric.Size = new System.Drawing.Size(386, 16);
            this.labelnumeric.TabIndex = 4;
            this.labelnumeric.Text = "Введите временной интервал для обновления процессов";
            // 
            // numericTimer
            // 
            this.numericTimer.Location = new System.Drawing.Point(38, 445);
            this.numericTimer.MaximumSize = new System.Drawing.Size(100, 0);
            this.numericTimer.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericTimer.MinimumSize = new System.Drawing.Size(1, 0);
            this.numericTimer.Name = "numericTimer";
            this.numericTimer.Size = new System.Drawing.Size(100, 22);
            this.numericTimer.TabIndex = 5;
            this.numericTimer.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // buttonUpdate
            // 
            this.buttonUpdate.Location = new System.Drawing.Point(190, 438);
            this.buttonUpdate.Name = "buttonUpdate";
            this.buttonUpdate.Size = new System.Drawing.Size(111, 35);
            this.buttonUpdate.TabIndex = 6;
            this.buttonUpdate.Text = "ОБНОВИТЬ";
            this.buttonUpdate.UseVisualStyleBackColor = true;
            this.buttonUpdate.Click += new System.EventHandler(this.buttonUpdate_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 500);
            this.Controls.Add(this.buttonUpdate);
            this.Controls.Add(this.numericTimer);
            this.Controls.Add(this.labelnumeric);
            this.Controls.Add(this.buttonSearch);
            this.Controls.Add(this.textBoxname);
            this.Controls.Add(this.labelproc);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericTimer)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label labelproc;
        private System.Windows.Forms.TextBox textBoxname;
        private System.Windows.Forms.Button buttonSearch;
        private System.Windows.Forms.Label labelnumeric;
        private System.Windows.Forms.NumericUpDown numericTimer;
        private System.Windows.Forms.Button buttonUpdate;
    }
}

