namespace ProcessManagement
{
    partial class dataGrid2
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
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.textBoxname2 = new System.Windows.Forms.TextBox();
            this.buttonAbort = new System.Windows.Forms.Button();
            this.labelCount = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView2
            // 
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Location = new System.Drawing.Point(12, 25);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.RowHeadersWidth = 51;
            this.dataGridView2.RowTemplate.Height = 24;
            this.dataGridView2.Size = new System.Drawing.Size(816, 331);
            this.dataGridView2.TabIndex = 0;
            // 
            // textBoxname2
            // 
            this.textBoxname2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxname2.Location = new System.Drawing.Point(54, 378);
            this.textBoxname2.Multiline = true;
            this.textBoxname2.Name = "textBoxname2";
            this.textBoxname2.Size = new System.Drawing.Size(124, 41);
            this.textBoxname2.TabIndex = 1;
            // 
            // buttonAbort
            // 
            this.buttonAbort.Location = new System.Drawing.Point(609, 383);
            this.buttonAbort.Name = "buttonAbort";
            this.buttonAbort.Size = new System.Drawing.Size(135, 41);
            this.buttonAbort.TabIndex = 2;
            this.buttonAbort.Text = "Завершить процесс";
            this.buttonAbort.UseVisualStyleBackColor = true;
            this.buttonAbort.Click += new System.EventHandler(this.buttonAbort_Click);
            // 
            // labelCount
            // 
            this.labelCount.AutoSize = true;
            this.labelCount.Location = new System.Drawing.Point(184, 383);
            this.labelCount.Name = "labelCount";
            this.labelCount.Size = new System.Drawing.Size(0, 16);
            this.labelCount.TabIndex = 4;
            // 
            // dataGrid2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(840, 450);
            this.Controls.Add(this.labelCount);
            this.Controls.Add(this.buttonAbort);
            this.Controls.Add(this.textBoxname2);
            this.Controls.Add(this.dataGridView2);
            this.Name = "dataGrid2";
            this.Text = "dataGrid2";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.TextBox textBoxname2;
        private System.Windows.Forms.Button buttonAbort;
        private System.Windows.Forms.Label labelCount;
    }
}