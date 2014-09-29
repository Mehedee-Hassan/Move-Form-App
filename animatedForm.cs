using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;

namespace formAnimation
{
	/// <summary>
	/// Summary description for animatedForm.
	/// </summary>
	public class animatedForm : System.Windows.Forms.Form
	{
		private System.Windows.Forms.Button btnClose;
		private int animationTime;
		private int flags;
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.Container components = null;

		public animatedForm()
		{
			//
			// Required for Windows Form Designer support
			//
			InitializeComponent();

			//
			// TODO: Add any constructor code after InitializeComponent call
			//
		}

		public animatedForm(int AnimationTime,int Flags)
		{
			animationTime = AnimationTime;
			flags = Flags;
			InitializeComponent();
		}

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		protected override void Dispose( bool disposing )
		{
			if( disposing )
			{
				if(components != null)
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
			this.btnClose = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// btnClose
			// 
			this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
			this.btnClose.Location = new System.Drawing.Point(104, 34);
			this.btnClose.Name = "btnClose";
			this.btnClose.Size = new System.Drawing.Size(88, 32);
			this.btnClose.TabIndex = 0;
			this.btnClose.Text = "Close";
			this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
			// 
			// animatedForm
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
			this.ClientSize = new System.Drawing.Size(296, 101);
			this.Controls.Add(this.btnClose);
			this.Name = "animatedForm";
			this.ShowInTaskbar = false;
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Animated Form in Action";
			this.TopMost = true;
			this.Load += new System.EventHandler(this.animatedForm_Load);
			this.ResumeLayout(false);

		}
		#endregion

		private void btnClose_Click(object sender, System.EventArgs e)
		{
			/*flags -= WinAPI.AW_ACTIVATE;
			flags += WinAPI.AW_HIDE;
			WinAPI.AnimateWindow(this.Handle,animationTime,flags);*/
			this.Dispose();
		}

		private void animatedForm_Load(object sender, System.EventArgs e)
		{
			WinAPI.AnimateWindow(this.Handle,animationTime,flags);
		}
	}
}
