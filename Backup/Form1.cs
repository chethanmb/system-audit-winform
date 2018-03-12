using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;
using Microsoft.Win32;

namespace SystemInfo
{
	/// <summary>
	/// Summary description for Form1.
	/// </summary>
	public class Form1 : System.Windows.Forms.Form
	{
		private System.Windows.Forms.TabControl tabControl1;
		private System.Windows.Forms.TabPage tabPage1;
		private System.Windows.Forms.TabPage tabPage2;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.Label label8;
		private System.Windows.Forms.Label label9;
		private System.Windows.Forms.Label label10;
		private System.Windows.Forms.Label label11;
		private System.Windows.Forms.Label label12;
		private System.Windows.Forms.Label label13;
		private System.Windows.Forms.Label label14;
		private System.Windows.Forms.Label label15;
		private System.Windows.Forms.Label label16;
		private System.Windows.Forms.Label label17;
		private System.Windows.Forms.Label label18;
		private System.Windows.Forms.Label label19;
		private System.Windows.Forms.Label label20;
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.Container components = null;

		public Form1()
		{
			//
			// Required for Windows Form Designer support
			//
			InitializeComponent();

			//
			// TODO: Add any constructor code after InitializeComponent call
			//
		}

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		protected override void Dispose( bool disposing )
		{
			if( disposing )
			{
				if (components != null) 
				{
					components.Dispose();
				}
			}
			base.Dispose( disposing );
		}

		#region Windows Form Designer generated code
		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.tabControl1 = new System.Windows.Forms.TabControl();
			this.tabPage1 = new System.Windows.Forms.TabPage();
			this.label20 = new System.Windows.Forms.Label();
			this.label19 = new System.Windows.Forms.Label();
			this.label18 = new System.Windows.Forms.Label();
			this.label17 = new System.Windows.Forms.Label();
			this.label6 = new System.Windows.Forms.Label();
			this.label5 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.tabPage2 = new System.Windows.Forms.TabPage();
			this.label16 = new System.Windows.Forms.Label();
			this.label15 = new System.Windows.Forms.Label();
			this.label14 = new System.Windows.Forms.Label();
			this.label13 = new System.Windows.Forms.Label();
			this.label12 = new System.Windows.Forms.Label();
			this.label11 = new System.Windows.Forms.Label();
			this.label10 = new System.Windows.Forms.Label();
			this.label9 = new System.Windows.Forms.Label();
			this.label8 = new System.Windows.Forms.Label();
			this.label7 = new System.Windows.Forms.Label();
			this.tabControl1.SuspendLayout();
			this.tabPage1.SuspendLayout();
			this.tabPage2.SuspendLayout();
			this.SuspendLayout();
			// 
			// tabControl1
			// 
			this.tabControl1.Controls.Add(this.tabPage1);
			this.tabControl1.Controls.Add(this.tabPage2);
			this.tabControl1.Location = new System.Drawing.Point(8, 8);
			this.tabControl1.Name = "tabControl1";
			this.tabControl1.SelectedIndex = 0;
			this.tabControl1.Size = new System.Drawing.Size(432, 248);
			this.tabControl1.TabIndex = 12;
			// 
			// tabPage1
			// 
			this.tabPage1.Controls.Add(this.label20);
			this.tabPage1.Controls.Add(this.label19);
			this.tabPage1.Controls.Add(this.label18);
			this.tabPage1.Controls.Add(this.label17);
			this.tabPage1.Controls.Add(this.label6);
			this.tabPage1.Controls.Add(this.label5);
			this.tabPage1.Controls.Add(this.label4);
			this.tabPage1.Controls.Add(this.label3);
			this.tabPage1.Controls.Add(this.label2);
			this.tabPage1.Controls.Add(this.label1);
			this.tabPage1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(178)));
			this.tabPage1.Location = new System.Drawing.Point(4, 22);
			this.tabPage1.Name = "tabPage1";
			this.tabPage1.Size = new System.Drawing.Size(424, 222);
			this.tabPage1.TabIndex = 0;
			this.tabPage1.Text = "HardWare";
			// 
			// label20
			// 
			this.label20.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.label20.Location = new System.Drawing.Point(136, 100);
			this.label20.Name = "label20";
			this.label20.Size = new System.Drawing.Size(256, 23);
			this.label20.TabIndex = 9;
			this.label20.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// label19
			// 
			this.label19.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.label19.Location = new System.Drawing.Point(8, 104);
			this.label19.Name = "label19";
			this.label19.TabIndex = 8;
			this.label19.Text = "CPU";
			this.label19.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// label18
			// 
			this.label18.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.label18.Location = new System.Drawing.Point(136, 176);
			this.label18.Name = "label18";
			this.label18.Size = new System.Drawing.Size(160, 23);
			this.label18.TabIndex = 7;
			this.label18.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// label17
			// 
			this.label17.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.label17.Location = new System.Drawing.Point(8, 176);
			this.label17.Name = "label17";
			this.label17.TabIndex = 6;
			this.label17.Text = "Monitor Size";
			this.label17.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// label6
			// 
			this.label6.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.label6.Location = new System.Drawing.Point(264, 136);
			this.label6.Name = "label6";
			this.label6.TabIndex = 5;
			this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// label5
			// 
			this.label5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.label5.Location = new System.Drawing.Point(8, 136);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(232, 23);
			this.label5.TabIndex = 4;
			this.label5.Text = "Memory Mapped To The Process  Context";
			this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// label4
			// 
			this.label4.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.label4.Location = new System.Drawing.Point(136, 64);
			this.label4.Name = "label4";
			this.label4.TabIndex = 3;
			this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// label3
			// 
			this.label3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.label3.Location = new System.Drawing.Point(8, 64);
			this.label3.Name = "label3";
			this.label3.TabIndex = 2;
			this.label3.Text = "Machine Name";
			this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// label2
			// 
			this.label2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.label2.Location = new System.Drawing.Point(136, 24);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(160, 23);
			this.label2.TabIndex = 1;
			this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// label1
			// 
			this.label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.label1.Location = new System.Drawing.Point(8, 24);
			this.label1.Name = "label1";
			this.label1.TabIndex = 0;
			this.label1.Text = "System Directory";
			this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// tabPage2
			// 
			this.tabPage2.Controls.Add(this.label16);
			this.tabPage2.Controls.Add(this.label15);
			this.tabPage2.Controls.Add(this.label14);
			this.tabPage2.Controls.Add(this.label13);
			this.tabPage2.Controls.Add(this.label12);
			this.tabPage2.Controls.Add(this.label11);
			this.tabPage2.Controls.Add(this.label10);
			this.tabPage2.Controls.Add(this.label9);
			this.tabPage2.Controls.Add(this.label8);
			this.tabPage2.Controls.Add(this.label7);
			this.tabPage2.Location = new System.Drawing.Point(4, 22);
			this.tabPage2.Name = "tabPage2";
			this.tabPage2.Size = new System.Drawing.Size(424, 222);
			this.tabPage2.TabIndex = 1;
			this.tabPage2.Text = "SoftWare";
			// 
			// label16
			// 
			this.label16.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.label16.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(178)));
			this.label16.Location = new System.Drawing.Point(136, 176);
			this.label16.Name = "label16";
			this.label16.TabIndex = 9;
			this.label16.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// label15
			// 
			this.label15.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(178)));
			this.label15.Location = new System.Drawing.Point(8, 176);
			this.label15.Name = "label15";
			this.label15.Size = new System.Drawing.Size(112, 23);
			this.label15.TabIndex = 8;
			this.label15.Text = "User Domain Name";
			this.label15.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// label14
			// 
			this.label14.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(178)));
			this.label14.Location = new System.Drawing.Point(136, 136);
			this.label14.Name = "label14";
			this.label14.TabIndex = 7;
			this.label14.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// label13
			// 
			this.label13.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(178)));
			this.label13.Location = new System.Drawing.Point(8, 136);
			this.label13.Name = "label13";
			this.label13.TabIndex = 6;
			this.label13.Text = "User Name";
			this.label13.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// label12
			// 
			this.label12.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(178)));
			this.label12.Location = new System.Drawing.Point(152, 96);
			this.label12.Name = "label12";
			this.label12.Size = new System.Drawing.Size(80, 23);
			this.label12.TabIndex = 5;
			this.label12.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// label11
			// 
			this.label11.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(178)));
			this.label11.Location = new System.Drawing.Point(8, 96);
			this.label11.Name = "label11";
			this.label11.Size = new System.Drawing.Size(120, 23);
			this.label11.TabIndex = 4;
			this.label11.Text = "OS - Version Number";
			this.label11.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// label10
			// 
			this.label10.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(178)));
			this.label10.Location = new System.Drawing.Point(128, 56);
			this.label10.Name = "label10";
			this.label10.Size = new System.Drawing.Size(208, 23);
			this.label10.TabIndex = 3;
			this.label10.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// label9
			// 
			this.label9.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(178)));
			this.label9.Location = new System.Drawing.Point(8, 56);
			this.label9.Name = "label9";
			this.label9.TabIndex = 2;
			this.label9.Text = "OS - Version";
			this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// label8
			// 
			this.label8.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(178)));
			this.label8.Location = new System.Drawing.Point(152, 16);
			this.label8.Name = "label8";
			this.label8.Size = new System.Drawing.Size(88, 23);
			this.label8.TabIndex = 1;
			this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// label7
			// 
			this.label7.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(178)));
			this.label7.Location = new System.Drawing.Point(8, 16);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(128, 23);
			this.label7.TabIndex = 0;
			this.label7.Text = "The OS Opened From ";
			this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// Form1
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
			this.ClientSize = new System.Drawing.Size(448, 270);
			this.Controls.Add(this.tabControl1);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
			this.MaximizeBox = false;
			this.Name = "Form1";
			this.Text = "System Info";
			this.Load += new System.EventHandler(this.Form1_Load);
			this.tabControl1.ResumeLayout(false);
			this.tabPage1.ResumeLayout(false);
			this.tabPage2.ResumeLayout(false);
			this.ResumeLayout(false);

		}
		#endregion

		/// <summary>
		/// The main entry point for the application.
		/// </summary>
		[STAThread]
		static void Main() 
		{
			Application.Run(new Form1());
		}

		private void Form1_Load(object sender, System.EventArgs e)
		{
			try
			{
				label18.Text = SystemInformation.PrimaryMonitorSize.ToString();
				label2.Text = System.Environment.SystemDirectory;
				label4.Text = System.Environment.MachineName;
				label6.Text = System.Environment.WorkingSet.ToString();
				int q = System.Environment.TickCount;
				int w = (q/1000)/60;
				label8.Text = w.ToString() + "  Minute(s)";
				label10.Text = System.Environment.OSVersion.ToString();
				label12.Text = System.Environment.Version.ToString();
				label14.Text = System.Environment.UserName;
				label16.Text = System.Environment.UserDomainName;
				RegistryKey Rkey = Registry.LocalMachine;
				Rkey = Rkey.OpenSubKey("HARDWARE\\DESCRIPTION\\System\\CentralProcessor\\0");
				label20.Text = (string)Rkey.GetValue("ProcessorNameString");
			}
			catch (Exception EX)
			{
				MessageBox.Show("The Following ERROR Occur ..." + EX.Message.ToString());
			}
		}

	}
}
