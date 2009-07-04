using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace GerenciadorFinanceiro.Controls
{
    public partial class CtrNavigator : UserControl
    {
        public DataSet  _DataSet { get; set; } 

        public CtrNavigator()
        {
            InitializeComponent();
        }
    }
}
