namespace Mesen.GUI.Debugger
{
	partial class frmEditComment
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
			if(disposing && (components != null)) {
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
			this.lblComment = new System.Windows.Forms.Label();
			this.txtComment = new System.Windows.Forms.TextBox();
			this.SuspendLayout();
			// 
			// baseConfigPanel
			// 
			this.baseConfigPanel.Location = new System.Drawing.Point(0, 42);
			this.baseConfigPanel.Size = new System.Drawing.Size(377, 29);
			// 
			// lblComment
			// 
			this.lblComment.AutoSize = true;
			this.lblComment.Location = new System.Drawing.Point(3, 15);
			this.lblComment.Name = "lblComment";
			this.lblComment.Size = new System.Drawing.Size(54, 13);
			this.lblComment.TabIndex = 4;
			this.lblComment.Text = "Comment:";
			// 
			// txtComment
			// 
			this.txtComment.AcceptsReturn = true;
			this.txtComment.Location = new System.Drawing.Point(63, 12);
			this.txtComment.Name = "txtComment";
			this.txtComment.ScrollBars = System.Windows.Forms.ScrollBars.Both;
			this.txtComment.Size = new System.Drawing.Size(311, 20);
			this.txtComment.TabIndex = 5;
			// 
			// frmEditComment
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(377, 71);
			this.Controls.Add(this.lblComment);
			this.Controls.Add(this.txtComment);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
			this.Name = "frmEditComment";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
			this.Text = "Edit Comment";
			this.Load += new System.EventHandler(this.frmEditComment_Load);
			this.Controls.SetChildIndex(this.baseConfigPanel, 0);
			this.Controls.SetChildIndex(this.txtComment, 0);
			this.Controls.SetChildIndex(this.lblComment, 0);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

	  #endregion

	  private System.Windows.Forms.Label lblComment;
	  private System.Windows.Forms.TextBox txtComment;
   }
}