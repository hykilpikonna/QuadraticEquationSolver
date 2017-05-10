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

namespace QuadraticEquationSolver
{
    public partial class QuadraticSolver : Form
    {
        public QuadraticSolver()
        {
            InitializeComponent();
        }

        private void Calculate_Click(object sender, EventArgs e)
        {
            String tempEquation = Input.Text;
            ArrayList equation = new ArrayList();
            String tempString = "";
            for (int i = 0; i < tempEquation.Length; i++)
            {
                if (!(tempEquation[i].Equals("+")))
                {
                    tempString += tempEquation[i];
                }
                else
                {
                    equation.Add(tempString);
                    tempString = "";
                }
            }
            if (equation.Count == 3)
            {
                int a = -600, b = -600, c = -600;

                tempString = "";
                for (int i = 0; i < 3; i++)
                {
                    for (int j = 0; j < ((String)equation[i]).Length; j++)
                    {
                        if (((String)equation[i])[j].Equals('-'))
                        {
                            
                        }
                        else if (((String)equation[i])[j].Equals('x'))
                        {
                            switch(i)
                            {
                                case 0:
                                    a = Int32.Parse(tempString);
                                    break;
                                case 1:
                                    b = Int32.Parse(tempString);
                                    break;
                                case 2:
                                    c = Int32.Parse(tempString);
                                    break;
                                default:
                                    break;
                            }
                            
                        }
                        else
                        {
                            tempString += ((String)equation[i])[j];
                        }
                    }
                }
                 
                if (((String)equation[0])[0].Equals('-'))
                {
                    a = a * -1;
                }
                if (((String)equation[1])[0].Equals('-'))
                {
                    b = b * -1;
                }
                if (((String)equation[2])[0].Equals('-'))
                {
                    c = c * -1;
                }

                Output1.Text = (((0 - b) + Math.Sqrt((b ^ 2) - (4 * a * c))) / 2).ToString();
                Output2.Text = (((0 - b) - Math.Sqrt((b ^ 2) - (4 * a * c))) / 2).ToString();
            }
            else
            {
                Output1.Text = "Error.(arraylist length != 3)";
                Output2.Text = "arraylist.length = " + equation.Count;
            }
        }
    }
}
