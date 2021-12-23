
using CargoTracking.Business.Abstract;
using CargoTracking.Business.Concrete;
using CargoTracking.DataAccess.Abstract;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CargoTracking
{
    public partial class Form1 : Form
    {
        CargoTrackingManager manager = new CargoTrackingManager(new InMemoryCargoTracking());
        public Form1()
        {
            InitializeComponent();
           
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int _id = Convert.ToInt32(textBox1.Text);
            foreach (var cargo in manager.GetById(_id))
            {
                MessageBox.Show(cargo.CargoStatus);
            }

        }
    }
}
