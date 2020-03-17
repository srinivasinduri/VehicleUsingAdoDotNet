namespace VehicleUsingAdoDotNet
{
    partial class VehicleDialog
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
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnOk = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.rbnTruck = new System.Windows.Forms.RadioButton();
            this.rbnCar = new System.Windows.Forms.RadioButton();
            this.cmbModel = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.cmbMake = new System.Windows.Forms.ComboBox();
            this.txtPrice = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.dtpdate = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.txtRegNo = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.epVehicle = new System.Windows.Forms.ErrorProvider(this.components);
            this.cmbColor = new System.Windows.Forms.ComboBox();
            this.txtSpeed = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.epVehicle)).BeginInit();
            this.SuspendLayout();
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(101, 258);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 122;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnOk
            // 
            this.btnOk.Location = new System.Drawing.Point(20, 259);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(75, 23);
            this.btnOk.TabIndex = 121;
            this.btnOk.Text = "Ok";
            this.btnOk.UseVisualStyleBackColor = true;
            this.btnOk.Click += new System.EventHandler(this.btnOk_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(17, 9);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(42, 13);
            this.label7.TabIndex = 120;
            this.label7.Text = "Vehicle";
            // 
            // rbnTruck
            // 
            this.rbnTruck.AutoSize = true;
            this.rbnTruck.Location = new System.Drawing.Point(110, 7);
            this.rbnTruck.Name = "rbnTruck";
            this.rbnTruck.Size = new System.Drawing.Size(53, 17);
            this.rbnTruck.TabIndex = 119;
            this.rbnTruck.TabStop = true;
            this.rbnTruck.Text = "Truck";
            this.rbnTruck.UseVisualStyleBackColor = true;
            this.rbnTruck.CheckedChanged += new System.EventHandler(this.rbnTruck_CheckedChanged);
            // 
            // rbnCar
            // 
            this.rbnCar.AutoSize = true;
            this.rbnCar.Location = new System.Drawing.Point(63, 7);
            this.rbnCar.Name = "rbnCar";
            this.rbnCar.Size = new System.Drawing.Size(41, 17);
            this.rbnCar.TabIndex = 118;
            this.rbnCar.TabStop = true;
            this.rbnCar.Text = "Car";
            this.rbnCar.UseVisualStyleBackColor = true;
            this.rbnCar.CheckedChanged += new System.EventHandler(this.rbnCar_CheckedChanged);
            // 
            // cmbModel
            // 
            this.cmbModel.FormattingEnabled = true;
            this.cmbModel.Location = new System.Drawing.Point(63, 169);
            this.cmbModel.Name = "cmbModel";
            this.cmbModel.Size = new System.Drawing.Size(98, 21);
            this.cmbModel.TabIndex = 117;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(21, 173);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(36, 13);
            this.label9.TabIndex = 116;
            this.label9.Text = "Model";
            // 
            // cmbMake
            // 
            this.cmbMake.FormattingEnabled = true;
            this.cmbMake.Location = new System.Drawing.Point(61, 137);
            this.cmbMake.Name = "cmbMake";
            this.cmbMake.Size = new System.Drawing.Size(100, 21);
            this.cmbMake.TabIndex = 115;
            this.cmbMake.SelectedIndexChanged += new System.EventHandler(this.cmbMake_SelectedIndexChanged);
            // 
            // txtPrice
            // 
            this.txtPrice.Location = new System.Drawing.Point(61, 201);
            this.txtPrice.Name = "txtPrice";
            this.txtPrice.ReadOnly = true;
            this.txtPrice.Size = new System.Drawing.Size(100, 20);
            this.txtPrice.TabIndex = 114;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(18, 201);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(31, 13);
            this.label8.TabIndex = 113;
            this.label8.Text = "Price";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(21, 140);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(34, 13);
            this.label4.TabIndex = 112;
            this.label4.Text = "Make";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(21, 109);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(31, 13);
            this.label3.TabIndex = 110;
            this.label3.Text = "Color";
            // 
            // dtpdate
            // 
            this.dtpdate.Location = new System.Drawing.Point(20, 78);
            this.dtpdate.Name = "dtpdate";
            this.dtpdate.Size = new System.Drawing.Size(143, 20);
            this.dtpdate.TabIndex = 109;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(17, 59);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(105, 13);
            this.label2.TabIndex = 108;
            this.label2.Text = "Date of Manufacture";
            // 
            // txtRegNo
            // 
            this.txtRegNo.Location = new System.Drawing.Point(64, 32);
            this.txtRegNo.Name = "txtRegNo";
            this.txtRegNo.Size = new System.Drawing.Size(100, 20);
            this.txtRegNo.TabIndex = 107;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(18, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 13);
            this.label1.TabIndex = 106;
            this.label1.Text = "RegNo.";
            // 
            // epVehicle
            // 
            this.epVehicle.ContainerControl = this;
            // 
            // cmbColor
            // 
            this.cmbColor.FormattingEnabled = true;
            this.cmbColor.Location = new System.Drawing.Point(61, 106);
            this.cmbColor.Name = "cmbColor";
            this.cmbColor.Size = new System.Drawing.Size(102, 21);
            this.cmbColor.TabIndex = 126;
            // 
            // txtSpeed
            // 
            this.txtSpeed.Location = new System.Drawing.Point(61, 227);
            this.txtSpeed.Name = "txtSpeed";
            this.txtSpeed.Size = new System.Drawing.Size(100, 20);
            this.txtSpeed.TabIndex = 127;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(17, 232);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(38, 13);
            this.label5.TabIndex = 128;
            this.label5.Text = "Speed";
            // 
            // VehicleDialog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(295, 291);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtSpeed);
            this.Controls.Add(this.cmbColor);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnOk);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.rbnTruck);
            this.Controls.Add(this.rbnCar);
            this.Controls.Add(this.cmbModel);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.cmbMake);
            this.Controls.Add(this.txtPrice);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dtpdate);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtRegNo);
            this.Controls.Add(this.label1);
            this.Name = "VehicleDialog";
            this.Text = "Vehicle Dialog";
            this.Load += new System.EventHandler(this.VehicleDialog_Load);
            ((System.ComponentModel.ISupportInitialize)(this.epVehicle)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnOk;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.RadioButton rbnTruck;
        private System.Windows.Forms.RadioButton rbnCar;
        private System.Windows.Forms.ComboBox cmbModel;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox cmbMake;
        private System.Windows.Forms.TextBox txtPrice;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker dtpdate;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtRegNo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ErrorProvider epVehicle;
        private System.Windows.Forms.ComboBox cmbColor;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtSpeed;
    }
}

