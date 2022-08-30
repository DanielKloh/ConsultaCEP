namespace ConsultaCEP
{
    partial class Form1
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            this.btnBuscarCEP = new MaterialSkin.Controls.MaterialRaisedButton();
            this.txtEndereco = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.SuspendLayout();
            // 
            // materialLabel1
            // 
            this.materialLabel1.AutoSize = true;
            this.materialLabel1.Depth = 0;
            this.materialLabel1.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel1.Location = new System.Drawing.Point(20, 89);
            this.materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel1.Name = "materialLabel1";
            this.materialLabel1.Size = new System.Drawing.Size(72, 19);
            this.materialLabel1.TabIndex = 0;
            this.materialLabel1.Text = "Endereço";
            // 
            // btnBuscarCEP
            // 
            this.btnBuscarCEP.Depth = 0;
            this.btnBuscarCEP.Location = new System.Drawing.Point(309, 127);
            this.btnBuscarCEP.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnBuscarCEP.Name = "btnBuscarCEP";
            this.btnBuscarCEP.Primary = true;
            this.btnBuscarCEP.Size = new System.Drawing.Size(100, 38);
            this.btnBuscarCEP.TabIndex = 2;
            this.btnBuscarCEP.Text = "Buscar CEP";
            this.btnBuscarCEP.UseVisualStyleBackColor = true;
            this.btnBuscarCEP.Click += new System.EventHandler(this.btnBuscarCEP_Click_1);
            // 
            // txtEndereco
            // 
            this.txtEndereco.Depth = 0;
            this.txtEndereco.Hint = "Endereço";
            this.txtEndereco.Location = new System.Drawing.Point(24, 142);
            this.txtEndereco.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtEndereco.Name = "txtEndereco";
            this.txtEndereco.PasswordChar = '\0';
            this.txtEndereco.SelectedText = "";
            this.txtEndereco.SelectionLength = 0;
            this.txtEndereco.SelectionStart = 0;
            this.txtEndereco.Size = new System.Drawing.Size(245, 23);
            this.txtEndereco.TabIndex = 3;
            this.txtEndereco.UseSystemPasswordChar = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(421, 210);
            this.Controls.Add(this.txtEndereco);
            this.Controls.Add(this.btnBuscarCEP);
            this.Controls.Add(this.materialLabel1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MaterialSkin.Controls.MaterialLabel materialLabel1;
        private MaterialSkin.Controls.MaterialRaisedButton btnBuscarCEP;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtEndereco;
    }
}

