namespace StudiaBiblii
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
            this.Księga = new System.Windows.Forms.Label();
            this.ListaKsiąg = new System.Windows.Forms.ComboBox();
            this.ListaRozdziałów = new System.Windows.Forms.ComboBox();
            this.ListaWersetów = new System.Windows.Forms.ComboBox();
            this.Pokaż = new System.Windows.Forms.Button();
            this.Losowy = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Księga
            // 
            this.Księga.AutoSize = true;
            this.Księga.Location = new System.Drawing.Point(13, 33);
            this.Księga.Name = "Księga";
            this.Księga.Size = new System.Drawing.Size(82, 13);
            this.Księga.TabIndex = 0;
            this.Księga.Text = "Wybierz księgę:";
            // 
            // ListaKsiąg
            // 
            this.ListaKsiąg.FormattingEnabled = true;
            this.ListaKsiąg.Location = new System.Drawing.Point(112, 30);
            this.ListaKsiąg.Name = "ListaKsiąg";
            this.ListaKsiąg.Size = new System.Drawing.Size(121, 21);
            this.ListaKsiąg.TabIndex = 1;
            this.ListaKsiąg.SelectedIndexChanged += new System.EventHandler(this.ListaKsiąg_SelectedIndexChanged);
            // 
            // ListaRozdziałów
            // 
            this.ListaRozdziałów.FormattingEnabled = true;
            this.ListaRozdziałów.Location = new System.Drawing.Point(248, 30);
            this.ListaRozdziałów.Name = "ListaRozdziałów";
            this.ListaRozdziałów.Size = new System.Drawing.Size(40, 21);
            this.ListaRozdziałów.TabIndex = 2;
            this.ListaRozdziałów.SelectedIndexChanged += new System.EventHandler(this.ListaRozdziałów_SelectedIndexChanged);
            // 
            // ListaWersetów
            // 
            this.ListaWersetów.FormattingEnabled = true;
            this.ListaWersetów.Location = new System.Drawing.Point(306, 30);
            this.ListaWersetów.Name = "ListaWersetów";
            this.ListaWersetów.Size = new System.Drawing.Size(68, 21);
            this.ListaWersetów.TabIndex = 3;
            // 
            // Pokaż
            // 
            this.Pokaż.Location = new System.Drawing.Point(16, 82);
            this.Pokaż.Name = "Pokaż";
            this.Pokaż.Size = new System.Drawing.Size(75, 23);
            this.Pokaż.TabIndex = 4;
            this.Pokaż.Text = "Pokaż";
            this.Pokaż.UseVisualStyleBackColor = true;
            this.Pokaż.Click += new System.EventHandler(this.Pokaż_Click);
            // 
            // Losowy
            // 
            this.Losowy.Location = new System.Drawing.Point(112, 81);
            this.Losowy.Name = "Losowy";
            this.Losowy.Size = new System.Drawing.Size(156, 23);
            this.Losowy.TabIndex = 5;
            this.Losowy.Text = "Wybierz losowy werset";
            this.Losowy.UseVisualStyleBackColor = true;
            this.Losowy.Click += new System.EventHandler(this.Losowy_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(516, 481);
            this.Controls.Add(this.Losowy);
            this.Controls.Add(this.Pokaż);
            this.Controls.Add(this.ListaWersetów);
            this.Controls.Add(this.ListaRozdziałów);
            this.Controls.Add(this.ListaKsiąg);
            this.Controls.Add(this.Księga);
            this.Name = "Form1";
            this.Text = "Opcje Biblii";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Księga;
        private System.Windows.Forms.ComboBox ListaKsiąg;
        private System.Windows.Forms.ComboBox ListaRozdziałów;
        private System.Windows.Forms.ComboBox ListaWersetów;
        private System.Windows.Forms.Button Pokaż;
        private System.Windows.Forms.Button Losowy;
    }
}

