namespace Podda3
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.DAmount = new System.Windows.Forms.Label();
            this.Daylbl = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.gunaButton1 = new Guna.UI.WinForms.GunaButton();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.podilabel1 = new System.Windows.Forms.Label();
            this.MoLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // DAmount
            // 
            resources.ApplyResources(this.DAmount, "DAmount");
            this.DAmount.Name = "DAmount";
            this.DAmount.Click += new System.EventHandler(this.label1_Click);
            // 
            // Daylbl
            // 
            resources.ApplyResources(this.Daylbl, "Daylbl");
            this.Daylbl.Name = "Daylbl";
            this.Daylbl.Click += new System.EventHandler(this.Daylbl_Click);
            // 
            // textBox1
            // 
            resources.ApplyResources(this.textBox1, "textBox1");
            this.textBox1.Name = "textBox1";
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // gunaButton1
            // 
            this.gunaButton1.AnimationHoverSpeed = 0.07F;
            this.gunaButton1.AnimationSpeed = 0.03F;
            this.gunaButton1.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.gunaButton1.BorderColor = System.Drawing.Color.Black;
            this.gunaButton1.DialogResult = System.Windows.Forms.DialogResult.None;
            this.gunaButton1.FocusedColor = System.Drawing.Color.Empty;
            resources.ApplyResources(this.gunaButton1, "gunaButton1");
            this.gunaButton1.ForeColor = System.Drawing.Color.White;
            this.gunaButton1.Image = null;
            this.gunaButton1.ImageSize = new System.Drawing.Size(20, 20);
            this.gunaButton1.Name = "gunaButton1";
            this.gunaButton1.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.gunaButton1.OnHoverBorderColor = System.Drawing.Color.Black;
            this.gunaButton1.OnHoverForeColor = System.Drawing.Color.White;
            this.gunaButton1.OnHoverImage = null;
            this.gunaButton1.OnPressedColor = System.Drawing.Color.Black;
            this.gunaButton1.Click += new System.EventHandler(this.AddButton1_Click);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            resources.ApplyResources(this.contextMenuStrip1, "contextMenuStrip1");
            // 
            // podilabel1
            // 
            resources.ApplyResources(this.podilabel1, "podilabel1");
            this.podilabel1.Name = "podilabel1";
            this.podilabel1.Click += new System.EventHandler(this.podilabel1_Click);
            // 
            // MoLabel
            // 
            resources.ApplyResources(this.MoLabel, "MoLabel");
            this.MoLabel.Name = "MoLabel";
            this.MoLabel.Click += new System.EventHandler(this.Day_Click);
            // 
            // Form1
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.Controls.Add(this.MoLabel);
            this.Controls.Add(this.podilabel1);
            this.Controls.Add(this.gunaButton1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.Daylbl);
            this.Controls.Add(this.DAmount);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label DAmount;
        private System.Windows.Forms.Label Daylbl;
        private System.Windows.Forms.TextBox textBox1;
        private Guna.UI.WinForms.GunaButton gunaButton1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.Label podilabel1;
        private System.Windows.Forms.Label MoLabel;
    }
}

