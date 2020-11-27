using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KeyGenerator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void crear_Click(object sender, EventArgs e)
        {
            int cant = Int16.Parse(cantidad.Text);
            for (int i = 0; i < cant; i++) {
            DBconnect.getInstance().insert(crearLlave());
            }
        }

        private String crearLlave() {
            
           return (randomHex() + "-" + randomHex() + "-" + randomHex());
        }
        //Este metodo esta sacado de Stack Overflow https://stackoverflow.com/questions/1054076/randomly-generated-hexadecimal-number-in-c-sharp
        static Random random = new Random();
        public static string randomHex()
        {
            byte[] buffer = new byte[2];
            random.NextBytes(buffer);
            string result = String.Concat(buffer.Select(x => x.ToString("X2")).ToArray());

            return result;
        }

    }
}
