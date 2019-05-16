namespace XPathTester
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
            this.txtXPathQuery = new System.Windows.Forms.TextBox();
            this.txtXmlDocument = new System.Windows.Forms.TextBox();
            this.btnTestXpath = new System.Windows.Forms.Button();
            this.btnClearQuery = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtXPathResult = new System.Windows.Forms.TextBox();
            this.lblResultCount = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtXPathQuery
            // 
            this.txtXPathQuery.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtXPathQuery.Location = new System.Drawing.Point(12, 21);
            this.txtXPathQuery.Multiline = true;
            this.txtXPathQuery.Name = "txtXPathQuery";
            this.txtXPathQuery.Size = new System.Drawing.Size(734, 47);
            this.txtXPathQuery.TabIndex = 0;
            // 
            // txtXmlDocument
            // 
            this.txtXmlDocument.Location = new System.Drawing.Point(6, 19);
            this.txtXmlDocument.Multiline = true;
            this.txtXmlDocument.Name = "txtXmlDocument";
            this.txtXmlDocument.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtXmlDocument.Size = new System.Drawing.Size(493, 312);
            this.txtXmlDocument.TabIndex = 1;
            // 
            // btnTestXpath
            // 
            this.btnTestXpath.Location = new System.Drawing.Point(787, 21);
            this.btnTestXpath.Name = "btnTestXpath";
            this.btnTestXpath.Size = new System.Drawing.Size(104, 47);
            this.btnTestXpath.TabIndex = 3;
            this.btnTestXpath.Text = "Test Xpath";
            this.btnTestXpath.UseVisualStyleBackColor = true;
            this.btnTestXpath.Click += new System.EventHandler(this.btnTestXpath_Click);
            // 
            // btnClearQuery
            // 
            this.btnClearQuery.Location = new System.Drawing.Point(903, 21);
            this.btnClearQuery.Name = "btnClearQuery";
            this.btnClearQuery.Size = new System.Drawing.Size(104, 47);
            this.btnClearQuery.TabIndex = 4;
            this.btnClearQuery.Text = "Clear Query";
            this.btnClearQuery.UseVisualStyleBackColor = true;
            this.btnClearQuery.Click += new System.EventHandler(this.btnClearQuery_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtXmlDocument);
            this.groupBox1.Location = new System.Drawing.Point(12, 134);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(505, 337);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "XML Document";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txtXPathResult);
            this.groupBox2.Location = new System.Drawing.Point(532, 134);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(505, 337);
            this.groupBox2.TabIndex = 6;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Result";
            // 
            // txtXPathResult
            // 
            this.txtXPathResult.Location = new System.Drawing.Point(6, 19);
            this.txtXPathResult.Multiline = true;
            this.txtXPathResult.Name = "txtXPathResult";
            this.txtXPathResult.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtXPathResult.Size = new System.Drawing.Size(493, 312);
            this.txtXPathResult.TabIndex = 1;
            // 
            // lblResultCount
            // 
            this.lblResultCount.AutoSize = true;
            this.lblResultCount.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblResultCount.Location = new System.Drawing.Point(534, 92);
            this.lblResultCount.Name = "lblResultCount";
            this.lblResultCount.Size = new System.Drawing.Size(113, 20);
            this.lblResultCount.TabIndex = 7;
            this.lblResultCount.Text = "Element found";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1069, 483);
            this.Controls.Add(this.lblResultCount);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnClearQuery);
            this.Controls.Add(this.btnTestXpath);
            this.Controls.Add(this.txtXPathQuery);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Xpath Tester";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtXPathQuery;
        private System.Windows.Forms.TextBox txtXmlDocument;
        private System.Windows.Forms.Button btnTestXpath;
        private System.Windows.Forms.Button btnClearQuery;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txtXPathResult;
        private System.Windows.Forms.Label lblResultCount;
    }
}

