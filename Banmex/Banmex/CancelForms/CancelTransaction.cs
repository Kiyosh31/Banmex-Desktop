using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Banmex.CancelForms
{
    public partial class CancelTransaction : Form
    {
        Class.Connection Connection;

        public CancelTransaction(Class.Connection Connection)
        {
            InitializeComponent();

            this.Connection = Connection;
        }
    }
}
