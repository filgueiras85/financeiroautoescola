using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GerenciadorFinanceiro.Controles
{
    class FormatTextBox: System.Windows.Forms.TextBox
    {
        string str = "";
        protected override void OnKeyDown(System.Windows.Forms.KeyEventArgs e)
        {
            int KeyCode = e.KeyValue;

            if (!IsNumeric(KeyCode))
            {
                e.Handled = true;
                return;
            }
            else
            {
                e.Handled = true;
            }
            if (((KeyCode == 8) || (KeyCode == 46)) && (str.Length > 0))
            {
                str = str.Substring(0, str.Length - 1);
            }
            else if (!((KeyCode == 8) || (KeyCode == 46)))
            {
                str = str + Convert.ToChar(KeyCode);
            }
            if (str.Length == 0)
            {
                this.Text = "";
            }
            if (str.Length == 1)
            {
                this.Text = "0,0" + str;
            }
            else if (str.Length == 2)
            {
                this.Text = "0," + str;
            }
            else if (str.Length > 2)
            {
                this.Text = str.Substring(0, str.Length - 2) + "," + str.Substring(str.Length - 2);
            }
            base.OnKeyDown(e);
        }
        private bool IsNumeric(int Val)
        {
            return ((Val >= 48 && Val <= 57) || (Val == 8) || (Val == 46));
        }
        protected override void OnKeyPress(System.Windows.Forms.KeyPressEventArgs e)
        {
            e.Handled = true;
            base.OnKeyPress(e);
        }        
    }
}
