namespace POS.Startup.Client
{
    partial class ClentStartupFrom
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
            this.btnMachine = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtMachineId = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnMachine
            // 
            this.btnMachine.Location = new System.Drawing.Point(224, 106);
            this.btnMachine.Name = "btnMachine";
            this.btnMachine.Size = new System.Drawing.Size(126, 23);
            this.btnMachine.TabIndex = 0;
            this.btnMachine.Text = "OK";
            this.btnMachine.UseVisualStyleBackColor = true;
            this.btnMachine.Click += new System.EventHandler(this.btnMachine_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(110, 71);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Enter Application";
            // 
            // txtMachineId
            // 
            this.txtMachineId.Location = new System.Drawing.Point(203, 64);
            this.txtMachineId.Name = "txtMachineId";
            this.txtMachineId.Size = new System.Drawing.Size(201, 20);
            this.txtMachineId.TabIndex = 2;
            // 
            // ClentStartupFrom
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(497, 240);
            this.Controls.Add(this.txtMachineId);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnMachine);
            this.Name = "ClentStartupFrom";
            this.Text = "Client Startup";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnMachine;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtMachineId;
    }
}

