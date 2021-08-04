
namespace CadastroPessoaFisiJuri
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.label1 = new System.Windows.Forms.Label();
            this.btnPessoaFisi = new System.Windows.Forms.Button();
            this.btnPessoaJuri = new System.Windows.Forms.Button();
            this.btnSair = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Verdana", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(141, 52);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(776, 45);
            this.label1.TabIndex = 0;
            this.label1.Text = "Cadastre-se em uma das opções abaixo:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // btnPessoaFisi
            // 
            this.btnPessoaFisi.BackColor = System.Drawing.Color.DarkGray;
            this.btnPessoaFisi.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnPessoaFisi.BackgroundImage")));
            this.btnPessoaFisi.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnPessoaFisi.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPessoaFisi.Font = new System.Drawing.Font("Tahoma", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnPessoaFisi.ForeColor = System.Drawing.Color.White;
            this.btnPessoaFisi.Location = new System.Drawing.Point(49, 205);
            this.btnPessoaFisi.Name = "btnPessoaFisi";
            this.btnPessoaFisi.Size = new System.Drawing.Size(431, 298);
            this.btnPessoaFisi.TabIndex = 1;
            this.btnPessoaFisi.Text = "Pessoa Física";
            this.btnPessoaFisi.UseVisualStyleBackColor = false;
            this.btnPessoaFisi.Click += new System.EventHandler(this.btnPessoaFisi_Click);
            // 
            // btnPessoaJuri
            // 
            this.btnPessoaJuri.BackColor = System.Drawing.Color.DarkGray;
            this.btnPessoaJuri.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnPessoaJuri.BackgroundImage")));
            this.btnPessoaJuri.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnPessoaJuri.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPessoaJuri.Font = new System.Drawing.Font("Tahoma", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnPessoaJuri.ForeColor = System.Drawing.Color.White;
            this.btnPessoaJuri.Location = new System.Drawing.Point(575, 205);
            this.btnPessoaJuri.Name = "btnPessoaJuri";
            this.btnPessoaJuri.Size = new System.Drawing.Size(431, 298);
            this.btnPessoaJuri.TabIndex = 2;
            this.btnPessoaJuri.Text = "Pessoa Jurídica";
            this.btnPessoaJuri.UseVisualStyleBackColor = false;
            this.btnPessoaJuri.Click += new System.EventHandler(this.button2_Click);
            // 
            // btnSair
            // 
            this.btnSair.BackColor = System.Drawing.Color.DarkGray;
            this.btnSair.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSair.Font = new System.Drawing.Font("Tahoma", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnSair.ForeColor = System.Drawing.Color.DodgerBlue;
            this.btnSair.Location = new System.Drawing.Point(831, 572);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(188, 64);
            this.btnSair.TabIndex = 3;
            this.btnSair.Text = "Sair";
            this.btnSair.UseVisualStyleBackColor = false;
            this.btnSair.Click += new System.EventHandler(this.button3_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Khaki;
            this.ClientSize = new System.Drawing.Size(1049, 648);
            this.Controls.Add(this.btnSair);
            this.Controls.Add(this.btnPessoaJuri);
            this.Controls.Add(this.btnPessoaFisi);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CadastroPessoaFisiJuri";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnPessoaFisi;
        private System.Windows.Forms.Button btnPessoaJuri;
        private System.Windows.Forms.Button btnSair;
    }
}

