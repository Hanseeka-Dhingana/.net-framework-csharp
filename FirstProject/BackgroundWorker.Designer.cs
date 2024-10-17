
namespace FirstProject
{
    partial class BackgroundWorker
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
            this.panel = new System.Windows.Forms.FlowLayoutPanel();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.b1 = new System.Windows.Forms.Button();
            this.BGW1 = new System.ComponentModel.BackgroundWorker();
            this.SuspendLayout();
            // 
            // panel
            // 
            this.panel.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel.Location = new System.Drawing.Point(0, 0);
            this.panel.Name = "panel";
            this.panel.Size = new System.Drawing.Size(958, 120);
            this.panel.TabIndex = 0;
            this.panel.Paint += new System.Windows.Forms.PaintEventHandler(this.flowLayoutPanel1_Paint);
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(355, 160);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(221, 31);
            this.progressBar1.TabIndex = 1;
            // 
            // b1
            // 
            this.b1.Location = new System.Drawing.Point(403, 232);
            this.b1.Name = "b1";
            this.b1.Size = new System.Drawing.Size(123, 48);
            this.b1.TabIndex = 2;
            this.b1.Text = "Execute";
            this.b1.UseVisualStyleBackColor = true;
            this.b1.Click += new System.EventHandler(this.b1_Click);
            // 
            // BGW1
            // 
            this.BGW1.WorkerReportsProgress = true;
            this.BGW1.DoWork += new System.ComponentModel.DoWorkEventHandler(this.BGW1_DoWork);
            this.BGW1.ProgressChanged += new System.ComponentModel.ProgressChangedEventHandler(this.BGW1_ProgressChanged);
            this.BGW1.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.BGW1_RunWorkerCompleted);
            // 
            // BackgroundWorker
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(958, 544);
            this.Controls.Add(this.b1);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.panel);
            this.Name = "BackgroundWorker";
            this.Text = "Form3";
            this.Load += new System.EventHandler(this.Form3_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel panel;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.Button b1;
        private System.ComponentModel.BackgroundWorker BGW1;
    }
}