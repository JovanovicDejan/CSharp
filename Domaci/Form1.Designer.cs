namespace Domaci
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
            this.components = new System.ComponentModel.Container();
            this.rtBox = new System.Windows.Forms.RichTextBox();
            this.menuStrip = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.fontBoldToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fontItalicToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fontColorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
            this.selectFontToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txPronadji = new System.Windows.Forms.TextBox();
            this.txZameni = new System.Windows.Forms.TextBox();
            this.button4 = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnFindAndReplace = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.openFile = new System.Windows.Forms.OpenFileDialog();
            this.menuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // rtBox
            // 
            this.rtBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.rtBox.ContextMenuStrip = this.menuStrip;
            this.rtBox.Location = new System.Drawing.Point(10, 96);
            this.rtBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.rtBox.Name = "rtBox";
            this.rtBox.Size = new System.Drawing.Size(681, 344);
            this.rtBox.TabIndex = 0;
            this.rtBox.Text = "";
            this.rtBox.TextChanged += new System.EventHandler(this.rtBox_TextChanged);
            // 
            // menuStrip
            // 
            this.menuStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fontBoldToolStripMenuItem,
            this.fontItalicToolStripMenuItem,
            this.fontColorToolStripMenuItem,
            this.toolStripMenuItem1,
            this.selectFontToolStripMenuItem});
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Size = new System.Drawing.Size(133, 98);
            // 
            // fontBoldToolStripMenuItem
            // 
            this.fontBoldToolStripMenuItem.Name = "fontBoldToolStripMenuItem";
            this.fontBoldToolStripMenuItem.Size = new System.Drawing.Size(132, 22);
            this.fontBoldToolStripMenuItem.Text = "Font Bold";
            this.fontBoldToolStripMenuItem.Click += new System.EventHandler(this.fontBoldToolStripMenuItem_Click);
            // 
            // fontItalicToolStripMenuItem
            // 
            this.fontItalicToolStripMenuItem.Name = "fontItalicToolStripMenuItem";
            this.fontItalicToolStripMenuItem.Size = new System.Drawing.Size(132, 22);
            this.fontItalicToolStripMenuItem.Text = "Font Italic";
            this.fontItalicToolStripMenuItem.Click += new System.EventHandler(this.fontItalicToolStripMenuItem_Click);
            // 
            // fontColorToolStripMenuItem
            // 
            this.fontColorToolStripMenuItem.Name = "fontColorToolStripMenuItem";
            this.fontColorToolStripMenuItem.Size = new System.Drawing.Size(132, 22);
            this.fontColorToolStripMenuItem.Text = "Font Color";
            this.fontColorToolStripMenuItem.Click += new System.EventHandler(this.fontColorToolStripMenuItem_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(129, 6);
            // 
            // selectFontToolStripMenuItem
            // 
            this.selectFontToolStripMenuItem.Name = "selectFontToolStripMenuItem";
            this.selectFontToolStripMenuItem.Size = new System.Drawing.Size(132, 22);
            this.selectFontToolStripMenuItem.Text = "Select Font";
            this.selectFontToolStripMenuItem.Click += new System.EventHandler(this.selectFontToolStripMenuItem_Click);
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(154, 20);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 22);
            this.label1.TabIndex = 2;
            this.label1.Text = "Pronadji :";
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(156, 44);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 22);
            this.label2.TabIndex = 3;
            this.label2.Text = "Zameni : ";
            // 
            // txPronadji
            // 
            this.txPronadji.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txPronadji.Location = new System.Drawing.Point(234, 23);
            this.txPronadji.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txPronadji.Name = "txPronadji";
            this.txPronadji.Size = new System.Drawing.Size(95, 20);
            this.txPronadji.TabIndex = 4;
            // 
            // txZameni
            // 
            this.txZameni.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txZameni.Location = new System.Drawing.Point(234, 48);
            this.txZameni.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txZameni.Name = "txZameni";
            this.txZameni.Size = new System.Drawing.Size(95, 20);
            this.txZameni.TabIndex = 5;
            // 
            // button4
            // 
            this.button4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button4.Font = new System.Drawing.Font("Palatino Linotype", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.Image = global::Domaci.Properties.Resources.delete_delete_exit_1577;
            this.button4.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button4.Location = new System.Drawing.Point(613, 11);
            this.button4.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(77, 67);
            this.button4.TabIndex = 8;
            this.button4.Text = "Zavrsi program";
            this.button4.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.btnExit);
            // 
            // btnSave
            // 
            this.btnSave.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSave.Font = new System.Drawing.Font("Palatino Linotype", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.Image = global::Domaci.Properties.Resources.Save_37110;
            this.btnSave.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnSave.Location = new System.Drawing.Point(477, 10);
            this.btnSave.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(93, 67);
            this.btnSave.TabIndex = 7;
            this.btnSave.Text = "Snimi fajl (Save as)";
            this.btnSave.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.button3_Click);
            // 
            // btnFindAndReplace
            // 
            this.btnFindAndReplace.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnFindAndReplace.Font = new System.Drawing.Font("Palatino Linotype", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFindAndReplace.Image = global::Domaci.Properties.Resources.actions_find_and_replace_15783;
            this.btnFindAndReplace.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnFindAndReplace.Location = new System.Drawing.Point(358, 11);
            this.btnFindAndReplace.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnFindAndReplace.Name = "btnFindAndReplace";
            this.btnFindAndReplace.Size = new System.Drawing.Size(76, 67);
            this.btnFindAndReplace.TabIndex = 6;
            this.btnFindAndReplace.Text = "Pronadji i zameni";
            this.btnFindAndReplace.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnFindAndReplace.UseVisualStyleBackColor = true;
            this.btnFindAndReplace.Click += new System.EventHandler(this.btnFindAndReplace_Click);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Palatino Linotype", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button1.Image = global::Domaci.Properties.Resources.open_file_40455;
            this.button1.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button1.Location = new System.Drawing.Point(10, 11);
            this.button1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(107, 66);
            this.button1.TabIndex = 1;
            this.button1.Text = "Otvori fajl";
            this.button1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.btnOpen);
            // 
            // openFile
            // 
            this.openFile.FileName = "openFileDialog1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(700, 449);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnFindAndReplace);
            this.Controls.Add(this.txZameni);
            this.Controls.Add(this.txPronadji);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.rtBox);
            this.KeyPreview = true;
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.MinimumSize = new System.Drawing.Size(716, 332);
            this.Name = "Form1";
            this.Text = "Form1";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.ExitApp);
            this.menuStrip.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox rtBox;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txPronadji;
        private System.Windows.Forms.TextBox txZameni;
        private System.Windows.Forms.Button btnFindAndReplace;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.ContextMenuStrip menuStrip;
        private System.Windows.Forms.ToolStripMenuItem fontBoldToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem fontItalicToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem fontColorToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem selectFontToolStripMenuItem;
        private System.Windows.Forms.OpenFileDialog openFile;
    }
}

