namespace JsonToExcel_Converter
{
    partial class Form1
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
            this.btSelecionar = new System.Windows.Forms.Button();
            this.arquivoOrigem = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.label2 = new System.Windows.Forms.Label();
            this.arquivoDestino = new System.Windows.Forms.TextBox();
            this.btSelecionarCSV = new System.Windows.Forms.Button();
            this.saveCSVdialog = new System.Windows.Forms.SaveFileDialog();
            this.btConvert = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btSelecionar
            // 
            this.btSelecionar.Location = new System.Drawing.Point(373, 12);
            this.btSelecionar.Name = "btSelecionar";
            this.btSelecionar.Size = new System.Drawing.Size(138, 41);
            this.btSelecionar.TabIndex = 0;
            this.btSelecionar.Text = "Selecionar";
            this.btSelecionar.UseVisualStyleBackColor = true;
            this.btSelecionar.Click += new System.EventHandler(this.btSelecionar_Click);
            // 
            // arquivoOrigem
            // 
            this.arquivoOrigem.Location = new System.Drawing.Point(12, 31);
            this.arquivoOrigem.Name = "arquivoOrigem";
            this.arquivoOrigem.Size = new System.Drawing.Size(355, 20);
            this.arquivoOrigem.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 12);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(74, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Arquivo JSON";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // openFileDialog
            // 
            this.openFileDialog.FileName = "openFileDialog1";
            this.openFileDialog.Filter = "Arquivos Json|*.json";
            this.openFileDialog.Title = "Arquivo JSON";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 59);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(112, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Arquivo Destino (CSV)";
            // 
            // arquivoDestino
            // 
            this.arquivoDestino.Location = new System.Drawing.Point(12, 78);
            this.arquivoDestino.Name = "arquivoDestino";
            this.arquivoDestino.Size = new System.Drawing.Size(355, 20);
            this.arquivoDestino.TabIndex = 5;
            // 
            // btSelecionarCSV
            // 
            this.btSelecionarCSV.Location = new System.Drawing.Point(373, 59);
            this.btSelecionarCSV.Name = "btSelecionarCSV";
            this.btSelecionarCSV.Size = new System.Drawing.Size(138, 41);
            this.btSelecionarCSV.TabIndex = 4;
            this.btSelecionarCSV.Text = "Selecionar";
            this.btSelecionarCSV.UseVisualStyleBackColor = true;
            this.btSelecionarCSV.Click += new System.EventHandler(this.btSelecionarCSV_Click);
            // 
            // saveCSVdialog
            // 
            this.saveCSVdialog.DefaultExt = "csv";
            this.saveCSVdialog.Filter = "Excel CSV|*.csv";
            // 
            // btConvert
            // 
            this.btConvert.Location = new System.Drawing.Point(131, 148);
            this.btConvert.Name = "btConvert";
            this.btConvert.Size = new System.Drawing.Size(236, 81);
            this.btConvert.TabIndex = 7;
            this.btConvert.Text = "Converter Agora";
            this.btConvert.UseVisualStyleBackColor = true;
            this.btConvert.Click += new System.EventHandler(this.btConvert_Click);
            // 
            // Form1
            // 
            this.ClientSize = new System.Drawing.Size(523, 251);
            this.Controls.Add(this.btConvert);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.arquivoDestino);
            this.Controls.Add(this.btSelecionarCSV);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.arquivoOrigem);
            this.Controls.Add(this.btSelecionar);
            this.Name = "Form1";
            this.Text = "Conversor de Json para CSV";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btSelecionar;
        private System.Windows.Forms.TextBox arquivoOrigem;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.OpenFileDialog openFileDialog;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox arquivoDestino;
        private System.Windows.Forms.Button btSelecionarCSV;
        private System.Windows.Forms.SaveFileDialog saveCSVdialog;
        private System.Windows.Forms.Button btConvert;
    }
}

