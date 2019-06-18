using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace List_Demo_2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            var newInventory = new List<Car>
            {
                new Car("3HGGK5H46JM185291","Fit", 4, "Red", "LX"),
                new Car("SHHFK7G44JU621982","Civic", 4, "Blue", "EX"),
                new Car("SHHFK7H54JU812940","Civic", 4, "Blue", "EX")
            };

            lbxNewCars.Items.AddRange(newInventory.ToArray());

            var usedInventory = new List<Car>
            {
                new Car("1HGCV1F92JA000590","Accord", 4, "Gray", "LX", 210000),
                new Car("JH4NA2163XT123891","NSX", 6, "Green", "R", 137000),
                new Car("JHMAP1149YT102348","S2000", 4, "Blue", "CR", 65000)
            };

            lbxUsedCars.Items.AddRange(usedInventory.ToArray());
        }

        private void lbxNewCars_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lbxNewCars.SelectedIndex != -1)
                if (MessageBox.Show($"Selling {lbxNewCars.SelectedItem}?",
                    "Honda Auto Land", MessageBoxButtons.OKCancel,
                    MessageBoxIcon.Question) == DialogResult.OK)
                {
                    lbxNewCars.Items.RemoveAt(lbxNewCars.SelectedIndex);
                }
        }

        private void lbxUsedCars_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            if (lbxUsedCars.SelectedIndex != -1)
                if (MessageBox.Show($"Selling {lbxUsedCars.SelectedItem}?",
                    "Honda Auto Land", MessageBoxButtons.OKCancel,
                    MessageBoxIcon.Question) == DialogResult.OK)
                {
                    lbxUsedCars.Items.RemoveAt(lbxUsedCars.SelectedIndex);
                }
        }
    }
}
