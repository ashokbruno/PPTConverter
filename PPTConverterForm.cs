using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using Microsoft.Office.Core;

namespace PPTConverter
{
	public partial class PPTConverterForm : Form
	{
		public PPTConverterForm()
		{
			InitializeComponent();

			if (Application.UserAppDataRegistry.GetValue("FolderLocation") != null)
			{
				bool bLoad = false;
				string folderLocation = "";
				try
				{
					folderLocation = Application.UserAppDataRegistry.GetValue("FolderLocation").ToString();
					System.IO.DirectoryInfo dir = new System.IO.DirectoryInfo(folderLocation);

					if (dir.Exists)
						bLoad = true;
				}
				catch (Exception)
				{
				}

				if (bLoad)
					textBoxFolder.Text = folderLocation;
				else
				{
					System.IO.DirectoryInfo currentDirectory = new System.IO.DirectoryInfo("h:");
					if (currentDirectory.Exists)
						textBoxFolder.Text = folderLocation;

				}
				UpdateFilesList();
			}
		}

		public void UpdateFilesList()
		{
			bool bLoad = false;
			DirectoryInfo dir = null;
			try
			{
				dir = new DirectoryInfo(textBoxFolder.Text);

				if (dir.Exists)
					bLoad = true;
			}
			catch (Exception)
			{
			}

			if (!bLoad)
				return;

			listBoxFiles.Items.Clear();
			if (textBoxFolder.Text.Length > 0)
			{
				listBoxFiles.BeginUpdate();

				if (dir.Exists)
				{
					foreach (FileInfo f in dir.GetFiles("*.ppt"))
					{
						listBoxFiles.Items.Add(f.Name.Replace(".ppt", ""));
					}
				}
				listBoxFiles.EndUpdate();
			}
		}

		private void OnFolderDragEnter(object sender, DragEventArgs e)
		{
			if (e.Data.GetDataPresent(DataFormats.FileDrop))
			{
				e.Effect = DragDropEffects.Copy;
			}
			else
			{
				e.Effect = DragDropEffects.None;
			}
		}

		private void OnDragDrop(object sender, DragEventArgs e)
		{
			string fileName = "";
			if (e.Data.GetDataPresent(DataFormats.FileDrop))
			{
				string[] fileNames;
				fileNames = (string[])e.Data.GetData(DataFormats.FileDrop);
				fileName = fileNames[0];
			}
			bool bLoad = false;
			try
			{
				System.IO.DirectoryInfo dir = new System.IO.DirectoryInfo(fileName);

				if (dir.Exists)
					bLoad = true;
			}
			catch (Exception)
			{
			}

			if (bLoad)
			{
				textBoxFolder.Text = fileName;
				UpdateFilesList();
			}
		}

		private void OnFolderTextChanged(object sender, EventArgs e)
		{
			UpdateFilesList();
		}

		private void FolderDlgBtn_Click(object sender, EventArgs e)
		{
			DialogResult dialogResult = folderBrowserDialog1.ShowDialog();
			if (dialogResult.Equals(DialogResult.OK))
			{
				textBoxFolder.Text = folderBrowserDialog1.SelectedPath;

				UpdateFilesList();
			}
		}

		private void PPTConverterForm_FormClosing(object sender, FormClosingEventArgs e)
		{
			Application.UserAppDataRegistry.SetValue("FolderLocation", textBoxFolder.Text);

			Application.Exit();
		}

		private void btnConvertSelected_Click(object sender, EventArgs e)
		{
			string strFullFilePath = "";

			int iSelectedIndex = listBoxFiles.SelectedIndex;
			if (iSelectedIndex >= 0)
			{

				string strLogName = listBoxFiles.SelectedItem.ToString();
				strFullFilePath = strLogName;
			}
			ConvertFile(textBoxFolder.Text + "\\" + strFullFilePath);
		}

		private void btnConvertAll_Click(object sender, EventArgs e)
		{
			progressBar1.Visible = true;
			progressBar1.Maximum = listBoxFiles.Items.Count;
			progressBar1.Step = 1;
			Microsoft.Office.Interop.PowerPoint.Application pptApp = new Microsoft.Office.Interop.PowerPoint.Application();
			foreach (object logListItem in listBoxFiles.Items)
			{
				progressBar1.PerformStep();
				this.Refresh();

				string strLogName = logListItem.ToString();
				string strFullFilePath = textBoxFolder.Text + "\\" + strLogName;

				if (File.Exists(strFullFilePath + ".ppt"))
				{
					Microsoft.Office.Interop.PowerPoint.Presentation pptPresentation = pptApp.Presentations.Open(strFullFilePath + ".ppt", MsoTriState.msoFalse, MsoTriState.msoFalse, MsoTriState.msoFalse);

					pptPresentation.SaveAs(strFullFilePath + ".pptx", Microsoft.Office.Interop.PowerPoint.PpSaveAsFileType.ppSaveAsOpenXMLPicturePresentation);
					pptPresentation.Close();
				}
			}
			pptApp.Quit();
			progressBar1.Visible = false;
		}

		private void ConvertFile(string strFilePath)
		{

			if (File.Exists(strFilePath + ".ppt"))
			{
				Microsoft.Office.Interop.PowerPoint.Application pptApp = new Microsoft.Office.Interop.PowerPoint.Application();
				Microsoft.Office.Interop.PowerPoint.Presentation pptPresentation = pptApp.Presentations.Open(strFilePath + ".ppt", MsoTriState.msoFalse, MsoTriState.msoFalse, MsoTriState.msoFalse);

				pptPresentation.SaveAs(strFilePath + ".pptx", Microsoft.Office.Interop.PowerPoint.PpSaveAsFileType.ppSaveAsOpenXMLPicturePresentation);
				pptPresentation.Close();

				pptApp.Quit();
			}
		}
	}
}
