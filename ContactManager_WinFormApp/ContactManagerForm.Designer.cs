namespace ContactManager_WinFormApp
{
    partial class ContactManagerForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ContactManagerForm));
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.contactListTab = new System.Windows.Forms.TabPage();
            this.viewlisttb = new System.Windows.Forms.TextBox();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.ViewListbtn = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.AddEditTab = new System.Windows.Forms.TabPage();
            this.signupidtb = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Signupidbtn = new System.Windows.Forms.Button();
            this.insertbtn = new System.Windows.Forms.Button();
            this.phonenumtb = new System.Windows.Forms.TextBox();
            this.emailtb = new System.Windows.Forms.TextBox();
            this.nametb = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProvider2 = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProvider3 = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProvider4 = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProvider5 = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProvider6 = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProvider7 = new System.Windows.Forms.ErrorProvider(this.components);
            this.viewsignupbtn = new System.Windows.Forms.Button();
            this.cancelbtn = new System.Windows.Forms.Button();
            this.veiwWholeListbtn = new System.Windows.Forms.Button();
            this.FetchWholeContactListbtn = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.Deletebtn = new System.Windows.Forms.Button();
            this.Searchbtn = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.searchtb = new System.Windows.Forms.TextBox();
            this.Exportbtn = new System.Windows.Forms.Button();
            this.tabControl1.SuspendLayout();
            this.contactListTab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.AddEditTab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider7)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.contactListTab);
            this.tabControl1.Controls.Add(this.AddEditTab);
            this.tabControl1.Location = new System.Drawing.Point(12, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(776, 532);
            this.tabControl1.TabIndex = 0;
            // 
            // contactListTab
            // 
            this.contactListTab.Controls.Add(this.Exportbtn);
            this.contactListTab.Controls.Add(this.veiwWholeListbtn);
            this.contactListTab.Controls.Add(this.viewsignupbtn);
            this.contactListTab.Controls.Add(this.viewlisttb);
            this.contactListTab.Controls.Add(this.dataGridView2);
            this.contactListTab.Controls.Add(this.ViewListbtn);
            this.contactListTab.Controls.Add(this.label6);
            this.contactListTab.Controls.Add(this.label5);
            this.contactListTab.Location = new System.Drawing.Point(4, 22);
            this.contactListTab.Name = "contactListTab";
            this.contactListTab.Padding = new System.Windows.Forms.Padding(3);
            this.contactListTab.Size = new System.Drawing.Size(768, 506);
            this.contactListTab.TabIndex = 0;
            this.contactListTab.Text = "Contacts";
            this.contactListTab.UseVisualStyleBackColor = true;
            // 
            // viewlisttb
            // 
            this.viewlisttb.ForeColor = System.Drawing.Color.Gray;
            this.viewlisttb.Location = new System.Drawing.Point(219, 95);
            this.viewlisttb.Name = "viewlisttb";
            this.viewlisttb.Size = new System.Drawing.Size(219, 20);
            this.viewlisttb.TabIndex = 0;
            this.viewlisttb.Text = "Enter your signup id";
            this.viewlisttb.Enter += new System.EventHandler(this.viewlisttb_Enter);
            this.viewlisttb.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.viewlisttb_KeyPress);
            this.viewlisttb.Leave += new System.EventHandler(this.viewlisttb_Leave);
            // 
            // dataGridView2
            // 
            this.dataGridView2.AllowUserToAddRows = false;
            this.dataGridView2.AllowUserToDeleteRows = false;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Location = new System.Drawing.Point(29, 306);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.ReadOnly = true;
            this.dataGridView2.Size = new System.Drawing.Size(701, 150);
            this.dataGridView2.TabIndex = 3;
            // 
            // ViewListbtn
            // 
            this.ViewListbtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ViewListbtn.Location = new System.Drawing.Point(219, 190);
            this.ViewListbtn.Name = "ViewListbtn";
            this.ViewListbtn.Size = new System.Drawing.Size(219, 37);
            this.ViewListbtn.TabIndex = 2;
            this.ViewListbtn.Text = "View Contact List";
            this.ViewListbtn.UseVisualStyleBackColor = true;
            this.ViewListbtn.Click += new System.EventHandler(this.ViewListbtn_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(285, 59);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(81, 16);
            this.label6.TabIndex = 1;
            this.label6.Text = "SignUp ID:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Wide Latin", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(12, 26);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(750, 23);
            this.label5.TabIndex = 0;
            this.label5.Text = "Enter your Signup id to see your contact list";
            // 
            // AddEditTab
            // 
            this.AddEditTab.Controls.Add(this.searchtb);
            this.AddEditTab.Controls.Add(this.Searchbtn);
            this.AddEditTab.Controls.Add(this.Deletebtn);
            this.AddEditTab.Controls.Add(this.button1);
            this.AddEditTab.Controls.Add(this.FetchWholeContactListbtn);
            this.AddEditTab.Controls.Add(this.cancelbtn);
            this.AddEditTab.Controls.Add(this.signupidtb);
            this.AddEditTab.Controls.Add(this.dataGridView1);
            this.AddEditTab.Controls.Add(this.Signupidbtn);
            this.AddEditTab.Controls.Add(this.insertbtn);
            this.AddEditTab.Controls.Add(this.phonenumtb);
            this.AddEditTab.Controls.Add(this.emailtb);
            this.AddEditTab.Controls.Add(this.nametb);
            this.AddEditTab.Controls.Add(this.label3);
            this.AddEditTab.Controls.Add(this.label2);
            this.AddEditTab.Controls.Add(this.label7);
            this.AddEditTab.Controls.Add(this.label4);
            this.AddEditTab.Controls.Add(this.label1);
            this.AddEditTab.Location = new System.Drawing.Point(4, 22);
            this.AddEditTab.Name = "AddEditTab";
            this.AddEditTab.Padding = new System.Windows.Forms.Padding(3);
            this.AddEditTab.Size = new System.Drawing.Size(768, 506);
            this.AddEditTab.TabIndex = 1;
            this.AddEditTab.Text = "Add/Edit";
            this.AddEditTab.UseVisualStyleBackColor = true;
            // 
            // signupidtb
            // 
            this.signupidtb.ForeColor = System.Drawing.Color.Gray;
            this.signupidtb.Location = new System.Drawing.Point(235, 164);
            this.signupidtb.Name = "signupidtb";
            this.signupidtb.Size = new System.Drawing.Size(188, 20);
            this.signupidtb.TabIndex = 3;
            this.signupidtb.Text = "Enter your signup id";
            this.signupidtb.Enter += new System.EventHandler(this.signupidtb_Enter);
            this.signupidtb.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.signupidtb_KeyPress);
            this.signupidtb.Leave += new System.EventHandler(this.signupidtb_Leave);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(79, 311);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(683, 189);
            this.dataGridView1.TabIndex = 6;
            this.dataGridView1.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.dataGridView1_MouseDoubleClick);
            // 
            // Signupidbtn
            // 
            this.Signupidbtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Signupidbtn.Location = new System.Drawing.Point(554, 61);
            this.Signupidbtn.Name = "Signupidbtn";
            this.Signupidbtn.Size = new System.Drawing.Size(196, 30);
            this.Signupidbtn.TabIndex = 5;
            this.Signupidbtn.Text = "View Signup id:";
            this.Signupidbtn.UseVisualStyleBackColor = true;
            this.Signupidbtn.Click += new System.EventHandler(this.Signupidbtn_Click);
            // 
            // insertbtn
            // 
            this.insertbtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.insertbtn.Location = new System.Drawing.Point(554, 169);
            this.insertbtn.Name = "insertbtn";
            this.insertbtn.Size = new System.Drawing.Size(196, 30);
            this.insertbtn.TabIndex = 4;
            this.insertbtn.Text = "Save";
            this.insertbtn.UseVisualStyleBackColor = true;
            this.insertbtn.Click += new System.EventHandler(this.insertbtn_Click);
            // 
            // phonenumtb
            // 
            this.phonenumtb.ForeColor = System.Drawing.Color.Gray;
            this.phonenumtb.Location = new System.Drawing.Point(235, 125);
            this.phonenumtb.Name = "phonenumtb";
            this.phonenumtb.Size = new System.Drawing.Size(188, 20);
            this.phonenumtb.TabIndex = 2;
            this.phonenumtb.Text = "Enter phone number";
            this.phonenumtb.Enter += new System.EventHandler(this.phonenumtb_Enter);
            this.phonenumtb.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.phonenumtb_KeyPress);
            this.phonenumtb.Leave += new System.EventHandler(this.phonenumtb_Leave);
            // 
            // emailtb
            // 
            this.emailtb.ForeColor = System.Drawing.Color.Gray;
            this.emailtb.Location = new System.Drawing.Point(235, 85);
            this.emailtb.Name = "emailtb";
            this.emailtb.Size = new System.Drawing.Size(188, 20);
            this.emailtb.TabIndex = 1;
            this.emailtb.Text = "Enter email address";
            this.emailtb.Enter += new System.EventHandler(this.emailtb_Enter);
            this.emailtb.Leave += new System.EventHandler(this.emailtb_Leave);
            // 
            // nametb
            // 
            this.nametb.ForeColor = System.Drawing.Color.Gray;
            this.nametb.Location = new System.Drawing.Point(235, 42);
            this.nametb.Name = "nametb";
            this.nametb.Size = new System.Drawing.Size(188, 20);
            this.nametb.TabIndex = 0;
            this.nametb.Text = "Enter name here";
            this.nametb.Enter += new System.EventHandler(this.nametb_Enter);
            this.nametb.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.nametb_KeyPress);
            this.nametb.Leave += new System.EventHandler(this.nametb_Leave);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(76, 126);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(113, 16);
            this.label3.TabIndex = 0;
            this.label3.Text = "Phone Number:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(78, 86);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 16);
            this.label2.TabIndex = 0;
            this.label2.Text = "Email:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(78, 164);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(81, 16);
            this.label4.TabIndex = 0;
            this.label4.Text = "SignUp ID:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(76, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Name:";
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // errorProvider2
            // 
            this.errorProvider2.ContainerControl = this;
            // 
            // errorProvider3
            // 
            this.errorProvider3.ContainerControl = this;
            // 
            // errorProvider4
            // 
            this.errorProvider4.ContainerControl = this;
            // 
            // errorProvider5
            // 
            this.errorProvider5.ContainerControl = this;
            // 
            // errorProvider6
            // 
            this.errorProvider6.ContainerControl = this;
            // 
            // errorProvider7
            // 
            this.errorProvider7.ContainerControl = this;
            // 
            // viewsignupbtn
            // 
            this.viewsignupbtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.viewsignupbtn.Location = new System.Drawing.Point(219, 133);
            this.viewsignupbtn.Name = "viewsignupbtn";
            this.viewsignupbtn.Size = new System.Drawing.Size(219, 37);
            this.viewsignupbtn.TabIndex = 4;
            this.viewsignupbtn.Text = "View SignUp id";
            this.viewsignupbtn.UseVisualStyleBackColor = true;
            this.viewsignupbtn.Click += new System.EventHandler(this.viewsignupbtn_Click);
            // 
            // cancelbtn
            // 
            this.cancelbtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cancelbtn.Location = new System.Drawing.Point(554, 205);
            this.cancelbtn.Name = "cancelbtn";
            this.cancelbtn.Size = new System.Drawing.Size(196, 30);
            this.cancelbtn.TabIndex = 7;
            this.cancelbtn.Text = "Cancel";
            this.cancelbtn.UseVisualStyleBackColor = true;
            this.cancelbtn.Click += new System.EventHandler(this.cancelbtn_Click);
            // 
            // veiwWholeListbtn
            // 
            this.veiwWholeListbtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.veiwWholeListbtn.Location = new System.Drawing.Point(219, 248);
            this.veiwWholeListbtn.Name = "veiwWholeListbtn";
            this.veiwWholeListbtn.Size = new System.Drawing.Size(219, 37);
            this.veiwWholeListbtn.TabIndex = 5;
            this.veiwWholeListbtn.Text = "View Whole Contact List";
            this.veiwWholeListbtn.UseVisualStyleBackColor = true;
            this.veiwWholeListbtn.Click += new System.EventHandler(this.veiwWholeListbtn_Click);
            // 
            // FetchWholeContactListbtn
            // 
            this.FetchWholeContactListbtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FetchWholeContactListbtn.Location = new System.Drawing.Point(554, 25);
            this.FetchWholeContactListbtn.Name = "FetchWholeContactListbtn";
            this.FetchWholeContactListbtn.Size = new System.Drawing.Size(196, 30);
            this.FetchWholeContactListbtn.TabIndex = 8;
            this.FetchWholeContactListbtn.Text = "View Whole Contact List";
            this.FetchWholeContactListbtn.UseVisualStyleBackColor = true;
            this.FetchWholeContactListbtn.Click += new System.EventHandler(this.FetchWholeContactListbtn_Click);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(554, 133);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(196, 30);
            this.button1.TabIndex = 9;
            this.button1.Text = "Edit Contact";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // Deletebtn
            // 
            this.Deletebtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Deletebtn.Location = new System.Drawing.Point(554, 97);
            this.Deletebtn.Name = "Deletebtn";
            this.Deletebtn.Size = new System.Drawing.Size(196, 30);
            this.Deletebtn.TabIndex = 10;
            this.Deletebtn.Text = "Delete Contact";
            this.Deletebtn.UseVisualStyleBackColor = true;
            this.Deletebtn.Click += new System.EventHandler(this.Deletebtn_Click);
            // 
            // Searchbtn
            // 
            this.Searchbtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Searchbtn.Image = ((System.Drawing.Image)(resources.GetObject("Searchbtn.Image")));
            this.Searchbtn.Location = new System.Drawing.Point(711, 273);
            this.Searchbtn.Name = "Searchbtn";
            this.Searchbtn.Size = new System.Drawing.Size(39, 32);
            this.Searchbtn.TabIndex = 11;
            this.Searchbtn.UseVisualStyleBackColor = true;
            this.Searchbtn.Click += new System.EventHandler(this.Searchbtn_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(76, 277);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(60, 16);
            this.label7.TabIndex = 0;
            this.label7.Text = "Search:";
            // 
            // searchtb
            // 
            this.searchtb.Location = new System.Drawing.Point(163, 273);
            this.searchtb.Name = "searchtb";
            this.searchtb.Size = new System.Drawing.Size(542, 20);
            this.searchtb.TabIndex = 12;
            this.searchtb.TextChanged += new System.EventHandler(this.searchtb_TextChanged);
            // 
            // Exportbtn
            // 
            this.Exportbtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Exportbtn.Location = new System.Drawing.Point(643, 462);
            this.Exportbtn.Name = "Exportbtn";
            this.Exportbtn.Size = new System.Drawing.Size(87, 38);
            this.Exportbtn.TabIndex = 6;
            this.Exportbtn.Text = "Export";
            this.Exportbtn.UseVisualStyleBackColor = true;
            this.Exportbtn.Click += new System.EventHandler(this.Exportbtn_Click);
            // 
            // ContactManagerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 556);
            this.Controls.Add(this.tabControl1);
            this.Name = "ContactManagerForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Contact Manager";
            this.tabControl1.ResumeLayout(false);
            this.contactListTab.ResumeLayout(false);
            this.contactListTab.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.AddEditTab.ResumeLayout(false);
            this.AddEditTab.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider7)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage contactListTab;
        private System.Windows.Forms.TabPage AddEditTab;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox phonenumtb;
        private System.Windows.Forms.TextBox emailtb;
        private System.Windows.Forms.TextBox nametb;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.ErrorProvider errorProvider2;
        private System.Windows.Forms.ErrorProvider errorProvider3;
        private System.Windows.Forms.Button insertbtn;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button Signupidbtn;
        private System.Windows.Forms.ErrorProvider errorProvider4;
        private System.Windows.Forms.ErrorProvider errorProvider5;
        private System.Windows.Forms.ErrorProvider errorProvider6;
        private System.Windows.Forms.TextBox signupidtb;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.Button ViewListbtn;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox viewlisttb;
        private System.Windows.Forms.ErrorProvider errorProvider7;
        private System.Windows.Forms.Button viewsignupbtn;
        private System.Windows.Forms.Button cancelbtn;
        private System.Windows.Forms.Button veiwWholeListbtn;
        private System.Windows.Forms.Button FetchWholeContactListbtn;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button Deletebtn;
        private System.Windows.Forms.Button Searchbtn;
        private System.Windows.Forms.TextBox searchtb;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button Exportbtn;
    }
}