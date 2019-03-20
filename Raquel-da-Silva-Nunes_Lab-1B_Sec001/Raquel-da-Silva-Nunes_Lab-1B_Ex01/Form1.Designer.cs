using System;

namespace Raquel_da_Silva_Nunes_Lab_1B_Ex01
{
    partial class Form1
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
            this.lblIntArray = new System.Windows.Forms.Label();
            this.txtInt = new System.Windows.Forms.TextBox();
            this.BtnGenerateInt = new System.Windows.Forms.Button();
            this.lblDoubleArray = new System.Windows.Forms.Label();
            this.txtDouble = new System.Windows.Forms.TextBox();
            this.BtnGenerateDouble = new System.Windows.Forms.Button();
            this.lblIntKey = new System.Windows.Forms.Label();
            this.txtIntKey = new System.Windows.Forms.TextBox();
            this.BtnSearch = new System.Windows.Forms.Button();
            this.lblDoubleKey = new System.Windows.Forms.Label();
            this.txtDoubleKey = new System.Windows.Forms.TextBox();
            this.BtnDoubleSearch = new System.Windows.Forms.Button();
            this.lblOutput = new System.Windows.Forms.Label();
            this.output = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lblIntArray
            // 
            this.lblIntArray.AutoSize = true;
            this.lblIntArray.Location = new System.Drawing.Point(34, 50);
            this.lblIntArray.Name = "lblIntArray";
            this.lblIntArray.Size = new System.Drawing.Size(49, 13);
            this.lblIntArray.TabIndex = 0;
            this.lblIntArray.Text = "Int Array:";
            // 
            // txtInt
            // 
            this.txtInt.Location = new System.Drawing.Point(131, 47);
            this.txtInt.Name = "txtInt";
            this.txtInt.Size = new System.Drawing.Size(176, 20);
            this.txtInt.TabIndex = 1;
            this.txtInt.TextChanged += new System.EventHandler(this.txtInt_TextChanged);
            // 
            // BtnGenerateInt
            // 
            this.BtnGenerateInt.Location = new System.Drawing.Point(313, 44);
            this.BtnGenerateInt.Name = "BtnGenerateInt";
            this.BtnGenerateInt.Size = new System.Drawing.Size(75, 23);
            this.BtnGenerateInt.TabIndex = 2;
            this.BtnGenerateInt.Text = "Generate";
            this.BtnGenerateInt.UseVisualStyleBackColor = true;
            this.BtnGenerateInt.Click += new System.EventHandler(this.BtnGenerateInt_Click);
            // 
            // lblDoubleArray
            // 
            this.lblDoubleArray.AutoSize = true;
            this.lblDoubleArray.Location = new System.Drawing.Point(34, 82);
            this.lblDoubleArray.Name = "lblDoubleArray";
            this.lblDoubleArray.Size = new System.Drawing.Size(71, 13);
            this.lblDoubleArray.TabIndex = 3;
            this.lblDoubleArray.Text = "Double Array:";
            // 
            // txtDouble
            // 
            this.txtDouble.Location = new System.Drawing.Point(131, 79);
            this.txtDouble.Name = "txtDouble";
            this.txtDouble.Size = new System.Drawing.Size(176, 20);
            this.txtDouble.TabIndex = 4;
            // 
            // BtnGenerateDouble
            // 
            this.BtnGenerateDouble.Location = new System.Drawing.Point(313, 77);
            this.BtnGenerateDouble.Name = "BtnGenerateDouble";
            this.BtnGenerateDouble.Size = new System.Drawing.Size(75, 23);
            this.BtnGenerateDouble.TabIndex = 5;
            this.BtnGenerateDouble.Text = "Generate";
            this.BtnGenerateDouble.UseVisualStyleBackColor = true;
            this.BtnGenerateDouble.Click += new System.EventHandler(this.BtnGenerateDouble_Click);
            // 
            // lblIntKey
            // 
            this.lblIntKey.AutoSize = true;
            this.lblIntKey.Location = new System.Drawing.Point(34, 112);
            this.lblIntKey.Name = "lblIntKey";
            this.lblIntKey.Size = new System.Drawing.Size(91, 13);
            this.lblIntKey.TabIndex = 6;
            this.lblIntKey.Text = "Integer Input Key:";
            // 
            // txtIntKey
            // 
            this.txtIntKey.Location = new System.Drawing.Point(131, 109);
            this.txtIntKey.Name = "txtIntKey";
            this.txtIntKey.Size = new System.Drawing.Size(176, 20);
            this.txtIntKey.TabIndex = 7;
            // 
            // BtnSearch
            // 
            this.BtnSearch.Location = new System.Drawing.Point(313, 106);
            this.BtnSearch.Name = "BtnSearch";
            this.BtnSearch.Size = new System.Drawing.Size(75, 23);
            this.BtnSearch.TabIndex = 8;
            this.BtnSearch.Text = "Search";
            this.BtnSearch.UseVisualStyleBackColor = true;
            this.BtnSearch.Click += new System.EventHandler(this.BtnSearch_Click);
            // 
            // lblDoubleKey
            // 
            this.lblDoubleKey.AutoSize = true;
            this.lblDoubleKey.Location = new System.Drawing.Point(33, 148);
            this.lblDoubleKey.Name = "lblDoubleKey";
            this.lblDoubleKey.Size = new System.Drawing.Size(92, 13);
            this.lblDoubleKey.TabIndex = 9;
            this.lblDoubleKey.Text = "Double Input Key:";
            // 
            // txtDoubleKey
            // 
            this.txtDoubleKey.Location = new System.Drawing.Point(131, 144);
            this.txtDoubleKey.Name = "txtDoubleKey";
            this.txtDoubleKey.Size = new System.Drawing.Size(176, 20);
            this.txtDoubleKey.TabIndex = 10;
            // 
            // BtnDoubleSearch
            // 
            this.BtnDoubleSearch.Location = new System.Drawing.Point(313, 141);
            this.BtnDoubleSearch.Name = "BtnDoubleSearch";
            this.BtnDoubleSearch.Size = new System.Drawing.Size(75, 23);
            this.BtnDoubleSearch.TabIndex = 11;
            this.BtnDoubleSearch.Text = "Search";
            this.BtnDoubleSearch.UseVisualStyleBackColor = true;
            this.BtnDoubleSearch.Click += new System.EventHandler(this.BtnDoubleSearch_Click);
            // 
            // lblOutput
            // 
            this.lblOutput.AutoSize = true;
            this.lblOutput.Location = new System.Drawing.Point(33, 178);
            this.lblOutput.Name = "lblOutput";
            this.lblOutput.Size = new System.Drawing.Size(42, 13);
            this.lblOutput.TabIndex = 12;
            this.lblOutput.Text = "Output:";
            // 
            // output
            // 
            this.output.Location = new System.Drawing.Point(131, 175);
            this.output.Name = "output";
            this.output.Size = new System.Drawing.Size(257, 20);
            this.output.TabIndex = 13;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(461, 261);
            this.Controls.Add(this.output);
            this.Controls.Add(this.lblOutput);
            this.Controls.Add(this.BtnDoubleSearch);
            this.Controls.Add(this.txtDoubleKey);
            this.Controls.Add(this.lblDoubleKey);
            this.Controls.Add(this.BtnSearch);
            this.Controls.Add(this.txtIntKey);
            this.Controls.Add(this.lblIntKey);
            this.Controls.Add(this.BtnGenerateDouble);
            this.Controls.Add(this.txtDouble);
            this.Controls.Add(this.lblDoubleArray);
            this.Controls.Add(this.BtnGenerateInt);
            this.Controls.Add(this.txtInt);
            this.Controls.Add(this.lblIntArray);
            this.Name = "Form1";
            this.Text = "Generic Linear Search Method";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private void txtInt_TextChanged(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        #endregion

        private System.Windows.Forms.Label lblIntArray;
        private System.Windows.Forms.TextBox txtInt;
        private System.Windows.Forms.Button BtnGenerateInt;
        private System.Windows.Forms.Label lblDoubleArray;
        private System.Windows.Forms.TextBox txtDouble;
        private System.Windows.Forms.Button BtnGenerateDouble;
        private System.Windows.Forms.Label lblIntKey;
        private System.Windows.Forms.TextBox txtIntKey;
        private System.Windows.Forms.Button BtnSearch;
        private System.Windows.Forms.Label lblDoubleKey;
        private System.Windows.Forms.TextBox txtDoubleKey;
        private System.Windows.Forms.Button BtnDoubleSearch;
        private System.Windows.Forms.Label lblOutput;
        private System.Windows.Forms.TextBox output;
    }
}

