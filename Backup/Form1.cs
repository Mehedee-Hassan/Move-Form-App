using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;

namespace formAnimation
{
	/// <summary>
	/// Summary description for Form1.
	/// </summary>
	public class Form1 : System.Windows.Forms.Form
	{
		private int animationTime;
		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.Button btnCollapseInward;
		private int flags;
		private System.Windows.Forms.NumericUpDown nudAnimationTime;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Button btnFadeEffect;
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.CheckBox chkSlide;
		private System.Windows.Forms.Button btnBottomToTop;
		private System.Windows.Forms.Button btnTopToBottom;
		private System.Windows.Forms.Button btnRightToLeft;
		private System.Windows.Forms.Button btnLeftToRight;
		private System.Windows.Forms.Button btnExit;
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
			animationTime = (int)nudAnimationTime.Value;

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
			this.panel1 = new System.Windows.Forms.Panel();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.chkSlide = new System.Windows.Forms.CheckBox();
			this.btnBottomToTop = new System.Windows.Forms.Button();
			this.btnTopToBottom = new System.Windows.Forms.Button();
			this.btnRightToLeft = new System.Windows.Forms.Button();
			this.btnLeftToRight = new System.Windows.Forms.Button();
			this.btnFadeEffect = new System.Windows.Forms.Button();
			this.label1 = new System.Windows.Forms.Label();
			this.nudAnimationTime = new System.Windows.Forms.NumericUpDown();
			this.btnCollapseInward = new System.Windows.Forms.Button();
			this.btnExit = new System.Windows.Forms.Button();
			this.panel1.SuspendLayout();
			this.groupBox1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.nudAnimationTime)).BeginInit();
			this.SuspendLayout();
			// 
			// panel1
			// 
			this.panel1.Controls.Add(this.btnExit);
			this.panel1.Controls.Add(this.groupBox1);
			this.panel1.Controls.Add(this.btnFadeEffect);
			this.panel1.Controls.Add(this.label1);
			this.panel1.Controls.Add(this.nudAnimationTime);
			this.panel1.Controls.Add(this.btnCollapseInward);
			this.panel1.Location = new System.Drawing.Point(8, 4);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(432, 158);
			this.panel1.TabIndex = 5;
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.chkSlide);
			this.groupBox1.Controls.Add(this.btnBottomToTop);
			this.groupBox1.Controls.Add(this.btnTopToBottom);
			this.groupBox1.Controls.Add(this.btnRightToLeft);
			this.groupBox1.Controls.Add(this.btnLeftToRight);
			this.groupBox1.Location = new System.Drawing.Point(8, 36);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(416, 77);
			this.groupBox1.TabIndex = 15;
			this.groupBox1.TabStop = false;
			// 
			// chkSlide
			// 
			this.chkSlide.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.chkSlide.Location = new System.Drawing.Point(144, 52);
			this.chkSlide.Name = "chkSlide";
			this.chkSlide.Size = new System.Drawing.Size(140, 16);
			this.chkSlide.TabIndex = 6;
			this.chkSlide.Text = "Use Slide Animation";
			// 
			// btnBottomToTop
			// 
			this.btnBottomToTop.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
			this.btnBottomToTop.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.btnBottomToTop.Location = new System.Drawing.Point(314, 19);
			this.btnBottomToTop.Name = "btnBottomToTop";
			this.btnBottomToTop.Size = new System.Drawing.Size(93, 24);
			this.btnBottomToTop.TabIndex = 5;
			this.btnBottomToTop.Text = "Bottom to Top";
			this.btnBottomToTop.Click += new System.EventHandler(this.btnBottomToTop_Click);
			// 
			// btnTopToBottom
			// 
			this.btnTopToBottom.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
			this.btnTopToBottom.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.btnTopToBottom.Location = new System.Drawing.Point(210, 19);
			this.btnTopToBottom.Name = "btnTopToBottom";
			this.btnTopToBottom.Size = new System.Drawing.Size(93, 24);
			this.btnTopToBottom.TabIndex = 4;
			this.btnTopToBottom.Text = "Top to Bottom";
			this.btnTopToBottom.Click += new System.EventHandler(this.btnTopToBottom_Click);
			// 
			// btnRightToLeft
			// 
			this.btnRightToLeft.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
			this.btnRightToLeft.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.btnRightToLeft.Location = new System.Drawing.Point(106, 19);
			this.btnRightToLeft.Name = "btnRightToLeft";
			this.btnRightToLeft.Size = new System.Drawing.Size(93, 24);
			this.btnRightToLeft.TabIndex = 3;
			this.btnRightToLeft.Text = "Right to Left";
			this.btnRightToLeft.Click += new System.EventHandler(this.btnRightToLeft_Click);
			// 
			// btnLeftToRight
			// 
			this.btnLeftToRight.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
			this.btnLeftToRight.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.btnLeftToRight.Location = new System.Drawing.Point(10, 19);
			this.btnLeftToRight.Name = "btnLeftToRight";
			this.btnLeftToRight.Size = new System.Drawing.Size(93, 24);
			this.btnLeftToRight.TabIndex = 2;
			this.btnLeftToRight.Text = "Left to Right";
			this.btnLeftToRight.Click += new System.EventHandler(this.btnLeftToRight_Click);
			// 
			// btnFadeEffect
			// 
			this.btnFadeEffect.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
			this.btnFadeEffect.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.btnFadeEffect.Location = new System.Drawing.Point(144, 123);
			this.btnFadeEffect.Name = "btnFadeEffect";
			this.btnFadeEffect.Size = new System.Drawing.Size(113, 24);
			this.btnFadeEffect.TabIndex = 8;
			this.btnFadeEffect.Text = "Fade Effect";
			this.btnFadeEffect.Click += new System.EventHandler(this.btnFadeEffect_Click);
			// 
			// label1
			// 
			this.label1.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.label1.Location = new System.Drawing.Point(104, 13);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(121, 16);
			this.label1.TabIndex = 13;
			this.label1.Text = "Animation Duration";
			// 
			// nudAnimationTime
			// 
			this.nudAnimationTime.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.nudAnimationTime.Increment = new System.Decimal(new int[] {
																			   100,
																			   0,
																			   0,
																			   0});
			this.nudAnimationTime.Location = new System.Drawing.Point(256, 10);
			this.nudAnimationTime.Maximum = new System.Decimal(new int[] {
																			 10000,
																			 0,
																			 0,
																			 0});
			this.nudAnimationTime.Minimum = new System.Decimal(new int[] {
																			 1000,
																			 0,
																			 0,
																			 0});
			this.nudAnimationTime.Name = "nudAnimationTime";
			this.nudAnimationTime.Size = new System.Drawing.Size(72, 22);
			this.nudAnimationTime.TabIndex = 1;
			this.nudAnimationTime.Value = new System.Decimal(new int[] {
																		   1000,
																		   0,
																		   0,
																		   0});
			this.nudAnimationTime.ValueChanged += new System.EventHandler(this.nudAnimationTime_ValueChanged);
			// 
			// btnCollapseInward
			// 
			this.btnCollapseInward.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
			this.btnCollapseInward.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.btnCollapseInward.Location = new System.Drawing.Point(20, 123);
			this.btnCollapseInward.Name = "btnCollapseInward";
			this.btnCollapseInward.Size = new System.Drawing.Size(113, 24);
			this.btnCollapseInward.TabIndex = 7;
			this.btnCollapseInward.Text = "Collapse Inward";
			this.btnCollapseInward.Click += new System.EventHandler(this.btnCollapseInward_Click);
			// 
			// btnExit
			// 
			this.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
			this.btnExit.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.btnExit.Location = new System.Drawing.Point(367, 123);
			this.btnExit.Name = "btnExit";
			this.btnExit.Size = new System.Drawing.Size(57, 24);
			this.btnExit.TabIndex = 9;
			this.btnExit.Text = "Exit";
			this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
			// 
			// Form1
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
			this.ClientSize = new System.Drawing.Size(448, 473);
			this.Controls.Add(this.panel1);
			this.Name = "Form1";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Windows Form Animation";
			this.panel1.ResumeLayout(false);
			this.groupBox1.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.nudAnimationTime)).EndInit();
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

		private void btnLeftToRight_Click(object sender, System.EventArgs e)
		{
			flags = WinAPI.AW_ACTIVATE|WinAPI.AW_HOR_POSITIVE;

			//for extra effects
			if(chkSlide.Checked)
			{
				flags |= WinAPI.AW_SLIDE;
			}
			
			animatedForm a = new animatedForm(animationTime,flags);
			a.Show();
		}

		private void btnRightToLeft_Click(object sender, System.EventArgs e)
		{
			flags = WinAPI.AW_ACTIVATE|WinAPI.AW_HOR_NEGATIVE;
			
			//for extra effects
			if(chkSlide.Checked)
			{
				flags |= WinAPI.AW_SLIDE;
			}
			
			animatedForm a = new animatedForm(animationTime,flags);
			a.Show();
		}

		private void btnTopToBottom_Click(object sender, System.EventArgs e)
		{
			flags = WinAPI.AW_ACTIVATE|WinAPI.AW_VER_POSITIVE;
			
			//for extra effects
			if(chkSlide.Checked)
			{
				flags |= WinAPI.AW_SLIDE;
			}
			
			animatedForm a = new animatedForm(animationTime,flags);
			a.Show();
		}

		private void btnBottomToTop_Click(object sender, System.EventArgs e)
		{
			flags = WinAPI.AW_ACTIVATE|WinAPI.AW_VER_NEGATIVE;
			
			//for extra effects
			if(chkSlide.Checked)
			{
				flags |= WinAPI.AW_SLIDE;
			}
			
			animatedForm a = new animatedForm(animationTime,flags);
			a.Show();
		}

		private void btnCollapseInward_Click(object sender, System.EventArgs e)
		{
			flags = WinAPI.AW_ACTIVATE|WinAPI.AW_CENTER;
			
			animatedForm a = new animatedForm(animationTime,flags);
			a.Show();		
		}

		private void btnFadeEffect_Click(object sender, System.EventArgs e)
		{
			flags = WinAPI.AW_ACTIVATE|WinAPI.AW_BLEND;

			animatedForm a = new animatedForm(animationTime,flags);
			a.Show();		
		}

		private void btnExit_Click(object sender, System.EventArgs e)
		{
			Application.Exit();
		}

		private void nudAnimationTime_ValueChanged(object sender, System.EventArgs e)
		{
			animationTime = (int)nudAnimationTime.Value;
		}
	}
}
