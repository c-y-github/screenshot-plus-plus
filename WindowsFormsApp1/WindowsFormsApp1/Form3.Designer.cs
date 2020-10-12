namespace WindowsFormsApp1
{
    partial class Form3
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
            this.components = new System.ComponentModel.Container();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.timer4 = new System.Windows.Forms.Timer(this.components);
            this.timer5 = new System.Windows.Forms.Timer(this.components);
            this.timer6 = new System.Windows.Forms.Timer(this.components);
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.toolStripTextBox1 = new System.Windows.Forms.ToolStripTextBox();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.contextMenuStrip2 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.框选翻译ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.箭头ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.文字ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.画笔ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.圆角矩形ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.实心圆角矩形ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.取色ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.保存ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.timer7 = new System.Windows.Forms.Timer(this.components);
            this.timer8 = new System.Windows.Forms.Timer(this.components);
            this.撤销ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenuStrip1.SuspendLayout();
            this.contextMenuStrip2.SuspendLayout();
            this.SuspendLayout();
            // 
            // timer1
            // 
            this.timer1.Interval = 1;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // timer2
            // 
            this.timer2.Interval = 1;
            this.timer2.Tick += new System.EventHandler(this.timer2_Tick);
            // 
            // timer4
            // 
            this.timer4.Interval = 1;
            this.timer4.Tick += new System.EventHandler(this.timer4_Tick);
            // 
            // timer5
            // 
            this.timer5.Interval = 1;
            this.timer5.Tick += new System.EventHandler(this.timer5_Tick);
            // 
            // timer6
            // 
            this.timer6.Interval = 1;
            this.timer6.Tick += new System.EventHandler(this.timer6_Tick);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(40, 40);
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripTextBox1,
            this.toolStripSeparator1,
            this.toolStripSeparator2});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this.contextMenuStrip1.Size = new System.Drawing.Size(121, 87);
            this.contextMenuStrip1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.contextMenuStrip1_MouseDown);
            this.contextMenuStrip1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.contextMenuStrip1_MouseUp);
            // 
            // toolStripTextBox1
            // 
            this.toolStripTextBox1.AcceptsReturn = true;
            this.toolStripTextBox1.AcceptsTab = true;
            this.toolStripTextBox1.AutoSize = false;
            this.toolStripTextBox1.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.toolStripTextBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.toolStripTextBox1.Font = new System.Drawing.Font("Segoe UI Symbol", 15.9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toolStripTextBox1.ForeColor = System.Drawing.Color.Red;
            this.toolStripTextBox1.Margin = new System.Windows.Forms.Padding(0);
            this.toolStripTextBox1.Name = "toolStripTextBox1";
            this.toolStripTextBox1.Size = new System.Drawing.Size(60, 71);
            this.toolStripTextBox1.TextBoxTextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.toolStripTextBox1.TextChanged += new System.EventHandler(this.toolStripTextBox1_TextChanged);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.BackColor = System.Drawing.Color.Black;
            this.toolStripSeparator1.ForeColor = System.Drawing.Color.Black;
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Overflow = System.Windows.Forms.ToolStripItemOverflow.Never;
            this.toolStripSeparator1.Size = new System.Drawing.Size(357, 6);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.BackColor = System.Drawing.Color.Black;
            this.toolStripSeparator2.ForeColor = System.Drawing.Color.Black;
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(357, 6);
            // 
            // contextMenuStrip2
            // 
            this.contextMenuStrip2.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.contextMenuStrip2.Font = new System.Drawing.Font("Segoe UI Symbol", 9F, System.Drawing.FontStyle.Bold);
            this.contextMenuStrip2.ImageScalingSize = new System.Drawing.Size(40, 40);
            this.contextMenuStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.框选翻译ToolStripMenuItem,
            this.箭头ToolStripMenuItem,
            this.文字ToolStripMenuItem,
            this.画笔ToolStripMenuItem,
            this.圆角矩形ToolStripMenuItem,
            this.实心圆角矩形ToolStripMenuItem,
            this.取色ToolStripMenuItem,
            this.toolStripSeparator3,
            this.保存ToolStripMenuItem,
            this.撤销ToolStripMenuItem});
            this.contextMenuStrip2.Name = "contextMenuStrip2";
            this.contextMenuStrip2.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this.contextMenuStrip2.Size = new System.Drawing.Size(361, 497);
            // 
            // 框选翻译ToolStripMenuItem
            // 
            this.框选翻译ToolStripMenuItem.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.框选翻译ToolStripMenuItem.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.框选翻译ToolStripMenuItem.Name = "框选翻译ToolStripMenuItem";
            this.框选翻译ToolStripMenuItem.Size = new System.Drawing.Size(220, 48);
            this.框选翻译ToolStripMenuItem.Text = "框选翻译";
            this.框选翻译ToolStripMenuItem.Click += new System.EventHandler(this.框选翻译ToolStripMenuItem_Click);
            // 
            // 箭头ToolStripMenuItem
            // 
            this.箭头ToolStripMenuItem.Name = "箭头ToolStripMenuItem";
            this.箭头ToolStripMenuItem.Size = new System.Drawing.Size(220, 48);
            this.箭头ToolStripMenuItem.Text = "箭头";
            this.箭头ToolStripMenuItem.Click += new System.EventHandler(this.箭头ToolStripMenuItem_Click);
            // 
            // 文字ToolStripMenuItem
            // 
            this.文字ToolStripMenuItem.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.文字ToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ControlText;
            this.文字ToolStripMenuItem.Name = "文字ToolStripMenuItem";
            this.文字ToolStripMenuItem.Size = new System.Drawing.Size(220, 48);
            this.文字ToolStripMenuItem.Text = "文字";
            this.文字ToolStripMenuItem.Click += new System.EventHandler(this.文字ToolStripMenuItem_Click);
            // 
            // 画笔ToolStripMenuItem
            // 
            this.画笔ToolStripMenuItem.Name = "画笔ToolStripMenuItem";
            this.画笔ToolStripMenuItem.Size = new System.Drawing.Size(220, 48);
            this.画笔ToolStripMenuItem.Text = "画笔";
            this.画笔ToolStripMenuItem.Click += new System.EventHandler(this.画笔ToolStripMenuItem_Click);
            // 
            // 圆角矩形ToolStripMenuItem
            // 
            this.圆角矩形ToolStripMenuItem.Name = "圆角矩形ToolStripMenuItem";
            this.圆角矩形ToolStripMenuItem.Size = new System.Drawing.Size(220, 48);
            this.圆角矩形ToolStripMenuItem.Text = "矩形";
            this.圆角矩形ToolStripMenuItem.Click += new System.EventHandler(this.圆角矩形ToolStripMenuItem_Click);
            // 
            // 实心圆角矩形ToolStripMenuItem
            // 
            this.实心圆角矩形ToolStripMenuItem.Name = "实心圆角矩形ToolStripMenuItem";
            this.实心圆角矩形ToolStripMenuItem.Size = new System.Drawing.Size(220, 48);
            this.实心圆角矩形ToolStripMenuItem.Text = "实心矩形";
            this.实心圆角矩形ToolStripMenuItem.Click += new System.EventHandler(this.实心圆角矩形ToolStripMenuItem_Click);
            // 
            // 取色ToolStripMenuItem
            // 
            this.取色ToolStripMenuItem.Name = "取色ToolStripMenuItem";
            this.取色ToolStripMenuItem.Size = new System.Drawing.Size(220, 48);
            this.取色ToolStripMenuItem.Text = "取色";
            this.取色ToolStripMenuItem.Click += new System.EventHandler(this.取色ToolStripMenuItem_Click);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(217, 6);
            // 
            // 保存ToolStripMenuItem
            // 
            this.保存ToolStripMenuItem.Name = "保存ToolStripMenuItem";
            this.保存ToolStripMenuItem.Size = new System.Drawing.Size(220, 48);
            this.保存ToolStripMenuItem.Text = "保存";
            this.保存ToolStripMenuItem.Click += new System.EventHandler(this.保存ToolStripMenuItem_Click);
            // 
            // timer7
            // 
            this.timer7.Interval = 1;
            this.timer7.Tick += new System.EventHandler(this.timer7_Tick);
            // 
            // timer8
            // 
            this.timer8.Interval = 1;
            this.timer8.Tick += new System.EventHandler(this.timer8_Tick);
            // 
            // 撤销ToolStripMenuItem
            // 
            this.撤销ToolStripMenuItem.Name = "撤销ToolStripMenuItem";
            this.撤销ToolStripMenuItem.Size = new System.Drawing.Size(360, 48);
            this.撤销ToolStripMenuItem.Text = "撤销";
            this.撤销ToolStripMenuItem.Click += new System.EventHandler(this.撤销ToolStripMenuItem_Click);
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(15F, 30F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.ContextMenuStrip = this.contextMenuStrip2;
            this.Cursor = System.Windows.Forms.Cursors.Cross;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form3";
            this.ShowInTaskbar = false;
            this.Text = "Form3";
            this.TopMost = true;
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Form3_MouseDown);
            this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Form3_MouseUp);
            this.contextMenuStrip1.ResumeLayout(false);
            this.contextMenuStrip1.PerformLayout();
            this.contextMenuStrip2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Timer timer2;
        private System.Windows.Forms.Timer timer4;
        private System.Windows.Forms.Timer timer5;
        private System.Windows.Forms.Timer timer6;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip2;
        private System.Windows.Forms.ToolStripMenuItem 框选翻译ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 箭头ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 文字ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 画笔ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 圆角矩形ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 实心圆角矩形ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 取色ToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripMenuItem 保存ToolStripMenuItem;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        private System.Windows.Forms.Timer timer7;
        public System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        public System.Windows.Forms.ToolStripTextBox toolStripTextBox1;
        private System.Windows.Forms.Timer timer8;
        private System.Windows.Forms.ToolStripMenuItem 撤销ToolStripMenuItem;
    }
}