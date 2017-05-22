namespace Calendar
{
    partial class AppointmentForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AppointmentForm));
            this.pnlButtons = new System.Windows.Forms.Panel();
            this.BtnSave = new System.Windows.Forms.Button();
            this.BtnCancel = new System.Windows.Forms.Button();
            this.lblSubject = new System.Windows.Forms.Label();
            this.lblLocation = new System.Windows.Forms.Label();
            this.txtbxSubject = new System.Windows.Forms.TextBox();
            this.txtbxLocation = new System.Windows.Forms.TextBox();
            this.lblDate = new System.Windows.Forms.Label();
            this.lblStartTime = new System.Windows.Forms.Label();
            this.lblLength = new System.Windows.Forms.Label();
            this.cmbbxLength = new System.Windows.Forms.ComboBox();
            this.lblOccurances = new System.Windows.Forms.Label();
            this.cmbbxFrequency = new System.Windows.Forms.ComboBox();
            this.lblFrequency = new System.Windows.Forms.Label();
            this.chkbxRecurring = new System.Windows.Forms.CheckBox();
            this.cmbbxStartTime = new System.Windows.Forms.ComboBox();
            this.lblDateSet = new System.Windows.Forms.Label();
            this.numOccurances = new System.Windows.Forms.NumericUpDown();
            this.pnlButtons.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numOccurances)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlButtons
            // 
            this.pnlButtons.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.pnlButtons.Controls.Add(this.BtnSave);
            this.pnlButtons.Controls.Add(this.BtnCancel);
            this.pnlButtons.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlButtons.Location = new System.Drawing.Point(0, 214);
            this.pnlButtons.Name = "pnlButtons";
            this.pnlButtons.Size = new System.Drawing.Size(422, 48);
            this.pnlButtons.TabIndex = 50;
            // 
            // BtnSave
            // 
            this.BtnSave.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.BtnSave.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.BtnSave.FlatAppearance.BorderColor = System.Drawing.SystemColors.ActiveCaption;
            this.BtnSave.FlatAppearance.BorderSize = 0;
            this.BtnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnSave.Location = new System.Drawing.Point(254, 13);
            this.BtnSave.Name = "BtnSave";
            this.BtnSave.Size = new System.Drawing.Size(75, 23);
            this.BtnSave.TabIndex = 8;
            this.BtnSave.Text = "Save";
            this.BtnSave.UseVisualStyleBackColor = false;
            this.BtnSave.Click += new System.EventHandler(this.BtnSave_Click);
            // 
            // BtnCancel
            // 
            this.BtnCancel.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.BtnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.BtnCancel.FlatAppearance.BorderColor = System.Drawing.SystemColors.ActiveCaption;
            this.BtnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnCancel.Location = new System.Drawing.Point(335, 13);
            this.BtnCancel.Name = "BtnCancel";
            this.BtnCancel.Size = new System.Drawing.Size(75, 23);
            this.BtnCancel.TabIndex = 9;
            this.BtnCancel.Text = "Cancel";
            this.BtnCancel.UseVisualStyleBackColor = false;
            // 
            // lblSubject
            // 
            this.lblSubject.AutoSize = true;
            this.lblSubject.Location = new System.Drawing.Point(12, 9);
            this.lblSubject.Name = "lblSubject";
            this.lblSubject.Size = new System.Drawing.Size(43, 13);
            this.lblSubject.TabIndex = 25;
            this.lblSubject.Text = "Subject";
            // 
            // lblLocation
            // 
            this.lblLocation.AutoSize = true;
            this.lblLocation.Location = new System.Drawing.Point(12, 60);
            this.lblLocation.Name = "lblLocation";
            this.lblLocation.Size = new System.Drawing.Size(48, 13);
            this.lblLocation.TabIndex = 26;
            this.lblLocation.Text = "Location";
            // 
            // txtbxSubject
            // 
            this.txtbxSubject.Location = new System.Drawing.Point(15, 25);
            this.txtbxSubject.Name = "txtbxSubject";
            this.txtbxSubject.Size = new System.Drawing.Size(395, 20);
            this.txtbxSubject.TabIndex = 0;
            // 
            // txtbxLocation
            // 
            this.txtbxLocation.Location = new System.Drawing.Point(15, 76);
            this.txtbxLocation.Name = "txtbxLocation";
            this.txtbxLocation.Size = new System.Drawing.Size(395, 20);
            this.txtbxLocation.TabIndex = 1;
            // 
            // lblDate
            // 
            this.lblDate.AutoSize = true;
            this.lblDate.Location = new System.Drawing.Point(12, 111);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(30, 13);
            this.lblDate.TabIndex = 27;
            this.lblDate.Text = "Date";
            // 
            // lblStartTime
            // 
            this.lblStartTime.AutoSize = true;
            this.lblStartTime.Location = new System.Drawing.Point(164, 111);
            this.lblStartTime.Name = "lblStartTime";
            this.lblStartTime.Size = new System.Drawing.Size(55, 13);
            this.lblStartTime.TabIndex = 28;
            this.lblStartTime.Text = "Start Time";
            // 
            // lblLength
            // 
            this.lblLength.AutoSize = true;
            this.lblLength.Location = new System.Drawing.Point(260, 111);
            this.lblLength.Name = "lblLength";
            this.lblLength.Size = new System.Drawing.Size(40, 13);
            this.lblLength.TabIndex = 30;
            this.lblLength.Text = "Length";
            // 
            // cmbbxLength
            // 
            this.cmbbxLength.FormattingEnabled = true;
            this.cmbbxLength.Location = new System.Drawing.Point(263, 126);
            this.cmbbxLength.Name = "cmbbxLength";
            this.cmbbxLength.Size = new System.Drawing.Size(121, 21);
            this.cmbbxLength.TabIndex = 4;
            // 
            // lblOccurances
            // 
            this.lblOccurances.AutoSize = true;
            this.lblOccurances.Location = new System.Drawing.Point(164, 174);
            this.lblOccurances.Name = "lblOccurances";
            this.lblOccurances.Size = new System.Drawing.Size(65, 13);
            this.lblOccurances.TabIndex = 35;
            this.lblOccurances.Text = "Occurances";
            // 
            // cmbbxFrequency
            // 
            this.cmbbxFrequency.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cmbbxFrequency.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cmbbxFrequency.Enabled = false;
            this.cmbbxFrequency.FormattingEnabled = true;
            this.cmbbxFrequency.Items.AddRange(new object[] {
            "Daily",
            "Weekly",
            "Monthly",
            "Yearly"});
            this.cmbbxFrequency.Location = new System.Drawing.Point(15, 189);
            this.cmbbxFrequency.Name = "cmbbxFrequency";
            this.cmbbxFrequency.Size = new System.Drawing.Size(121, 21);
            this.cmbbxFrequency.TabIndex = 6;
            // 
            // lblFrequency
            // 
            this.lblFrequency.AutoSize = true;
            this.lblFrequency.Location = new System.Drawing.Point(12, 174);
            this.lblFrequency.Name = "lblFrequency";
            this.lblFrequency.Size = new System.Drawing.Size(57, 13);
            this.lblFrequency.TabIndex = 33;
            this.lblFrequency.Text = "Frequency";
            // 
            // chkbxRecurring
            // 
            this.chkbxRecurring.AutoSize = true;
            this.chkbxRecurring.Location = new System.Drawing.Point(15, 153);
            this.chkbxRecurring.Name = "chkbxRecurring";
            this.chkbxRecurring.Size = new System.Drawing.Size(134, 17);
            this.chkbxRecurring.TabIndex = 5;
            this.chkbxRecurring.Text = "Recurring Appointment";
            this.chkbxRecurring.UseVisualStyleBackColor = true;
            this.chkbxRecurring.CheckedChanged += new System.EventHandler(this.chkbxRecurring_CheckedChanged);
            // 
            // cmbbxStartTime
            // 
            this.cmbbxStartTime.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cmbbxStartTime.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cmbbxStartTime.FormattingEnabled = true;
            this.cmbbxStartTime.Location = new System.Drawing.Point(167, 126);
            this.cmbbxStartTime.Name = "cmbbxStartTime";
            this.cmbbxStartTime.Size = new System.Drawing.Size(69, 21);
            this.cmbbxStartTime.TabIndex = 51;
            // 
            // lblDateSet
            // 
            this.lblDateSet.AutoSize = true;
            this.lblDateSet.Location = new System.Drawing.Point(18, 129);
            this.lblDateSet.Name = "lblDateSet";
            this.lblDateSet.Size = new System.Drawing.Size(28, 13);
            this.lblDateSet.TabIndex = 53;
            this.lblDateSet.Text = "date";
            // 
            // numOccurances
            // 
            this.numOccurances.Location = new System.Drawing.Point(167, 189);
            this.numOccurances.Maximum = new decimal(new int[] {
            999,
            0,
            0,
            0});
            this.numOccurances.Minimum = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.numOccurances.Name = "numOccurances";
            this.numOccurances.Size = new System.Drawing.Size(69, 20);
            this.numOccurances.TabIndex = 54;
            this.numOccurances.Value = new decimal(new int[] {
            2,
            0,
            0,
            0});
            // 
            // AppointmentForm
            // 
            this.AcceptButton = this.BtnSave;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.CancelButton = this.BtnCancel;
            this.ClientSize = new System.Drawing.Size(422, 262);
            this.Controls.Add(this.numOccurances);
            this.Controls.Add(this.lblDateSet);
            this.Controls.Add(this.cmbbxStartTime);
            this.Controls.Add(this.chkbxRecurring);
            this.Controls.Add(this.lblOccurances);
            this.Controls.Add(this.cmbbxLength);
            this.Controls.Add(this.cmbbxFrequency);
            this.Controls.Add(this.lblLength);
            this.Controls.Add(this.lblFrequency);
            this.Controls.Add(this.lblStartTime);
            this.Controls.Add(this.lblDate);
            this.Controls.Add(this.txtbxLocation);
            this.Controls.Add(this.txtbxSubject);
            this.Controls.Add(this.lblLocation);
            this.Controls.Add(this.lblSubject);
            this.Controls.Add(this.pnlButtons);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "AppointmentForm";
            this.Text = " ";
            this.Load += new System.EventHandler(this.AppointmentForm_Load);
            this.pnlButtons.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.numOccurances)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pnlButtons;
        private System.Windows.Forms.Button BtnCancel;
        private System.Windows.Forms.Button BtnSave;
        private System.Windows.Forms.Label lblSubject;
        private System.Windows.Forms.Label lblLocation;
        private System.Windows.Forms.TextBox txtbxSubject;
        private System.Windows.Forms.TextBox txtbxLocation;
        private System.Windows.Forms.Label lblDate;
        private System.Windows.Forms.Label lblStartTime;
        private System.Windows.Forms.Label lblLength;
        private System.Windows.Forms.ComboBox cmbbxLength;
        private System.Windows.Forms.Label lblOccurances;
        private System.Windows.Forms.ComboBox cmbbxFrequency;
        private System.Windows.Forms.Label lblFrequency;
        private System.Windows.Forms.CheckBox chkbxRecurring;
        private System.Windows.Forms.ComboBox cmbbxStartTime;
        private System.Windows.Forms.Label lblDateSet;
        private System.Windows.Forms.NumericUpDown numOccurances;
    }
}