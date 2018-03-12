using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;
using Microsoft.Win32;
using System.Collections.Generic;
//using System.Linq;
using System.Text;
using System.Management;
using System.DirectoryServices.AccountManagement;
using System.Net;
using System.IO;
//using System.Xml.Linq;
using System.Diagnostics;
using System.Security.Principal;
using System.Threading;

namespace SystemInfo
{
   
    
    
    
    
    
    /// <summary>
    /// Summary description for Form1.
    /// </summary>
    public class Form1 : System.Windows.Forms.Form
    {
        private Label label1_bitlocker;
        private Label label12_cddvd;
        private Label label10_externalmediausbout;
        private Label label1_usb;
        private Label label_mcafeedatdate;
        private Label label7_mcafeedatversion;
        private Label label5_cpuserialno;
        private Label label1_emailid;
        private GroupBox groupBox1;
        private SaveFileDialog saveFileDialog1;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem menuToolStripMenuItem;
        private ToolStripMenuItem saveToolStripMenuItem;
        private ToolStripMenuItem exitToolStripMenuItem;
        private RichTextBox richTextBox_hostname;
        private Label label2;
        private Label label1;
        private RichTextBox richTextBox_ntid;
        private RichTextBox richTextBox_bitlocker;
        private RichTextBox richTextBox_dvd;
        private RichTextBox richTextBox_usb;
        private RichTextBox richTextBox_datdate;
        private RichTextBox richTextBox_datversion;
        private RichTextBox richTextBox_serialno;
        private RichTextBox richTextBox_emailid;
        private ToolStripSeparator toolStripSeparator1;
        private RichTextBox richTextBox_displayname;
        private CheckBox checkBox1;
        private ProgressBar progressBar1;



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
           this.saveToolStripMenuItem.Click += new System.EventHandler(this.saveToolStripMenuItem_Click);
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            this.checkBox1.Click += new EventHandler(this.checkBox1_Click);
            

            //this.checkBox_ntloginid
            //this.checkBox_ntloginid.Click += new System.EventHandler(this.checkBox_ntloginid_Click);


            //
            // TODO: Add any constructor code after InitializeComponent call
            //
        }

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                if (components != null)
                {
                    components.Dispose();
                }
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.label1_bitlocker = new System.Windows.Forms.Label();
            this.label12_cddvd = new System.Windows.Forms.Label();
            this.label10_externalmediausbout = new System.Windows.Forms.Label();
            this.label1_usb = new System.Windows.Forms.Label();
            this.label_mcafeedatdate = new System.Windows.Forms.Label();
            this.label7_mcafeedatversion = new System.Windows.Forms.Label();
            this.label5_cpuserialno = new System.Windows.Forms.Label();
            this.label1_emailid = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.richTextBox_displayname = new System.Windows.Forms.RichTextBox();
            this.richTextBox_bitlocker = new System.Windows.Forms.RichTextBox();
            this.richTextBox_dvd = new System.Windows.Forms.RichTextBox();
            this.richTextBox_usb = new System.Windows.Forms.RichTextBox();
            this.richTextBox_datdate = new System.Windows.Forms.RichTextBox();
            this.richTextBox_datversion = new System.Windows.Forms.RichTextBox();
            this.richTextBox_serialno = new System.Windows.Forms.RichTextBox();
            this.richTextBox_emailid = new System.Windows.Forms.RichTextBox();
            this.richTextBox_ntid = new System.Windows.Forms.RichTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.richTextBox_hostname = new System.Windows.Forms.RichTextBox();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.menuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.groupBox1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1_bitlocker
            // 
            this.label1_bitlocker.AutoSize = true;
            this.label1_bitlocker.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label1_bitlocker.Location = new System.Drawing.Point(6, 335);
            this.label1_bitlocker.Name = "label1_bitlocker";
            this.label1_bitlocker.Size = new System.Drawing.Size(63, 17);
            this.label1_bitlocker.TabIndex = 22;
            this.label1_bitlocker.Text = "BitLocker";
            // 
            // label12_cddvd
            // 
            this.label12_cddvd.AutoSize = true;
            this.label12_cddvd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label12_cddvd.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label12_cddvd.Location = new System.Drawing.Point(6, 297);
            this.label12_cddvd.Name = "label12_cddvd";
            this.label12_cddvd.Size = new System.Drawing.Size(56, 17);
            this.label12_cddvd.TabIndex = 20;
            this.label12_cddvd.Text = "CD/DVD";
            // 
            // label10_externalmediausbout
            // 
            this.label10_externalmediausbout.AutoSize = true;
            this.label10_externalmediausbout.Location = new System.Drawing.Point(52, 256);
            this.label10_externalmediausbout.Name = "label10_externalmediausbout";
            this.label10_externalmediausbout.Size = new System.Drawing.Size(0, 13);
            this.label10_externalmediausbout.TabIndex = 18;
            // 
            // label1_usb
            // 
            this.label1_usb.AutoSize = true;
            this.label1_usb.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label1_usb.Location = new System.Drawing.Point(6, 256);
            this.label1_usb.Name = "label1_usb";
            this.label1_usb.Size = new System.Drawing.Size(32, 17);
            this.label1_usb.TabIndex = 17;
            this.label1_usb.Text = "USB";
            // 
            // label_mcafeedatdate
            // 
            this.label_mcafeedatdate.AutoSize = true;
            this.label_mcafeedatdate.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label_mcafeedatdate.Location = new System.Drawing.Point(6, 216);
            this.label_mcafeedatdate.Name = "label_mcafeedatdate";
            this.label_mcafeedatdate.Size = new System.Drawing.Size(63, 17);
            this.label_mcafeedatdate.TabIndex = 15;
            this.label_mcafeedatdate.Text = "DAT date";
            // 
            // label7_mcafeedatversion
            // 
            this.label7_mcafeedatversion.AutoSize = true;
            this.label7_mcafeedatversion.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label7_mcafeedatversion.Location = new System.Drawing.Point(6, 181);
            this.label7_mcafeedatversion.Name = "label7_mcafeedatversion";
            this.label7_mcafeedatversion.Size = new System.Drawing.Size(80, 17);
            this.label7_mcafeedatversion.TabIndex = 14;
            this.label7_mcafeedatversion.Text = "DAT version";
            // 
            // label5_cpuserialno
            // 
            this.label5_cpuserialno.AutoSize = true;
            this.label5_cpuserialno.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5_cpuserialno.Location = new System.Drawing.Point(6, 142);
            this.label5_cpuserialno.Name = "label5_cpuserialno";
            this.label5_cpuserialno.Size = new System.Drawing.Size(65, 17);
            this.label5_cpuserialno.TabIndex = 13;
            this.label5_cpuserialno.Text = "Serial No.";
            // 
            // label1_emailid
            // 
            this.label1_emailid.AutoSize = true;
            this.label1_emailid.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label1_emailid.Location = new System.Drawing.Point(6, 27);
            this.label1_emailid.Name = "label1_emailid";
            this.label1_emailid.Size = new System.Drawing.Size(57, 17);
            this.label1_emailid.TabIndex = 10;
            this.label1_emailid.Text = "Email ID";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.progressBar1);
            this.groupBox1.Controls.Add(this.checkBox1);
            this.groupBox1.Controls.Add(this.richTextBox_displayname);
            this.groupBox1.Controls.Add(this.richTextBox_bitlocker);
            this.groupBox1.Controls.Add(this.richTextBox_dvd);
            this.groupBox1.Controls.Add(this.richTextBox_usb);
            this.groupBox1.Controls.Add(this.richTextBox_datdate);
            this.groupBox1.Controls.Add(this.richTextBox_datversion);
            this.groupBox1.Controls.Add(this.richTextBox_serialno);
            this.groupBox1.Controls.Add(this.richTextBox_emailid);
            this.groupBox1.Controls.Add(this.richTextBox_ntid);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.richTextBox_hostname);
            this.groupBox1.Controls.Add(this.label1_bitlocker);
            this.groupBox1.Controls.Add(this.label12_cddvd);
            this.groupBox1.Controls.Add(this.label10_externalmediausbout);
            this.groupBox1.Controls.Add(this.label1_usb);
            this.groupBox1.Controls.Add(this.label1_emailid);
            this.groupBox1.Controls.Add(this.label_mcafeedatdate);
            this.groupBox1.Controls.Add(this.label5_cpuserialno);
            this.groupBox1.Controls.Add(this.label7_mcafeedatversion);
            this.groupBox1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.groupBox1.Location = new System.Drawing.Point(12, 27);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(527, 385);
            this.groupBox1.TabIndex = 13;
            this.groupBox1.TabStop = false;
            // 
            // richTextBox_displayname
            // 
            this.richTextBox_displayname.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.richTextBox_displayname.Location = new System.Drawing.Point(373, 148);
            this.richTextBox_displayname.Name = "richTextBox_displayname";
            this.richTextBox_displayname.ReadOnly = true;
            this.richTextBox_displayname.Size = new System.Drawing.Size(136, 21);
            this.richTextBox_displayname.TabIndex = 50;
            this.richTextBox_displayname.Text = "";
            // 
            // richTextBox_bitlocker
            // 
            this.richTextBox_bitlocker.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.richTextBox_bitlocker.Location = new System.Drawing.Point(87, 335);
            this.richTextBox_bitlocker.Multiline = false;
            this.richTextBox_bitlocker.Name = "richTextBox_bitlocker";
            this.richTextBox_bitlocker.ReadOnly = true;
            this.richTextBox_bitlocker.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.None;
            this.richTextBox_bitlocker.Size = new System.Drawing.Size(126, 20);
            this.richTextBox_bitlocker.TabIndex = 49;
            this.richTextBox_bitlocker.Text = "";
            // 
            // richTextBox_dvd
            // 
            this.richTextBox_dvd.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.richTextBox_dvd.Location = new System.Drawing.Point(87, 297);
            this.richTextBox_dvd.Multiline = false;
            this.richTextBox_dvd.Name = "richTextBox_dvd";
            this.richTextBox_dvd.ReadOnly = true;
            this.richTextBox_dvd.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.None;
            this.richTextBox_dvd.Size = new System.Drawing.Size(126, 20);
            this.richTextBox_dvd.TabIndex = 48;
            this.richTextBox_dvd.Text = "";
            // 
            // richTextBox_usb
            // 
            this.richTextBox_usb.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.richTextBox_usb.Location = new System.Drawing.Point(87, 256);
            this.richTextBox_usb.Multiline = false;
            this.richTextBox_usb.Name = "richTextBox_usb";
            this.richTextBox_usb.ReadOnly = true;
            this.richTextBox_usb.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.None;
            this.richTextBox_usb.Size = new System.Drawing.Size(126, 20);
            this.richTextBox_usb.TabIndex = 47;
            this.richTextBox_usb.Text = "";
            // 
            // richTextBox_datdate
            // 
            this.richTextBox_datdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.richTextBox_datdate.Location = new System.Drawing.Point(87, 216);
            this.richTextBox_datdate.Multiline = false;
            this.richTextBox_datdate.Name = "richTextBox_datdate";
            this.richTextBox_datdate.ReadOnly = true;
            this.richTextBox_datdate.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.None;
            this.richTextBox_datdate.Size = new System.Drawing.Size(126, 20);
            this.richTextBox_datdate.TabIndex = 46;
            this.richTextBox_datdate.Text = "";
            // 
            // richTextBox_datversion
            // 
            this.richTextBox_datversion.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.richTextBox_datversion.Location = new System.Drawing.Point(87, 181);
            this.richTextBox_datversion.Multiline = false;
            this.richTextBox_datversion.Name = "richTextBox_datversion";
            this.richTextBox_datversion.ReadOnly = true;
            this.richTextBox_datversion.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.None;
            this.richTextBox_datversion.Size = new System.Drawing.Size(126, 20);
            this.richTextBox_datversion.TabIndex = 45;
            this.richTextBox_datversion.Text = "";
            // 
            // richTextBox_serialno
            // 
            this.richTextBox_serialno.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.richTextBox_serialno.Location = new System.Drawing.Point(87, 142);
            this.richTextBox_serialno.Multiline = false;
            this.richTextBox_serialno.Name = "richTextBox_serialno";
            this.richTextBox_serialno.ReadOnly = true;
            this.richTextBox_serialno.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.None;
            this.richTextBox_serialno.Size = new System.Drawing.Size(126, 20);
            this.richTextBox_serialno.TabIndex = 44;
            this.richTextBox_serialno.Text = "";
            // 
            // richTextBox_emailid
            // 
            this.richTextBox_emailid.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.richTextBox_emailid.ForeColor = System.Drawing.SystemColors.WindowText;
            this.richTextBox_emailid.Location = new System.Drawing.Point(87, 27);
            this.richTextBox_emailid.Multiline = false;
            this.richTextBox_emailid.Name = "richTextBox_emailid";
            this.richTextBox_emailid.ReadOnly = true;
            this.richTextBox_emailid.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.None;
            this.richTextBox_emailid.Size = new System.Drawing.Size(173, 20);
            this.richTextBox_emailid.TabIndex = 43;
            this.richTextBox_emailid.Text = "";
            // 
            // richTextBox_ntid
            // 
            this.richTextBox_ntid.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.richTextBox_ntid.Location = new System.Drawing.Point(87, 64);
            this.richTextBox_ntid.Multiline = false;
            this.richTextBox_ntid.Name = "richTextBox_ntid";
            this.richTextBox_ntid.ReadOnly = true;
            this.richTextBox_ntid.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.None;
            this.richTextBox_ntid.Size = new System.Drawing.Size(173, 20);
            this.richTextBox_ntid.TabIndex = 42;
            this.richTextBox_ntid.Text = "";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(6, 103);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 17);
            this.label2.TabIndex = 41;
            this.label2.Text = "HostName";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(6, 66);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(42, 17);
            this.label1.TabIndex = 40;
            this.label1.Text = "NT ID";
            // 
            // richTextBox_hostname
            // 
            this.richTextBox_hostname.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.richTextBox_hostname.Location = new System.Drawing.Point(87, 103);
            this.richTextBox_hostname.Multiline = false;
            this.richTextBox_hostname.Name = "richTextBox_hostname";
            this.richTextBox_hostname.ReadOnly = true;
            this.richTextBox_hostname.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.None;
            this.richTextBox_hostname.Size = new System.Drawing.Size(126, 20);
            this.richTextBox_hostname.TabIndex = 39;
            this.richTextBox_hostname.Text = "";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(552, 25);
            this.menuStrip1.TabIndex = 14;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // menuToolStripMenuItem
            // 
            this.menuToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.saveToolStripMenuItem,
            this.toolStripSeparator1,
            this.exitToolStripMenuItem});
            this.menuToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuToolStripMenuItem.Name = "menuToolStripMenuItem";
            this.menuToolStripMenuItem.Size = new System.Drawing.Size(53, 21);
            this.menuToolStripMenuItem.Text = "Menu";
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(103, 22);
            this.saveToolStripMenuItem.Text = "Save";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(100, 6);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(103, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            // 
            // checkBox1
            // 
            this.checkBox1.Appearance = System.Windows.Forms.Appearance.Button;
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(278, 148);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(79, 23);
            this.checkBox1.TabIndex = 51;
            this.checkBox1.Text = "DisplayName";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(278, 177);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(79, 19);
            this.progressBar1.TabIndex = 52;
            // 
            // Form1
            // 
            this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
            this.ClientSize = new System.Drawing.Size(552, 421);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "System Info";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

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
            String output = null;
            String s = null;


            try
            {

                richTextBox_emailid.Text = userMailID(output); //Calling userMailID()
                richTextBox_ntid.Text = userNTloginID(output); //System.Environment.MachineName;
                richTextBox_hostname.Text = HostName(output);  //System.Environment.WorkingSet.ToString();
                richTextBox_serialno.Text = CPUSerialNo(output);
                // int q = System.Environment.TickCount;
                // int w = (q / 1000) / 60;
                richTextBox_datdate.Text = McAfeeDATdate(output);
                richTextBox_datversion.Text = McAfeeDATversion(output);
                richTextBox_usb.Text = ExternalMediaUSB();

                richTextBox_dvd.Text = ExternalMediaDVD();
                // richTextBox_bitlocker.Text = bitlocker(output);
                
                //richTextBox_displayname.Text = DisplayName(s);
                RegistryKey Rkey = Registry.LocalMachine;
                Rkey = Rkey.OpenSubKey("HARDWARE\\DESCRIPTION\\System\\CentralProcessor\\0");

                
            }            
            catch (Exception EX)
            {
                MessageBox.Show("Following ERROR Occured--->" + EX.Message.ToString());
               // MessageBox.Show("Try Running the Program as Administrator");
            }
         }

        
     
        
         string FileName = string.Empty;
      /*  private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog open = new OpenFileDialog();

            open.Filter = "Text Files (.txt)|*.txt|All Files (*.*)|*.*";
            open.Title = "Open File";
            open.FileName = "";

            if (open.ShowDialog() == DialogResult.OK)
            {
                // save the opened FileName in our variable
                this.FileName = open.FileName;
                this.Text = string.Format("{0}", Path.GetFileNameWithoutExtension(open.FileName));
                StreamReader reader = new StreamReader(open.FileName);
               // richTextBox1.Text = reader.ReadToEnd();
                reader.Close();
            }
        } */
        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog saving = new SaveFileDialog();

            saving.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.MyComputer);

            saving.Filter = "Text Files (.txt)|*.txt|All Files (*.*)|*.*";
            saving.Title = "Save As";
            saving.FileName = "Untitled";

            if (saving.ShowDialog() == DialogResult.OK)
            {
                // save the new FileName in our variable
                this.FileName = saving.FileName;
                StreamWriter writing = new StreamWriter(saving.FileName);
                writing.Write("Email ID: ");
                writing.Write(richTextBox_emailid.Text);
                writing.Write(Environment.NewLine);
                writing.Write(Environment.NewLine);
                writing.Write("NT id: ");
                writing.Write(richTextBox_ntid.Text);
                writing.Write(Environment.NewLine);
                writing.Write(Environment.NewLine);
                writing.Write("HostName: ");
                writing.Write(richTextBox_hostname.Text);
                writing.Write(Environment.NewLine);
                writing.Write(Environment.NewLine);
                writing.Write("System Serial No.: ");
                writing.Write(richTextBox_serialno.Text);
                writing.Write(Environment.NewLine);
                writing.Write(Environment.NewLine);
                writing.Write("McAfee DAT version: ");
                writing.Write(richTextBox_datversion.Text);
                writing.Write(Environment.NewLine);
                writing.Write(Environment.NewLine);
                writing.Write("McAfee DAT date: ");
                writing.Write(richTextBox_datdate.Text);
                writing.Write(Environment.NewLine);
                writing.Write(Environment.NewLine);
                writing.Write("USB Protection: ");
                writing.Write(richTextBox_usb.Text);
                writing.Write(Environment.NewLine);
                writing.Write(Environment.NewLine);
                writing.Write("CD/DVD: ");
                writing.Write(richTextBox_dvd.Text);
                writing.Write(Environment.NewLine);
                writing.Write(Environment.NewLine);
                writing.Write("BitLocker Status: ");
                writing.Write(richTextBox_bitlocker.Text);
                writing.Write(Environment.NewLine);
                writing.Write(Environment.NewLine);


                writing.Close();
            }
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.Application.ExitThread();
            System.Windows.Forms.Application.Exit();
            
        }
        /* private void saveToolStripMenuItem_Click(object sender, EventArgs e)
         {
             if (string.IsNullOrEmpty(this.FileName))
             {
                 // call SaveAs 
                 saveasToolStripMenuItem_Click(sender, e);
             }
             else
             {
                 // we already have the filename. we overwrite that file.
                 StreamWriter writer = new StreamWriter(this.FileName);
                 //writer.Write(richTextBox1.Text);
                 writer.Close();
             }
         }
         private void newToolStripMenuItem_Click(object sender, EventArgs e)
         {
             // clear the FileName
             this.FileName = string.Empty;
           //  richTextBox1.Clear();
         }
         */




        public string userMailID(string output)
        {
            try
            {
                Process process = new Process();    //start cmd process
                process.StartInfo.Arguments = "/upn";   //command argument for whoami (whoami /upn)
                process.StartInfo.FileName = "whoami.exe";  //prepare to run whoami command
                process.StartInfo.UseShellExecute = false;  //run cmd invisible
                process.StartInfo.RedirectStandardOutput = true;
                process.Start();    //start cmd with whoami /upn command
                StreamReader reader = process.StandardOutput;
                output = reader.ReadToEnd();
                process.WaitForExit();
                process.Close();
                return (output);
            }
            catch (Exception EX)
            {
                output = "ERROR : Not Found";
                return (output);
            }
        }

        
        public string userNTloginID(string output)
        {
            try
            {
                Process process = new Process();    //start cmd process
                process.StartInfo.FileName = "whoami.exe";  //prepare to run whoami command
                process.StartInfo.UseShellExecute = false;  //run cmd invisible
                process.StartInfo.RedirectStandardOutput = true;
                process.Start();    //start cmd with whoami /upn command
                StreamReader reader = process.StandardOutput;
                output = reader.ReadToEnd();
                process.WaitForExit();
                process.Close();
                return (output);
            }
            catch (Exception EX)
            {
                output = "ERROR : Not Found";
                return (output);
            }
        }

        public string HostName(string output)
        {
            output = Dns.GetHostName(); //method "Dns.GetHostName", available in System.Net namespace
            return (output);
        }

        public string CPUSerialNo(string output)
        {
            ManagementObjectSearcher mos = new ManagementObjectSearcher("select * from Win32_BIOS");
            foreach (ManagementObject managementObject in mos.Get())
            {
                if (managementObject["SerialNumber"] != null)
                {
                    output = managementObject["SerialNumber"].ToString();   //Display CPU serial number                
                }
            }
            return (output);
        }

        public string McAfeeDATversion(string output)
        {
            try
            {
                RegistryKey key = Registry.LocalMachine.OpenSubKey("Software\\Wow6432Node\\McAfee\\DATReputation");
                if (key != null)
                {
                    Object o = key.GetValue("szRepDATVer");
                    if (o != null)
                    {
                        Version version = new Version(o as String);
                        // Console.WriteLine("DAT version: " + version);
                        output = version.ToString();
                    }
                }
                return (output);
            }
            catch (Exception)
            {
                string o = "ERROR : Not Found";
                return (o);
            }
        }

        public string McAfeeDATdate(string output)
        {
            try
            {
                RegistryKey key = Registry.LocalMachine.OpenSubKey("Software\\Wow6432Node\\McAfee\\AVEngine");
                if (key != null)
                {
                    object objValue = key.GetValue("AVDatDate");
                    output = objValue.ToString();
                    // Int64 regVal = Convert.ToInt64(stringValue);
                }
                return (output);
            }
            catch (Exception)
            {
                string E = "ERROR : Not Found";
                return (E);
            }
        }

        public string ExternalMediaUSB()
        {
            RegistryKey key;
            key = Registry.LocalMachine.OpenSubKey("SYSTEM\\CurrentControlSet\\Services\\UsbStor");

            if (System.Convert.ToInt16(key.GetValue("Start", null)) == 4)
                return ("Protected");
            else
                return ("Unprotected");
        }

        public string ExternalMediaDVD()
        {
            RegistryKey key;
            key = Registry.LocalMachine.OpenSubKey("SYSTEM\\CurrentControlSet\\Services\\cdrom");
            if (System.Convert.ToInt16(key.GetValue("Start", null)) == 4)
                return ("Protected");
            else
                return ("Unprotected");
        }

        public string bitlocker(string output)
        {

            ManagementObjectSearcher Encryption = new ManagementObjectSearcher(@"root\cimv2\Security\MicrosoftVolumeEncryption", "SELECT * FROM Win32_EncryptableVolume");

            foreach (ManagementObject QueryObj in Encryption.Get())
            {
                string EncryptionStatus = QueryObj.GetPropertyValue("ProtectionStatus").ToString();

                if (EncryptionStatus == "1")
                {
                    output = "ON";
                }
                else if (EncryptionStatus == "0")
                {
                    output = "OFF";
                }
                else if (EncryptionStatus == "2")
                {
                    output = "Unknown";
                }
            }
            return (output);
    
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            // Determine the CheckState of the check box.  
            if (checkBox1.CheckState == CheckState.Checked)
            {
                // If checked, do not allow items to be dragged onto the form.  
                this.AllowDrop = false;
            }
        }

        private void checkBox1_Click(object sender, System.EventArgs e)
        {
            switch (checkBox1.CheckState)
            {
                case CheckState.Checked:
                    richTextBox_displayname.Text = UserPrincipal.Current.DisplayName.ToString();
                    for (int n = 10; n < 100; n++)
                    {
                        progressBar1.Value = n;
                    }
                    break;
                case CheckState.Unchecked:
                    
                    break;
                case CheckState.Indeterminate:
                    
                    break;
                   
            }         
           // progressBar1.Value = 0;
        
        }





        /*   public string DisplayName(string s)
           {

               s = UserPrincipal.Current.DisplayName.ToString();
               return (s);
           } */



    }

    }














/*private void label1_systemdirectory_Click(object sender, EventArgs e)
        {

        }

        private void label2_emailidout_Click(object sender, EventArgs e)
        {

        }
    }
}
*/
