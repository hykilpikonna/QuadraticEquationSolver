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
            /*String tempEquation = Input.Text;
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
            }*/

            int A = 0, B = 0, C = 0;

            if (IsNumeric(a.Text))
            {
                A = Int32.Parse(a.Text);
            }
            else
            {
                Output1.Text = "ERROR";
                Output2.Text = "A is not an int";
            }

            if (IsNumeric(b.Text))
            {
                B = Int32.Parse(b.Text);
            }
            else
            {
                Output1.Text = "ERROR";
                Output2.Text = "B is not an int";
            }

            if (IsNumeric(c.Text))
            {
                C = Int32.Parse(c.Text);
            }
            else
            {
                Output1.Text = "ERROR";
                Output2.Text = "C is not an int";
            }

            Output1.Text = (((0 - B) + Math.Sqrt((Math.Pow(B, 2)) - (4 * A * C))) / (2 * A)).ToString();
            Output2.Text = (((0 - B) - Math.Sqrt((Math.Pow(B, 2)) - (4 * A * C))) / (2 * A)).ToString();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void QuadraticSolver_Load(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        public static System.Boolean IsNumeric(System.Object Expression)
        {
            if (Expression == null || Expression is DateTime)
                return false;

            if (Expression is Int16 || Expression is Int32 || Expression is Int64 || Expression is Decimal || Expression is Single || Expression is Double || Expression is Boolean)
                return true;

            try
            {
                if (Expression is string)
                    Double.Parse(Expression as string);
                else
                    Double.Parse(Expression.ToString());
                return true;
            }
            catch { } // just dismiss errors but return false
            return false;
        }

        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            if (keyData == Keys.Escape)
            {
                this.Close();
                return true;
            }
            return base.ProcessCmdKey(ref msg, keyData);
        }

        private bool mouseDown;
        private Point lastLocation;

        private void QuadraticSolver_MouseDown(object sender, MouseEventArgs e)
        {
            mouseDown = true;
            lastLocation = e.Location;
        }

        private void QuadraticSolver_MouseUp(object sender, MouseEventArgs e)
        {
            mouseDown = false;
        }

        private void QuadraticSolver_MouseMove(object sender, MouseEventArgs e)
        {
            if (mouseDown)
            {
                this.Location = new Point(
                    (this.Location.X - lastLocation.X) + e.X, (this.Location.Y - lastLocation.Y) + e.Y);

                this.Update();
            }
        }
    }
}
