namespace SimpleDataApp
{
    partial class Navigation
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
            this.label1 = new System.Windows.Forms.Label();
            this.btnGoToAdd = new System.Windows.Forms.Button();
            this.btnGoToFillOrCancel = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(296, 75);
            this.label1.Margin = new System.Windows.Forms.Padding(30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(207, 30);
            this.label1.TabIndex = 0;
            this.label1.Text = "Co chcesz zrobić?";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // btnGoToAdd
            // 
            this.btnGoToAdd.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.btnGoToAdd.AutoSize = true;
            this.btnGoToAdd.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnGoToAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnGoToAdd.Location = new System.Drawing.Point(323, 155);
            this.btnGoToAdd.Margin = new System.Windows.Forms.Padding(20);
            this.btnGoToAdd.MaximumSize = new System.Drawing.Size(300, 0);
            this.btnGoToAdd.Name = "btnGoToAdd";
            this.btnGoToAdd.Size = new System.Drawing.Size(154, 50);
            this.btnGoToAdd.TabIndex = 1;
            this.btnGoToAdd.Text = "Dodaj konto";
            this.btnGoToAdd.UseVisualStyleBackColor = true;
            this.btnGoToAdd.Click += new System.EventHandler(this.btnGoToAdd_Click);
            // 
            // btnGoToFillOrCancel
            // 
            this.btnGoToFillOrCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.btnGoToFillOrCancel.AutoSize = true;
            this.btnGoToFillOrCancel.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnGoToFillOrCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnGoToFillOrCancel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnGoToFillOrCancel.Location = new System.Drawing.Point(224, 245);
            this.btnGoToFillOrCancel.Margin = new System.Windows.Forms.Padding(20);
            this.btnGoToFillOrCancel.Name = "btnGoToFillOrCancel";
            this.btnGoToFillOrCancel.Size = new System.Drawing.Size(351, 50);
            this.btnGoToFillOrCancel.TabIndex = 2;
            this.btnGoToFillOrCancel.Text = "Wypełnij lub usuń zamówienie";
            this.btnGoToFillOrCancel.UseVisualStyleBackColor = true;
            this.btnGoToFillOrCancel.Click += new System.EventHandler(this.btnGoToFillOrCancel_Click);
            // 
            // btnExit
            // 
            this.btnExit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.btnExit.AutoSize = true;
            this.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnExit.Location = new System.Drawing.Point(685, 355);
            this.btnExit.Margin = new System.Windows.Forms.Padding(5, 40, 5, 40);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(110, 55);
            this.btnExit.TabIndex = 3;
            this.btnExit.Text = "Zakończ";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 60F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.Controls.Add(this.label1, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.btnGoToAdd, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.btnGoToFillOrCancel, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.btnExit, 2, 4);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 5;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(800, 450);
            this.tableLayoutPanel1.TabIndex = 4;
            // 
            // Navigation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "Navigation";
            this.Text = "Navigation";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnGoToAdd;
        private System.Windows.Forms.Button btnGoToFillOrCancel;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
    }
}