using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Banmex.Menu
{
    public partial class MakeTransaction : Form
    {
        Class.Connection Connection = new Class.Connection();

        public MakeTransaction(Class.Connection Connection)
        {
            InitializeComponent();

            this.Connection = Connection;
        }
    }
}
