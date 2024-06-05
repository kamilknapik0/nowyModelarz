using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Modelarz
{
    public partial class PodgladWizyt : Form
    {
        public PodgladWizyt(DateTime selectedDate)
        {
            InitializeComponent();
            label2.Text = selectedDate.ToString("d MMMM yyyy"); 
            LoadVisits(selectedDate);
            this.Font = new Font("Open Sans", this.Font.Size);
        }

        private void LoadVisits(DateTime selectedDate)
        {

            for (int i = 0; i < Home.dataArray.GetLength(0); i++)
            {
                if (Home.dataArray[i, 0].Equals(selectedDate.ToString("dd-MM-yyyy")))
                {
                    string text = $"{Home.dataArray[i, 1]} {Home.dataArray[i, 2]}, Godzina: {Home.dataArray[i, 3]}";
                    listBox1.Items.Add(text);
                }

            }
        
    }
    }
}
