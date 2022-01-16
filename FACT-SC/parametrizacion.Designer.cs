namespace FACT_SC
{
    partial class parametrizacion
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
            this.btnAtras = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnAtras
            // 
            this.btnAtras.BackgroundImage = global::FACT_SC.Properties.Resources.icoAtras;
            this.btnAtras.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnAtras.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAtras.FlatAppearance.BorderSize = 0;
            this.btnAtras.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAtras.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAtras.Location = new System.Drawing.Point(745, 12);
            this.btnAtras.Name = "btnAtras";
            this.btnAtras.Size = new System.Drawing.Size(43, 45);
            this.btnAtras.TabIndex = 68;
            this.btnAtras.Tag = "";
            this.btnAtras.UseVisualStyleBackColor = true;
            this.btnAtras.Click += new System.EventHandler(this.btnAtras_Click);
            // 
            // parametrizacion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnAtras);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "parametrizacion";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Parametrización";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnAtras;
    }
}