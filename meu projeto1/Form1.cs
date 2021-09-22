using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace meu_projeto1
{
    public partial class Calculadora : Form
    {
        public Calculadora()
        {
            InitializeComponent();
        }

        List<Double> tmp = new List<Double>();

        void valor(double var) 
        {
            this.txbRes.Text += Convert.ToString(var);
        }
        void operador(char var) 
        {
            string txb = txbRes.Text;
            if ((String.IsNullOrEmpty(txb)) != true)
            {
                if ((txb[txb.Length - 1] != '+') && (txb[txb.Length - 1] != '-') && (txb[txb.Length - 1] != '%') && (txb[txb.Length - 1] != 'x') && (txb[txb.Length - 1] != '/') && (txb[txb.Length - 1] != '!') && (txb[txb.Length - 1] != '√'))
                {
                    this.txbRes.Text += var;
                }
            }
        }

        private void bt_1_Click(object sender, EventArgs e)
        {
            valor(1);
        }


        private void bt_2_Click(object sender, EventArgs e)
        {
            valor(2);
        }

        private void bt_3_Click(object sender, EventArgs e)
        {
            valor(3);
        }

        private void bt_4_Click(object sender, EventArgs e)
        {
            valor(4);
        }

        private void bt_5_Click(object sender, EventArgs e)
        {
            valor(5);
        }

        private void bt_6_Click(object sender, EventArgs e)
        {
            valor(6);
        }

        private void bt_7_Click(object sender, EventArgs e)
        {
            valor(7);
        }

        private void bt_8_Click(object sender, EventArgs e)
        {
            valor(8);
        }

        private void bt_9_Click(object sender, EventArgs e)
        {
            valor(9);
        }

        private void bt_0_Click(object sender, EventArgs e)
        {
            valor(0);
        }
        private void bt_dot_Click(object sender, EventArgs e)
        {
            string txb = txbRes.Text;
            if ((String.IsNullOrEmpty(txb)) != true)
            {
                if (txb[txb.Length - 1] != ',')
                {
                    this.txbRes.Text += ',';
                }
            }
        }

        private void debug_TextChanged(object sender, EventArgs e)
        {

        }

        private void bt_ig_Click(object sender, EventArgs e)
        {
            string all = txbRes.Text;
            string[] numbers = all.Split('+','-','x','/','%','!','√');
            string[] operador = all.Split('1','2','3','4','5','6','7','8','9','0');
            operador = operador.Where(x => !string.IsNullOrEmpty(x)).ToArray();
            numbers = numbers.Where(x => !string.IsNullOrEmpty(x)).ToArray();
            if (all[0] == '-') {
                numbers[0] = "-" + numbers[0];
                for (var x = 0; x < operador.Length; x++) {
                    if (x != operador.Length - 1) {
                        operador[x] = operador[x + 1];
                    }
                }
            }
            for (var z = 0; z < numbers.Length; z++) {
                Double[] numberC = new Double[50];
                for (var y = 0; y < numbers.Length; y++) {
                    numberC[y] = Convert.ToDouble(numbers[y]);
                }
                if (operador[z] == "+") 
                {
                    Double Res = numberC[z] + numberC[z + 1];
                    this.txbRes.Text = Convert.ToString(Res);
                    break;
                }
                if (operador[z] == "-")
                {
                    Double Res = numberC[z] - numberC[z + 1];
                    this.txbRes.Text = Convert.ToString(Res);
                    break;
                }
                if (operador[z] == "x")
                {
                    Double Res = numberC[z]*numberC[z + 1];
                    this.txbRes.Text = Convert.ToString(Res);
                    break;
                }
                if (operador[z] == "/")
                {
                    Double Res = numberC[z] / numberC[z + 1];
                    this.txbRes.Text = Convert.ToString(Res);
                    break;
                }
                if (operador[z] == "%")
                {
                    Double Res = numberC[z] * (numberC[z + 1] / 100);
                    this.txbRes.Text = Convert.ToString(Res);
                    break;
                }
                if (operador[z] == "!")
                {
                    for (var v = numberC[z] - 1; v >= 1; v--) {
                        numberC[z] = numberC[z] * v;
                    }
                    Double Res = numberC[z];
                    this.txbRes.Text = Convert.ToString(Res);
                    break;
                }
                if (operador[z] == "√")
                {
                    Double Res = Math.Sqrt(numberC[0]);
                    this.txbRes.Text = Convert.ToString(Res);
                    break;
                }
            }

        }

        private void bt_plus_Click(object sender, EventArgs e)
        {
            operador('+');
        }

        private void bt_minus_Click(object sender, EventArgs e)
        {
            operador('-');
        }

        private void bt_clean_Click(object sender, EventArgs e)
        {
            this.txbRes.Text = "";
        }

        private void bt_div_Click(object sender, EventArgs e)
        {
            operador('/');
        }

        private void bt_mult_Click(object sender, EventArgs e)
        {
            operador('x');
        }

        private void bt_porce_Click(object sender, EventArgs e)
        {
            operador('%');
        }

        private void bt_fatorial_Click(object sender, EventArgs e)
        {
            operador('!');
        }

        private void bt_sqr_Click(object sender, EventArgs e)
        {
            operador('√');
        }
    }
}
