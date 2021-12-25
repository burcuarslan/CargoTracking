
using CargoTrackingApp.Business.Abstract;
using CargoTrackingApp.Business.Concrete;
using CargoTrackingApp.DataAccess.Abstract;
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
using System.Threading;

namespace CargoTrackingApp
{
    public partial class Form1 : Form
    {
        CargoTrackingManager manager = new CargoTrackingManager(new InMemoryCargoTracking());
       // ICargoTrackingService _trackingService;


        public Form1()
        {
            InitializeComponent();
           // _trackingService = trackingService;
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
            InMemoryCargoTracking ınMemory = new InMemoryCargoTracking();

            MessageBox.Show((ınMemory.b).ToString());

        }
        
        private void button2_Click(object sender, EventArgs e)
        {

            CargoTracking newCargo = new CargoTracking(Convert.ToInt32(textBox2.Text),textBox3.Text,textBox4.Text, textBox5.Text, textBox6.Text, textBox7.Text, Convert.ToInt32(textBox8.Text),textBox9.Text,textBox10.Text,Convert.ToInt32(textBox11.Text),textBox12.Text);

            manager.Add(newCargo);
            Thread.Sleep(5000);
            foreach (var c in manager.GetAll())
            {
                MessageBox.Show(c.Name);
                
            }
            
        }

        private void button3_Click(object sender, EventArgs e)
        {
            //int delete = Convert.ToInt32(textBox13.Text);
            //manager.Delete(delete);
        }
    }
}
