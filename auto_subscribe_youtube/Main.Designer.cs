namespace auto_subscribe_youtube
{
    partial class Main
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
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.lableEmail = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtRecovery = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtPass = new System.Windows.Forms.TextBox();
            this.btnAuto = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtChannel = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtLink = new System.Windows.Forms.TextBox();
            this.btnAddChannel = new System.Windows.Forms.Button();
            this.cl_Channel = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cl_Link = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(75, 55);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(365, 22);
            this.txtEmail.TabIndex = 0;
            // 
            // lableEmail
            // 
            this.lableEmail.AutoSize = true;
            this.lableEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lableEmail.Location = new System.Drawing.Point(70, 27);
            this.lableEmail.Name = "lableEmail";
            this.lableEmail.Size = new System.Drawing.Size(65, 25);
            this.lableEmail.TabIndex = 1;
            this.lableEmail.Text = "Email";
            this.lableEmail.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(70, 146);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(161, 25);
            this.label1.TabIndex = 3;
            this.label1.Text = "Email Recovery";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // txtRecovery
            // 
            this.txtRecovery.Location = new System.Drawing.Point(75, 174);
            this.txtRecovery.Name = "txtRecovery";
            this.txtRecovery.Size = new System.Drawing.Size(365, 22);
            this.txtRecovery.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(70, 86);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(106, 25);
            this.label2.TabIndex = 5;
            this.label2.Text = "Password";
            this.label2.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // txtPass
            // 
            this.txtPass.Location = new System.Drawing.Point(75, 114);
            this.txtPass.Name = "txtPass";
            this.txtPass.Size = new System.Drawing.Size(365, 22);
            this.txtPass.TabIndex = 4;
            // 
            // btnAuto
            // 
            this.btnAuto.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.btnAuto.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAuto.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnAuto.Location = new System.Drawing.Point(126, 226);
            this.btnAuto.Name = "btnAuto";
            this.btnAuto.Size = new System.Drawing.Size(269, 43);
            this.btnAuto.TabIndex = 6;
            this.btnAuto.Text = "Auto Subscribe";
            this.btnAuto.UseVisualStyleBackColor = false;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.cl_Channel,
            this.cl_Link});
            this.dataGridView1.Location = new System.Drawing.Point(527, 68);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(605, 493);
            this.dataGridView1.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(735, 27);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(133, 25);
            this.label3.TabIndex = 8;
            this.label3.Text = "List Channel";
            this.label3.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(70, 357);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(93, 25);
            this.label4.TabIndex = 10;
            this.label4.Text = "Channel";
            this.label4.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // txtChannel
            // 
            this.txtChannel.Location = new System.Drawing.Point(75, 385);
            this.txtChannel.Name = "txtChannel";
            this.txtChannel.Size = new System.Drawing.Size(365, 22);
            this.txtChannel.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(70, 430);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(52, 25);
            this.label5.TabIndex = 12;
            this.label5.Text = "Link";
            this.label5.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // txtLink
            // 
            this.txtLink.Location = new System.Drawing.Point(75, 458);
            this.txtLink.Name = "txtLink";
            this.txtLink.Size = new System.Drawing.Size(365, 22);
            this.txtLink.TabIndex = 11;
            // 
            // btnAddChannel
            // 
            this.btnAddChannel.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.btnAddChannel.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddChannel.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnAddChannel.Location = new System.Drawing.Point(126, 518);
            this.btnAddChannel.Name = "btnAddChannel";
            this.btnAddChannel.Size = new System.Drawing.Size(269, 43);
            this.btnAddChannel.TabIndex = 13;
            this.btnAddChannel.Text = "Add Channel";
            this.btnAddChannel.UseVisualStyleBackColor = false;
            // 
            // cl_Channel
            // 
            this.cl_Channel.DataPropertyName = "channel";
            this.cl_Channel.HeaderText = "Channel";
            this.cl_Channel.MinimumWidth = 6;
            this.cl_Channel.Name = "cl_Channel";
            this.cl_Channel.Width = 125;
            // 
            // cl_Link
            // 
            this.cl_Link.DataPropertyName = "link";
            this.cl_Link.HeaderText = "Link";
            this.cl_Link.MinimumWidth = 6;
            this.cl_Link.Name = "cl_Link";
            this.cl_Link.Width = 125;
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1176, 620);
            this.Controls.Add(this.btnAddChannel);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtLink);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtChannel);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btnAuto);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtPass);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtRecovery);
            this.Controls.Add(this.lableEmail);
            this.Controls.Add(this.txtEmail);
            this.Name = "Main";
            this.Text = "Main";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Label lableEmail;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtRecovery;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtPass;
        private System.Windows.Forms.Button btnAuto;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtChannel;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtLink;
        private System.Windows.Forms.Button btnAddChannel;
        private System.Windows.Forms.DataGridViewTextBoxColumn cl_Channel;
        private System.Windows.Forms.DataGridViewTextBoxColumn cl_Link;
    }
}