using System.Windows.Forms;

namespace WindowsFormsApp1
{
    partial class BifurcationDiagram
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
            this.generate = new System.Windows.Forms.Button();
            this.bDiagram = new System.Windows.Forms.PictureBox();
            this.bDiagramProgress = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.bDiagram)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bDiagramProgress)).BeginInit();
            this.SuspendLayout();
            // 
            // generate
            // 
            this.generate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.generate.Location = new System.Drawing.Point(718, 12);
            this.generate.Name = "generate";
            this.generate.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.generate.Size = new System.Drawing.Size(70, 23);
            this.generate.TabIndex = 0;
            this.generate.Text = "Generate";
            this.generate.UseVisualStyleBackColor = true;
            this.generate.Click += new System.EventHandler(this.generation_Click);
            // 
            // bDiagram
            // 
            this.bDiagram.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
            | System.Windows.Forms.AnchorStyles.Left)));
            this.bDiagram.Location = new System.Drawing.Point(12, 12);
            this.bDiagram.Name = "Diagram";
            this.bDiagram.Size = new System.Drawing.Size(614, 341);
            this.bDiagram.TabIndex = 1;
            this.bDiagram.TabStop = false;
            // 
            // bDiagramProgress
            // 
            this.bDiagramProgress.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.bDiagramProgress.Location = new System.Drawing.Point(12, 359);
            this.bDiagramProgress.Name = "DiagramProgress";
            this.bDiagramProgress.Size = new System.Drawing.Size(776, 79);
            this.bDiagramProgress.TabIndex = 2;
            this.bDiagramProgress.TabStop = false;
            // 
            // BifurcationDiagram
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.bDiagramProgress);
            this.Controls.Add(this.bDiagram);
            this.Controls.Add(this.generate);
            this.Name = "BifurcationDiagram";
            this.Text = "Bifurcation Diagram";
            ((System.ComponentModel.ISupportInitialize)(this.bDiagram)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bDiagramProgress)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button generate;
        private System.Windows.Forms.PictureBox bDiagram;
        private PictureBox bDiagramProgress;
        private System.Windows.Forms.PictureBox pictureBox2;
    }
}

