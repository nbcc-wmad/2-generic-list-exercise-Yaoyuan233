using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
/* Arthor:YaoyuanGuo
 * Date:4/26/2019
 */
namespace exercise2
{

    public partial class Form1 : Form
    {
        public string Grade;
        private ArrayList grade = new ArrayList();

        public Form1()
        {
            InitializeComponent();
        }

        private void btnShowGrade_Click(object sender, EventArgs e)
        {
            grade.Add(txtScore.Text.Trim());
            grade.Sort();
            int index = grade.IndexOf(txtScore.Text.Trim());
            grade.Remove(txtScore.Text.Trim());
            if(index==0)
            {
                Grade = "F";
            }
            else if (index == 1)
            {
                Grade = "D";

            }
            else if (index == 2)
            {
                Grade = "C";

            }
            else if (index == 3)
            {
                Grade = "B";

            }
            else if(index == 4)
            {
                Grade = "A";

            }
            MessageBox.Show(Grade);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            grade.Add("299");
            grade.Add("349");
            grade.Add("399");
            grade.Add("449");
            grade.Add("500");
        }
    }
}
