using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MultiForm
{
    public partial class ViewForm : Form
    {
        public ViewForm(Person person)
        {
            InitializeComponent();
            NameLabel.Text = person.Name;
            SurnameLabel1.Text = person.Surname;
            NumbertextBox.Text = person.Number;
            EmailtextBox.Text = person.Email;
            Additionlabel.Text = $"Gender : {person.Gender}\n\nData of birht : {person.DataOfBirth}";
            Favoritelabel2.Visible = person.Favortie;
            pictureBox1.Image = Image.FromFile(person.Image);
        }

        private void Closebutton1_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
