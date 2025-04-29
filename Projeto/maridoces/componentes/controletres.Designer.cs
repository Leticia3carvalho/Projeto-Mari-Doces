namespace maridoces.conexao
{
    partial class controletres
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

        #region Código gerado pelo Designer de Componentes

        /// <summary> 
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            btn_Todos = new Button();
            btn_escpecial = new Button();
            btn_aniversario = new Button();
            pnl_promo = new Panel();
            flp_promo = new FlowLayoutPanel();
            pnl_promo.SuspendLayout();
            SuspendLayout();
            // 
            // btn_Todos
            // 
            btn_Todos.Font = new Font("Berlin Sans FB", 14F, FontStyle.Bold, GraphicsUnit.Pixel);
            btn_Todos.Location = new Point(3, 3);
            btn_Todos.Name = "btn_Todos";
            btn_Todos.Size = new Size(81, 33);
            btn_Todos.TabIndex = 2;
            btn_Todos.Text = "Todos";
            btn_Todos.UseVisualStyleBackColor = true;
            // 
            // btn_escpecial
            // 
            btn_escpecial.Font = new Font("Berlin Sans FB", 14F, FontStyle.Bold, GraphicsUnit.Pixel);
            btn_escpecial.Location = new Point(90, 3);
            btn_escpecial.Name = "btn_escpecial";
            btn_escpecial.Size = new Size(132, 33);
            btn_escpecial.TabIndex = 3;
            btn_escpecial.Text = "Especial páscoa";
            btn_escpecial.UseVisualStyleBackColor = true;
            // 
            // btn_aniversario
            // 
            btn_aniversario.Font = new Font("Berlin Sans FB", 14F, FontStyle.Bold, GraphicsUnit.Pixel);
            btn_aniversario.Location = new Point(228, 3);
            btn_aniversario.Name = "btn_aniversario";
            btn_aniversario.Size = new Size(109, 33);
            btn_aniversario.TabIndex = 4;
            btn_aniversario.Text = "Aniversário";
            btn_aniversario.UseVisualStyleBackColor = true;
            // 
            // pnl_promo
            // 
            pnl_promo.BackColor = Color.BlanchedAlmond;
            pnl_promo.Controls.Add(btn_aniversario);
            pnl_promo.Controls.Add(btn_Todos);
            pnl_promo.Controls.Add(btn_escpecial);
            pnl_promo.Dock = DockStyle.Top;
            pnl_promo.Location = new Point(0, 0);
            pnl_promo.Margin = new Padding(0);
            pnl_promo.Name = "pnl_promo";
            pnl_promo.Size = new Size(712, 42);
            pnl_promo.TabIndex = 5;
            // 
            // flp_promo
            // 
            flp_promo.AutoScroll = true;
            flp_promo.BackColor = Color.BlanchedAlmond;
            flp_promo.Dock = DockStyle.Fill;
            flp_promo.Location = new Point(0, 42);
            flp_promo.Name = "flp_promo";
            flp_promo.Size = new Size(712, 449);
            flp_promo.TabIndex = 6;
            // 
            // controletres
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(flp_promo);
            Controls.Add(pnl_promo);
            Name = "controletres";
            Size = new Size(712, 491);
            pnl_promo.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Button btn_Todos;
        private Button btn_escpecial;
        private Button btn_aniversario;
        private Panel pnl_promo;
        private FlowLayoutPanel flp_promo;
    }
}
