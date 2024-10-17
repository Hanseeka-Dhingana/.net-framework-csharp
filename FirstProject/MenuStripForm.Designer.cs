
namespace FirstProject
{
    partial class MenuStripForm
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
            this.dT1 = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.fontDialog1 = new System.Windows.Forms.FontDialog();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.colorPickerByTextBoxToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.colorPickerByToolBoxToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fileDialogBoxToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.backgroundWorkerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolTipFormToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mediaPlayerFormToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dataGridViewToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bacgroundToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.backgroundColorChangeByButtonToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.backgroundColorChangeByTimeIntervalToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pictureBoxToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.textFieldToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dT1
            // 
            this.dT1.Location = new System.Drawing.Point(362, 222);
            this.dT1.Name = "dT1";
            this.dT1.Size = new System.Drawing.Size(200, 26);
            this.dT1.TabIndex = 0;
            this.dT1.ValueChanged += new System.EventHandler(this.dT1_ValueChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(344, 95);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(189, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "DateTime Picker Program";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(334, 143);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(310, 38);
            this.textBox1.TabIndex = 2;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(682, 95);
            this.button1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(159, 35);
            this.button1.TabIndex = 3;
            this.button1.Text = "Font Change";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(682, 175);
            this.button2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(159, 35);
            this.button2.TabIndex = 4;
            this.button2.Text = "without object";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(57, 95);
            this.button3.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(129, 35);
            this.button3.TabIndex = 5;
            this.button3.Text = "fore color ";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(57, 146);
            this.button4.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(129, 35);
            this.button4.TabIndex = 6;
            this.button4.Text = "Back color ";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem1});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(966, 33);
            this.menuStrip1.TabIndex = 7;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.colorPickerByTextBoxToolStripMenuItem,
            this.colorPickerByToolBoxToolStripMenuItem,
            this.fileDialogBoxToolStripMenuItem,
            this.backgroundWorkerToolStripMenuItem,
            this.toolTipFormToolStripMenuItem,
            this.mediaPlayerFormToolStripMenuItem,
            this.dataGridViewToolStripMenuItem,
            this.bacgroundToolStripMenuItem,
            this.pictureBoxToolStripMenuItem,
            this.textFieldToolStripMenuItem});
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(73, 29);
            this.toolStripMenuItem1.Text = "Menu";
            this.toolStripMenuItem1.Click += new System.EventHandler(this.toolStripMenuItem1_Click);
            // 
            // colorPickerByTextBoxToolStripMenuItem
            // 
            this.colorPickerByTextBoxToolStripMenuItem.Name = "colorPickerByTextBoxToolStripMenuItem";
            this.colorPickerByTextBoxToolStripMenuItem.Size = new System.Drawing.Size(284, 34);
            this.colorPickerByTextBoxToolStripMenuItem.Text = "ColorPickerByTextBox";
            this.colorPickerByTextBoxToolStripMenuItem.Click += new System.EventHandler(this.colorPickerByTextBoxToolStripMenuItem_Click);
            // 
            // colorPickerByToolBoxToolStripMenuItem
            // 
            this.colorPickerByToolBoxToolStripMenuItem.Name = "colorPickerByToolBoxToolStripMenuItem";
            this.colorPickerByToolBoxToolStripMenuItem.Size = new System.Drawing.Size(284, 34);
            this.colorPickerByToolBoxToolStripMenuItem.Text = "ColorPickerByToolBox";
            this.colorPickerByToolBoxToolStripMenuItem.Click += new System.EventHandler(this.colorPickerByToolBoxToolStripMenuItem_Click);
            // 
            // fileDialogBoxToolStripMenuItem
            // 
            this.fileDialogBoxToolStripMenuItem.Name = "fileDialogBoxToolStripMenuItem";
            this.fileDialogBoxToolStripMenuItem.Size = new System.Drawing.Size(284, 34);
            this.fileDialogBoxToolStripMenuItem.Text = "fileDialogBox";
            this.fileDialogBoxToolStripMenuItem.Click += new System.EventHandler(this.fileDialogBoxToolStripMenuItem_Click);
            // 
            // backgroundWorkerToolStripMenuItem
            // 
            this.backgroundWorkerToolStripMenuItem.Name = "backgroundWorkerToolStripMenuItem";
            this.backgroundWorkerToolStripMenuItem.Size = new System.Drawing.Size(284, 34);
            this.backgroundWorkerToolStripMenuItem.Text = "BackgroundWorker";
            this.backgroundWorkerToolStripMenuItem.Click += new System.EventHandler(this.backgroundWorkerToolStripMenuItem_Click);
            // 
            // toolTipFormToolStripMenuItem
            // 
            this.toolTipFormToolStripMenuItem.Name = "toolTipFormToolStripMenuItem";
            this.toolTipFormToolStripMenuItem.Size = new System.Drawing.Size(284, 34);
            this.toolTipFormToolStripMenuItem.Text = "ToolTipForm";
            this.toolTipFormToolStripMenuItem.Click += new System.EventHandler(this.toolTipFormToolStripMenuItem_Click);
            // 
            // mediaPlayerFormToolStripMenuItem
            // 
            this.mediaPlayerFormToolStripMenuItem.Name = "mediaPlayerFormToolStripMenuItem";
            this.mediaPlayerFormToolStripMenuItem.Size = new System.Drawing.Size(284, 34);
            this.mediaPlayerFormToolStripMenuItem.Text = "MediaPlayerForm";
            this.mediaPlayerFormToolStripMenuItem.Click += new System.EventHandler(this.mediaPlayerFormToolStripMenuItem_Click);
            // 
            // dataGridViewToolStripMenuItem
            // 
            this.dataGridViewToolStripMenuItem.Name = "dataGridViewToolStripMenuItem";
            this.dataGridViewToolStripMenuItem.Size = new System.Drawing.Size(284, 34);
            this.dataGridViewToolStripMenuItem.Text = "DataGridView";
            this.dataGridViewToolStripMenuItem.Click += new System.EventHandler(this.dataGridViewToolStripMenuItem_Click);
            // 
            // bacgroundToolStripMenuItem
            // 
            this.bacgroundToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.backgroundColorChangeByButtonToolStripMenuItem,
            this.backgroundColorChangeByTimeIntervalToolStripMenuItem});
            this.bacgroundToolStripMenuItem.Name = "bacgroundToolStripMenuItem";
            this.bacgroundToolStripMenuItem.Size = new System.Drawing.Size(284, 34);
            this.bacgroundToolStripMenuItem.Text = "Bacground";
            // 
            // backgroundColorChangeByButtonToolStripMenuItem
            // 
            this.backgroundColorChangeByButtonToolStripMenuItem.Name = "backgroundColorChangeByButtonToolStripMenuItem";
            this.backgroundColorChangeByButtonToolStripMenuItem.Size = new System.Drawing.Size(440, 34);
            this.backgroundColorChangeByButtonToolStripMenuItem.Text = "BackgroundColorChange by button";
            this.backgroundColorChangeByButtonToolStripMenuItem.Click += new System.EventHandler(this.backgroundColorChangeByButtonToolStripMenuItem_Click);
            // 
            // backgroundColorChangeByTimeIntervalToolStripMenuItem
            // 
            this.backgroundColorChangeByTimeIntervalToolStripMenuItem.Name = "backgroundColorChangeByTimeIntervalToolStripMenuItem";
            this.backgroundColorChangeByTimeIntervalToolStripMenuItem.Size = new System.Drawing.Size(440, 34);
            this.backgroundColorChangeByTimeIntervalToolStripMenuItem.Text = "BackgroundColorChange by time Interval";
            this.backgroundColorChangeByTimeIntervalToolStripMenuItem.Click += new System.EventHandler(this.backgroundColorChangeByTimeIntervalToolStripMenuItem_Click);
            // 
            // pictureBoxToolStripMenuItem
            // 
            this.pictureBoxToolStripMenuItem.Name = "pictureBoxToolStripMenuItem";
            this.pictureBoxToolStripMenuItem.Size = new System.Drawing.Size(284, 34);
            this.pictureBoxToolStripMenuItem.Text = "PictureBox";
            this.pictureBoxToolStripMenuItem.Click += new System.EventHandler(this.pictureBoxToolStripMenuItem_Click);
            // 
            // textFieldToolStripMenuItem
            // 
            this.textFieldToolStripMenuItem.Name = "textFieldToolStripMenuItem";
            this.textFieldToolStripMenuItem.Size = new System.Drawing.Size(284, 34);
            this.textFieldToolStripMenuItem.Text = "TextField";
            this.textFieldToolStripMenuItem.Click += new System.EventHandler(this.textFieldToolStripMenuItem_Click);
            // 
            // MenuStripForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(966, 566);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dT1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MenuStripForm";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker dT1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.FontDialog fontDialog1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.ColorDialog colorDialog1;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem colorPickerByTextBoxToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem colorPickerByToolBoxToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem fileDialogBoxToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem backgroundWorkerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolTipFormToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mediaPlayerFormToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem dataGridViewToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem bacgroundToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem backgroundColorChangeByButtonToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem backgroundColorChangeByTimeIntervalToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pictureBoxToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem textFieldToolStripMenuItem;
    }
}

