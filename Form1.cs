using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Threading;
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
        private int flags;
        private Button moveLeftToRightButton;
        private Button moveRightToLeft;
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.Container components = null;

		public Form1()
		{
			InitializeComponent();
	

		}


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
            this.moveLeftToRightButton = new System.Windows.Forms.Button();
            this.moveRightToLeft = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // moveLeftToRightButton
            // 
            this.moveLeftToRightButton.Location = new System.Drawing.Point(12, 28);
            this.moveLeftToRightButton.Name = "moveLeftToRightButton";
            this.moveLeftToRightButton.Size = new System.Drawing.Size(141, 23);
            this.moveLeftToRightButton.TabIndex = 6;
            this.moveLeftToRightButton.Text = "Move Left To Right";
            this.moveLeftToRightButton.UseVisualStyleBackColor = true;
            this.moveLeftToRightButton.Click += new System.EventHandler(this.moveButton_Click);
            // 
            // moveRightToLeft
            // 
            this.moveRightToLeft.Location = new System.Drawing.Point(202, 28);
            this.moveRightToLeft.Name = "moveRightToLeft";
            this.moveRightToLeft.Size = new System.Drawing.Size(141, 23);
            this.moveRightToLeft.TabIndex = 7;
            this.moveRightToLeft.Text = "Move Right To Left";
            this.moveRightToLeft.UseVisualStyleBackColor = true;
            this.moveRightToLeft.Click += new System.EventHandler(this.moveRightToLeft_Click);
            // 
            // Form1
            // 
            this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
            this.ClientSize = new System.Drawing.Size(367, 63);
            this.Controls.Add(this.moveRightToLeft);
            this.Controls.Add(this.moveLeftToRightButton);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Windows Form Animation";
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


	    private Rectangle GetScreen()
	    {
	        return Screen.PrimaryScreen.Bounds;
	    }


        private void moveButton_Click(object sender, EventArgs e)
        {

            int width = this.GetScreen().Width - this.Width;
            
            animatedForm a = new animatedForm();
            for (int i = 0; i < width; i += 3)
            {
                
            
                a.Location = new Point(i , 50);


                a.Show();
                Thread.Sleep(10);
            }


        }

        private void moveRightToLeft_Click(object sender, EventArgs e)
        {
            int widht = GetScreen().Width - this.Width;

            animatedForm a = new animatedForm();
            for (int i = widht; i >= 0; i -= 3)
            {


                a.Location = new Point(i, 50);


                a.Show();
                Thread.Sleep(10);
            }
        }
	}
}
