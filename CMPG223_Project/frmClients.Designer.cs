
namespace CMPG223_Project
{
    partial class frmClients
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
            this.gbxAddClient = new System.Windows.Forms.GroupBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.lblEmail = new System.Windows.Forms.Label();
            this.lblCellNumber = new System.Windows.Forms.Label();
            this.txtCellNumber = new System.Windows.Forms.TextBox();
            this.btnAddClient = new System.Windows.Forms.Button();
            this.txtLastName = new System.Windows.Forms.TextBox();
            this.lblLastName = new System.Windows.Forms.Label();
            this.lblFirstName = new System.Windows.Forms.Label();
            this.txtFirstName = new System.Windows.Forms.TextBox();
            this.gbxRemoveClient = new System.Windows.Forms.GroupBox();
            this.btnRemoveClient = new System.Windows.Forms.Button();
            this.lblClientID = new System.Windows.Forms.Label();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.gbxUpdateClient = new System.Windows.Forms.GroupBox();
            this.txtEmailUpdate = new System.Windows.Forms.TextBox();
            this.lblEmailUpdate = new System.Windows.Forms.Label();
            this.lblCNUpdate = new System.Windows.Forms.Label();
            this.txtCNUpdate = new System.Windows.Forms.TextBox();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.txtLNUpdate = new System.Windows.Forms.TextBox();
            this.lblLNUpdate = new System.Windows.Forms.Label();
            this.lblFNUpdate = new System.Windows.Forms.Label();
            this.txtFNUpdate = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.gbxAddClient.SuspendLayout();
            this.gbxRemoveClient.SuspendLayout();
            this.gbxUpdateClient.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // gbxAddClient
            // 
            this.gbxAddClient.BackColor = System.Drawing.Color.Transparent;
            this.gbxAddClient.Controls.Add(this.txtEmail);
            this.gbxAddClient.Controls.Add(this.lblEmail);
            this.gbxAddClient.Controls.Add(this.lblCellNumber);
            this.gbxAddClient.Controls.Add(this.txtCellNumber);
            this.gbxAddClient.Controls.Add(this.btnAddClient);
            this.gbxAddClient.Controls.Add(this.txtLastName);
            this.gbxAddClient.Controls.Add(this.lblLastName);
            this.gbxAddClient.Controls.Add(this.lblFirstName);
            this.gbxAddClient.Controls.Add(this.txtFirstName);
            this.gbxAddClient.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.gbxAddClient.Font = new System.Drawing.Font("Bookman Old Style", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbxAddClient.ForeColor = System.Drawing.Color.White;
            this.gbxAddClient.Location = new System.Drawing.Point(12, 12);
            this.gbxAddClient.Name = "gbxAddClient";
            this.gbxAddClient.Size = new System.Drawing.Size(248, 430);
            this.gbxAddClient.TabIndex = 12;
            this.gbxAddClient.TabStop = false;
            this.gbxAddClient.Text = "Add Client";
            // 
            // txtEmail
            // 
            this.txtEmail.Cursor = System.Windows.Forms.Cursors.Hand;
            this.txtEmail.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEmail.Location = new System.Drawing.Point(29, 313);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(186, 25);
            this.txtEmail.TabIndex = 11;
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Font = new System.Drawing.Font("Times New Roman", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmail.Location = new System.Drawing.Point(54, 280);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(133, 22);
            this.lblEmail.TabIndex = 10;
            this.lblEmail.Text = "Email Address:";
            // 
            // lblCellNumber
            // 
            this.lblCellNumber.AutoSize = true;
            this.lblCellNumber.Font = new System.Drawing.Font("Times New Roman", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCellNumber.Location = new System.Drawing.Point(29, 198);
            this.lblCellNumber.Name = "lblCellNumber";
            this.lblCellNumber.Size = new System.Drawing.Size(165, 22);
            this.lblCellNumber.TabIndex = 9;
            this.lblCellNumber.Text = "Cellphone Number:";
            // 
            // txtCellNumber
            // 
            this.txtCellNumber.Cursor = System.Windows.Forms.Cursors.Hand;
            this.txtCellNumber.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCellNumber.Location = new System.Drawing.Point(29, 231);
            this.txtCellNumber.Name = "txtCellNumber";
            this.txtCellNumber.Size = new System.Drawing.Size(186, 25);
            this.txtCellNumber.TabIndex = 8;
            // 
            // btnAddClient
            // 
            this.btnAddClient.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAddClient.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnAddClient.Font = new System.Drawing.Font("Tahoma", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddClient.Location = new System.Drawing.Point(29, 364);
            this.btnAddClient.Name = "btnAddClient";
            this.btnAddClient.Size = new System.Drawing.Size(186, 38);
            this.btnAddClient.TabIndex = 7;
            this.btnAddClient.Text = "Add Client";
            this.btnAddClient.UseVisualStyleBackColor = true;
            // 
            // txtLastName
            // 
            this.txtLastName.Cursor = System.Windows.Forms.Cursors.Hand;
            this.txtLastName.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLastName.Location = new System.Drawing.Point(29, 144);
            this.txtLastName.Name = "txtLastName";
            this.txtLastName.Size = new System.Drawing.Size(186, 25);
            this.txtLastName.TabIndex = 6;
            // 
            // lblLastName
            // 
            this.lblLastName.AutoSize = true;
            this.lblLastName.Font = new System.Drawing.Font("Times New Roman", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLastName.Location = new System.Drawing.Point(69, 111);
            this.lblLastName.Name = "lblLastName";
            this.lblLastName.Size = new System.Drawing.Size(100, 22);
            this.lblLastName.TabIndex = 5;
            this.lblLastName.Text = "Last Name:";
            // 
            // lblFirstName
            // 
            this.lblFirstName.AutoSize = true;
            this.lblFirstName.Font = new System.Drawing.Font("Times New Roman", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFirstName.Location = new System.Drawing.Point(69, 29);
            this.lblFirstName.Name = "lblFirstName";
            this.lblFirstName.Size = new System.Drawing.Size(104, 22);
            this.lblFirstName.TabIndex = 4;
            this.lblFirstName.Text = "First Name:";
            // 
            // txtFirstName
            // 
            this.txtFirstName.Cursor = System.Windows.Forms.Cursors.Hand;
            this.txtFirstName.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFirstName.Location = new System.Drawing.Point(29, 62);
            this.txtFirstName.Name = "txtFirstName";
            this.txtFirstName.Size = new System.Drawing.Size(186, 25);
            this.txtFirstName.TabIndex = 0;
            // 
            // gbxRemoveClient
            // 
            this.gbxRemoveClient.BackColor = System.Drawing.Color.Transparent;
            this.gbxRemoveClient.Controls.Add(this.btnRemoveClient);
            this.gbxRemoveClient.Controls.Add(this.lblClientID);
            this.gbxRemoveClient.Controls.Add(this.textBox4);
            this.gbxRemoveClient.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.gbxRemoveClient.Font = new System.Drawing.Font("Bookman Old Style", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbxRemoveClient.ForeColor = System.Drawing.Color.White;
            this.gbxRemoveClient.Location = new System.Drawing.Point(287, 12);
            this.gbxRemoveClient.Name = "gbxRemoveClient";
            this.gbxRemoveClient.Size = new System.Drawing.Size(248, 202);
            this.gbxRemoveClient.TabIndex = 13;
            this.gbxRemoveClient.TabStop = false;
            this.gbxRemoveClient.Text = "Remove Client";
            // 
            // btnRemoveClient
            // 
            this.btnRemoveClient.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRemoveClient.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnRemoveClient.Font = new System.Drawing.Font("Tahoma", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRemoveClient.Location = new System.Drawing.Point(29, 131);
            this.btnRemoveClient.Name = "btnRemoveClient";
            this.btnRemoveClient.Size = new System.Drawing.Size(186, 38);
            this.btnRemoveClient.TabIndex = 7;
            this.btnRemoveClient.Text = "Remove Client";
            this.btnRemoveClient.UseVisualStyleBackColor = true;
            // 
            // lblClientID
            // 
            this.lblClientID.AutoSize = true;
            this.lblClientID.Font = new System.Drawing.Font("Times New Roman", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblClientID.Location = new System.Drawing.Point(71, 29);
            this.lblClientID.Name = "lblClientID";
            this.lblClientID.Size = new System.Drawing.Size(94, 22);
            this.lblClientID.TabIndex = 4;
            this.lblClientID.Text = "Client_ID:";
            this.lblClientID.Click += new System.EventHandler(this.lblClientID_Click);
            // 
            // textBox4
            // 
            this.textBox4.Cursor = System.Windows.Forms.Cursors.Hand;
            this.textBox4.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox4.Location = new System.Drawing.Point(29, 62);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(186, 25);
            this.textBox4.TabIndex = 0;
            // 
            // gbxUpdateClient
            // 
            this.gbxUpdateClient.BackColor = System.Drawing.Color.Transparent;
            this.gbxUpdateClient.Controls.Add(this.txtEmailUpdate);
            this.gbxUpdateClient.Controls.Add(this.lblEmailUpdate);
            this.gbxUpdateClient.Controls.Add(this.lblCNUpdate);
            this.gbxUpdateClient.Controls.Add(this.txtCNUpdate);
            this.gbxUpdateClient.Controls.Add(this.btnUpdate);
            this.gbxUpdateClient.Controls.Add(this.txtLNUpdate);
            this.gbxUpdateClient.Controls.Add(this.lblLNUpdate);
            this.gbxUpdateClient.Controls.Add(this.lblFNUpdate);
            this.gbxUpdateClient.Controls.Add(this.txtFNUpdate);
            this.gbxUpdateClient.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.gbxUpdateClient.Font = new System.Drawing.Font("Bookman Old Style", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbxUpdateClient.ForeColor = System.Drawing.Color.White;
            this.gbxUpdateClient.Location = new System.Drawing.Point(555, 12);
            this.gbxUpdateClient.Name = "gbxUpdateClient";
            this.gbxUpdateClient.Size = new System.Drawing.Size(248, 430);
            this.gbxUpdateClient.TabIndex = 13;
            this.gbxUpdateClient.TabStop = false;
            this.gbxUpdateClient.Text = "Update Client Information";
            // 
            // txtEmailUpdate
            // 
            this.txtEmailUpdate.Cursor = System.Windows.Forms.Cursors.Hand;
            this.txtEmailUpdate.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEmailUpdate.Location = new System.Drawing.Point(29, 313);
            this.txtEmailUpdate.Name = "txtEmailUpdate";
            this.txtEmailUpdate.Size = new System.Drawing.Size(186, 25);
            this.txtEmailUpdate.TabIndex = 11;
            // 
            // lblEmailUpdate
            // 
            this.lblEmailUpdate.AutoSize = true;
            this.lblEmailUpdate.Font = new System.Drawing.Font("Times New Roman", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmailUpdate.Location = new System.Drawing.Point(54, 280);
            this.lblEmailUpdate.Name = "lblEmailUpdate";
            this.lblEmailUpdate.Size = new System.Drawing.Size(133, 22);
            this.lblEmailUpdate.TabIndex = 10;
            this.lblEmailUpdate.Text = "Email Address:";
            // 
            // lblCNUpdate
            // 
            this.lblCNUpdate.AutoSize = true;
            this.lblCNUpdate.Font = new System.Drawing.Font("Times New Roman", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCNUpdate.Location = new System.Drawing.Point(29, 198);
            this.lblCNUpdate.Name = "lblCNUpdate";
            this.lblCNUpdate.Size = new System.Drawing.Size(165, 22);
            this.lblCNUpdate.TabIndex = 9;
            this.lblCNUpdate.Text = "Cellphone Number:";
            // 
            // txtCNUpdate
            // 
            this.txtCNUpdate.Cursor = System.Windows.Forms.Cursors.Hand;
            this.txtCNUpdate.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCNUpdate.Location = new System.Drawing.Point(29, 231);
            this.txtCNUpdate.Name = "txtCNUpdate";
            this.txtCNUpdate.Size = new System.Drawing.Size(186, 25);
            this.txtCNUpdate.TabIndex = 8;
            // 
            // btnUpdate
            // 
            this.btnUpdate.BackColor = System.Drawing.Color.Transparent;
            this.btnUpdate.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnUpdate.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnUpdate.Font = new System.Drawing.Font("Tahoma", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdate.Location = new System.Drawing.Point(29, 364);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(186, 38);
            this.btnUpdate.TabIndex = 7;
            this.btnUpdate.Text = "Update Client";
            this.btnUpdate.UseVisualStyleBackColor = false;
            // 
            // txtLNUpdate
            // 
            this.txtLNUpdate.Cursor = System.Windows.Forms.Cursors.Hand;
            this.txtLNUpdate.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLNUpdate.Location = new System.Drawing.Point(29, 144);
            this.txtLNUpdate.Name = "txtLNUpdate";
            this.txtLNUpdate.Size = new System.Drawing.Size(186, 25);
            this.txtLNUpdate.TabIndex = 6;
            // 
            // lblLNUpdate
            // 
            this.lblLNUpdate.AutoSize = true;
            this.lblLNUpdate.Font = new System.Drawing.Font("Times New Roman", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLNUpdate.Location = new System.Drawing.Point(69, 111);
            this.lblLNUpdate.Name = "lblLNUpdate";
            this.lblLNUpdate.Size = new System.Drawing.Size(100, 22);
            this.lblLNUpdate.TabIndex = 5;
            this.lblLNUpdate.Text = "Last Name:";
            // 
            // lblFNUpdate
            // 
            this.lblFNUpdate.AutoSize = true;
            this.lblFNUpdate.Font = new System.Drawing.Font("Times New Roman", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFNUpdate.Location = new System.Drawing.Point(69, 29);
            this.lblFNUpdate.Name = "lblFNUpdate";
            this.lblFNUpdate.Size = new System.Drawing.Size(104, 22);
            this.lblFNUpdate.TabIndex = 4;
            this.lblFNUpdate.Text = "First Name:";
            // 
            // txtFNUpdate
            // 
            this.txtFNUpdate.Cursor = System.Windows.Forms.Cursors.Hand;
            this.txtFNUpdate.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFNUpdate.Location = new System.Drawing.Point(29, 62);
            this.txtFNUpdate.Name = "txtFNUpdate";
            this.txtFNUpdate.Size = new System.Drawing.Size(186, 25);
            this.txtFNUpdate.TabIndex = 0;
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.Color.LightGray;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 518);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(791, 256);
            this.dataGridView1.TabIndex = 14;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Bookman Old Style", 20F, System.Drawing.FontStyle.Underline);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(12, 469);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(266, 32);
            this.label1.TabIndex = 15;
            this.label1.Text = "Client Information:";
            // 
            // frmClients
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::CMPG223_Project.Properties.Resources.Back_4;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(819, 786);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.gbxUpdateClient);
            this.Controls.Add(this.gbxRemoveClient);
            this.Controls.Add(this.gbxAddClient);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Name = "frmClients";
            this.Text = "Client Information";
            this.gbxAddClient.ResumeLayout(false);
            this.gbxAddClient.PerformLayout();
            this.gbxRemoveClient.ResumeLayout(false);
            this.gbxRemoveClient.PerformLayout();
            this.gbxUpdateClient.ResumeLayout(false);
            this.gbxUpdateClient.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox gbxAddClient;
        private System.Windows.Forms.Button btnAddClient;
        private System.Windows.Forms.TextBox txtLastName;
        private System.Windows.Forms.Label lblLastName;
        private System.Windows.Forms.Label lblFirstName;
        private System.Windows.Forms.TextBox txtFirstName;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.Label lblCellNumber;
        private System.Windows.Forms.TextBox txtCellNumber;
        private System.Windows.Forms.GroupBox gbxRemoveClient;
        private System.Windows.Forms.Button btnRemoveClient;
        private System.Windows.Forms.Label lblClientID;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.GroupBox gbxUpdateClient;
        private System.Windows.Forms.TextBox txtEmailUpdate;
        private System.Windows.Forms.Label lblEmailUpdate;
        private System.Windows.Forms.Label lblCNUpdate;
        private System.Windows.Forms.TextBox txtCNUpdate;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.TextBox txtLNUpdate;
        private System.Windows.Forms.Label lblLNUpdate;
        private System.Windows.Forms.Label lblFNUpdate;
        private System.Windows.Forms.TextBox txtFNUpdate;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label1;
    }
}