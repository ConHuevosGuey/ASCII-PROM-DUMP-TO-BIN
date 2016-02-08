using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace PROMTXT_TO_BIN
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
		}
		string input_file;
		string output_file;

		private void btn_Input_Click(object sender, EventArgs e)
		{
			if (openFileDialog1.ShowDialog() == DialogResult.OK & openFileDialog1.FileName != null)
			{
				input_file = openFileDialog1.FileName;
				txt_input.Text = openFileDialog1.FileName;
				EnableConvert();
			}
		}

		private void EnableConvert()
		{
			if (input_file != null && output_file != null) { btn_convert.Enabled = true; }
		}

		private void btn_output_Click(object sender, EventArgs e)
		{
			if (saveFileDialog1.ShowDialog() == DialogResult.OK & saveFileDialog1.FileName != null)
			{
				output_file = saveFileDialog1.FileName;
				txt_output.Text = saveFileDialog1.FileName;
				EnableConvert();
			}
		}

		private void btn_convert_Click(object sender, EventArgs e)
		{
			string line;
			byte[] data = new byte[256];
			int i = 0;
			System.IO.StreamReader file = new System.IO.StreamReader(openFileDialog1.FileName);
			while ((line = file.ReadLine()) != null)
			{
				data[i] = Convert.ToByte(line.Substring(12, 4), 2);
				i++;
			}
			file.Close();
			try
			{
				File.WriteAllBytes(output_file, data);
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message);
			}
		}
	}
}
