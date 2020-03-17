namespace VehicleUsingAdoDotNet
{
    partial class VehicleForm
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
            this.btnSave = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.dgvVehicleDetails = new System.Windows.Forms.DataGridView();
            this.btnAdd = new System.Windows.Forms.Button();
            this.TypeOfVehicle = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RegNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DateOfManufacture = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Color = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Make = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Model = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Price = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Speed = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvVehicleDetails)).BeginInit();
            this.SuspendLayout();
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(636, 263);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(121, 23);
            this.btnSave.TabIndex = 9;
            this.btnSave.Text = "Save To CSV";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(559, 263);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(75, 23);
            this.btnDelete.TabIndex = 8;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(481, 263);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(75, 23);
            this.btnUpdate.TabIndex = 7;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // dgvVehicleDetails
            // 
            this.dgvVehicleDetails.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvVehicleDetails.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.TypeOfVehicle,
            this.RegNo,
            this.DateOfManufacture,
            this.Color,
            this.Make,
            this.Model,
            this.Price,
            this.Speed});
            this.dgvVehicleDetails.Location = new System.Drawing.Point(3, 21);
            this.dgvVehicleDetails.Name = "dgvVehicleDetails";
            this.dgvVehicleDetails.RowHeadersWidth = 62;
            this.dgvVehicleDetails.Size = new System.Drawing.Size(769, 236);
            this.dgvVehicleDetails.TabIndex = 5;
            this.dgvVehicleDetails.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvVehicleDetails_CellContentClick);
            this.dgvVehicleDetails.SelectionChanged += new System.EventHandler(this.slected_changed);
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(404, 263);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 23);
            this.btnAdd.TabIndex = 6;
            this.btnAdd.Text = "Import";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // TypeOfVehicle
            // 
            this.TypeOfVehicle.DataPropertyName = "TypeOfVehicle";
            this.TypeOfVehicle.HeaderText = "TypeOfVehicle";
            this.TypeOfVehicle.MinimumWidth = 8;
            this.TypeOfVehicle.Name = "TypeOfVehicle";
            this.TypeOfVehicle.Width = 150;
            // 
            // RegNo
            // 
            this.RegNo.DataPropertyName = "RegNo";
            this.RegNo.HeaderText = "RegNo";
            this.RegNo.MinimumWidth = 8;
            this.RegNo.Name = "RegNo";
            this.RegNo.Width = 150;
            // 
            // DateOfManufacture
            // 
            this.DateOfManufacture.DataPropertyName = "DateOfManufacture";
            this.DateOfManufacture.HeaderText = "DateOfManufacture";
            this.DateOfManufacture.MinimumWidth = 8;
            this.DateOfManufacture.Name = "DateOfManufacture";
            this.DateOfManufacture.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.DateOfManufacture.Width = 150;
            // 
            // Color
            // 
            this.Color.DataPropertyName = "Color";
            this.Color.HeaderText = "Color";
            this.Color.MinimumWidth = 8;
            this.Color.Name = "Color";
            this.Color.Width = 150;
            // 
            // Make
            // 
            this.Make.DataPropertyName = "Make";
            this.Make.HeaderText = "Make";
            this.Make.MinimumWidth = 8;
            this.Make.Name = "Make";
            this.Make.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Make.Width = 150;
            // 
            // Model
            // 
            this.Model.DataPropertyName = "Model";
            this.Model.HeaderText = "Model";
            this.Model.MinimumWidth = 8;
            this.Model.Name = "Model";
            this.Model.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Model.Width = 150;
            // 
            // Price
            // 
            this.Price.DataPropertyName = "Price";
            this.Price.HeaderText = "Price";
            this.Price.MinimumWidth = 8;
            this.Price.Name = "Price";
            this.Price.Width = 150;
            // 
            // Speed
            // 
            this.Speed.DataPropertyName = "Speed";
            this.Speed.HeaderText = "Speed";
            this.Speed.Name = "Speed";
            // 
            // VehicleForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(769, 299);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.dgvVehicleDetails);
            this.Name = "VehicleForm";
            this.Text = "Vehicle Form";
            this.Load += new System.EventHandler(this.VehicleForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvVehicleDetails)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.DataGridView dgvVehicleDetails;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.DataGridViewTextBoxColumn TypeOfVehicle;
        private System.Windows.Forms.DataGridViewTextBoxColumn RegNo;
        private System.Windows.Forms.DataGridViewTextBoxColumn DateOfManufacture;
        private System.Windows.Forms.DataGridViewTextBoxColumn Color;
        private System.Windows.Forms.DataGridViewTextBoxColumn Make;
        private System.Windows.Forms.DataGridViewTextBoxColumn Model;
        private System.Windows.Forms.DataGridViewTextBoxColumn Price;
        private System.Windows.Forms.DataGridViewTextBoxColumn Speed;
    }
}