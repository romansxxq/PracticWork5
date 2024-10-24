using System;
using System.Text;
using System.Windows.Forms;
using Microsoft.VisualBasic;

namespace PracticWork5
{
    internal class Task2_option9
    {
        static void Main(string[] args)
        {
            double x, y = 0;
            string S;
            Repeat:
            x = 93;
            Console.OutputEncoding = Encoding.UTF8;
            S = Interaction.InputBox("Введіть x: ", "Введення", x.ToString());
            x = Convert.ToDouble(S);
            if (x > -3)
            {
                y = Math.Sin(Math.Pow(x, y) + 1);
            }
            else
            {
                if (x >= 0)
                {
                    y = 2 * x + Math.Pow(Math.Log(4.4), 2);
                }
                else
                {
                    if (Math.Abs(x) < -3 && x < 0)
                    {
                        y = Math.Pow(Math.E, (1 / x));
                    }
                }
            }
            DialogResult R = MessageBox.Show($"При x = {x} обчислено y={y}. Бажаєте рахувати ще?", "Результати обчислень", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            if (R == DialogResult.Yes)
            {
                goto Repeat;
            }
        }

    }
}
