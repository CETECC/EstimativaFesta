namespace EstimativaJantar
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
            this.label1 = new System.Windows.Forms.Label();
            this.numQtdPessoas = new System.Windows.Forms.NumericUpDown();
            this.chkDecoracaoChique = new System.Windows.Forms.CheckBox();
            this.chkOpcaoSaudavel = new System.Windows.Forms.CheckBox();
            this.label2 = new System.Windows.Forms.Label();
            this.lblCusto = new System.Windows.Forms.Label();
            this.btnDetalhes = new System.Windows.Forms.LinkLabel();
            ((System.ComponentModel.ISupportInitialize)(this.numQtdPessoas)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(55, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(136, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Número de Pessoas";
            // 
            // numQtdPessoas
            // 
            this.numQtdPessoas.Location = new System.Drawing.Point(55, 29);
            this.numQtdPessoas.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.numQtdPessoas.Name = "numQtdPessoas";
            this.numQtdPessoas.Size = new System.Drawing.Size(137, 22);
            this.numQtdPessoas.TabIndex = 1;
            this.numQtdPessoas.ValueChanged += new System.EventHandler(this.numQtdPessoas_ValueChanged);
            // 
            // chkDecoracaoChique
            // 
            this.chkDecoracaoChique.AutoSize = true;
            this.chkDecoracaoChique.Location = new System.Drawing.Point(55, 82);
            this.chkDecoracaoChique.Name = "chkDecoracaoChique";
            this.chkDecoracaoChique.Size = new System.Drawing.Size(147, 21);
            this.chkDecoracaoChique.TabIndex = 2;
            this.chkDecoracaoChique.Text = "Decoracao Chique";
            this.chkDecoracaoChique.UseVisualStyleBackColor = true;
            this.chkDecoracaoChique.CheckedChanged += new System.EventHandler(this.chkDecoracaoChique_CheckedChanged);
            // 
            // chkOpcaoSaudavel
            // 
            this.chkOpcaoSaudavel.AutoSize = true;
            this.chkOpcaoSaudavel.Location = new System.Drawing.Point(55, 109);
            this.chkOpcaoSaudavel.Name = "chkOpcaoSaudavel";
            this.chkOpcaoSaudavel.Size = new System.Drawing.Size(135, 21);
            this.chkOpcaoSaudavel.TabIndex = 3;
            this.chkOpcaoSaudavel.Text = "Opção Saudável";
            this.chkOpcaoSaudavel.UseVisualStyleBackColor = true;
            this.chkOpcaoSaudavel.CheckedChanged += new System.EventHandler(this.chkOpcaoSaudavel_CheckedChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 169);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 17);
            this.label2.TabIndex = 4;
            this.label2.Text = "Custo";
            // 
            // lblCusto
            // 
            this.lblCusto.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblCusto.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCusto.Location = new System.Drawing.Point(63, 158);
            this.lblCusto.Name = "lblCusto";
            this.lblCusto.Size = new System.Drawing.Size(147, 37);
            this.lblCusto.TabIndex = 5;
            this.lblCusto.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // btnDetalhes
            // 
            this.btnDetalhes.AutoSize = true;
            this.btnDetalhes.Location = new System.Drawing.Point(88, 219);
            this.btnDetalhes.Name = "btnDetalhes";
            this.btnDetalhes.Size = new System.Drawing.Size(64, 17);
            this.btnDetalhes.TabIndex = 6;
            this.btnDetalhes.TabStop = true;
            this.btnDetalhes.Text = "Detalhes";
            this.btnDetalhes.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.btnDetalhes_LinkClicked);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(245, 255);
            this.Controls.Add(this.btnDetalhes);
            this.Controls.Add(this.lblCusto);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.chkOpcaoSaudavel);
            this.Controls.Add(this.chkDecoracaoChique);
            this.Controls.Add(this.numQtdPessoas);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Form1";
            this.Text = "Planejador de Festas";
            ((System.ComponentModel.ISupportInitialize)(this.numQtdPessoas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown numQtdPessoas;
        private System.Windows.Forms.CheckBox chkDecoracaoChique;
        private System.Windows.Forms.CheckBox chkOpcaoSaudavel;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblCusto;
        private System.Windows.Forms.LinkLabel btnDetalhes;
    }
}

