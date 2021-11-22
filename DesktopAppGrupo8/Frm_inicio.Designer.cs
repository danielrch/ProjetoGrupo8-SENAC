
namespace DesktopAppGrupo8
{
    partial class Frm_inicio
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
            this.Btn_CadAluno = new System.Windows.Forms.Button();
            this.Btn_CadProfessor = new System.Windows.Forms.Button();
            this.Btn_CadFornecedor = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.Lbl_Principal = new System.Windows.Forms.Label();
            this.Btn_Sair = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Btn_CadAluno
            // 
            this.Btn_CadAluno.Location = new System.Drawing.Point(12, 122);
            this.Btn_CadAluno.Name = "Btn_CadAluno";
            this.Btn_CadAluno.Size = new System.Drawing.Size(174, 89);
            this.Btn_CadAluno.TabIndex = 0;
            this.Btn_CadAluno.Text = "Cadastro de Alunos";
            this.Btn_CadAluno.UseVisualStyleBackColor = true;
            // 
            // Btn_CadProfessor
            // 
            this.Btn_CadProfessor.Location = new System.Drawing.Point(192, 122);
            this.Btn_CadProfessor.Name = "Btn_CadProfessor";
            this.Btn_CadProfessor.Size = new System.Drawing.Size(174, 89);
            this.Btn_CadProfessor.TabIndex = 1;
            this.Btn_CadProfessor.Text = "Cadastro de Professores";
            this.Btn_CadProfessor.UseVisualStyleBackColor = true;
            // 
            // Btn_CadFornecedor
            // 
            this.Btn_CadFornecedor.Location = new System.Drawing.Point(372, 122);
            this.Btn_CadFornecedor.Name = "Btn_CadFornecedor";
            this.Btn_CadFornecedor.Size = new System.Drawing.Size(174, 89);
            this.Btn_CadFornecedor.TabIndex = 2;
            this.Btn_CadFornecedor.Text = "Cadastro de Fornecedores";
            this.Btn_CadFornecedor.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(12, 217);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(174, 23);
            this.button4.TabIndex = 3;
            this.button4.Text = "Listar Alunos";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(192, 217);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(174, 23);
            this.button5.TabIndex = 4;
            this.button5.Text = "Listar Professores";
            this.button5.UseVisualStyleBackColor = true;
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(372, 217);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(174, 23);
            this.button6.TabIndex = 5;
            this.button6.Text = "Listar Fornecedores";
            this.button6.UseVisualStyleBackColor = true;
            // 
            // Lbl_Principal
            // 
            this.Lbl_Principal.AutoSize = true;
            this.Lbl_Principal.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.Lbl_Principal.Location = new System.Drawing.Point(185, 50);
            this.Lbl_Principal.Name = "Lbl_Principal";
            this.Lbl_Principal.Size = new System.Drawing.Size(189, 24);
            this.Lbl_Principal.TabIndex = 6;
            this.Lbl_Principal.Text = "UNIVERSIDADE GP8";
            this.Lbl_Principal.Click += new System.EventHandler(this.label1_Click);
            // 
            // Btn_Sair
            // 
            this.Btn_Sair.Location = new System.Drawing.Point(469, 280);
            this.Btn_Sair.Name = "Btn_Sair";
            this.Btn_Sair.Size = new System.Drawing.Size(77, 33);
            this.Btn_Sair.TabIndex = 7;
            this.Btn_Sair.Text = "Sair";
            this.Btn_Sair.UseVisualStyleBackColor = true;
            this.Btn_Sair.Click += new System.EventHandler(this.Btn_Sair_Click);
            // 
            // Frm_inicio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(558, 325);
            this.ControlBox = false;
            this.Controls.Add(this.Btn_Sair);
            this.Controls.Add(this.Lbl_Principal);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.Btn_CadFornecedor);
            this.Controls.Add(this.Btn_CadProfessor);
            this.Controls.Add(this.Btn_CadAluno);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Frm_inicio";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "UNIVERSIDADE GP8";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Btn_CadAluno;
        private System.Windows.Forms.Button Btn_CadProfessor;
        private System.Windows.Forms.Button Btn_CadFornecedor;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Label Lbl_Principal;
        private System.Windows.Forms.Button Btn_Sair;
    }
}

