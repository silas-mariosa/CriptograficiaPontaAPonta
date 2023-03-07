namespace CriptograficiaPontaAPonta
{
    partial class GeradorDeCripitografia
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            tb_decode=new TextBox();
            button2=new Button();
            label4=new Label();
            btn_gerarKey=new Button();
            label3=new Label();
            tb_key=new TextBox();
            button1=new Button();
            label2=new Label();
            tb_encripitar=new TextBox();
            btn_BuscaSerial=new Button();
            label1=new Label();
            tb_numeroHD=new TextBox();
            SuspendLayout();
            // 
            // tb_decode
            // 
            tb_decode.Font=new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            tb_decode.Location=new Point(12, 409);
            tb_decode.Name="tb_decode";
            tb_decode.Size=new Size(473, 32);
            tb_decode.TabIndex=24;
            // 
            // button2
            // 
            button2.Font=new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            button2.Location=new Point(12, 444);
            button2.Name="button2";
            button2.Size=new Size(114, 32);
            button2.TabIndex=23;
            button2.Text="Desencriptar";
            button2.UseVisualStyleBackColor=true;
            button2.Click+=button2_Click;
            // 
            // label4
            // 
            label4.AutoSize=true;
            label4.Font=new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location=new Point(12, 381);
            label4.Name="label4";
            label4.Size=new Size(148, 25);
            label4.TabIndex=22;
            label4.Text="Descripitografar";
            // 
            // btn_gerarKey
            // 
            btn_gerarKey.Font=new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btn_gerarKey.Location=new Point(12, 190);
            btn_gerarKey.Name="btn_gerarKey";
            btn_gerarKey.Size=new Size(114, 32);
            btn_gerarKey.TabIndex=21;
            btn_gerarKey.Text="Gera Key";
            btn_gerarKey.UseVisualStyleBackColor=true;
            btn_gerarKey.Click+=btn_gerarKey_Click;
            // 
            // label3
            // 
            label3.AutoSize=true;
            label3.Font=new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location=new Point(12, 125);
            label3.Name="label3";
            label3.Size=new Size(42, 25);
            label3.TabIndex=20;
            label3.Text="Key";
            // 
            // tb_key
            // 
            tb_key.Font=new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            tb_key.Location=new Point(12, 152);
            tb_key.Name="tb_key";
            tb_key.Size=new Size(473, 32);
            tb_key.TabIndex=19;
            // 
            // button1
            // 
            button1.Font=new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            button1.Location=new Point(12, 317);
            button1.Name="button1";
            button1.Size=new Size(114, 32);
            button1.TabIndex=18;
            button1.Text="Encriptar";
            button1.UseVisualStyleBackColor=true;
            button1.Click+=button1_Click;
            // 
            // label2
            // 
            label2.AutoSize=true;
            label2.Font=new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location=new Point(12, 252);
            label2.Name="label2";
            label2.Size=new Size(115, 25);
            label2.TabIndex=17;
            label2.Text="Criptografar";
            // 
            // tb_encripitar
            // 
            tb_encripitar.Font=new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            tb_encripitar.Location=new Point(12, 279);
            tb_encripitar.Name="tb_encripitar";
            tb_encripitar.Size=new Size(473, 32);
            tb_encripitar.TabIndex=16;
            // 
            // btn_BuscaSerial
            // 
            btn_BuscaSerial.Font=new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btn_BuscaSerial.Location=new Point(12, 74);
            btn_BuscaSerial.Name="btn_BuscaSerial";
            btn_BuscaSerial.Size=new Size(114, 32);
            btn_BuscaSerial.TabIndex=15;
            btn_BuscaSerial.Text="Buscar Serial";
            btn_BuscaSerial.UseVisualStyleBackColor=true;
            btn_BuscaSerial.Click+=btn_BuscaSerial_Click;
            // 
            // label1
            // 
            label1.AutoSize=true;
            label1.Font=new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location=new Point(12, 9);
            label1.Name="label1";
            label1.Size=new Size(166, 25);
            label1.TabIndex=14;
            label1.Text="Busca Número HD";
            // 
            // tb_numeroHD
            // 
            tb_numeroHD.Font=new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            tb_numeroHD.Location=new Point(12, 36);
            tb_numeroHD.Name="tb_numeroHD";
            tb_numeroHD.Size=new Size(473, 32);
            tb_numeroHD.TabIndex=13;
            // 
            // GeradorDeCripitografia
            // 
            AutoScaleDimensions=new SizeF(7F, 15F);
            AutoScaleMode=AutoScaleMode.Font;
            BackColor=SystemColors.ActiveCaption;
            ClientSize=new Size(498, 491);
            Controls.Add(tb_decode);
            Controls.Add(button2);
            Controls.Add(label4);
            Controls.Add(btn_gerarKey);
            Controls.Add(label3);
            Controls.Add(tb_key);
            Controls.Add(button1);
            Controls.Add(label2);
            Controls.Add(tb_encripitar);
            Controls.Add(btn_BuscaSerial);
            Controls.Add(label1);
            Controls.Add(tb_numeroHD);
            Name="GeradorDeCripitografia";
            Text="GeradorDeCripitografia";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox tb_decode;
        private Button button2;
        private Label label4;
        private Button btn_gerarKey;
        private Label label3;
        private TextBox tb_key;
        private Button button1;
        private Label label2;
        private TextBox tb_encripitar;
        private Button btn_BuscaSerial;
        private Label label1;
        private TextBox tb_numeroHD;
    }
}