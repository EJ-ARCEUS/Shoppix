namespace Shoppix
{
    partial class UserControlProductDesc
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.pictureBoxProduct = new System.Windows.Forms.PictureBox();
            this.labelName = new System.Windows.Forms.Label();
            this.labelDesc = new System.Windows.Forms.Label();
            this.btnAddCart = new System.Windows.Forms.Button();
            this.btnMinus = new System.Windows.Forms.Button();
            this.btnPlus = new System.Windows.Forms.Button();
            this.textBoxQua = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxProduct)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBoxProduct
            // 
            this.pictureBoxProduct.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.pictureBoxProduct.Location = new System.Drawing.Point(23, 30);
            this.pictureBoxProduct.Name = "pictureBoxProduct";
            this.pictureBoxProduct.Size = new System.Drawing.Size(295, 286);
            this.pictureBoxProduct.TabIndex = 0;
            this.pictureBoxProduct.TabStop = false;
            // 
            // labelName
            // 
            this.labelName.AutoSize = true;
            this.labelName.Location = new System.Drawing.Point(335, 60);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(93, 16);
            this.labelName.TabIndex = 1;
            this.labelName.Text = "product NAem";
            // 
            // labelDesc
            // 
            this.labelDesc.AutoSize = true;
            this.labelDesc.Location = new System.Drawing.Point(335, 266);
            this.labelDesc.Name = "labelDesc";
            this.labelDesc.Size = new System.Drawing.Size(37, 16);
            this.labelDesc.TabIndex = 2;
            this.labelDesc.Text = "desc";
            // 
            // btnAddCart
            // 
            this.btnAddCart.Location = new System.Drawing.Point(45, 427);
            this.btnAddCart.Name = "btnAddCart";
            this.btnAddCart.Size = new System.Drawing.Size(171, 68);
            this.btnAddCart.TabIndex = 3;
            this.btnAddCart.Text = "Add to Cart";
            this.btnAddCart.UseVisualStyleBackColor = true;
            // 
            // btnMinus
            // 
            this.btnMinus.Location = new System.Drawing.Point(431, 472);
            this.btnMinus.Name = "btnMinus";
            this.btnMinus.Size = new System.Drawing.Size(75, 23);
            this.btnMinus.TabIndex = 4;
            this.btnMinus.Text = "-";
            this.btnMinus.UseVisualStyleBackColor = true;
            // 
            // btnPlus
            // 
            this.btnPlus.Location = new System.Drawing.Point(611, 472);
            this.btnPlus.Name = "btnPlus";
            this.btnPlus.Size = new System.Drawing.Size(75, 23);
            this.btnPlus.TabIndex = 5;
            this.btnPlus.Text = "+";
            this.btnPlus.UseVisualStyleBackColor = true;
            // 
            // textBoxQua
            // 
            this.textBoxQua.Location = new System.Drawing.Point(534, 472);
            this.textBoxQua.Name = "textBoxQua";
            this.textBoxQua.Size = new System.Drawing.Size(49, 22);
            this.textBoxQua.TabIndex = 6;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnPlus);
            this.panel1.Controls.Add(this.pictureBoxProduct);
            this.panel1.Controls.Add(this.textBoxQua);
            this.panel1.Controls.Add(this.labelName);
            this.panel1.Controls.Add(this.labelDesc);
            this.panel1.Controls.Add(this.btnAddCart);
            this.panel1.Controls.Add(this.btnMinus);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(752, 602);
            this.panel1.TabIndex = 8;
            // 
            // UserControlProductDesc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel1);
            this.Name = "UserControlProductDesc";
            this.Size = new System.Drawing.Size(752, 602);
            this.Load += new System.EventHandler(this.UserControlProductDesc_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxProduct)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBoxProduct;
        private System.Windows.Forms.Label labelName;
        private System.Windows.Forms.Label labelDesc;
        private System.Windows.Forms.Button btnAddCart;
        private System.Windows.Forms.Button btnMinus;
        private System.Windows.Forms.Button btnPlus;
        private System.Windows.Forms.TextBox textBoxQua;
        private System.Windows.Forms.Panel panel1;
    }
}
