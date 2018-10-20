namespace Assign2
{
    partial class Form1
    {
     
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
            this.clearButton = new System.Windows.Forms.Button();
            this.okButton = new System.Windows.Forms.Button();
            this.l = new System.Windows.Forms.Label();
            this.l1 = new System.Windows.Forms.Label();
            this.l2 = new System.Windows.Forms.Label();
            this.t1 = new System.Windows.Forms.TextBox();
            this.t2 = new System.Windows.Forms.TextBox();
            this.t3 = new System.Windows.Forms.TextBox();
            this.gb = new System.Windows.Forms.GroupBox();
            this.radio8 = new System.Windows.Forms.RadioButton();
            this.radio7 = new System.Windows.Forms.RadioButton();
            this.radio6 = new System.Windows.Forms.RadioButton();
            this.radio5 = new System.Windows.Forms.RadioButton();
            this.radio4 = new System.Windows.Forms.RadioButton();
            this.radio3 = new System.Windows.Forms.RadioButton();
            this.radio2 = new System.Windows.Forms.RadioButton();
            this.radio1 = new System.Windows.Forms.RadioButton();
            this.RESULTS = new System.Windows.Forms.ListBox();
            this.gb.SuspendLayout();
            this.SuspendLayout();
            // 
            // clearButton
            // 
            this.clearButton.BackColor = System.Drawing.Color.Red;
            this.clearButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.clearButton.Cursor = System.Windows.Forms.Cursors.WaitCursor;
            this.clearButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.clearButton.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clearButton.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.clearButton.Location = new System.Drawing.Point(422, 206);
            this.clearButton.Name = "clearButton";
            this.clearButton.Size = new System.Drawing.Size(104, 47);
            this.clearButton.TabIndex = 0;
            this.clearButton.Text = "Cancel";
            this.clearButton.UseMnemonic = false;
            this.clearButton.UseVisualStyleBackColor = false;
            this.clearButton.UseWaitCursor = true;
            this.clearButton.Click += new System.EventHandler(this.cancel_Click);
            // 
            // okButton
            // 
            this.okButton.BackColor = System.Drawing.Color.Chartreuse;
            this.okButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.okButton.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.okButton.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.okButton.Location = new System.Drawing.Point(304, 206);
            this.okButton.Name = "okButton";
            this.okButton.Size = new System.Drawing.Size(106, 47);
            this.okButton.TabIndex = 1;
            this.okButton.Text = "Enter";
            this.okButton.UseMnemonic = false;
            this.okButton.UseVisualStyleBackColor = false;
            this.okButton.UseWaitCursor = true;
            this.okButton.Click += new System.EventHandler(this.ok_Click);
            // 
            // l
            // 
            this.l.AutoSize = true;
            this.l.Font = new System.Drawing.Font("Monotype Corsiva", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.l.Location = new System.Drawing.Point(358, 58);
            this.l.Name = "l";
            this.l.Size = new System.Drawing.Size(49, 20);
            this.l.TabIndex = 2;
            this.l.Text = "Name";
            this.l.UseWaitCursor = true;
            // 
            // l1
            // 
            this.l1.AutoSize = true;
            this.l1.Font = new System.Drawing.Font("Monotype Corsiva", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.l1.Location = new System.Drawing.Point(300, 97);
            this.l1.Name = "l1";
            this.l1.Size = new System.Drawing.Size(107, 20);
            this.l1.TabIndex = 3;
            this.l1.Text = "OfficeNumber";
            this.l1.UseWaitCursor = true;
            // 
            // l2
            // 
            this.l2.AutoSize = true;
            this.l2.Font = new System.Drawing.Font("Monotype Corsiva", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.l2.Location = new System.Drawing.Point(271, 135);
            this.l2.Name = "l2";
            this.l2.Size = new System.Drawing.Size(136, 20);
            this.l2.TabIndex = 4;
            this.l2.Text = "TelephoneNumber";
            this.l2.UseWaitCursor = true;
            this.l2.Click += new System.EventHandler(this.Label_Click);
            // 
            // t1
            // 
            this.t1.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.t1.Location = new System.Drawing.Point(422, 51);
            this.t1.Name = "t1";
            this.t1.Size = new System.Drawing.Size(104, 27);
            this.t1.TabIndex = 5;
            this.t1.UseWaitCursor = true;
            // 
            // t2
            // 
            this.t2.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.t2.Location = new System.Drawing.Point(422, 97);
            this.t2.Name = "t2";
            this.t2.Size = new System.Drawing.Size(104, 27);
            this.t2.TabIndex = 6;
            this.t2.UseWaitCursor = true;
            this.t2.TextChanged += new System.EventHandler(this.Tb2_TextChanged);
            // 
            // t3
            // 
            this.t3.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.t3.Location = new System.Drawing.Point(422, 135);
            this.t3.Name = "t3";
            this.t3.Size = new System.Drawing.Size(104, 27);
            this.t3.TabIndex = 7;
            this.t3.UseWaitCursor = true;
            // 
            // gb
            // 
            this.gb.BackColor = System.Drawing.Color.LightSalmon;
            this.gb.Controls.Add(this.radio8);
            this.gb.Controls.Add(this.radio7);
            this.gb.Controls.Add(this.clearButton);
            this.gb.Controls.Add(this.okButton);
            this.gb.Controls.Add(this.t3);
            this.gb.Controls.Add(this.radio6);
            this.gb.Controls.Add(this.l2);
            this.gb.Controls.Add(this.t2);
            this.gb.Controls.Add(this.radio5);
            this.gb.Controls.Add(this.t1);
            this.gb.Controls.Add(this.l1);
            this.gb.Controls.Add(this.radio4);
            this.gb.Controls.Add(this.radio3);
            this.gb.Controls.Add(this.radio2);
            this.gb.Controls.Add(this.l);
            this.gb.Controls.Add(this.radio1);
            this.gb.Cursor = System.Windows.Forms.Cursors.WaitCursor;
            this.gb.Dock = System.Windows.Forms.DockStyle.Left;
            this.gb.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gb.Location = new System.Drawing.Point(0, 0);
            this.gb.Name = "gb";
            this.gb.Padding = new System.Windows.Forms.Padding(0, 1, 2, 3);
            this.gb.Size = new System.Drawing.Size(540, 470);
            this.gb.TabIndex = 9;
            this.gb.TabStop = false;
            this.gb.Text = "Select from the given options";
            this.gb.UseWaitCursor = true;
            // 
            // radio8
            // 
            this.radio8.AutoSize = true;
            this.radio8.Location = new System.Drawing.Point(14, 371);
            this.radio8.Name = "radio8";
            this.radio8.Size = new System.Drawing.Size(64, 23);
            this.radio8.TabIndex = 7;
            this.radio8.TabStop = true;
            this.radio8.Text = "Quit";
            this.radio8.UseVisualStyleBackColor = true;
            this.radio8.UseWaitCursor = true;
            this.radio8.CheckedChanged += new System.EventHandler(this.RadioButtons_CheckChanged);
            // 
            // radio7
            // 
            this.radio7.AutoSize = true;
            this.radio7.Location = new System.Drawing.Point(13, 325);
            this.radio7.Name = "radio7";
            this.radio7.Size = new System.Drawing.Size(118, 23);
            this.radio7.TabIndex = 6;
            this.radio7.TabStop = true;
            this.radio7.Text = "Sort the list";
            this.radio7.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.radio7.UseVisualStyleBackColor = false;
            this.radio7.UseWaitCursor = true;
            this.radio7.CheckedChanged += new System.EventHandler(this.RadioButtons_CheckChanged);
            // 
            // radio6
            // 
            this.radio6.AutoSize = true;
            this.radio6.ForeColor = System.Drawing.Color.Black;
            this.radio6.Location = new System.Drawing.Point(13, 276);
            this.radio6.Name = "radio6";
            this.radio6.Size = new System.Drawing.Size(191, 23);
            this.radio6.TabIndex = 5;
            this.radio6.TabStop = true;
            this.radio6.Text = "Update OfficeNumber";
            this.radio6.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.radio6.UseVisualStyleBackColor = false;
            this.radio6.UseWaitCursor = true;
            this.radio6.CheckedChanged += new System.EventHandler(this.RadioButtons_CheckChanged);
            // 
            // radio5
            // 
            this.radio5.AutoSize = true;
            this.radio5.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radio5.Location = new System.Drawing.Point(14, 228);
            this.radio5.Name = "radio5";
            this.radio5.Size = new System.Drawing.Size(244, 23);
            this.radio5.TabIndex = 4;
            this.radio5.TabStop = true;
            this.radio5.Text = "Search for TelephoneNumber";
            this.radio5.UseVisualStyleBackColor = false;
            this.radio5.UseWaitCursor = true;
            this.radio5.CheckedChanged += new System.EventHandler(this.RadioButtons_CheckChanged);
            // 
            // radio4
            // 
            this.radio4.AutoSize = true;
            this.radio4.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radio4.Location = new System.Drawing.Point(14, 181);
            this.radio4.Name = "radio4";
            this.radio4.Size = new System.Drawing.Size(219, 23);
            this.radio4.TabIndex = 3;
            this.radio4.TabStop = true;
            this.radio4.Text = "Search for Office Number";
            this.radio4.UseVisualStyleBackColor = true;
            this.radio4.UseWaitCursor = true;
            this.radio4.CheckedChanged += new System.EventHandler(this.RadioButtons_CheckChanged);
            // 
            // radio3
            // 
            this.radio3.AutoSize = true;
            this.radio3.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radio3.Location = new System.Drawing.Point(13, 132);
            this.radio3.Name = "radio3";
            this.radio3.Size = new System.Drawing.Size(149, 23);
            this.radio3.TabIndex = 2;
            this.radio3.TabStop = true;
            this.radio3.Text = "Search for name";
            this.radio3.UseVisualStyleBackColor = true;
            this.radio3.UseWaitCursor = true;
            this.radio3.CheckedChanged += new System.EventHandler(this.RadioButtons_CheckChanged);
            // 
            // radio2
            // 
            this.radio2.AutoSize = true;
            this.radio2.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radio2.Location = new System.Drawing.Point(14, 87);
            this.radio2.Name = "radio2";
            this.radio2.Size = new System.Drawing.Size(123, 23);
            this.radio2.TabIndex = 1;
            this.radio2.TabStop = true;
            this.radio2.Text = "Add an entry";
            this.radio2.UseVisualStyleBackColor = true;
            this.radio2.UseWaitCursor = true;
            this.radio2.CheckedChanged += new System.EventHandler(this.RadioButtons_CheckChanged);
            // 
            // radio1
            // 
            this.radio1.AutoSize = true;
            this.radio1.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radio1.Location = new System.Drawing.Point(14, 50);
            this.radio1.Name = "radio1";
            this.radio1.Size = new System.Drawing.Size(99, 23);
            this.radio1.TabIndex = 0;
            this.radio1.TabStop = true;
            this.radio1.Text = "Print list";
            this.radio1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.radio1.UseVisualStyleBackColor = true;
            this.radio1.UseWaitCursor = true;
            this.radio1.CheckedChanged += new System.EventHandler(this.RadioButtons_CheckChanged);
            // 
            // RESULTS
            // 
            this.RESULTS.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.RESULTS.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.RESULTS.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.RESULTS.Cursor = System.Windows.Forms.Cursors.WaitCursor;
            this.RESULTS.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RESULTS.ForeColor = System.Drawing.SystemColors.Desktop;
            this.RESULTS.FormattingEnabled = true;
            this.RESULTS.HorizontalScrollbar = true;
            this.RESULTS.ImeMode = System.Windows.Forms.ImeMode.AlphaFull;
            this.RESULTS.ItemHeight = 19;
            this.RESULTS.Location = new System.Drawing.Point(566, 12);
            this.RESULTS.Margin = new System.Windows.Forms.Padding(5);
            this.RESULTS.Name = "RESULTS";
            this.RESULTS.ScrollAlwaysVisible = true;
            this.RESULTS.Size = new System.Drawing.Size(496, 439);
            this.RESULTS.TabIndex = 10;
            this.RESULTS.UseTabStops = false;
            this.RESULTS.UseWaitCursor = true;
            this.RESULTS.SelectedIndexChanged += new System.EventHandler(this.lBox_SelectedIndexChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkKhaki;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(1076, 470);
            this.Controls.Add(this.RESULTS);
            this.Controls.Add(this.gb);
            this.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.Black;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.ImeMode = System.Windows.Forms.ImeMode.On;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.gb.ResumeLayout(false);
            this.gb.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button clearButton;
        private System.Windows.Forms.Button okButton;
        private System.Windows.Forms.Label l;
        private System.Windows.Forms.Label l1;
        private System.Windows.Forms.Label l2;
        private System.Windows.Forms.TextBox t1;
        private System.Windows.Forms.TextBox t2;
        private System.Windows.Forms.TextBox t3;
        private System.Windows.Forms.GroupBox gb;
        private System.Windows.Forms.RadioButton radio8;
        private System.Windows.Forms.RadioButton radio7;
        private System.Windows.Forms.RadioButton radio6;
        private System.Windows.Forms.RadioButton radio5;
        private System.Windows.Forms.RadioButton radio4;
        private System.Windows.Forms.RadioButton radio3;
        private System.Windows.Forms.RadioButton radio2;
        private System.Windows.Forms.RadioButton radio1;
        private System.Windows.Forms.ListBox RESULTS;
    }
}

