using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AdminPanel.Presenters;
using Manipulator.Shared.Infrastructure;

namespace AdminPanel
{
    public partial class MainForm : Form
    {
        public MainPresenter Presenter { get; set; }

        public MainForm()
        {
            InitializeComponent();

            dataGridView1.DataSource = bindingSource1;

            bindingSource1.DataSource = Presenter.TableRecords;
        }
    }
}