
namespace AStar
{
    partial class AskStartFinishCells
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
            this.lblInfo = new System.Windows.Forms.Label();
            this.lblStart = new System.Windows.Forms.Label();
            this.lblFinish = new System.Windows.Forms.Label();
            this.inpFinishX = new System.Windows.Forms.TextBox();
            this.inpFinishY = new System.Windows.Forms.TextBox();
            this.inpStartX = new System.Windows.Forms.TextBox();
            this.inpStartY = new System.Windows.Forms.TextBox();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblInfo
            // 
            this.lblInfo.AutoSize = true;
            this.lblInfo.Location = new System.Drawing.Point(13, 13);
            this.lblInfo.Name = "lblInfo";
            this.lblInfo.Size = new System.Drawing.Size(45, 13);
            this.lblInfo.TabIndex = 0;
            this.lblInfo.Text = "(no info)";
            // 
            // lblStart
            // 
            this.lblStart.AutoSize = true;
            this.lblStart.Location = new System.Drawing.Point(13, 44);
            this.lblStart.Name = "lblStart";
            this.lblStart.Size = new System.Drawing.Size(32, 13);
            this.lblStart.TabIndex = 1;
            this.lblStart.Text = "Start:";
            // 
            // lblFinish
            // 
            this.lblFinish.AutoSize = true;
            this.lblFinish.Location = new System.Drawing.Point(13, 70);
            this.lblFinish.Name = "lblFinish";
            this.lblFinish.Size = new System.Drawing.Size(37, 13);
            this.lblFinish.TabIndex = 2;
            this.lblFinish.Text = "Finish:";
            // 
            // inpFinishX
            // 
            this.inpFinishX.Location = new System.Drawing.Point(56, 67);
            this.inpFinishX.Name = "inpFinishX";
            this.inpFinishX.Size = new System.Drawing.Size(43, 20);
            this.inpFinishX.TabIndex = 3;
            // 
            // inpFinishY
            // 
            this.inpFinishY.Location = new System.Drawing.Point(105, 67);
            this.inpFinishY.Name = "inpFinishY";
            this.inpFinishY.Size = new System.Drawing.Size(43, 20);
            this.inpFinishY.TabIndex = 4;
            // 
            // inpStartX
            // 
            this.inpStartX.Location = new System.Drawing.Point(56, 41);
            this.inpStartX.Name = "inpStartX";
            this.inpStartX.Size = new System.Drawing.Size(43, 20);
            this.inpStartX.TabIndex = 5;
            // 
            // inpStartY
            // 
            this.inpStartY.Location = new System.Drawing.Point(105, 41);
            this.inpStartY.Name = "inpStartY";
            this.inpStartY.Size = new System.Drawing.Size(43, 20);
            this.inpStartY.TabIndex = 6;
            // 
            // btnSubmit
            // 
            this.btnSubmit.Location = new System.Drawing.Point(16, 94);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(131, 23);
            this.btnSubmit.TabIndex = 7;
            this.btnSubmit.Text = "Submit";
            this.btnSubmit.UseVisualStyleBackColor = true;
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // AskStartFinishCells
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(165, 130);
            this.Controls.Add(this.btnSubmit);
            this.Controls.Add(this.inpStartY);
            this.Controls.Add(this.inpStartX);
            this.Controls.Add(this.inpFinishY);
            this.Controls.Add(this.inpFinishX);
            this.Controls.Add(this.lblFinish);
            this.Controls.Add(this.lblStart);
            this.Controls.Add(this.lblInfo);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "AskStartFinishCells";
            this.Text = "AskStartFinishCells";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblInfo;
        private System.Windows.Forms.Label lblStart;
        private System.Windows.Forms.Label lblFinish;
        private System.Windows.Forms.TextBox inpFinishX;
        private System.Windows.Forms.TextBox inpFinishY;
        private System.Windows.Forms.TextBox inpStartX;
        private System.Windows.Forms.TextBox inpStartY;
        private System.Windows.Forms.Button btnSubmit;
    }
}