namespace maridoces
{
    partial class card
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
            lbl_nomeCard = new Label();
            card_1 = new Panel();
            pictureBox1 = new PictureBox();
            card_1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // lbl_nomeCard
            // 
            lbl_nomeCard.AutoEllipsis = true;
            lbl_nomeCard.BackColor = Color.BlanchedAlmond;
            lbl_nomeCard.Font = new Font("Berlin Sans FB Demi", 14F, FontStyle.Bold, GraphicsUnit.Pixel);
            lbl_nomeCard.Location = new Point(75, 18);
            lbl_nomeCard.Name = "lbl_nomeCard";
            lbl_nomeCard.Size = new Size(82, 38);
            lbl_nomeCard.TabIndex = 1;
            lbl_nomeCard.Text = "Promoções";
            // 
            // card_1
            // 
            card_1.BackColor = Color.BlanchedAlmond;
            card_1.Controls.Add(lbl_nomeCard);
            card_1.Dock = DockStyle.Fill;
            card_1.Location = new Point(0, 0);
            card_1.Name = "card_1";
            card_1.Size = new Size(160, 70);
            card_1.TabIndex = 2;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.Transparent;
            pictureBox1.BackgroundImageLayout = ImageLayout.Center;
            pictureBox1.Location = new Point(0, 4);
            pictureBox1.Margin = new Padding(0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(62, 62);
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // card
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.BlanchedAlmond;
            Controls.Add(pictureBox1);
            Controls.Add(card_1);
            Margin = new Padding(0, 6, 0, 6);
            Name = "card";
            Size = new Size(160, 70);
            card_1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private Label lbl_nomeCard;
        private Panel card_1;
        private PictureBox pictureBox1;
    }
}
