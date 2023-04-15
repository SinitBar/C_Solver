namespace C_Solver
{
    partial class Form
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
            this.buttonOpenFile = new System.Windows.Forms.Button();
            this.buttonRun = new System.Windows.Forms.Button();
            this.labelResult = new System.Windows.Forms.Label();
            this.labelVC1 = new System.Windows.Forms.Label();
            this.labelVC2 = new System.Windows.Forms.Label();
            this.labelVC3 = new System.Windows.Forms.Label();
            this.labelVC4 = new System.Windows.Forms.Label();
            this.labelC1 = new System.Windows.Forms.Label();
            this.labelC2 = new System.Windows.Forms.Label();
            this.labelC3 = new System.Windows.Forms.Label();
            this.labelC4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // buttonOpenFile
            // 
            this.buttonOpenFile.Location = new System.Drawing.Point(12, 12);
            this.buttonOpenFile.Name = "buttonOpenFile";
            this.buttonOpenFile.Size = new System.Drawing.Size(378, 65);
            this.buttonOpenFile.TabIndex = 0;
            this.buttonOpenFile.Text = "Открыть файл txt с матрицей смежности";
            this.buttonOpenFile.UseVisualStyleBackColor = true;
            this.buttonOpenFile.Click += new System.EventHandler(this.buttonOpenFile_Click);
            // 
            // buttonRun
            // 
            this.buttonRun.Location = new System.Drawing.Point(410, 12);
            this.buttonRun.Name = "buttonRun";
            this.buttonRun.Size = new System.Drawing.Size(378, 65);
            this.buttonRun.TabIndex = 2;
            this.buttonRun.Text = "Выполнить алгоритм";
            this.buttonRun.UseVisualStyleBackColor = true;
            this.buttonRun.Click += new System.EventHandler(this.buttonRun_Click);
            // 
            // labelResult
            // 
            this.labelResult.AutoSize = true;
            this.labelResult.Location = new System.Drawing.Point(12, 100);
            this.labelResult.Name = "labelResult";
            this.labelResult.Size = new System.Drawing.Size(199, 25);
            this.labelResult.TabIndex = 3;
            this.labelResult.Text = "Результат выполнения:";
            // 
            // labelVC1
            // 
            this.labelVC1.AutoSize = true;
            this.labelVC1.Location = new System.Drawing.Point(12, 140);
            this.labelVC1.Name = "labelVC1";
            this.labelVC1.Size = new System.Drawing.Size(185, 25);
            this.labelVC1.TabIndex = 4;
            this.labelVC1.Text = "Список вершин в C1:";
            // 
            // labelVC2
            // 
            this.labelVC2.AutoSize = true;
            this.labelVC2.Location = new System.Drawing.Point(12, 180);
            this.labelVC2.Name = "labelVC2";
            this.labelVC2.Size = new System.Drawing.Size(185, 25);
            this.labelVC2.TabIndex = 5;
            this.labelVC2.Text = "Список вершин в C2:";
            // 
            // labelVC3
            // 
            this.labelVC3.AutoSize = true;
            this.labelVC3.Location = new System.Drawing.Point(12, 220);
            this.labelVC3.Name = "labelVC3";
            this.labelVC3.Size = new System.Drawing.Size(185, 25);
            this.labelVC3.TabIndex = 6;
            this.labelVC3.Text = "Список вершин в C3:";
            // 
            // labelVC4
            // 
            this.labelVC4.AutoSize = true;
            this.labelVC4.Location = new System.Drawing.Point(12, 260);
            this.labelVC4.Name = "labelVC4";
            this.labelVC4.Size = new System.Drawing.Size(185, 25);
            this.labelVC4.TabIndex = 7;
            this.labelVC4.Text = "Список вершин в C4:";
            // 
            // labelC1
            // 
            this.labelC1.AutoSize = true;
            this.labelC1.Location = new System.Drawing.Point(200, 140);
            this.labelC1.Name = "labelC1";
            this.labelC1.Size = new System.Drawing.Size(33, 25);
            this.labelC1.TabIndex = 8;
            this.labelC1.Text = "C1";
            // 
            // labelC2
            // 
            this.labelC2.AutoSize = true;
            this.labelC2.Location = new System.Drawing.Point(200, 180);
            this.labelC2.Name = "labelC2";
            this.labelC2.Size = new System.Drawing.Size(33, 25);
            this.labelC2.TabIndex = 9;
            this.labelC2.Text = "C2";
            // 
            // labelC3
            // 
            this.labelC3.AutoSize = true;
            this.labelC3.Location = new System.Drawing.Point(200, 220);
            this.labelC3.Name = "labelC3";
            this.labelC3.Size = new System.Drawing.Size(33, 25);
            this.labelC3.TabIndex = 10;
            this.labelC3.Text = "C3";
            // 
            // labelC4
            // 
            this.labelC4.AutoSize = true;
            this.labelC4.Location = new System.Drawing.Point(200, 260);
            this.labelC4.Name = "labelC4";
            this.labelC4.Size = new System.Drawing.Size(33, 25);
            this.labelC4.TabIndex = 11;
            this.labelC4.Text = "C4";
            // 
            // Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 311);
            this.Controls.Add(this.labelC4);
            this.Controls.Add(this.labelC3);
            this.Controls.Add(this.labelC2);
            this.Controls.Add(this.labelC1);
            this.Controls.Add(this.labelVC4);
            this.Controls.Add(this.labelVC3);
            this.Controls.Add(this.labelVC2);
            this.Controls.Add(this.labelVC1);
            this.Controls.Add(this.labelResult);
            this.Controls.Add(this.buttonRun);
            this.Controls.Add(this.buttonOpenFile);
            this.Name = "Form";
            this.Text = "Разделение на подсхемы";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button buttonOpenFile;
        private Button buttonRun;
        private Label labelResult;
        private Label labelVC1;
        private Label labelVC2;
        private Label labelVC3;
        private Label labelVC4;
        private Label labelC1;
        private Label labelC2;
        private Label labelC3;
        private Label labelC4;
    }
}