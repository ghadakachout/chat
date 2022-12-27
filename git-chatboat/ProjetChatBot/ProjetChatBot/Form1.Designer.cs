namespace ProjetChatBot
{
    partial class Responses
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
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.authDBDataSet1 = new ProjetChatBot.AuthDBDataSet();
            this.questionDBDataSet = new ProjetChatBot.questionDBDataSet();
            this.tbllogBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tbllogTableAdapter = new ProjetChatBot.questionDBDataSetTableAdapters.tbllogTableAdapter();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.authDBDataSet2 = new ProjetChatBot.AuthDBDataSet();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.questionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.contenuDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.authDBDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.questionDBDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbllogBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.authDBDataSet2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(669, 396);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(149, 58);
            this.button1.TabIndex = 0;
            this.button1.Text = "Ajouter";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(437, 396);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(175, 57);
            this.button2.TabIndex = 1;
            this.button2.Text = "Supprimer";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(256, 396);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(143, 57);
            this.button3.TabIndex = 2;
            this.button3.Text = "Modifier ";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // authDBDataSet1
            // 
            this.authDBDataSet1.DataSetName = "AuthDBDataSet";
            this.authDBDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // questionDBDataSet
            // 
            this.questionDBDataSet.DataSetName = "questionDBDataSet";
            this.questionDBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tbllogBindingSource
            // 
            this.tbllogBindingSource.DataMember = "tbllog";
            this.tbllogBindingSource.DataSource = this.questionDBDataSet;
            // 
            // tbllogTableAdapter
            // 
            this.tbllogTableAdapter.ClearBeforeFill = true;
            // 
            // textBox1
            // 
            this.textBox1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tbllogBindingSource, "contenu", true));
            this.textBox1.Location = new System.Drawing.Point(236, 158);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(582, 66);
            this.textBox1.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(76, 177);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(142, 32);
            this.label1.TabIndex = 4;
            this.label1.Text = "Reponses";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(116, 89);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 32);
            this.label2.TabIndex = 5;
            this.label2.Text = "ID";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(75, 277);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(143, 32);
            this.label3.TabIndex = 6;
            this.label3.Text = "Questions";
            // 
            // textBox2
            // 
            this.textBox2.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tbllogBindingSource, "Id", true));
            this.textBox2.Location = new System.Drawing.Point(236, 75);
            this.textBox2.Multiline = true;
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(582, 60);
            this.textBox2.TabIndex = 7;
            this.textBox2.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // textBox3
            // 
            this.textBox3.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tbllogBindingSource, "question", true));
            this.textBox3.Location = new System.Drawing.Point(236, 253);
            this.textBox3.Multiline = true;
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(582, 58);
            this.textBox3.TabIndex = 8;
            // 
            // authDBDataSet2
            // 
            this.authDBDataSet2.DataSetName = "AuthDBDataSet";
            this.authDBDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.questionDataGridViewTextBoxColumn,
            this.contenuDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.tbllogBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(247, 514);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 102;
            this.dataGridView1.RowTemplate.Height = 40;
            this.dataGridView1.Size = new System.Drawing.Size(858, 86);
            this.dataGridView1.TabIndex = 9;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "Id";
            this.idDataGridViewTextBoxColumn.HeaderText = "Id";
            this.idDataGridViewTextBoxColumn.MinimumWidth = 12;
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            this.idDataGridViewTextBoxColumn.Width = 250;
            // 
            // questionDataGridViewTextBoxColumn
            // 
            this.questionDataGridViewTextBoxColumn.DataPropertyName = "question";
            this.questionDataGridViewTextBoxColumn.HeaderText = "Question_Adq";
            this.questionDataGridViewTextBoxColumn.MinimumWidth = 12;
            this.questionDataGridViewTextBoxColumn.Name = "questionDataGridViewTextBoxColumn";
            this.questionDataGridViewTextBoxColumn.Width = 250;
            // 
            // contenuDataGridViewTextBoxColumn
            // 
            this.contenuDataGridViewTextBoxColumn.DataPropertyName = "contenu";
            this.contenuDataGridViewTextBoxColumn.HeaderText = "Contenu";
            this.contenuDataGridViewTextBoxColumn.MinimumWidth = 12;
            this.contenuDataGridViewTextBoxColumn.Name = "contenuDataGridViewTextBoxColumn";
            this.contenuDataGridViewTextBoxColumn.Width = 250;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(868, 397);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(137, 56);
            this.button4.TabIndex = 10;
            this.button4.Text = "Save";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(562, 735);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(183, 77);
            this.button5.TabIndex = 11;
            this.button5.Text = "Quitter";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // Responses
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1338, 1233);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Name = "Responses";
            this.Text = "Reponses";
            this.Load += new System.EventHandler(this.Responses_Load);
            ((System.ComponentModel.ISupportInitialize)(this.authDBDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.questionDBDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbllogBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.authDBDataSet2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private AuthDBDataSet authDBDataSet1;
        private questionDBDataSet questionDBDataSet;
        private System.Windows.Forms.BindingSource tbllogBindingSource;
        private questionDBDataSetTableAdapters.tbllogTableAdapter tbllogTableAdapter;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
        private AuthDBDataSet authDBDataSet2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn questionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn contenuDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
    }
}