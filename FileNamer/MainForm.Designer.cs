namespace FileNamer
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.panel_top = new System.Windows.Forms.Panel();
            this.pic_logo = new System.Windows.Forms.PictureBox();
            this.pic_minimise = new System.Windows.Forms.PictureBox();
            this.pic_close = new System.Windows.Forms.PictureBox();
            this.panel_txt_append = new System.Windows.Forms.Panel();
            this.txt_text_append = new System.Windows.Forms.ComboBox();
            this.label_txt_to_append = new System.Windows.Forms.Label();
            this.label_creation = new System.Windows.Forms.Label();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.pic_choose_file = new System.Windows.Forms.PictureBox();
            this.label_file_path = new System.Windows.Forms.Label();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.pic_rename_file = new System.Windows.Forms.PictureBox();
            this.panel_top.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pic_logo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_minimise)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_close)).BeginInit();
            this.panel_txt_append.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pic_choose_file)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_rename_file)).BeginInit();
            this.SuspendLayout();
            // 
            // panel_top
            // 
            this.panel_top.BackgroundImage = global::FileNamer.Properties.Resources.shadow_bg;
            this.panel_top.Controls.Add(this.pic_logo);
            this.panel_top.Controls.Add(this.pic_minimise);
            this.panel_top.Controls.Add(this.pic_close);
            this.panel_top.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel_top.Location = new System.Drawing.Point(0, 0);
            this.panel_top.Name = "panel_top";
            this.panel_top.Size = new System.Drawing.Size(305, 22);
            this.panel_top.TabIndex = 0;
            this.panel_top.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel_top_MouseDown);
            this.panel_top.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panel_top_MouseMove);
            // 
            // pic_logo
            // 
            this.pic_logo.BackgroundImage = global::FileNamer.Properties.Resources.fileNamer;
            this.pic_logo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pic_logo.Dock = System.Windows.Forms.DockStyle.Left;
            this.pic_logo.Location = new System.Drawing.Point(0, 0);
            this.pic_logo.Name = "pic_logo";
            this.pic_logo.Size = new System.Drawing.Size(22, 22);
            this.pic_logo.TabIndex = 3;
            this.pic_logo.TabStop = false;
            // 
            // pic_minimise
            // 
            this.pic_minimise.BackgroundImage = global::FileNamer.Properties.Resources.Min;
            this.pic_minimise.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pic_minimise.Dock = System.Windows.Forms.DockStyle.Right;
            this.pic_minimise.Location = new System.Drawing.Point(260, 0);
            this.pic_minimise.Name = "pic_minimise";
            this.pic_minimise.Size = new System.Drawing.Size(22, 22);
            this.pic_minimise.TabIndex = 2;
            this.pic_minimise.TabStop = false;
            this.pic_minimise.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pic_minimise_MouseDown);
            this.pic_minimise.MouseLeave += new System.EventHandler(this.pic_minimise_MouseLeave);
            this.pic_minimise.MouseHover += new System.EventHandler(this.pic_minimise_MouseHover);
            // 
            // pic_close
            // 
            this.pic_close.BackgroundImage = global::FileNamer.Properties.Resources.Close;
            this.pic_close.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pic_close.Dock = System.Windows.Forms.DockStyle.Right;
            this.pic_close.Location = new System.Drawing.Point(282, 0);
            this.pic_close.Name = "pic_close";
            this.pic_close.Size = new System.Drawing.Size(23, 22);
            this.pic_close.TabIndex = 0;
            this.pic_close.TabStop = false;
            this.pic_close.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pic_close_MouseDown);
            this.pic_close.MouseLeave += new System.EventHandler(this.pic_close_MouseLeave);
            this.pic_close.MouseHover += new System.EventHandler(this.pic_close_MouseHover);
            // 
            // panel_txt_append
            // 
            this.panel_txt_append.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.panel_txt_append.Controls.Add(this.txt_text_append);
            this.panel_txt_append.Location = new System.Drawing.Point(40, 52);
            this.panel_txt_append.Name = "panel_txt_append";
            this.panel_txt_append.Size = new System.Drawing.Size(223, 34);
            this.panel_txt_append.TabIndex = 1;
            // 
            // txt_text_append
            // 
            this.txt_text_append.AutoCompleteCustomSource.AddRange(new string[] {
            "Airtel",
            "Reliance",
            "Steam"});
            this.txt_text_append.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.txt_text_append.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.txt_text_append.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_text_append.FormattingEnabled = true;
            this.txt_text_append.Items.AddRange(new object[] {
            "Airtel",
            "Reliance",
            "Steam"});
            this.txt_text_append.Location = new System.Drawing.Point(5, 4);
            this.txt_text_append.Margin = new System.Windows.Forms.Padding(5);
            this.txt_text_append.Name = "txt_text_append";
            this.txt_text_append.Size = new System.Drawing.Size(213, 24);
            this.txt_text_append.TabIndex = 1;
            // 
            // label_txt_to_append
            // 
            this.label_txt_to_append.AutoSize = true;
            this.label_txt_to_append.BackColor = System.Drawing.Color.Transparent;
            this.label_txt_to_append.Font = new System.Drawing.Font("BankGothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_txt_to_append.ForeColor = System.Drawing.Color.White;
            this.label_txt_to_append.Location = new System.Drawing.Point(42, 35);
            this.label_txt_to_append.Name = "label_txt_to_append";
            this.label_txt_to_append.Size = new System.Drawing.Size(129, 14);
            this.label_txt_to_append.TabIndex = 2;
            this.label_txt_to_append.Text = "Text To Append";
            // 
            // label_creation
            // 
            this.label_creation.AutoSize = true;
            this.label_creation.BackColor = System.Drawing.Color.Transparent;
            this.label_creation.Font = new System.Drawing.Font("BankGothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_creation.ForeColor = System.Drawing.Color.White;
            this.label_creation.Location = new System.Drawing.Point(42, 98);
            this.label_creation.Name = "label_creation";
            this.label_creation.Size = new System.Drawing.Size(120, 14);
            this.label_creation.TabIndex = 3;
            this.label_creation.Text = "Creation Date";
            // 
            // pic_choose_file
            // 
            this.pic_choose_file.BackgroundImage = global::FileNamer.Properties.Resources.chooseFile;
            this.pic_choose_file.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pic_choose_file.Location = new System.Drawing.Point(45, 115);
            this.pic_choose_file.Name = "pic_choose_file";
            this.pic_choose_file.Size = new System.Drawing.Size(137, 35);
            this.pic_choose_file.TabIndex = 4;
            this.pic_choose_file.TabStop = false;
            this.pic_choose_file.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pic_choose_file_MouseDown);
            this.pic_choose_file.MouseLeave += new System.EventHandler(this.pic_choose_file_MouseLeave);
            this.pic_choose_file.MouseHover += new System.EventHandler(this.pic_choose_file_MouseHover);
            // 
            // label_file_path
            // 
            this.label_file_path.BackColor = System.Drawing.Color.Transparent;
            this.label_file_path.Font = new System.Drawing.Font("BankGothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_file_path.ForeColor = System.Drawing.Color.White;
            this.label_file_path.Location = new System.Drawing.Point(42, 164);
            this.label_file_path.Name = "label_file_path";
            this.label_file_path.Size = new System.Drawing.Size(216, 97);
            this.label_file_path.TabIndex = 5;
            this.label_file_path.Text = "File Path";
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            this.openFileDialog1.InitialDirectory = "C:\\Users\\DJAD\\Downloads\\Chrome Downloads";
            // 
            // pic_rename_file
            // 
            this.pic_rename_file.BackgroundImage = global::FileNamer.Properties.Resources.btn_rename;
            this.pic_rename_file.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pic_rename_file.Location = new System.Drawing.Point(45, 264);
            this.pic_rename_file.Name = "pic_rename_file";
            this.pic_rename_file.Size = new System.Drawing.Size(213, 35);
            this.pic_rename_file.TabIndex = 6;
            this.pic_rename_file.TabStop = false;
            this.pic_rename_file.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pic_rename_file_MouseDown);
            this.pic_rename_file.MouseLeave += new System.EventHandler(this.pic_rename_file_MouseLeave);
            this.pic_rename_file.MouseHover += new System.EventHandler(this.pic_rename_file_MouseHover);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.BackgroundImage = global::FileNamer.Properties.Resources.shadow_bg;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(305, 305);
            this.Controls.Add(this.pic_rename_file);
            this.Controls.Add(this.label_file_path);
            this.Controls.Add(this.pic_choose_file);
            this.Controls.Add(this.label_creation);
            this.Controls.Add(this.label_txt_to_append);
            this.Controls.Add(this.panel_txt_append);
            this.Controls.Add(this.panel_top);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainForm";
            this.Text = "File Namer";
            this.panel_top.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pic_logo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_minimise)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_close)).EndInit();
            this.panel_txt_append.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pic_choose_file)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_rename_file)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel_top;
        private System.Windows.Forms.PictureBox pic_minimise;
        private System.Windows.Forms.PictureBox pic_close;
        private System.Windows.Forms.PictureBox pic_logo;
        private System.Windows.Forms.Panel panel_txt_append;
        private System.Windows.Forms.Label label_txt_to_append;
        private System.Windows.Forms.ComboBox txt_text_append;
        private System.Windows.Forms.Label label_creation;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        private System.Windows.Forms.PictureBox pic_choose_file;
        private System.Windows.Forms.Label label_file_path;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.PictureBox pic_rename_file;
    }
}

