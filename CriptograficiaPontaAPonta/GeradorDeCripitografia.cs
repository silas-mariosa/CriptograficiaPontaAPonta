using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CriptograficiaPontaAPonta
{
    public partial class GeradorDeCripitografia : Form
    {
        public string textoCriptografado { get; private set; }
        public string KeyGerada { get; private set; }

        public GeradorDeCripitografia()
        {
            InitializeComponent();
        }
        private void btn_BuscaSerial_Click(object sender, EventArgs e)
        {
            tb_numeroHD.Text = BuscaSerialHD.GetHDDSerialNumber();
        }

        private void btn_gerarKey_Click(object sender, EventArgs e)
        {
            KeyGerada = tb_key.Text;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            textoCriptografado = GetAndSetterEncodeCode.EncryptString(tb_numeroHD.Text, KeyGerada);
            tb_encripitar.Text = textoCriptografado;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            tb_decode.Text = GetAndSetterEncodeCode.DecryptString(textoCriptografado, KeyGerada);
        }
    }
}
