namespace Tiro_alla_fune
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
            Corda_Ondulata = new PictureBox();
            Corda_Dura = new PictureBox();
            Start = new Button();
            ((System.ComponentModel.ISupportInitialize)Corda_Ondulata).BeginInit();
            ((System.ComponentModel.ISupportInitialize)Corda_Dura).BeginInit();
            SuspendLayout();
            // 
            // Corda_Ondulata
            // 
            Corda_Ondulata.Image = (Image)resources.GetObject("Corda_Ondulata.Image");
            Corda_Ondulata.Location = new Point(211, 178);
            Corda_Ondulata.Name = "Corda_Ondulata";
            Corda_Ondulata.Size = new Size(350, 150);
            Corda_Ondulata.SizeMode = PictureBoxSizeMode.Zoom;
            Corda_Ondulata.TabIndex = 0;
            Corda_Ondulata.TabStop = false;
            Corda_Ondulata.Click += pictureBox1_Click;
            // 
            // Corda_Dura
            // 
            Corda_Dura.Image = (Image)resources.GetObject("Corda_Dura.Image");
            Corda_Dura.Location = new Point(154, 178);
            Corda_Dura.Name = "Corda_Dura";
            Corda_Dura.Size = new Size(450, 130);
            Corda_Dura.SizeMode = PictureBoxSizeMode.Zoom;
            Corda_Dura.TabIndex = 1;
            Corda_Dura.TabStop = false;
            Corda_Dura.Visible = false;
            Corda_Dura.LocationChanged += Corda_Dura_LocationChanged;
            // 
            // Start
            // 
            Start.Location = new Point(347, 334);
            Start.Name = "Start";
            Start.Size = new Size(100, 50);
            Start.TabIndex = 2;
            Start.Text = "START";
            Start.UseVisualStyleBackColor = true;
            Start.Click += Start_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(Start);
            Controls.Add(Corda_Dura);
            Controls.Add(Corda_Ondulata);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            Click += Form1_Click;
            ((System.ComponentModel.ISupportInitialize)Corda_Ondulata).EndInit();
            ((System.ComponentModel.ISupportInitialize)Corda_Dura).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private PictureBox Corda_Ondulata;
        private PictureBox Corda_Dura;
        private Button Start;
    }
}