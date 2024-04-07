namespace pryProyectoNave
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
            pctNavePrincipal = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pctNavePrincipal).BeginInit();
            SuspendLayout();
            // 
            // pctNavePrincipal
            // 
            pctNavePrincipal.BackColor = Color.Transparent;
            pctNavePrincipal.Image = (Image)resources.GetObject("pctNavePrincipal.Image");
            pctNavePrincipal.Location = new Point(234, 239);
            pctNavePrincipal.Name = "pctNavePrincipal";
            pctNavePrincipal.Size = new Size(313, 214);
            pctNavePrincipal.SizeMode = PictureBoxSizeMode.Zoom;
            pctNavePrincipal.TabIndex = 0;
            pctNavePrincipal.TabStop = false;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.istockphoto_1208374691_612x612;
            ClientSize = new Size(800, 450);
            Controls.Add(pctNavePrincipal);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)pctNavePrincipal).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private PictureBox pctNavePrincipal;
    }
}
