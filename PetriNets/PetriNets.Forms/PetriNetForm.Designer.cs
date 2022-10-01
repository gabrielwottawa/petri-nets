namespace PetriNets.Forms
{
    partial class PetriNetForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.MarkPlace_NumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.CretePlace_Button = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.IdPlace_TextBox = new System.Windows.Forms.TextBox();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.Clear_Button = new System.Windows.Forms.Button();
            this.RunCycle_Button = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.CreateTransition_Button = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.IdTransition_TextBox = new System.Windows.Forms.TextBox();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.ConnIdTransition_TrasitionPlace_ComboBox = new System.Windows.Forms.ComboBox();
            this.ConnIdPlace_TrasitionPlace_ComboBox = new System.Windows.Forms.ComboBox();
            this.ConnCreate_TrasitionPlace_Button = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.ConnWeight_TrasitionPlace_NumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.label9 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.ConnType_PlaceTrasition_ComboBox = new System.Windows.Forms.ComboBox();
            this.ConnIdTransition_PlaceTrasition_ComboBox = new System.Windows.Forms.ComboBox();
            this.ConnIdPlace_PlaceTrasition_ComboBox = new System.Windows.Forms.ComboBox();
            this.ConnCreate_PlaceTrasition_Button = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.ConnWeight_PlaceTrasition_NumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox7 = new System.Windows.Forms.GroupBox();
            this.DataGridView = new System.Windows.Forms.DataGridView();
            this.Connections_ListView = new System.Windows.Forms.ListView();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.MarkPlace_NumericUpDown)).BeginInit();
            this.groupBox5.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox6.SuspendLayout();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ConnWeight_TrasitionPlace_NumericUpDown)).BeginInit();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ConnWeight_PlaceTrasition_NumericUpDown)).BeginInit();
            this.groupBox7.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.groupBox1.Controls.Add(this.MarkPlace_NumericUpDown);
            this.groupBox1.Controls.Add(this.CretePlace_Button);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.IdPlace_TextBox);
            this.groupBox1.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.groupBox1.ForeColor = System.Drawing.Color.Black;
            this.groupBox1.Location = new System.Drawing.Point(18, 33);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(340, 182);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Lugar";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // MarkPlace_NumericUpDown
            // 
            this.MarkPlace_NumericUpDown.Location = new System.Drawing.Point(143, 73);
            this.MarkPlace_NumericUpDown.Name = "MarkPlace_NumericUpDown";
            this.MarkPlace_NumericUpDown.Size = new System.Drawing.Size(177, 34);
            this.MarkPlace_NumericUpDown.TabIndex = 18;
            // 
            // CretePlace_Button
            // 
            this.CretePlace_Button.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.CretePlace_Button.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.CretePlace_Button.Location = new System.Drawing.Point(18, 113);
            this.CretePlace_Button.Name = "CretePlace_Button";
            this.CretePlace_Button.Size = new System.Drawing.Size(302, 39);
            this.CretePlace_Button.TabIndex = 10;
            this.CretePlace_Button.Text = "Criar";
            this.CretePlace_Button.UseVisualStyleBackColor = false;
            this.CretePlace_Button.Click += new System.EventHandler(this.button5_Click);
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label2.Location = new System.Drawing.Point(18, 73);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(119, 31);
            this.label2.TabIndex = 7;
            this.label2.Text = "Marcas:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label1.Location = new System.Drawing.Point(18, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(119, 31);
            this.label1.TabIndex = 6;
            this.label1.Text = "Identificador:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // IdPlace_TextBox
            // 
            this.IdPlace_TextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.IdPlace_TextBox.Location = new System.Drawing.Point(143, 33);
            this.IdPlace_TextBox.MaxLength = 200;
            this.IdPlace_TextBox.Name = "IdPlace_TextBox";
            this.IdPlace_TextBox.Size = new System.Drawing.Size(177, 34);
            this.IdPlace_TextBox.TabIndex = 5;
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.Clear_Button);
            this.groupBox5.Controls.Add(this.RunCycle_Button);
            this.groupBox5.Controls.Add(this.groupBox2);
            this.groupBox5.Controls.Add(this.groupBox1);
            this.groupBox5.Controls.Add(this.groupBox6);
            this.groupBox5.Location = new System.Drawing.Point(32, 24);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(373, 971);
            this.groupBox5.TabIndex = 4;
            this.groupBox5.TabStop = false;
            // 
            // Clear_Button
            // 
            this.Clear_Button.BackColor = System.Drawing.Color.Tomato;
            this.Clear_Button.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Clear_Button.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Clear_Button.Location = new System.Drawing.Point(191, 920);
            this.Clear_Button.Name = "Clear_Button";
            this.Clear_Button.Size = new System.Drawing.Size(167, 39);
            this.Clear_Button.TabIndex = 25;
            this.Clear_Button.Text = "Limpar";
            this.Clear_Button.UseVisualStyleBackColor = false;
            // 
            // RunCycle_Button
            // 
            this.RunCycle_Button.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.RunCycle_Button.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.RunCycle_Button.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.RunCycle_Button.Location = new System.Drawing.Point(18, 920);
            this.RunCycle_Button.Name = "RunCycle_Button";
            this.RunCycle_Button.Size = new System.Drawing.Size(167, 39);
            this.RunCycle_Button.TabIndex = 24;
            this.RunCycle_Button.Text = "Executar Ciclo";
            this.RunCycle_Button.UseVisualStyleBackColor = false;
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.groupBox2.Controls.Add(this.CreateTransition_Button);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.IdTransition_TextBox);
            this.groupBox2.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.groupBox2.ForeColor = System.Drawing.Color.Black;
            this.groupBox2.Location = new System.Drawing.Point(18, 221);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(340, 151);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Transição";
            // 
            // CreateTransition_Button
            // 
            this.CreateTransition_Button.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.CreateTransition_Button.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.CreateTransition_Button.Location = new System.Drawing.Point(18, 82);
            this.CreateTransition_Button.Name = "CreateTransition_Button";
            this.CreateTransition_Button.Size = new System.Drawing.Size(302, 39);
            this.CreateTransition_Button.TabIndex = 8;
            this.CreateTransition_Button.Text = "Criar";
            this.CreateTransition_Button.UseVisualStyleBackColor = false;
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label3.Location = new System.Drawing.Point(18, 42);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(119, 31);
            this.label3.TabIndex = 9;
            this.label3.Text = "Identificador:";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // IdTransition_TextBox
            // 
            this.IdTransition_TextBox.Location = new System.Drawing.Point(143, 42);
            this.IdTransition_TextBox.MaxLength = 200;
            this.IdTransition_TextBox.Name = "IdTransition_TextBox";
            this.IdTransition_TextBox.Size = new System.Drawing.Size(177, 34);
            this.IdTransition_TextBox.TabIndex = 8;
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.groupBox4);
            this.groupBox6.Controls.Add(this.groupBox3);
            this.groupBox6.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.groupBox6.Location = new System.Drawing.Point(18, 378);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(340, 536);
            this.groupBox6.TabIndex = 5;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "Conexão";
            // 
            // groupBox4
            // 
            this.groupBox4.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.groupBox4.Controls.Add(this.ConnIdTransition_TrasitionPlace_ComboBox);
            this.groupBox4.Controls.Add(this.ConnIdPlace_TrasitionPlace_ComboBox);
            this.groupBox4.Controls.Add(this.ConnCreate_TrasitionPlace_Button);
            this.groupBox4.Controls.Add(this.label8);
            this.groupBox4.Controls.Add(this.label10);
            this.groupBox4.Controls.Add(this.ConnWeight_TrasitionPlace_NumericUpDown);
            this.groupBox4.Controls.Add(this.label9);
            this.groupBox4.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.groupBox4.ForeColor = System.Drawing.Color.Black;
            this.groupBox4.Location = new System.Drawing.Point(18, 310);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(307, 200);
            this.groupBox4.TabIndex = 2;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Transição -> Lugar";
            // 
            // ConnIdTransition_TrasitionPlace_ComboBox
            // 
            this.ConnIdTransition_TrasitionPlace_ComboBox.FormattingEnabled = true;
            this.ConnIdTransition_TrasitionPlace_ComboBox.Location = new System.Drawing.Point(137, 37);
            this.ConnIdTransition_TrasitionPlace_ComboBox.Name = "ConnIdTransition_TrasitionPlace_ComboBox";
            this.ConnIdTransition_TrasitionPlace_ComboBox.Size = new System.Drawing.Size(164, 29);
            this.ConnIdTransition_TrasitionPlace_ComboBox.TabIndex = 23;
            this.ConnIdTransition_TrasitionPlace_ComboBox.SelectedIndexChanged += new System.EventHandler(this.comboBox5_SelectedIndexChanged);
            // 
            // ConnIdPlace_TrasitionPlace_ComboBox
            // 
            this.ConnIdPlace_TrasitionPlace_ComboBox.FormattingEnabled = true;
            this.ConnIdPlace_TrasitionPlace_ComboBox.Location = new System.Drawing.Point(137, 72);
            this.ConnIdPlace_TrasitionPlace_ComboBox.Name = "ConnIdPlace_TrasitionPlace_ComboBox";
            this.ConnIdPlace_TrasitionPlace_ComboBox.Size = new System.Drawing.Size(164, 29);
            this.ConnIdPlace_TrasitionPlace_ComboBox.TabIndex = 22;
            this.ConnIdPlace_TrasitionPlace_ComboBox.SelectedIndexChanged += new System.EventHandler(this.comboBox4_SelectedIndexChanged);
            // 
            // ConnCreate_TrasitionPlace_Button
            // 
            this.ConnCreate_TrasitionPlace_Button.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.ConnCreate_TrasitionPlace_Button.Location = new System.Drawing.Point(12, 142);
            this.ConnCreate_TrasitionPlace_Button.Name = "ConnCreate_TrasitionPlace_Button";
            this.ConnCreate_TrasitionPlace_Button.Size = new System.Drawing.Size(289, 39);
            this.ConnCreate_TrasitionPlace_Button.TabIndex = 16;
            this.ConnCreate_TrasitionPlace_Button.Text = "Criar";
            this.ConnCreate_TrasitionPlace_Button.UseVisualStyleBackColor = false;
            this.ConnCreate_TrasitionPlace_Button.Click += new System.EventHandler(this.button4_Click);
            // 
            // label8
            // 
            this.label8.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label8.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label8.Location = new System.Drawing.Point(12, 37);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(119, 31);
            this.label8.TabIndex = 21;
            this.label8.Text = "Id Transição:";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label10
            // 
            this.label10.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label10.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label10.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label10.Location = new System.Drawing.Point(12, 72);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(119, 31);
            this.label10.TabIndex = 17;
            this.label10.Text = "Id Lugar:";
            this.label10.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label10.Click += new System.EventHandler(this.label10_Click);
            // 
            // ConnWeight_TrasitionPlace_NumericUpDown
            // 
            this.ConnWeight_TrasitionPlace_NumericUpDown.Location = new System.Drawing.Point(137, 107);
            this.ConnWeight_TrasitionPlace_NumericUpDown.Name = "ConnWeight_TrasitionPlace_NumericUpDown";
            this.ConnWeight_TrasitionPlace_NumericUpDown.Size = new System.Drawing.Size(164, 29);
            this.ConnWeight_TrasitionPlace_NumericUpDown.TabIndex = 18;
            this.ConnWeight_TrasitionPlace_NumericUpDown.ValueChanged += new System.EventHandler(this.numericUpDown7_ValueChanged);
            // 
            // label9
            // 
            this.label9.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label9.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label9.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label9.Location = new System.Drawing.Point(12, 107);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(119, 31);
            this.label9.TabIndex = 19;
            this.label9.Text = "Peso:";
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label9.Click += new System.EventHandler(this.label9_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.groupBox3.Controls.Add(this.ConnType_PlaceTrasition_ComboBox);
            this.groupBox3.Controls.Add(this.ConnIdTransition_PlaceTrasition_ComboBox);
            this.groupBox3.Controls.Add(this.ConnIdPlace_PlaceTrasition_ComboBox);
            this.groupBox3.Controls.Add(this.ConnCreate_PlaceTrasition_Button);
            this.groupBox3.Controls.Add(this.label7);
            this.groupBox3.Controls.Add(this.label6);
            this.groupBox3.Controls.Add(this.ConnWeight_PlaceTrasition_NumericUpDown);
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Controls.Add(this.label4);
            this.groupBox3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.groupBox3.ForeColor = System.Drawing.Color.Black;
            this.groupBox3.Location = new System.Drawing.Point(18, 57);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(307, 235);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Lugar -> Transição";
            // 
            // ConnType_PlaceTrasition_ComboBox
            // 
            this.ConnType_PlaceTrasition_ComboBox.FormattingEnabled = true;
            this.ConnType_PlaceTrasition_ComboBox.Location = new System.Drawing.Point(137, 142);
            this.ConnType_PlaceTrasition_ComboBox.Name = "ConnType_PlaceTrasition_ComboBox";
            this.ConnType_PlaceTrasition_ComboBox.Size = new System.Drawing.Size(164, 29);
            this.ConnType_PlaceTrasition_ComboBox.TabIndex = 17;
            // 
            // ConnIdTransition_PlaceTrasition_ComboBox
            // 
            this.ConnIdTransition_PlaceTrasition_ComboBox.FormattingEnabled = true;
            this.ConnIdTransition_PlaceTrasition_ComboBox.Location = new System.Drawing.Point(137, 72);
            this.ConnIdTransition_PlaceTrasition_ComboBox.Name = "ConnIdTransition_PlaceTrasition_ComboBox";
            this.ConnIdTransition_PlaceTrasition_ComboBox.Size = new System.Drawing.Size(164, 29);
            this.ConnIdTransition_PlaceTrasition_ComboBox.TabIndex = 16;
            // 
            // ConnIdPlace_PlaceTrasition_ComboBox
            // 
            this.ConnIdPlace_PlaceTrasition_ComboBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ConnIdPlace_PlaceTrasition_ComboBox.FormattingEnabled = true;
            this.ConnIdPlace_PlaceTrasition_ComboBox.Location = new System.Drawing.Point(137, 37);
            this.ConnIdPlace_PlaceTrasition_ComboBox.Name = "ConnIdPlace_PlaceTrasition_ComboBox";
            this.ConnIdPlace_PlaceTrasition_ComboBox.Size = new System.Drawing.Size(156, 29);
            this.ConnIdPlace_PlaceTrasition_ComboBox.TabIndex = 5;
            // 
            // ConnCreate_PlaceTrasition_Button
            // 
            this.ConnCreate_PlaceTrasition_Button.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.ConnCreate_PlaceTrasition_Button.Location = new System.Drawing.Point(8, 177);
            this.ConnCreate_PlaceTrasition_Button.Name = "ConnCreate_PlaceTrasition_Button";
            this.ConnCreate_PlaceTrasition_Button.Size = new System.Drawing.Size(293, 39);
            this.ConnCreate_PlaceTrasition_Button.TabIndex = 10;
            this.ConnCreate_PlaceTrasition_Button.Text = "Criar";
            this.ConnCreate_PlaceTrasition_Button.UseVisualStyleBackColor = false;
            // 
            // label7
            // 
            this.label7.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label7.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label7.Location = new System.Drawing.Point(12, 142);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(119, 31);
            this.label7.TabIndex = 15;
            this.label7.Text = "Tipo Conexão:";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label6
            // 
            this.label6.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label6.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label6.Location = new System.Drawing.Point(12, 35);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(119, 31);
            this.label6.TabIndex = 13;
            this.label6.Text = "Id Lugar:";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // ConnWeight_PlaceTrasition_NumericUpDown
            // 
            this.ConnWeight_PlaceTrasition_NumericUpDown.Location = new System.Drawing.Point(137, 107);
            this.ConnWeight_PlaceTrasition_NumericUpDown.Name = "ConnWeight_PlaceTrasition_NumericUpDown";
            this.ConnWeight_PlaceTrasition_NumericUpDown.Size = new System.Drawing.Size(164, 29);
            this.ConnWeight_PlaceTrasition_NumericUpDown.TabIndex = 10;
            // 
            // label5
            // 
            this.label5.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label5.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label5.Location = new System.Drawing.Point(12, 107);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(119, 31);
            this.label5.TabIndex = 11;
            this.label5.Text = "Peso:";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label4
            // 
            this.label4.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label4.Location = new System.Drawing.Point(12, 70);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(119, 31);
            this.label4.TabIndex = 9;
            this.label4.Text = "Id Transição:";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // groupBox7
            // 
            this.groupBox7.Controls.Add(this.DataGridView);
            this.groupBox7.Controls.Add(this.Connections_ListView);
            this.groupBox7.Location = new System.Drawing.Point(424, 24);
            this.groupBox7.Name = "groupBox7";
            this.groupBox7.Size = new System.Drawing.Size(1469, 971);
            this.groupBox7.TabIndex = 5;
            this.groupBox7.TabStop = false;
            // 
            // DataGridView
            // 
            this.DataGridView.BackgroundColor = System.Drawing.SystemColors.GradientInactiveCaption;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.DataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.DataGridView.DefaultCellStyle = dataGridViewCellStyle2;
            this.DataGridView.GridColor = System.Drawing.SystemColors.ActiveCaption;
            this.DataGridView.Location = new System.Drawing.Point(6, 491);
            this.DataGridView.Name = "DataGridView";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DataGridView.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.DataGridView.RowTemplate.Height = 25;
            this.DataGridView.Size = new System.Drawing.Size(1457, 472);
            this.DataGridView.TabIndex = 1;
            // 
            // Connections_ListView
            // 
            this.Connections_ListView.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.Connections_ListView.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Connections_ListView.Location = new System.Drawing.Point(6, 13);
            this.Connections_ListView.Name = "Connections_ListView";
            this.Connections_ListView.Size = new System.Drawing.Size(1457, 472);
            this.Connections_ListView.TabIndex = 0;
            this.Connections_ListView.UseCompatibleStateImageBehavior = false;
            // 
            // PetriNet
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1920, 1017);
            this.Controls.Add(this.groupBox7);
            this.Controls.Add(this.groupBox5);
            this.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Name = "PetriNet";
            this.Text = "PetriNet";
            this.Load += new System.EventHandler(this.PetriNet_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.MarkPlace_NumericUpDown)).EndInit();
            this.groupBox5.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox6.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ConnWeight_TrasitionPlace_NumericUpDown)).EndInit();
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ConnWeight_PlaceTrasition_NumericUpDown)).EndInit();
            this.groupBox7.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private GroupBox groupBox1;
        private GroupBox groupBox5;
        private GroupBox groupBox4;
        private GroupBox groupBox3;
        private GroupBox groupBox2;
        private Label label1;
        private TextBox IdPlace_TextBox;
        private Label label2;
        private Button CreateTransition_Button;
        private Label label3;
        private TextBox IdTransition_TextBox;
        private GroupBox groupBox6;
        private ComboBox ConnIdTransition_TrasitionPlace_ComboBox;
        private ComboBox ConnIdPlace_TrasitionPlace_ComboBox;
        private Button ConnCreate_TrasitionPlace_Button;
        private Label label8;
        private Label label10;
        private NumericUpDown ConnWeight_TrasitionPlace_NumericUpDown;
        private Label label9;
        private ComboBox ConnType_PlaceTrasition_ComboBox;
        private ComboBox ConnIdTransition_PlaceTrasition_ComboBox;
        private ComboBox ConnIdPlace_PlaceTrasition_ComboBox;
        private Button ConnCreate_PlaceTrasition_Button;
        private Label label7;
        private Label label6;
        private NumericUpDown ConnWeight_PlaceTrasition_NumericUpDown;
        private Label label5;
        private Label label4;
        private Button CretePlace_Button;
        private NumericUpDown MarkPlace_NumericUpDown;
        private GroupBox groupBox7;
        private DataGridView DataGridView;
        private ListView Connections_ListView;
        private Button RunCycle_Button;
        private Button Clear_Button;
    }
}