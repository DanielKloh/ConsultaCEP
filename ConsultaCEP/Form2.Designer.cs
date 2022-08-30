namespace ConsultaCEP
{
    partial class Form2
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
            this.txtEndereco = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.txtCEP = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.txtComplemento2 = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.txtBairro = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.txtEstado = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.txtCidade = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.btnConfirmar = new MaterialSkin.Controls.MaterialRaisedButton();
            this.button1 = new MaterialSkin.Controls.MaterialRaisedButton();
            this.materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel2 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel3 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel4 = new MaterialSkin.Controls.MaterialLabel();
            this.SuspendLayout();
            // 
            // txtEndereco
            // 
            this.txtEndereco.Depth = 0;
            this.txtEndereco.Hint = "Endereço";
            this.txtEndereco.Location = new System.Drawing.Point(11, 196);
            this.txtEndereco.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtEndereco.Name = "txtEndereco";
            this.txtEndereco.PasswordChar = '\0';
            this.txtEndereco.SelectedText = "";
            this.txtEndereco.SelectionLength = 0;
            this.txtEndereco.SelectionStart = 0;
            this.txtEndereco.Size = new System.Drawing.Size(232, 23);
            this.txtEndereco.TabIndex = 0;
            this.txtEndereco.UseSystemPasswordChar = false;
            // 
            // txtCEP
            // 
            this.txtCEP.Depth = 0;
            this.txtCEP.Hint = "CEP";
            this.txtCEP.Location = new System.Drawing.Point(12, 111);
            this.txtCEP.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtCEP.Name = "txtCEP";
            this.txtCEP.PasswordChar = '\0';
            this.txtCEP.SelectedText = "";
            this.txtCEP.SelectionLength = 0;
            this.txtCEP.SelectionStart = 0;
            this.txtCEP.Size = new System.Drawing.Size(149, 23);
            this.txtCEP.TabIndex = 1;
            this.txtCEP.UseSystemPasswordChar = false;
            // 
            // txtComplemento2
            // 
            this.txtComplemento2.Depth = 0;
            this.txtComplemento2.Hint = "Complemento";
            this.txtComplemento2.Location = new System.Drawing.Point(11, 284);
            this.txtComplemento2.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtComplemento2.Name = "txtComplemento2";
            this.txtComplemento2.PasswordChar = '\0';
            this.txtComplemento2.SelectedText = "";
            this.txtComplemento2.SelectionLength = 0;
            this.txtComplemento2.SelectionStart = 0;
            this.txtComplemento2.Size = new System.Drawing.Size(232, 23);
            this.txtComplemento2.TabIndex = 2;
            this.txtComplemento2.UseSystemPasswordChar = false;
            // 
            // txtBairro
            // 
            this.txtBairro.Depth = 0;
            this.txtBairro.Hint = "";
            this.txtBairro.Location = new System.Drawing.Point(12, 329);
            this.txtBairro.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtBairro.Name = "txtBairro";
            this.txtBairro.PasswordChar = '\0';
            this.txtBairro.SelectedText = "";
            this.txtBairro.SelectionLength = 0;
            this.txtBairro.SelectionStart = 0;
            this.txtBairro.Size = new System.Drawing.Size(75, 23);
            this.txtBairro.TabIndex = 3;
            this.txtBairro.Text = "cidade";
            this.txtBairro.UseSystemPasswordChar = false;
            // 
            // txtEstado
            // 
            this.txtEstado.Depth = 0;
            this.txtEstado.Hint = "Estado";
            this.txtEstado.Location = new System.Drawing.Point(11, 454);
            this.txtEstado.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtEstado.Name = "txtEstado";
            this.txtEstado.PasswordChar = '\0';
            this.txtEstado.SelectedText = "";
            this.txtEstado.SelectionLength = 0;
            this.txtEstado.SelectionStart = 0;
            this.txtEstado.Size = new System.Drawing.Size(232, 23);
            this.txtEstado.TabIndex = 4;
            this.txtEstado.UseSystemPasswordChar = false;
            // 
            // txtCidade
            // 
            this.txtCidade.Depth = 0;
            this.txtCidade.Hint = "Cidade";
            this.txtCidade.Location = new System.Drawing.Point(11, 370);
            this.txtCidade.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtCidade.Name = "txtCidade";
            this.txtCidade.PasswordChar = '\0';
            this.txtCidade.SelectedText = "";
            this.txtCidade.SelectionLength = 0;
            this.txtCidade.SelectionStart = 0;
            this.txtCidade.Size = new System.Drawing.Size(232, 23);
            this.txtCidade.TabIndex = 5;
            this.txtCidade.UseSystemPasswordChar = false;
            // 
            // btnConfirmar
            // 
            this.btnConfirmar.Depth = 0;
            this.btnConfirmar.Location = new System.Drawing.Point(211, 91);
            this.btnConfirmar.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnConfirmar.Name = "btnConfirmar";
            this.btnConfirmar.Primary = true;
            this.btnConfirmar.Size = new System.Drawing.Size(125, 43);
            this.btnConfirmar.TabIndex = 6;
            this.btnConfirmar.Text = "Buscar";
            this.btnConfirmar.UseVisualStyleBackColor = true;
            this.btnConfirmar.Click += new System.EventHandler(this.btnConfirmar_Click_1);
            // 
            // button1
            // 
            this.button1.Depth = 0;
            this.button1.Location = new System.Drawing.Point(103, 496);
            this.button1.MouseState = MaterialSkin.MouseState.HOVER;
            this.button1.Name = "button1";
            this.button1.Primary = true;
            this.button1.Size = new System.Drawing.Size(140, 34);
            this.button1.TabIndex = 7;
            this.button1.Text = "Confirmar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // materialLabel1
            // 
            this.materialLabel1.AutoSize = true;
            this.materialLabel1.Depth = 0;
            this.materialLabel1.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel1.Location = new System.Drawing.Point(12, 79);
            this.materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel1.Name = "materialLabel1";
            this.materialLabel1.Size = new System.Drawing.Size(37, 19);
            this.materialLabel1.TabIndex = 8;
            this.materialLabel1.Text = "CEP";
            // 
            // materialLabel2
            // 
            this.materialLabel2.AutoSize = true;
            this.materialLabel2.Depth = 0;
            this.materialLabel2.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel2.Location = new System.Drawing.Point(7, 153);
            this.materialLabel2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel2.Name = "materialLabel2";
            this.materialLabel2.Size = new System.Drawing.Size(71, 19);
            this.materialLabel2.TabIndex = 9;
            this.materialLabel2.Text = "endereço";
            // 
            // materialLabel3
            // 
            this.materialLabel3.AutoSize = true;
            this.materialLabel3.Depth = 0;
            this.materialLabel3.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel3.Location = new System.Drawing.Point(8, 242);
            this.materialLabel3.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel3.Name = "materialLabel3";
            this.materialLabel3.Size = new System.Drawing.Size(104, 19);
            this.materialLabel3.TabIndex = 10;
            this.materialLabel3.Text = "Complemento";
            // 
            // materialLabel4
            // 
            this.materialLabel4.AutoSize = true;
            this.materialLabel4.Depth = 0;
            this.materialLabel4.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel4.Location = new System.Drawing.Point(12, 414);
            this.materialLabel4.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel4.Name = "materialLabel4";
            this.materialLabel4.Size = new System.Drawing.Size(55, 19);
            this.materialLabel4.TabIndex = 11;
            this.materialLabel4.Text = "estado";
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(369, 542);
            this.Controls.Add(this.materialLabel4);
            this.Controls.Add(this.materialLabel3);
            this.Controls.Add(this.materialLabel2);
            this.Controls.Add(this.materialLabel1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnConfirmar);
            this.Controls.Add(this.txtCidade);
            this.Controls.Add(this.txtEstado);
            this.Controls.Add(this.txtBairro);
            this.Controls.Add(this.txtComplemento2);
            this.Controls.Add(this.txtCEP);
            this.Controls.Add(this.txtEndereco);
            this.Name = "Form2";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MaterialSkin.Controls.MaterialSingleLineTextField txtEndereco;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtCEP;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtComplemento2;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtBairro;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtEstado;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtCidade;
        private MaterialSkin.Controls.MaterialRaisedButton btnConfirmar;
        private MaterialSkin.Controls.MaterialRaisedButton button1;
        private MaterialSkin.Controls.MaterialLabel materialLabel1;
        private MaterialSkin.Controls.MaterialLabel materialLabel2;
        private MaterialSkin.Controls.MaterialLabel materialLabel3;
        private MaterialSkin.Controls.MaterialLabel materialLabel4;
    }
}