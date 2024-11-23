namespace WinFormsTabla
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
            PanelPrincipal = new Panel();
            richTextBoxResultados = new RichTextBox();
            Ver = new Button();
            textboxNumero = new TextBox();
            labelNumero = new Label();
            labelTitulo = new Label();
            labelNombre = new Label();
            PanelPrincipal.SuspendLayout();
            SuspendLayout();
            // 
            // PanelPrincipal
            // 
            PanelPrincipal.BackColor = Color.FromArgb(255, 128, 0);
            PanelPrincipal.Controls.Add(labelNombre);
            PanelPrincipal.Controls.Add(richTextBoxResultados);
            PanelPrincipal.Controls.Add(Ver);
            PanelPrincipal.Controls.Add(textboxNumero);
            PanelPrincipal.Controls.Add(labelNumero);
            PanelPrincipal.Controls.Add(labelTitulo);
            PanelPrincipal.Location = new Point(12, 12);
            PanelPrincipal.Name = "PanelPrincipal";
            PanelPrincipal.Size = new Size(776, 426);
            PanelPrincipal.TabIndex = 0;
            // 
            // richTextBoxResultados
            // 
            richTextBoxResultados.Font = new Font("Algerian", 14F, FontStyle.Regular, GraphicsUnit.Point, 0);
            richTextBoxResultados.Location = new Point(503, 27);
            richTextBoxResultados.Name = "richTextBoxResultados";
            richTextBoxResultados.Size = new Size(256, 382);
            richTextBoxResultados.TabIndex = 4;
            richTextBoxResultados.Text = "";
            richTextBoxResultados.TextChanged += richTextBoxResultados_TextChanged;
            // 
            // Ver
            // 
            Ver.Location = new Point(189, 186);
            Ver.Name = "Ver";
            Ver.Size = new Size(112, 34);
            Ver.TabIndex = 3;
            Ver.Text = "Ver tabla";
            Ver.UseVisualStyleBackColor = true;
            Ver.Click += Ver_Click;
            // 
            // textboxNumero
            // 
            textboxNumero.Location = new Point(169, 139);
            textboxNumero.Name = "textboxNumero";
            textboxNumero.Size = new Size(150, 31);
            textboxNumero.TabIndex = 2;
            // 
            // labelNumero
            // 
            labelNumero.AutoSize = true;
            labelNumero.Font = new Font("Showcard Gothic", 11F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labelNumero.ForeColor = SystemColors.ButtonHighlight;
            labelNumero.Location = new Point(118, 98);
            labelNumero.Name = "labelNumero";
            labelNumero.Size = new Size(265, 28);
            labelNumero.TabIndex = 1;
            labelNumero.Text = "¿Que numero quieres?";
            // 
            // labelTitulo
            // 
            labelTitulo.AutoSize = true;
            labelTitulo.Font = new Font("Showcard Gothic", 16F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labelTitulo.ForeColor = SystemColors.ActiveCaptionText;
            labelTitulo.Location = new Point(88, 48);
            labelTitulo.Name = "labelTitulo";
            labelTitulo.Size = new Size(377, 40);
            labelTitulo.TabIndex = 0;
            labelTitulo.Text = "Tabla de multiplicar";
            labelTitulo.Click += label1_Click;
            // 
            // labelNombre
            // 
            labelNombre.AutoSize = true;
            labelNombre.Font = new Font("Showcard Gothic", 12F, FontStyle.Italic, GraphicsUnit.Point, 0);
            labelNombre.Location = new Point(117, 322);
            labelNombre.Name = "labelNombre";
            labelNombre.Size = new Size(266, 30);
            labelNombre.TabIndex = 5;
            labelNombre.Text = "Omar Romero Lopez";
            labelNombre.Click += label1_Click_1;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(PanelPrincipal);
            Name = "Form1";
            Text = "Form1";
            PanelPrincipal.ResumeLayout(false);
            PanelPrincipal.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel PanelPrincipal;
        private Label labelTitulo;
        private Label labelNumero;
        private RichTextBox richTextBoxResultados;
        private Button Ver;
        private TextBox textboxNumero;
        private Label labelNombre;
    }
}
