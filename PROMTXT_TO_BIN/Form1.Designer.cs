namespace PROMTXT_TO_BIN
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
			this.btn_convert = new System.Windows.Forms.Button();
			this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
			this.txt_input = new System.Windows.Forms.TextBox();
			this.txt_output = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.btn_Input = new System.Windows.Forms.Button();
			this.btn_output = new System.Windows.Forms.Button();
			this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
			this.SuspendLayout();
			// 
			// btn_convert
			// 
			this.btn_convert.Enabled = false;
			this.btn_convert.Location = new System.Drawing.Point(151, 108);
			this.btn_convert.Name = "btn_convert";
			this.btn_convert.Size = new System.Drawing.Size(134, 23);
			this.btn_convert.TabIndex = 0;
			this.btn_convert.Text = "Convert";
			this.btn_convert.UseVisualStyleBackColor = true;
			this.btn_convert.Click += new System.EventHandler(this.btn_convert_Click);
			// 
			// openFileDialog1
			// 
			this.openFileDialog1.Filter = "Text Document|*.txt";
			// 
			// txt_input
			// 
			this.txt_input.Location = new System.Drawing.Point(13, 26);
			this.txt_input.Name = "txt_input";
			this.txt_input.ReadOnly = true;
			this.txt_input.Size = new System.Drawing.Size(332, 20);
			this.txt_input.TabIndex = 1;
			// 
			// txt_output
			// 
			this.txt_output.Location = new System.Drawing.Point(12, 76);
			this.txt_output.Name = "txt_output";
			this.txt_output.ReadOnly = true;
			this.txt_output.Size = new System.Drawing.Size(333, 20);
			this.txt_output.TabIndex = 2;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(15, 9);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(43, 13);
			this.label1.TabIndex = 3;
			this.label1.Text = "INPUT:";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(9, 60);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(55, 13);
			this.label2.TabIndex = 4;
			this.label2.Text = "OUTPUT:";
			// 
			// btn_Input
			// 
			this.btn_Input.Location = new System.Drawing.Point(358, 25);
			this.btn_Input.Name = "btn_Input";
			this.btn_Input.Size = new System.Drawing.Size(75, 23);
			this.btn_Input.TabIndex = 5;
			this.btn_Input.Text = "Open...";
			this.btn_Input.UseVisualStyleBackColor = true;
			this.btn_Input.Click += new System.EventHandler(this.btn_Input_Click);
			// 
			// btn_output
			// 
			this.btn_output.Location = new System.Drawing.Point(358, 75);
			this.btn_output.Name = "btn_output";
			this.btn_output.Size = new System.Drawing.Size(75, 23);
			this.btn_output.TabIndex = 6;
			this.btn_output.Text = "Open...";
			this.btn_output.UseVisualStyleBackColor = true;
			this.btn_output.Click += new System.EventHandler(this.btn_output_Click);
			// 
			// saveFileDialog1
			// 
			this.saveFileDialog1.Filter = "Binary File|*.bin";
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(437, 143);
			this.Controls.Add(this.btn_output);
			this.Controls.Add(this.btn_Input);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.txt_output);
			this.Controls.Add(this.txt_input);
			this.Controls.Add(this.btn_convert);
			this.Name = "Form1";
			this.Text = "ASCII PROM TO BIN";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Button btn_convert;
		private System.Windows.Forms.OpenFileDialog openFileDialog1;
		private System.Windows.Forms.TextBox txt_input;
		private System.Windows.Forms.TextBox txt_output;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Button btn_Input;
		private System.Windows.Forms.Button btn_output;
		private System.Windows.Forms.SaveFileDialog saveFileDialog1;
	}
}

