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
using Newtonsoft.Json;

namespace MultiForm
{
    public partial class Form1 : Form
    {

        private List<Person> people = new List<Person>();
        public Form1()
        {
            InitializeComponent();
            people = JsonConvert.DeserializeObject<List<Person>>(File.ReadAllText("data.json"));
            PersonlistBox.Items.AddRange(people.ToArray());
            
        }

        private void ViewButton_Click(object sender, EventArgs e)
        {
            //  MessageBox.Show("ok");//net
            // MessageBox.Show("ok");//net


            if (PersonlistBox.SelectedItem is Person person)
            {
                ViewForm a = new ViewForm(person);
                a.ShowDialog();
            }
            
        }

        protected override void OnClosing(CancelEventArgs e)
        {
            File.WriteAllText("data.json", JsonConvert.SerializeObject(people));
            base.OnClosing(e);
        }


        private void Form1_DoubleClick(object sender, EventArgs e)
        {
            ViewButton_Click(sender,e);
        }

        private void Addbutton1_Click(object sender, EventArgs e)//dobavlenie
        {
            var addForm = new AddForm();
            var result= addForm.ShowDialog();
            if (result==DialogResult.OK)
            {
                people.Add(addForm.Person);
                PersonlistBox.Items.Add(addForm.Person);
            }
            
        }

        private void Deletebutton1_Click(object sender, EventArgs e)//udalenie
        {
            if (PersonlistBox.SelectedItem is Person person)
            {
                int index = people.IndexOf(person);
                people.RemoveAt(index);
                PersonlistBox.Items.RemoveAt(index);
            }
        }

        private void Editbutton1_Click(object sender, EventArgs e)
        {
            Person selectedPerson = PersonlistBox.SelectedItem as Person;
            if (selectedPerson!=null)
            {
                AddForm editForm = new AddForm(selectedPerson);
                var result = editForm.ShowDialog();
                if (result==DialogResult.OK)
                {
                    int index = PersonlistBox.SelectedIndex;
                    people.RemoveAt(index);
                    people.Insert(index,editForm.Person);

                    PersonlistBox.Items.RemoveAt(index);
                    PersonlistBox.Items.Insert(index,editForm.Person);
                }
            }
        }
    }
}
