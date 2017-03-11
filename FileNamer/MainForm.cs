using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Threading;
using System.IO;

namespace FileNamer
{
    public partial class MainForm : Form
    {
        private System.Drawing.Point MouseDownLocation;
        String globalPath = @"";
        String globalDateTime = @"";
        String fileExtension = @"";

        public MainForm()
        {
            InitializeComponent();
            this.CenterToScreen();
        }

        #region Min And Maximise
        private void pic_minimise_MouseHover(object sender, EventArgs e)
        {
            pic_minimise.BackgroundImage = Properties.Resources.Min_hover;
        }

        private void pic_minimise_MouseLeave(object sender, EventArgs e)
        {
            pic_minimise.BackgroundImage = Properties.Resources.Min;
        }

        private void pic_minimise_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                this.WindowState = FormWindowState.Minimized;
            }
        }

        private void pic_close_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                DialogResult dialog = MessageBox.Show("Do you really want to Exit?", "Exit Application", MessageBoxButtons.YesNo);
                if (dialog == DialogResult.Yes)
                {
                    Application.Exit();
                }
            }
        }

        private void pic_close_MouseHover(object sender, EventArgs e)
        {
            pic_close.BackgroundImage = Properties.Resources.Close_hover;
        }

        private void pic_close_MouseLeave(object sender, EventArgs e)
        {
            pic_close.BackgroundImage = Properties.Resources.Close;
        }
        #endregion

        #region Panel Form Mover
        private void panel_top_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                MouseDownLocation = e.Location;
            }
        }

        private void panel_top_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                this.Left = e.X + this.Left - MouseDownLocation.X;
                this.Top = e.Y + this.Top - MouseDownLocation.Y;
            }
        }
        #endregion

        #region File Choosing Button
        private void pic_choose_file_MouseHover(object sender, EventArgs e)
        {
            pic_choose_file.BackgroundImage = Properties.Resources.chooseFile_hover;
        }

        private void pic_choose_file_MouseLeave(object sender, EventArgs e)
        {
            pic_choose_file.BackgroundImage = Properties.Resources.chooseFile;
        }

        private void pic_choose_file_MouseDown(object sender, MouseEventArgs e)
        {
            try
            {
                if (e.Button == MouseButtons.Left)
                {
                    var path = "";
                    DialogResult r = openFileDialog1.ShowDialog();
                    if (r == DialogResult.OK)
                    {
                        path = openFileDialog1.FileName;
                    }
                    globalPath = path;
                    label_file_path.Text = globalPath;

                    DateTime dt = File.GetCreationTime(globalPath);
                    globalDateTime = dt.ToShortDateString() + "_" + dt.ToShortTimeString();
                    label_creation.Text = globalDateTime;
                }
            }
            catch (Exception ex) { MessageBox.Show(ex.Message+""); }
        }
        #endregion

        #region File Rename Button
        private void pic_rename_file_MouseHover(object sender, EventArgs e)
        {
            pic_rename_file.BackgroundImage = Properties.Resources.btn_rename_hover;
        }

        private void pic_rename_file_MouseLeave(object sender, EventArgs e)
        {
            pic_rename_file.BackgroundImage = Properties.Resources.btn_rename;
        }

        private void pic_rename_file_MouseDown(object sender, MouseEventArgs e)
        {
            try
            {
                String text = txt_text_append.Text.ToString() + "_";
                globalDateTime = globalDateTime.Replace(':', '-'); label_creation.Text = globalDateTime;
                fileExtension = Path.GetExtension(globalPath);

                String FinalRename = text + globalDateTime + fileExtension;

                DialogResult dialog = MessageBox.Show("Rename to '" + FinalRename + "'", "File Rename", MessageBoxButtons.YesNo);
                if (e.Button == MouseButtons.Left && dialog == DialogResult.Yes)
                {
                    String previousFName = Path.GetFileName(globalPath);
                    String renamedPath = globalPath.Replace(previousFName, FinalRename);
                    System.IO.File.Move(globalPath, renamedPath);

                    setDirPrevious();
                }
            }
            catch (Exception ex) { MessageBox.Show(ex.Message + ""); }
        }
        #endregion

        /// <summary>
        /// Sets the location to the previously used directory
        /// </summary>
        public void setDirPrevious()
        {
            try
            {
                String xFileName = Path.GetFileName(globalPath);
                String dir = globalPath.Replace(xFileName, "");
                openFileDialog1.InitialDirectory = dir;
            }
            catch (Exception ex) { MessageBox.Show(ex.Message + ""); }
        }
    }
}
