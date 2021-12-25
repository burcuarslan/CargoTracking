using CargoTrackingApp;
using CargoTrackingApp.Business.Concrete;
using CargoTrackingApp.DataAccess.Concrete;
using CargoTrackingApp.Entity.Concrete;
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
    public partial class Cargo :Form
    {
        CargoTrackingManager manager;

        public Cargo()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            manager = new CargoTrackingManager(new InMemoryCargoTracking());
            Tracking newCargo = new Tracking(Convert.ToInt32(textBox2.Text), textBox3.Text, textBox4.Text, textBox5.Text, textBox6.Text, Convert.ToInt32(textBox7.Text), textBox8.Text, textBox9.Text, Convert.ToInt32(textBox10.Text),textBox11.Text);

            manager.Add(newCargo);

            foreach (var c in manager.GetAll())
            {
                MessageBox.Show(c.Name);

            }
        }
    }
}
