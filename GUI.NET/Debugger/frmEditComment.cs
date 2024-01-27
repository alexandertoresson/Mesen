using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using Mesen.GUI.Forms;

namespace Mesen.GUI.Debugger
{
	public partial class frmEditComment : BaseConfigForm
	{
		private CodeLabel _originalLabel;

		public frmEditComment(CodeLabel label, CodeLabel originalLabel = null)
		{
			InitializeComponent();
			_originalLabel = originalLabel;
			Entity = label;
			AddBinding("Comment", txtComment);
		}

		protected override void OnShown(EventArgs e)
		{
			base.OnShown(e);
			txtComment.Focus();
		}

		protected override bool ValidateInput()
		{
			UpdateObject();
			return !txtComment.Text.Contains('\x1');
		}

		protected override void OnFormClosed(FormClosedEventArgs e)
		{
			base.OnFormClosed(e);
		}

		protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
		{
			if(keyData == (Keys.Control | Keys.Enter)) {
				this.DialogResult = DialogResult.OK;
				this.Close();
			}
			return base.ProcessCmdKey(ref msg, keyData);
		}

		private void frmEditComment_Load(object sender, EventArgs e)
		{

		}
   }
}
