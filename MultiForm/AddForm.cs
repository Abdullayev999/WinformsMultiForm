using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MultiForm
{
    public partial class AddForm : Form
    {
        public Person Person { get;private set; }
        private string imagePath = null;
        public AddForm()
        {
            InitializeComponent();
        }

        public AddForm(Person person)
        {
            InitializeComponent();
            NametextBox.Text = person.Name;
            SurnametextBox1.Text= person.Surname ;
            EmailtextBox.Text = person.Email;
            NumbermaskedTextBox1.Text = person.Number;
            dateTimePicker1.Value = person.DataOfBirth;
            FavoritecheckBox1.Checked = person.Favortie;
            switch (person.Gender)
            {
                case Gender.Male:
                    MaleradioButton1.Checked = true;
                    break;
                case Gender.Female:
                    FemaleradioButton3.Checked = true;
                    break;
                case Gender.Other:
                    Other.Checked = false;
                    break;
            }


            pictureBox.Image=Image.FromFile(person.Image);
        }

        private string UploadAndGetNewPath(string oldPath)
        {
            string newPath = null;
           
            try
            {
                
                var directory = Directory.GetCurrentDirectory();
                if (!Directory.Exists($@"{directory}\Photos"))
                {
                    Directory.CreateDirectory($@"{directory}\Photos");
                }

                if (oldPath == null)
                {
                    newPath = $@"{directory}\Photos\default_image.png";
                }
                else 
                {
                    var extention = Path.GetExtension(oldPath);
                    newPath = $@"{directory}\Photos\{Guid.NewGuid()}{extention}";
                    File.Copy(oldPath, newPath);
                }
               
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }

            return newPath;
        }
        private void Closebutton1_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }

        private void Addbutton1_Click(object sender, EventArgs e)
        {
           
            Person = new Person();
            Person.Name = NametextBox.Text;
            Person.Surname = SurnametextBox1.Text;
            Person.Email = EmailtextBox.Text;
            Person.Number = NumbermaskedTextBox1.Text;
            Person.DataOfBirth = dateTimePicker1.Value;
            Person.Favortie = FavoritecheckBox1.Checked;
            Person.Image = UploadAndGetNewPath(imagePath);
            if (MaleradioButton1.Checked)
            {
                Person.Gender = Gender.Male;
            }
            else if (FemaleradioButton3.Checked)
            {
                Person.Gender = Gender.Female;
            }
            else
            {
                Person.Gender = Gender.Other;
            }
            DialogResult = DialogResult.OK;
            Close();
        }

        private void Imagebutton_Click(object sender, EventArgs e)
        {
            var dialoge = new OpenFileDialog();
            dialoge.Filter = "Image ( *.png,*.jpg ) | *.jpg;*.png";
            var result = dialoge.ShowDialog();
            if (result==DialogResult.OK)
            {
                imagePath = dialoge.FileName;
                pictureBox.Image = Image.FromFile(imagePath);
            }
        }
    }
}
