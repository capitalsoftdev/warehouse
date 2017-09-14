namespace WarehouseClient.ProductManagement
{
    partial class MunitForm
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
            this.munitDataGridView = new System.Windows.Forms.DataGridView();
            this.addMunitButton = new System.Windows.Forms.Button();
            this.disableMunitButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.munitDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // munitDataGridView
            // 
            this.munitDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.munitDataGridView.Location = new System.Drawing.Point(31, 70);
            this.munitDataGridView.Name = "munitDataGridView";
            this.munitDataGridView.Size = new System.Drawing.Size(584, 334);
            this.munitDataGridView.TabIndex = 0;
            this.munitDataGridView.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.munitDataGridView_CellDoubleClick);
            // 
            // addMunitButton
            // 
            this.addMunitButton.Location = new System.Drawing.Point(43, 23);
            this.addMunitButton.Name = "addMunitButton";
            this.addMunitButton.Size = new System.Drawing.Size(154, 26);
            this.addMunitButton.TabIndex = 1;
            this.addMunitButton.Text = "Add New Munit";
            this.addMunitButton.UseVisualStyleBackColor = true;
            this.addMunitButton.Click += new System.EventHandler(this.addMunitButton_Click);
            // 
            // disableMunitButton
            // 
            this.disableMunitButton.Location = new System.Drawing.Point(228, 24);
            this.disableMunitButton.Name = "disableMunitButton";
            this.disableMunitButton.Size = new System.Drawing.Size(163, 24);
            this.disableMunitButton.TabIndex = 2;
            this.disableMunitButton.Text = "Disable Munit";
            this.disableMunitButton.UseVisualStyleBackColor = true;
            this.disableMunitButton.Click += new System.EventHandler(this.disableMunitButton_Click);
            // 
            // MunitForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(701, 448);
            this.Controls.Add(this.disableMunitButton);
            this.Controls.Add(this.addMunitButton);
            this.Controls.Add(this.munitDataGridView);
            this.Name = "MunitForm";
            this.Text = "MunitForm";
            this.Load += new System.EventHandler(this.MunitForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.munitDataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView munitDataGridView;
        private System.Windows.Forms.Button addMunitButton;
        private System.Windows.Forms.Button disableMunitButton;
    }
}