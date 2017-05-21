namespace LittleTim
{
    partial class littleTimFrm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(littleTimFrm));
            this.timePastLbl = new System.Windows.Forms.Label();
            this.timePastTmr = new System.Windows.Forms.Timer(this.components);
            this.pauseTmr = new System.Windows.Forms.Timer(this.components);
            this.nameTxtBx = new System.Windows.Forms.TextBox();
            this.titleScrollTmr = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // timePastLbl
            // 
            this.timePastLbl.AutoSize = true;
            this.timePastLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.timePastLbl.Location = new System.Drawing.Point(12, 9);
            this.timePastLbl.Name = "timePastLbl";
            this.timePastLbl.Size = new System.Drawing.Size(143, 37);
            this.timePastLbl.TabIndex = 0;
            this.timePastLbl.Text = "00:00:00";
            this.timePastLbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.timePastLbl.MouseClick += new System.Windows.Forms.MouseEventHandler(this.timePastLbl_MouseClick);
            // 
            // timePastTmr
            // 
            this.timePastTmr.Interval = 1000;
            this.timePastTmr.Tick += new System.EventHandler(this.timePastTmr_Tick);
            // 
            // pauseTmr
            // 
            this.pauseTmr.Interval = 1000;
            this.pauseTmr.Tick += new System.EventHandler(this.pauseTmr_Tick);
            // 
            // nameTxtBx
            // 
            this.nameTxtBx.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.nameTxtBx.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nameTxtBx.Location = new System.Drawing.Point(12, 39);
            this.nameTxtBx.Name = "nameTxtBx";
            this.nameTxtBx.Size = new System.Drawing.Size(140, 26);
            this.nameTxtBx.TabIndex = 1;
            this.nameTxtBx.Text = "LittleTim";
            this.nameTxtBx.Visible = false;
            this.nameTxtBx.DoubleClick += new System.EventHandler(this.nameTxtBx_DoubleClick);
            this.nameTxtBx.KeyDown += new System.Windows.Forms.KeyEventHandler(this.nameTxtBx_KeyDown);
            // 
            // titleScrollTmr
            // 
            this.titleScrollTmr.Interval = 500;
            this.titleScrollTmr.Tick += new System.EventHandler(this.titleScrollTmr_Tick);
            // 
            // littleTimFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(165, 53);
            this.Controls.Add(this.nameTxtBx);
            this.Controls.Add(this.timePastLbl);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "littleTimFrm";
            this.TopMost = true;
            this.DoubleClick += new System.EventHandler(this.littleTimFrm_DoubleClick);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label timePastLbl;
        private System.Windows.Forms.Timer timePastTmr;
        private System.Windows.Forms.Timer pauseTmr;
        private System.Windows.Forms.TextBox nameTxtBx;
        private System.Windows.Forms.Timer titleScrollTmr;
    }
}

