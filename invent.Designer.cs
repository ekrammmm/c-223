namespace save
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
            this.components = new System.ComponentModel.Container();
            this.addbtn = new System.Windows.Forms.Button();
            this.cancelbtn = new System.Windows.Forms.Button();
            this.numtxt = new System.Windows.Forms.TextBox();
            this.invtxt = new System.Windows.Forms.TextBox();
            this.objtxt = new System.Windows.Forms.TextBox();
            this.counttxt = new System.Windows.Forms.TextBox();
            this.pricetxt = new System.Windows.Forms.TextBox();
            this.numlbl = new System.Windows.Forms.Label();
            this.datelbl = new System.Windows.Forms.Label();
            this.invlbl = new System.Windows.Forms.Label();
            this.objlbl = new System.Windows.Forms.Label();
            this.countlbl = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.pricelbl = new System.Windows.Forms.Label();
            this.newgridproduct = new System.Windows.Forms.DataGridView();
            this.errorProviderobjname = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.newgridproduct)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderobjname)).BeginInit();
            this.SuspendLayout();
            // 
            // addbtn
            // 
            this.addbtn.Location = new System.Drawing.Point(53, 247);
            this.addbtn.Name = "addbtn";
            this.addbtn.Size = new System.Drawing.Size(75, 23);
            this.addbtn.TabIndex = 0;
            this.addbtn.Text = "ADD";
            this.addbtn.UseVisualStyleBackColor = true;
            this.addbtn.Click += new System.EventHandler(this.addbtn_Click);
            // 
            // cancelbtn
            // 
            this.cancelbtn.Location = new System.Drawing.Point(169, 247);
            this.cancelbtn.Name = "cancelbtn";
            this.cancelbtn.Size = new System.Drawing.Size(75, 23);
            this.cancelbtn.TabIndex = 1;
            this.cancelbtn.Text = "CANCEL";
            this.cancelbtn.UseVisualStyleBackColor = true;
            this.cancelbtn.Click += new System.EventHandler(this.cancelbtn_Click);
            // 
            // numtxt
            // 
            this.numtxt.Location = new System.Drawing.Point(53, 63);
            this.numtxt.Name = "numtxt";
            this.numtxt.Size = new System.Drawing.Size(100, 20);
            this.numtxt.TabIndex = 2;
            // 
            // invtxt
            // 
            this.invtxt.Location = new System.Drawing.Point(535, 66);
            this.invtxt.Name = "invtxt";
            this.invtxt.Size = new System.Drawing.Size(100, 20);
            this.invtxt.TabIndex = 3;
            // 
            // objtxt
            // 
            this.objtxt.Location = new System.Drawing.Point(53, 137);
            this.objtxt.Name = "objtxt";
            this.objtxt.Size = new System.Drawing.Size(100, 20);
            this.objtxt.TabIndex = 4;
            // 
            // counttxt
            // 
            this.counttxt.Location = new System.Drawing.Point(53, 206);
            this.counttxt.Name = "counttxt";
            this.counttxt.Size = new System.Drawing.Size(100, 20);
            this.counttxt.TabIndex = 5;
            // 
            // pricetxt
            // 
            this.pricetxt.Location = new System.Drawing.Point(369, 206);
            this.pricetxt.Name = "pricetxt";
            this.pricetxt.Size = new System.Drawing.Size(100, 20);
            this.pricetxt.TabIndex = 6;
            // 
            // numlbl
            // 
            this.numlbl.AutoSize = true;
            this.numlbl.Location = new System.Drawing.Point(50, 47);
            this.numlbl.Name = "numlbl";
            this.numlbl.Size = new System.Drawing.Size(54, 13);
            this.numlbl.TabIndex = 7;
            this.numlbl.Text = "NUMBER";
            // 
            // datelbl
            // 
            this.datelbl.AutoSize = true;
            this.datelbl.Location = new System.Drawing.Point(270, 47);
            this.datelbl.Name = "datelbl";
            this.datelbl.Size = new System.Drawing.Size(36, 13);
            this.datelbl.TabIndex = 8;
            this.datelbl.Text = "DATE";
            // 
            // invlbl
            // 
            this.invlbl.AutoSize = true;
            this.invlbl.Location = new System.Drawing.Point(532, 47);
            this.invlbl.Name = "invlbl";
            this.invlbl.Size = new System.Drawing.Size(121, 13);
            this.invlbl.TabIndex = 9;
            this.invlbl.Text = "INVONTORY NUMBER";
            // 
            // objlbl
            // 
            this.objlbl.AutoSize = true;
            this.objlbl.Location = new System.Drawing.Point(50, 111);
            this.objlbl.Name = "objlbl";
            this.objlbl.Size = new System.Drawing.Size(85, 13);
            this.objlbl.TabIndex = 10;
            this.objlbl.Text = "OBJECT NAME ";
            // 
            // countlbl
            // 
            this.countlbl.AutoSize = true;
            this.countlbl.Location = new System.Drawing.Point(50, 177);
            this.countlbl.Name = "countlbl";
            this.countlbl.Size = new System.Drawing.Size(45, 13);
            this.countlbl.TabIndex = 11;
            this.countlbl.Text = "COUNT";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(456, 325);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(0, 13);
            this.label6.TabIndex = 12;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(239, 63);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker1.TabIndex = 13;
            // 
            // pricelbl
            // 
            this.pricelbl.AutoSize = true;
            this.pricelbl.Location = new System.Drawing.Point(377, 177);
            this.pricelbl.Name = "pricelbl";
            this.pricelbl.Size = new System.Drawing.Size(39, 13);
            this.pricelbl.TabIndex = 14;
            this.pricelbl.Text = "PRICE";
            // 
            // newgridproduct
            // 
            this.newgridproduct.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.newgridproduct.Location = new System.Drawing.Point(53, 288);
            this.newgridproduct.Name = "newgridproduct";
            this.newgridproduct.Size = new System.Drawing.Size(712, 150);
            this.newgridproduct.TabIndex = 15;
            this.newgridproduct.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.newgridproduct_CellContentClick);
            // 
            // errorProviderobjname
            // 
            this.errorProviderobjname.ContainerControl = this;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.newgridproduct);
            this.Controls.Add(this.pricelbl);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.countlbl);
            this.Controls.Add(this.objlbl);
            this.Controls.Add(this.invlbl);
            this.Controls.Add(this.datelbl);
            this.Controls.Add(this.numlbl);
            this.Controls.Add(this.pricetxt);
            this.Controls.Add(this.counttxt);
            this.Controls.Add(this.objtxt);
            this.Controls.Add(this.invtxt);
            this.Controls.Add(this.numtxt);
            this.Controls.Add(this.cancelbtn);
            this.Controls.Add(this.addbtn);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.newgridproduct)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderobjname)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button addbtn;
        private System.Windows.Forms.Button cancelbtn;
        private System.Windows.Forms.TextBox numtxt;
        private System.Windows.Forms.TextBox invtxt;
        private System.Windows.Forms.TextBox objtxt;
        private System.Windows.Forms.TextBox counttxt;
        private System.Windows.Forms.TextBox pricetxt;
        private System.Windows.Forms.Label numlbl;
        private System.Windows.Forms.Label datelbl;
        private System.Windows.Forms.Label invlbl;
        private System.Windows.Forms.Label objlbl;
        private System.Windows.Forms.Label countlbl;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label pricelbl;
        private System.Windows.Forms.DataGridView newgridproduct;
        private System.Windows.Forms.ErrorProvider errorProviderobjname;
    }
}

