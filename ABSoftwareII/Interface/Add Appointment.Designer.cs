namespace ABSoftwareII
{
	partial class addAppointment
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
			this.cancelBtn = new System.Windows.Forms.Button();
			this.savebtn = new System.Windows.Forms.Button();
			this.label6 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.comboBoxType = new System.Windows.Forms.ComboBox();
			this.dateTimePickerStart = new System.Windows.Forms.DateTimePicker();
			this.dateTimePickerEnd = new System.Windows.Forms.DateTimePicker();
			this.comboBoxName = new System.Windows.Forms.ComboBox();
			this.timeTip1 = new System.Windows.Forms.ToolTip(this.components);
			this.textBoxID = new System.Windows.Forms.TextBox();
			this.label5 = new System.Windows.Forms.Label();
			this.usernameLabel = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// cancelBtn
			// 
			this.cancelBtn.Location = new System.Drawing.Point(198, 426);
			this.cancelBtn.Name = "cancelBtn";
			this.cancelBtn.Size = new System.Drawing.Size(75, 23);
			this.cancelBtn.TabIndex = 44;
			this.cancelBtn.Text = "Cancel";
			this.cancelBtn.UseVisualStyleBackColor = true;
			this.cancelBtn.Click += new System.EventHandler(this.cancelBtn_Click);
			// 
			// savebtn
			// 
			this.savebtn.Location = new System.Drawing.Point(25, 426);
			this.savebtn.Name = "savebtn";
			this.savebtn.Size = new System.Drawing.Size(75, 23);
			this.savebtn.TabIndex = 43;
			this.savebtn.Text = "Save";
			this.savebtn.UseVisualStyleBackColor = true;
			this.savebtn.Click += new System.EventHandler(this.savebtn_Click);
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Location = new System.Drawing.Point(25, 354);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(26, 13);
			this.label6.TabIndex = 36;
			this.label6.Text = "End";
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(25, 284);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(29, 13);
			this.label4.TabIndex = 34;
			this.label4.Text = "Start";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(25, 214);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(31, 13);
			this.label3.TabIndex = 33;
			this.label3.Text = "Type";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(25, 144);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(35, 13);
			this.label2.TabIndex = 32;
			this.label2.Text = "Name";
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(25, 20);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(133, 20);
			this.label1.TabIndex = 31;
			this.label1.Text = "Add Appointment";
			// 
			// comboBoxType
			// 
			this.comboBoxType.FormattingEnabled = true;
			this.comboBoxType.Location = new System.Drawing.Point(94, 211);
			this.comboBoxType.Name = "comboBoxType";
			this.comboBoxType.Size = new System.Drawing.Size(160, 21);
			this.comboBoxType.TabIndex = 46;
			// 
			// dateTimePickerStart
			// 
			this.dateTimePickerStart.CustomFormat = "MM-dd-yyyy hh:mm tt";
			this.dateTimePickerStart.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
			this.dateTimePickerStart.Location = new System.Drawing.Point(94, 281);
			this.dateTimePickerStart.Name = "dateTimePickerStart";
			this.dateTimePickerStart.Size = new System.Drawing.Size(160, 20);
			this.dateTimePickerStart.TabIndex = 47;
			// 
			// dateTimePickerEnd
			// 
			this.dateTimePickerEnd.CustomFormat = "MM-dd-yyyy hh:mm tt";
			this.dateTimePickerEnd.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
			this.dateTimePickerEnd.Location = new System.Drawing.Point(94, 351);
			this.dateTimePickerEnd.Name = "dateTimePickerEnd";
			this.dateTimePickerEnd.Size = new System.Drawing.Size(160, 20);
			this.dateTimePickerEnd.TabIndex = 48;
			// 
			// comboBoxName
			// 
			this.comboBoxName.FormattingEnabled = true;
			this.comboBoxName.Location = new System.Drawing.Point(94, 141);
			this.comboBoxName.Name = "comboBoxName";
			this.comboBoxName.Size = new System.Drawing.Size(160, 21);
			this.comboBoxName.TabIndex = 49;
			// 
			// textBoxID
			// 
			this.textBoxID.Location = new System.Drawing.Point(94, 71);
			this.textBoxID.Name = "textBoxID";
			this.textBoxID.ReadOnly = true;
			this.textBoxID.Size = new System.Drawing.Size(20, 20);
			this.textBoxID.TabIndex = 50;
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Location = new System.Drawing.Point(25, 74);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(40, 13);
			this.label5.TabIndex = 51;
			this.label5.Text = "App ID";
			// 
			// usernameLabel
			// 
			this.usernameLabel.AutoSize = true;
			this.usernameLabel.Location = new System.Drawing.Point(335, 10);
			this.usernameLabel.Name = "usernameLabel";
			this.usernameLabel.Size = new System.Drawing.Size(35, 13);
			this.usernameLabel.TabIndex = 52;
			this.usernameLabel.Text = "label8";
			// 
			// addAppointment
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(384, 466);
			this.Controls.Add(this.usernameLabel);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.textBoxID);
			this.Controls.Add(this.comboBoxName);
			this.Controls.Add(this.dateTimePickerEnd);
			this.Controls.Add(this.dateTimePickerStart);
			this.Controls.Add(this.comboBoxType);
			this.Controls.Add(this.cancelBtn);
			this.Controls.Add(this.savebtn);
			this.Controls.Add(this.label6);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Name = "addAppointment";
			this.Text = "Add Appointment";
			this.Load += new System.EventHandler(this.addAppointment_Load);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion
		private System.Windows.Forms.Button cancelBtn;
		private System.Windows.Forms.Button savebtn;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.ComboBox comboBoxType;
		private System.Windows.Forms.DateTimePicker dateTimePickerStart;
		private System.Windows.Forms.DateTimePicker dateTimePickerEnd;
		private System.Windows.Forms.ComboBox comboBoxName;
		private System.Windows.Forms.ToolTip timeTip1;
		private System.Windows.Forms.TextBox textBoxID;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Label usernameLabel;
	}
}