namespace WinFormsApp1
{
    partial class MainForm
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            menuStrip1 = new MenuStrip();
            FileToolStripMenuItem = new ToolStripMenuItem();
            CreateToolStripMenuItem = new ToolStripMenuItem();
            OpenToolStripMenuItem = new ToolStripMenuItem();
            SaveToolStripMenuItem = new ToolStripMenuItem();
            toolStripSeparator1 = new ToolStripSeparator();
            CloseToolStripMenuItem = new ToolStripMenuItem();
            SettingToolStripMenuItem = new ToolStripMenuItem();
            ColorToolStripMenuItem = new ToolStripMenuItem();
            ShriftToolStripMenuItem = new ToolStripMenuItem();
            PapkaToolStripMenuItem = new ToolStripMenuItem();
            FormatToolStripMenuItem = new ToolStripMenuItem();
            ContextMenuStrip = new ContextMenuStrip(components);
            Color1ToolStripMenuItem = new ToolStripMenuItem();
            Shrift1ToolStripMenuItem = new ToolStripMenuItem();
            VidToolStripMenuItem = new ToolStripMenuItem();
            NotchToolStripMenuItem = new ToolStripMenuItem();
            DrugayaToolStripMenuItem = new ToolStripMenuItem();
            OpenRichTextBox = new RichTextBox();
            OpenFileDialog = new OpenFileDialog();
            SaveFileDialog = new SaveFileDialog();
            ColorDialog = new ColorDialog();
            FontDialog = new FontDialog();
            FolderBrowserDialog = new FolderBrowserDialog();
            ToolStrip = new ToolStrip();
            ShriftToolStripButton = new ToolStripComboBox();
            LeftToolStripButton = new ToolStripButton();
            CentrToolStripButton = new ToolStripButton();
            RightToolStripButton = new ToolStripButton();
            statusStrip1 = new StatusStrip();
            TimeStatusLabel = new ToolStripStatusLabel();
            toolStripProgressBar1 = new ToolStripStatusLabel();
            SimvolToolLabel = new ToolStripStatusLabel();
            BezProbSimvolToolLabel = new ToolStripStatusLabel();
            MainTimer = new System.Windows.Forms.Timer(components);
            menuStrip1.SuspendLayout();
            ContextMenuStrip.SuspendLayout();
            ToolStrip.SuspendLayout();
            statusStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { FileToolStripMenuItem, SettingToolStripMenuItem, FormatToolStripMenuItem, VidToolStripMenuItem, DrugayaToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(800, 24);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // FileToolStripMenuItem
            // 
            FileToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { CreateToolStripMenuItem, OpenToolStripMenuItem, SaveToolStripMenuItem, toolStripSeparator1, CloseToolStripMenuItem });
            FileToolStripMenuItem.Name = "FileToolStripMenuItem";
            FileToolStripMenuItem.Size = new Size(48, 20);
            FileToolStripMenuItem.Text = "Файл";
            // 
            // CreateToolStripMenuItem
            // 
            CreateToolStripMenuItem.Name = "CreateToolStripMenuItem";
            CreateToolStripMenuItem.ShortcutKeys = Keys.Control | Keys.N;
            CreateToolStripMenuItem.Size = new Size(173, 22);
            CreateToolStripMenuItem.Text = "Создать";
            CreateToolStripMenuItem.Click += создатьToolStripMenuItem_Click;
            // 
            // OpenToolStripMenuItem
            // 
            OpenToolStripMenuItem.Name = "OpenToolStripMenuItem";
            OpenToolStripMenuItem.ShortcutKeys = Keys.Control | Keys.O;
            OpenToolStripMenuItem.Size = new Size(173, 22);
            OpenToolStripMenuItem.Text = "Открыть";
            OpenToolStripMenuItem.Click += OpenToolStripMenuItem1_Click;
            // 
            // SaveToolStripMenuItem
            // 
            SaveToolStripMenuItem.Name = "SaveToolStripMenuItem";
            SaveToolStripMenuItem.ShortcutKeys = Keys.Control | Keys.S;
            SaveToolStripMenuItem.Size = new Size(173, 22);
            SaveToolStripMenuItem.Text = "Сохранить";
            SaveToolStripMenuItem.Click += SaveToolStripMenuItem_Click;
            // 
            // toolStripSeparator1
            // 
            toolStripSeparator1.Name = "toolStripSeparator1";
            toolStripSeparator1.Size = new Size(170, 6);
            // 
            // CloseToolStripMenuItem
            // 
            CloseToolStripMenuItem.Name = "CloseToolStripMenuItem";
            CloseToolStripMenuItem.Size = new Size(173, 22);
            CloseToolStripMenuItem.Text = "Закртыть";
            CloseToolStripMenuItem.Click += CloseToolStripMenuItem_Click;
            // 
            // SettingToolStripMenuItem
            // 
            SettingToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { ColorToolStripMenuItem, ShriftToolStripMenuItem, PapkaToolStripMenuItem });
            SettingToolStripMenuItem.Name = "SettingToolStripMenuItem";
            SettingToolStripMenuItem.Size = new Size(78, 20);
            SettingToolStripMenuItem.Text = "Настройка";
            // 
            // ColorToolStripMenuItem
            // 
            ColorToolStripMenuItem.Name = "ColorToolStripMenuItem";
            ColorToolStripMenuItem.Size = new Size(194, 22);
            ColorToolStripMenuItem.Text = "Цвет";
            ColorToolStripMenuItem.Click += ColorToolStripMenuItem_Click;
            // 
            // ShriftToolStripMenuItem
            // 
            ShriftToolStripMenuItem.Name = "ShriftToolStripMenuItem";
            ShriftToolStripMenuItem.Size = new Size(194, 22);
            ShriftToolStripMenuItem.Text = "Шрифт";
            ShriftToolStripMenuItem.Click += ShriftToolStripMenuItem_Click;
            // 
            // PapkaToolStripMenuItem
            // 
            PapkaToolStripMenuItem.Name = "PapkaToolStripMenuItem";
            PapkaToolStripMenuItem.Size = new Size(194, 22);
            PapkaToolStripMenuItem.Text = "Папка по умолчанию";
            PapkaToolStripMenuItem.Click += PapkaToolStripMenuItem_Click;
            // 
            // FormatToolStripMenuItem
            // 
            FormatToolStripMenuItem.DropDown = ContextMenuStrip;
            FormatToolStripMenuItem.Name = "FormatToolStripMenuItem";
            FormatToolStripMenuItem.Size = new Size(115, 20);
            FormatToolStripMenuItem.Text = "Форматирование";
            // 
            // ContextMenuStrip
            // 
            ContextMenuStrip.Items.AddRange(new ToolStripItem[] { Color1ToolStripMenuItem, Shrift1ToolStripMenuItem });
            ContextMenuStrip.Name = "ContextMenuStrip";
            ContextMenuStrip.OwnerItem = FormatToolStripMenuItem;
            ContextMenuStrip.Size = new Size(114, 48);
            // 
            // Color1ToolStripMenuItem
            // 
            Color1ToolStripMenuItem.Name = "Color1ToolStripMenuItem";
            Color1ToolStripMenuItem.Size = new Size(113, 22);
            Color1ToolStripMenuItem.Text = "Цвет";
            Color1ToolStripMenuItem.Click += Color1ToolStripMenuItem_Click;
            // 
            // Shrift1ToolStripMenuItem
            // 
            Shrift1ToolStripMenuItem.Name = "Shrift1ToolStripMenuItem";
            Shrift1ToolStripMenuItem.Size = new Size(113, 22);
            Shrift1ToolStripMenuItem.Text = "Шрифт";
            Shrift1ToolStripMenuItem.Click += Shrift1ToolStripMenuItem_Click;
            // 
            // VidToolStripMenuItem
            // 
            VidToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { NotchToolStripMenuItem });
            VidToolStripMenuItem.Name = "VidToolStripMenuItem";
            VidToolStripMenuItem.Size = new Size(39, 20);
            VidToolStripMenuItem.Text = "Вид";
            // 
            // NotchToolStripMenuItem
            // 
            NotchToolStripMenuItem.Name = "NotchToolStripMenuItem";
            NotchToolStripMenuItem.Size = new Size(145, 22);
            NotchToolStripMenuItem.Text = "Ночная тема";
            NotchToolStripMenuItem.Click += NotchToolStripMenuItem_Click;
            // 
            // DrugayaToolStripMenuItem
            // 
            DrugayaToolStripMenuItem.Name = "DrugayaToolStripMenuItem";
            DrugayaToolStripMenuItem.Size = new Size(98, 20);
            DrugayaToolStripMenuItem.Text = "Другая форма";
            DrugayaToolStripMenuItem.Click += DrugayaToolStripMenuItem_Click;
            // 
            // OpenRichTextBox
            // 
            OpenRichTextBox.ContextMenuStrip = ContextMenuStrip;
            OpenRichTextBox.Location = new Point(0, 52);
            OpenRichTextBox.Name = "OpenRichTextBox";
            OpenRichTextBox.Size = new Size(800, 369);
            OpenRichTextBox.TabIndex = 1;
            OpenRichTextBox.Text = "";
            OpenRichTextBox.TextChanged += OpenRichTextBox_TextChanged;
            // 
            // OpenFileDialog
            // 
            OpenFileDialog.FileName = "openFileDialog1";
            // 
            // SaveFileDialog
            // 
            SaveFileDialog.Filter = "txt|*.txt|rtf|*.rtf";
            // 
            // ToolStrip
            // 
            ToolStrip.Items.AddRange(new ToolStripItem[] { ShriftToolStripButton, LeftToolStripButton, CentrToolStripButton, RightToolStripButton });
            ToolStrip.Location = new Point(0, 24);
            ToolStrip.Name = "ToolStrip";
            ToolStrip.Size = new Size(800, 25);
            ToolStrip.TabIndex = 2;
            ToolStrip.Text = "toolStrip1";
            // 
            // ShriftToolStripButton
            // 
            ShriftToolStripButton.DropDownStyle = ComboBoxStyle.DropDownList;
            ShriftToolStripButton.Name = "ShriftToolStripButton";
            ShriftToolStripButton.Size = new Size(150, 25);
            ShriftToolStripButton.Click += ShriftToolStripButton_Click;
            // 
            // LeftToolStripButton
            // 
            LeftToolStripButton.DisplayStyle = ToolStripItemDisplayStyle.Image;
            LeftToolStripButton.Image = (Image)resources.GetObject("LeftToolStripButton.Image");
            LeftToolStripButton.ImageTransparentColor = Color.Magenta;
            LeftToolStripButton.Name = "LeftToolStripButton";
            LeftToolStripButton.Size = new Size(23, 22);
            LeftToolStripButton.Text = "Слева";
            LeftToolStripButton.Click += LeftToolStripButton_Click;
            // 
            // CentrToolStripButton
            // 
            CentrToolStripButton.DisplayStyle = ToolStripItemDisplayStyle.Image;
            CentrToolStripButton.Image = (Image)resources.GetObject("CentrToolStripButton.Image");
            CentrToolStripButton.ImageTransparentColor = Color.Magenta;
            CentrToolStripButton.Name = "CentrToolStripButton";
            CentrToolStripButton.Size = new Size(23, 22);
            CentrToolStripButton.Text = "По центру";
            CentrToolStripButton.Click += CentrToolStripButton_Click;
            // 
            // RightToolStripButton
            // 
            RightToolStripButton.DisplayStyle = ToolStripItemDisplayStyle.Image;
            RightToolStripButton.Image = (Image)resources.GetObject("RightToolStripButton.Image");
            RightToolStripButton.ImageTransparentColor = Color.Magenta;
            RightToolStripButton.Name = "RightToolStripButton";
            RightToolStripButton.Size = new Size(23, 22);
            RightToolStripButton.Text = "Справа";
            RightToolStripButton.Click += RightToolStripButton_Click;
            // 
            // statusStrip1
            // 
            statusStrip1.BackgroundImageLayout = ImageLayout.None;
            statusStrip1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            statusStrip1.Items.AddRange(new ToolStripItem[] { TimeStatusLabel, toolStripProgressBar1, SimvolToolLabel, BezProbSimvolToolLabel });
            statusStrip1.Location = new Point(0, 424);
            statusStrip1.Name = "statusStrip1";
            statusStrip1.Size = new Size(800, 26);
            statusStrip1.TabIndex = 3;
            statusStrip1.Text = "statusStrip1";
            // 
            // TimeStatusLabel
            // 
            TimeStatusLabel.Name = "TimeStatusLabel";
            TimeStatusLabel.Size = new Size(105, 21);
            TimeStatusLabel.Text = "Дата и время";
            // 
            // toolStripProgressBar1
            // 
            toolStripProgressBar1.Name = "toolStripProgressBar1";
            toolStripProgressBar1.Size = new Size(0, 21);
            // 
            // SimvolToolLabel
            // 
            SimvolToolLabel.Name = "SimvolToolLabel";
            SimvolToolLabel.Size = new Size(132, 21);
            SimvolToolLabel.Text = "Кол-во символов";
            // 
            // BezProbSimvolToolLabel
            // 
            BezProbSimvolToolLabel.Name = "BezProbSimvolToolLabel";
            BezProbSimvolToolLabel.Size = new Size(224, 21);
            BezProbSimvolToolLabel.Text = "Кол-во символов без пробела";
            // 
            // MainTimer
            // 
            MainTimer.Interval = 1000;
            MainTimer.Tick += MainTimer_Tick;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(statusStrip1);
            Controls.Add(ToolStrip);
            Controls.Add(OpenRichTextBox);
            Controls.Add(menuStrip1);
            KeyPreview = true;
            MainMenuStrip = menuStrip1;
            Name = "MainForm";
            Text = "Файл";
            FormClosed += MainForm_FormClosed;
            Load += MainForm_Load;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ContextMenuStrip.ResumeLayout(false);
            ToolStrip.ResumeLayout(false);
            ToolStrip.PerformLayout();
            statusStrip1.ResumeLayout(false);
            statusStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem FileToolStripMenuItem;
        private RichTextBox OpenRichTextBox;
        private OpenFileDialog OpenFileDialog;
        private ToolStripMenuItem OpenToolStripMenuItem;
        private ToolStripMenuItem SaveToolStripMenuItem;
        private SaveFileDialog SaveFileDialog;
        private ToolStripMenuItem SettingToolStripMenuItem;
        private ToolStripMenuItem ColorToolStripMenuItem;
        private ToolStripMenuItem ShriftToolStripMenuItem;
        private ToolStripMenuItem PapkaToolStripMenuItem;
        private ColorDialog ColorDialog;
        private FontDialog FontDialog;
        private FolderBrowserDialog FolderBrowserDialog;
        private ToolStripMenuItem CreateToolStripMenuItem;
        private ToolStripMenuItem CloseToolStripMenuItem;
        private ToolStripMenuItem VidToolStripMenuItem;
        private ToolStripMenuItem NotchToolStripMenuItem;
        private ToolStripMenuItem DrugayaToolStripMenuItem;
        private ToolStripSeparator toolStripSeparator1;
        private ToolStripMenuItem FormatToolStripMenuItem;
        private ToolStrip ToolStrip;
        private ToolStripButton LeftToolStripButton;
        private ToolStripButton CentrToolStripButton;
        private ToolStripButton RightToolStripButton;
        private StatusStrip statusStrip1;
        private System.Windows.Forms.Timer MainTimer;
        private ToolStripStatusLabel TimeStatusLabel;
        private ToolStripStatusLabel toolStripProgressBar1;
        private ToolStripStatusLabel SimvolToolLabel;
        private ToolStripStatusLabel BezProbSimvolToolLabel;
        private ContextMenuStrip ContextMenuStrip;
        private ToolStripMenuItem Color1ToolStripMenuItem;
        private ToolStripMenuItem Shrift1ToolStripMenuItem;
        private ToolStripComboBox ShriftToolStripButton;
    }
}
