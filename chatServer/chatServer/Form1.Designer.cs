namespace chatServer
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            txtIP = new TextBox();
            numPorta = new NumericUpDown();
            btnIniciarServidor = new Button();
            listaLog = new ListBox();
            ((System.ComponentModel.ISupportInitialize)numPorta).BeginInit();
            SuspendLayout();
            // 
            // txtIP
            // 
            txtIP.Location = new Point(12, 21);
            txtIP.Name = "txtIP";
            txtIP.Size = new Size(163, 23);
            txtIP.TabIndex = 0;
            txtIP.Text = "127.0.0.1";
            // 
            // numPorta
            // 
            numPorta.Location = new Point(206, 18);
            numPorta.Maximum = new decimal(new int[] { 9999, 0, 0, 0 });
            numPorta.Minimum = new decimal(new int[] { 1000, 0, 0, 0 });
            numPorta.Name = "numPorta";
            numPorta.Size = new Size(120, 23);
            numPorta.TabIndex = 1;
            numPorta.Value = new decimal(new int[] { 1000, 0, 0, 0 });
            // 
            // btnIniciarServidor
            // 
            btnIniciarServidor.Location = new Point(367, 20);
            btnIniciarServidor.Name = "btnIniciarServidor";
            btnIniciarServidor.Size = new Size(170, 23);
            btnIniciarServidor.TabIndex = 2;
            btnIniciarServidor.Text = "Start Server";
            btnIniciarServidor.UseVisualStyleBackColor = true;
            btnIniciarServidor.Click += btnIniciarServidor_Click;
            // 
            // listaLog
            // 
            listaLog.FormattingEnabled = true;
            listaLog.ItemHeight = 15;
            listaLog.Location = new Point(12, 61);
            listaLog.Name = "listaLog";
            listaLog.Size = new Size(710, 334);
            listaLog.TabIndex = 3;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(736, 430);
            Controls.Add(listaLog);
            Controls.Add(btnIniciarServidor);
            Controls.Add(numPorta);
            Controls.Add(txtIP);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)numPorta).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtIP;
        private NumericUpDown numPorta;
        private Button btnIniciarServidor;
        private ListBox listaLog;
    }
}
