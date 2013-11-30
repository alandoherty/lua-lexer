namespace LuaParser
{
    partial class Main
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
            this.richText = new System.Windows.Forms.RichTextBox();
            this.listView1 = new System.Windows.Forms.ListView();
            this.clmError = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clmLine = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.parseTimer = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // richText
            // 
            this.richText.AcceptsTab = true;
            this.richText.Dock = System.Windows.Forms.DockStyle.Top;
            this.richText.Location = new System.Drawing.Point(0, 0);
            this.richText.Name = "richText";
            this.richText.Size = new System.Drawing.Size(634, 393);
            this.richText.TabIndex = 0;
            this.richText.Text = "";
            this.richText.TextChanged += new System.EventHandler(this.richText_TextChanged);
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.clmError,
            this.clmLine});
            this.listView1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.listView1.GridLines = true;
            this.listView1.Location = new System.Drawing.Point(0, 399);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(634, 113);
            this.listView1.TabIndex = 1;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            // 
            // clmError
            // 
            this.clmError.Text = "Error";
            // 
            // clmLine
            // 
            this.clmLine.Text = "Line";
            // 
            // parseTimer
            // 
            this.parseTimer.Enabled = true;
            this.parseTimer.Interval = 500;
            this.parseTimer.Tick += new System.EventHandler(this.parseTimer_Tick);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(634, 512);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.richText);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Main";
            this.Text = "Lua Stuff";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RichTextBox richText;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader clmError;
        private System.Windows.Forms.ColumnHeader clmLine;
        private System.Windows.Forms.Timer parseTimer;
    }
}

