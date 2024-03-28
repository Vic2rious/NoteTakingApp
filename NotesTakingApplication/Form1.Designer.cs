namespace NotesTakingApplication
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            save = new Button();
            create = new Button();
            list = new ListView();
            delete = new Button();
            btnSetFont = new Button();
            btnSetColor = new Button();
            textbox = new RichTextBox();
            Title = new TextBox();
            colorDialog1 = new ColorDialog();
            fontDialog = new FontDialog();
            label1 = new Label();
            SuspendLayout();
            // 
            // save
            // 
            save.Location = new Point(149, 263);
            save.Name = "save";
            save.Size = new Size(75, 23);
            save.TabIndex = 0;
            save.Text = "save";
            save.UseVisualStyleBackColor = true;
            save.Click += save_Click;
            // 
            // create
            // 
            create.Location = new Point(288, 263);
            create.Name = "create";
            create.Size = new Size(75, 23);
            create.TabIndex = 1;
            create.Text = "clear";
            create.UseVisualStyleBackColor = true;
            create.Click += create_Click_1;
            // 
            // list
            // 
            list.Location = new Point(149, 83);
            list.Name = "list";
            list.Size = new Size(121, 97);
            list.TabIndex = 2;
            list.UseCompatibleStateImageBehavior = false;
            list.SelectedIndexChanged += list_SelectedIndexChanged;
            // 
            // delete
            // 
            delete.Location = new Point(405, 263);
            delete.Name = "delete";
            delete.Size = new Size(75, 23);
            delete.TabIndex = 3;
            delete.Text = "delete";
            delete.UseVisualStyleBackColor = true;
            delete.Click += delete_Click_1;
            // 
            // btnSetFont
            // 
            btnSetFont.Location = new Point(560, 156);
            btnSetFont.Name = "btnSetFont";
            btnSetFont.Size = new Size(75, 23);
            btnSetFont.TabIndex = 4;
            btnSetFont.Text = "Set Font";
            btnSetFont.UseVisualStyleBackColor = true;
            btnSetFont.Click += button2_Click;
            // 
            // btnSetColor
            // 
            btnSetColor.Location = new Point(560, 74);
            btnSetColor.Name = "btnSetColor";
            btnSetColor.Size = new Size(75, 23);
            btnSetColor.TabIndex = 5;
            btnSetColor.Text = "Set Colour";
            btnSetColor.UseVisualStyleBackColor = true;
            btnSetColor.Click += btnSetColor_Click_1;
            // 
            // textbox
            // 
            textbox.Location = new Point(359, 83);
            textbox.Name = "textbox";
            textbox.Size = new Size(100, 96);
            textbox.TabIndex = 6;
            textbox.Text = "";
            textbox.TextChanged += richTextBox1_TextChanged;
            // 
            // Title
            // 
            Title.Location = new Point(359, 30);
            Title.Name = "Title";
            Title.Size = new Size(100, 23);
            Title.TabIndex = 7;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(149, 65);
            label1.Name = "label1";
            label1.Size = new Size(66, 15);
            label1.TabIndex = 8;
            label1.Text = "Timestamp";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label1);
            Controls.Add(Title);
            Controls.Add(textbox);
            Controls.Add(btnSetColor);
            Controls.Add(btnSetFont);
            Controls.Add(delete);
            Controls.Add(list);
            Controls.Add(create);
            Controls.Add(save);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button save;
        private Button create;
        private ListView list;
        private Button delete;
        private Button btnSetFont;
        private Button btnSetColor;
        private RichTextBox textbox;
        private TextBox Title;
        private ColorDialog colorDialog1;
        private FontDialog fontDialog;
        private Label label1;
    }
}