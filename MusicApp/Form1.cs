using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static MusicApp.Program;

namespace MusicApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnSignUp_Click(object sender, EventArgs e)
        {
            using (Form2 form2 = new Form2())
            {

                switch (form2.ShowDialog())
                {
                    case DialogResult.OK:

                        using (MusicAppContext data = new MusicAppContext())
                        {
                            data.User.Add(new User() { FirstName = form2.FirstName, LastName = form2.LastName, Email = form2.Email, Password = form2.Password });
                            data.SaveChanges();

                        }

                        break;
                }
            }
        }
    }
}
