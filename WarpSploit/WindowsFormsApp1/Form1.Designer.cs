namespace WarpSploit
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.Color2 = new System.Windows.Forms.ColorWithAlpha();
            this.alphaGradientPanel4 = new System.Windows.Forms.AlphaGradientPanel();
            this.alphaGradientPanel5 = new System.Windows.Forms.AlphaGradientPanel();
            this.alphaGradientPanel2 = new System.Windows.Forms.AlphaGradientPanel();
            this.alphaGradientPanel3 = new System.Windows.Forms.AlphaGradientPanel();
            this.alphaGradientPanel1 = new System.Windows.Forms.AlphaGradientPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.txtChatLog = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.toolTip2 = new System.Windows.Forms.ToolTip(this.components);
            this.toolTip3 = new System.Windows.Forms.ToolTip(this.components);
            this.toolTip4 = new System.Windows.Forms.ToolTip(this.components);
            this.Editor = new FastColoredTextBoxNS.FastColoredTextBox();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.toolTip5 = new System.Windows.Forms.ToolTip(this.components);
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Editor)).BeginInit();
            this.SuspendLayout();
            // 
            // Color2
            // 
            this.Color2.Alpha = 255;
            this.Color2.Color = System.Drawing.Color.Gray;
            this.Color2.Parent = this.alphaGradientPanel3;
            // 
            // alphaGradientPanel4
            // 
            this.alphaGradientPanel4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.alphaGradientPanel4.BackColor = System.Drawing.Color.Transparent;
            this.alphaGradientPanel4.Border = false;
            this.alphaGradientPanel4.BorderColor = System.Drawing.SystemColors.ActiveBorder;
            this.alphaGradientPanel4.Colors.Add(this.Color2);
            this.alphaGradientPanel4.ContentPadding = new System.Windows.Forms.Padding(0);
            this.alphaGradientPanel4.CornerRadius = 8;
            this.alphaGradientPanel4.Corners = ((System.Windows.Forms.Corner)((((System.Windows.Forms.Corner.TopLeft | System.Windows.Forms.Corner.TopRight) 
            | System.Windows.Forms.Corner.BottomLeft) 
            | System.Windows.Forms.Corner.BottomRight)));
            this.alphaGradientPanel4.ForeColor = System.Drawing.SystemColors.ControlText;
            this.alphaGradientPanel4.Gradient = false;
            this.alphaGradientPanel4.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical;
            this.alphaGradientPanel4.GradientOffset = 1F;
            this.alphaGradientPanel4.GradientSize = new System.Drawing.Size(0, 0);
            this.alphaGradientPanel4.GradientWrapMode = System.Drawing.Drawing2D.WrapMode.Tile;
            this.alphaGradientPanel4.Grayscale = false;
            this.alphaGradientPanel4.Image = ((System.Drawing.Image)(resources.GetObject("alphaGradientPanel4.Image")));
            this.alphaGradientPanel4.ImageAlpha = 255;
            this.alphaGradientPanel4.ImagePadding = new System.Windows.Forms.Padding(5);
            this.alphaGradientPanel4.ImagePosition = System.Windows.Forms.ImagePosition.Center;
            this.alphaGradientPanel4.ImageSize = new System.Drawing.Size(18, 18);
            this.alphaGradientPanel4.Location = new System.Drawing.Point(641, 6);
            this.alphaGradientPanel4.Name = "alphaGradientPanel4";
            this.alphaGradientPanel4.Rounded = true;
            this.alphaGradientPanel4.Size = new System.Drawing.Size(32, 32);
            this.alphaGradientPanel4.TabIndex = 3;
            this.alphaGradientPanel4.Click += alphaGradientPanel4_Click;
            this.toolTip2.SetToolTip(this.alphaGradientPanel4, "Save the script to a Lua file.");
            // 
            // alphaGradientPanel5
            // 
            this.alphaGradientPanel5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.alphaGradientPanel5.BackColor = System.Drawing.Color.Transparent;
            this.alphaGradientPanel5.Border = false;
            this.alphaGradientPanel5.BorderColor = System.Drawing.SystemColors.ActiveBorder;
            this.alphaGradientPanel5.Colors.Add(this.Color2);
            this.alphaGradientPanel5.ContentPadding = new System.Windows.Forms.Padding(0);
            this.alphaGradientPanel5.CornerRadius = 8;
            this.alphaGradientPanel5.Corners = ((System.Windows.Forms.Corner)((((System.Windows.Forms.Corner.TopLeft | System.Windows.Forms.Corner.TopRight) 
            | System.Windows.Forms.Corner.BottomLeft) 
            | System.Windows.Forms.Corner.BottomRight)));
            this.alphaGradientPanel5.ForeColor = System.Drawing.SystemColors.ControlText;
            this.alphaGradientPanel5.Gradient = false;
            this.alphaGradientPanel5.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical;
            this.alphaGradientPanel5.GradientOffset = 1F;
            this.alphaGradientPanel5.GradientSize = new System.Drawing.Size(0, 0);
            this.alphaGradientPanel5.GradientWrapMode = System.Drawing.Drawing2D.WrapMode.Tile;
            this.alphaGradientPanel5.Grayscale = false;
            this.alphaGradientPanel5.Image = ((System.Drawing.Image)(resources.GetObject("alphaGradientPanel5.Image")));
            this.alphaGradientPanel5.ImageAlpha = 255;
            this.alphaGradientPanel5.ImagePadding = new System.Windows.Forms.Padding(5);
            this.alphaGradientPanel5.ImagePosition = System.Windows.Forms.ImagePosition.Center;
            this.alphaGradientPanel5.ImageSize = new System.Drawing.Size(18, 18);
            this.alphaGradientPanel5.Location = new System.Drawing.Point(603, 6);
            this.alphaGradientPanel5.Name = "alphaGradientPanel5";
            this.alphaGradientPanel5.Rounded = true;
            this.alphaGradientPanel5.Size = new System.Drawing.Size(32, 32);
            this.alphaGradientPanel5.TabIndex = 7;
            this.alphaGradientPanel5.Click += alphaGradientPanel5_Click;
            this.toolTip5.SetToolTip(this.alphaGradientPanel5, "Join to report bugs and chat with \r\nother users which is using \r\nWarpSploit.");
            // 
            // alphaGradientPanel2
            // 
            this.alphaGradientPanel2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.alphaGradientPanel2.BackColor = System.Drawing.Color.Transparent;
            this.alphaGradientPanel2.Border = false;
            this.alphaGradientPanel2.BorderColor = System.Drawing.SystemColors.ActiveBorder;
            this.alphaGradientPanel2.Colors.Add(this.Color2);
            this.alphaGradientPanel2.ContentPadding = new System.Windows.Forms.Padding(0);
            this.alphaGradientPanel2.CornerRadius = 8;
            this.alphaGradientPanel2.Corners = ((System.Windows.Forms.Corner)((((System.Windows.Forms.Corner.TopLeft | System.Windows.Forms.Corner.TopRight) 
            | System.Windows.Forms.Corner.BottomLeft) 
            | System.Windows.Forms.Corner.BottomRight)));
            this.alphaGradientPanel2.ForeColor = System.Drawing.SystemColors.ControlText;
            this.alphaGradientPanel2.Gradient = false;
            this.alphaGradientPanel2.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical;
            this.alphaGradientPanel2.GradientOffset = 1F;
            this.alphaGradientPanel2.GradientSize = new System.Drawing.Size(0, 0);
            this.alphaGradientPanel2.GradientWrapMode = System.Drawing.Drawing2D.WrapMode.Tile;
            this.alphaGradientPanel2.Grayscale = false;
            this.alphaGradientPanel2.Image = ((System.Drawing.Image)(resources.GetObject("alphaGradientPanel2.Image")));
            this.alphaGradientPanel2.ImageAlpha = 255;
            this.alphaGradientPanel2.ImagePadding = new System.Windows.Forms.Padding(5);
            this.alphaGradientPanel2.ImagePosition = System.Windows.Forms.ImagePosition.Center;
            this.alphaGradientPanel2.ImageSize = new System.Drawing.Size(18, 18);
            this.alphaGradientPanel2.Location = new System.Drawing.Point(717, 6);
            this.alphaGradientPanel2.Name = "alphaGradientPanel2";
            this.alphaGradientPanel2.Rounded = true;
            this.alphaGradientPanel2.Size = new System.Drawing.Size(32, 32);
            this.alphaGradientPanel2.TabIndex = 1;
            this.alphaGradientPanel2.Click += alphaGradientPanel2_Click;
            this.toolTip3.SetToolTip(this.alphaGradientPanel2, "Execute the script provided.");
            // 
            // alphaGradientPanel3
            // 
            this.alphaGradientPanel3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.alphaGradientPanel3.BackColor = System.Drawing.Color.Transparent;
            this.alphaGradientPanel3.Border = false;
            this.alphaGradientPanel3.BorderColor = System.Drawing.SystemColors.ActiveBorder;
            this.alphaGradientPanel3.Colors.Add(this.Color2);
            this.alphaGradientPanel3.ContentPadding = new System.Windows.Forms.Padding(0);
            this.alphaGradientPanel3.CornerRadius = 8;
            this.alphaGradientPanel3.Corners = ((System.Windows.Forms.Corner)((((System.Windows.Forms.Corner.TopLeft | System.Windows.Forms.Corner.TopRight) 
            | System.Windows.Forms.Corner.BottomLeft) 
            | System.Windows.Forms.Corner.BottomRight)));
            this.alphaGradientPanel3.ForeColor = System.Drawing.SystemColors.ControlText;
            this.alphaGradientPanel3.Gradient = false;
            this.alphaGradientPanel3.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical;
            this.alphaGradientPanel3.GradientOffset = 1F;
            this.alphaGradientPanel3.GradientSize = new System.Drawing.Size(0, 0);
            this.alphaGradientPanel3.GradientWrapMode = System.Drawing.Drawing2D.WrapMode.Tile;
            this.alphaGradientPanel3.Grayscale = false;
            this.alphaGradientPanel3.Image = ((System.Drawing.Image)(resources.GetObject("alphaGradientPanel3.Image")));
            this.alphaGradientPanel3.ImageAlpha = 255;
            this.alphaGradientPanel3.ImagePadding = new System.Windows.Forms.Padding(5);
            this.alphaGradientPanel3.ImagePosition = System.Windows.Forms.ImagePosition.Center;
            this.alphaGradientPanel3.ImageSize = new System.Drawing.Size(18, 18);
            this.alphaGradientPanel3.Location = new System.Drawing.Point(679, 6);
            this.alphaGradientPanel3.Name = "alphaGradientPanel3";
            this.alphaGradientPanel3.Rounded = true;
            this.alphaGradientPanel3.Size = new System.Drawing.Size(32, 32);
            this.alphaGradientPanel3.TabIndex = 4;
            this.alphaGradientPanel3.Click += alphaGradientPanel3_Click;
            this.toolTip1.SetToolTip(this.alphaGradientPanel3, "Load from a file.");
            // 
            // alphaGradientPanel1
            // 
            this.alphaGradientPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.alphaGradientPanel1.BackColor = System.Drawing.Color.Transparent;
            this.alphaGradientPanel1.Border = false;
            this.alphaGradientPanel1.BorderColor = System.Drawing.SystemColors.ActiveBorder;
            this.alphaGradientPanel1.ContentPadding = new System.Windows.Forms.Padding(0);
            this.alphaGradientPanel1.CornerRadius = 8;
            this.alphaGradientPanel1.Corners = ((System.Windows.Forms.Corner)((((System.Windows.Forms.Corner.TopLeft | System.Windows.Forms.Corner.TopRight) 
            | System.Windows.Forms.Corner.BottomLeft) 
            | System.Windows.Forms.Corner.BottomRight)));
            this.alphaGradientPanel1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.alphaGradientPanel1.Gradient = false;
            this.alphaGradientPanel1.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical;
            this.alphaGradientPanel1.GradientOffset = 1F;
            this.alphaGradientPanel1.GradientSize = new System.Drawing.Size(0, 0);
            this.alphaGradientPanel1.GradientWrapMode = System.Drawing.Drawing2D.WrapMode.Tile;
            this.alphaGradientPanel1.Grayscale = false;
            this.alphaGradientPanel1.Image = ((System.Drawing.Image)(resources.GetObject("alphaGradientPanel1.Image")));
            this.alphaGradientPanel1.ImageAlpha = 255;
            this.alphaGradientPanel1.ImagePadding = new System.Windows.Forms.Padding(5);
            this.alphaGradientPanel1.ImagePosition = System.Windows.Forms.ImagePosition.Center;
            this.alphaGradientPanel1.ImageSize = new System.Drawing.Size(18, 18);
            this.alphaGradientPanel1.Location = new System.Drawing.Point(755, 6);
            this.alphaGradientPanel1.Name = "alphaGradientPanel1";
            this.alphaGradientPanel1.Rounded = true;
            this.alphaGradientPanel1.Size = new System.Drawing.Size(32, 32);
            this.alphaGradientPanel1.TabIndex = 2;
            this.alphaGradientPanel1.Click += alphaGradientPanel1_Click;
            this.toolTip4.SetToolTip(this.alphaGradientPanel1, "Attach to Roblox.");
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.Controls.Add(this.alphaGradientPanel5);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.alphaGradientPanel4);
            this.panel1.Controls.Add(this.alphaGradientPanel3);
            this.panel1.Controls.Add(this.alphaGradientPanel1);
            this.panel1.Controls.Add(this.alphaGradientPanel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 394);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(791, 41);
            this.panel1.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Segoe UI Variable Text Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(0, 19);
            this.label4.Margin = new System.Windows.Forms.Padding(0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(130, 22);
            this.label4.TabIndex = 6;
            this.label4.Text = "©️ Warp Softworks.";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Segoe UI Variable Display Semib", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(0, 0);
            this.label3.Margin = new System.Windows.Forms.Padding(0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(130, 19);
            this.label3.TabIndex = 5;
            this.label3.Text = "WarpSploit v1.3pre1";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Transparent;
            this.panel2.Controls.Add(this.txtChatLog);
            this.panel2.Controls.Add(this.textBox1);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(196, 394);
            this.panel2.TabIndex = 5;
            // 
            // txtChatLog
            // 
            this.txtChatLog.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(12)))), ((int)(((byte)(12)))));
            this.txtChatLog.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtChatLog.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.txtChatLog.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtChatLog.Enabled = false;
            this.txtChatLog.Font = new System.Drawing.Font("Segoe UI Variable Text", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtChatLog.ForeColor = System.Drawing.Color.White;
            this.txtChatLog.ImeMode = System.Windows.Forms.ImeMode.Disable;
            this.txtChatLog.Location = new System.Drawing.Point(0, 57);
            this.txtChatLog.MaxLength = 1500000000;
            this.txtChatLog.Multiline = true;
            this.txtChatLog.Name = "txtChatLog";
            this.txtChatLog.ReadOnly = true;
            this.txtChatLog.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtChatLog.ShortcutsEnabled = false;
            this.txtChatLog.Size = new System.Drawing.Size(196, 315);
            this.txtChatLog.TabIndex = 5;
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.SystemColors.Window;
            this.textBox1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.textBox1.Font = new System.Drawing.Font("Segoe UI Variable Text", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(0, 372);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(196, 22);
            this.textBox1.TabIndex = 4;
            this.textBox1.KeyDown += textBox1_KeyDown;
            // 
            // label2
            // 
            this.label2.Dock = System.Windows.Forms.DockStyle.Top;
            this.label2.Font = new System.Drawing.Font("Segoe UI Variable Text Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(0, 35);
            this.label2.Margin = new System.Windows.Forms.Padding(0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(196, 22);
            this.label2.TabIndex = 1;
            this.label2.Text = "Your AI assistant in WarpSploit.";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.Font = new System.Drawing.Font("Segoe UI Variable Display Semib", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Margin = new System.Windows.Forms.Padding(0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(196, 35);
            this.label1.TabIndex = 0;
            this.label1.Text = "WS Copilot";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // toolTip1
            // 
            this.toolTip1.ToolTipTitle = "Load from File";
            // 
            // toolTip2
            // 
            this.toolTip2.ToolTipTitle = "Save to File";
            // 
            // toolTip3
            // 
            this.toolTip3.ToolTipTitle = "Execute";
            // 
            // toolTip4
            // 
            this.toolTip4.ToolTipTitle = "Attach";
            // 
            // Editor
            // 
            this.Editor.AutoCompleteBracketsList = new char[] {
        '(',
        ')',
        '{',
        '}',
        '[',
        ']',
        '\"',
        '\"',
        '\'',
        '\''};
            this.Editor.AutoIndentCharsPatterns = "\r\n^\\s*[\\w\\.]+(\\s\\w+)?\\s*(?<range>=)\\s*(?<range>.+)\r\n";
            this.Editor.AutoScrollMinSize = new System.Drawing.Size(203, 15);
            this.Editor.BackBrush = null;
            this.Editor.BackColor = System.Drawing.Color.Transparent;
            this.Editor.BracketsHighlightStrategy = FastColoredTextBoxNS.BracketsHighlightStrategy.Strategy2;
            this.Editor.CharCnWidth = 16;
            this.Editor.CharHeight = 15;
            this.Editor.CharWidth = 8;
            this.Editor.CommentPrefix = "--";
            this.Editor.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.Editor.DisabledColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(180)))), ((int)(((byte)(180)))), ((int)(((byte)(180)))));
            this.Editor.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Editor.Font = new System.Drawing.Font("Cascadia Mono SemiBold", 9.75F, System.Drawing.FontStyle.Bold);
            this.Editor.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.Editor.IndentBackColor = System.Drawing.Color.Transparent;
            this.Editor.IsReplaceMode = false;
            this.Editor.Language = FastColoredTextBoxNS.Language.Lua;
            this.Editor.LeftBracket = '(';
            this.Editor.LeftBracket2 = '{';
            this.Editor.LineNumberColor = System.Drawing.Color.White;
            this.Editor.Location = new System.Drawing.Point(196, 0);
            this.Editor.Name = "Editor";
            this.Editor.Paddings = new System.Windows.Forms.Padding(0);
            this.Editor.RightBracket = ')';
            this.Editor.RightBracket2 = '}';
            this.Editor.SelectionColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(255)))));
            this.Editor.ServiceColors = ((FastColoredTextBoxNS.ServiceColors)(resources.GetObject("Editor.ServiceColors")));
            this.Editor.Size = new System.Drawing.Size(595, 394);
            this.Editor.TabIndex = 6;
            this.Editor.Text = "--[[\r\nWelcome!\r\nThis is the script editor.\r\nYou can place scripts here like other executors!\r\n]]--";
            this.Editor.Zoom = 100;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.DefaultExt = "lua";
            this.openFileDialog1.FileName = "openFileDialog1";
            this.openFileDialog1.Filter = "Lua Files|*.lua|Text Files|*.txt|All Files|*.*";
            this.openFileDialog1.Title = "WarpSploit - Load Script";
            // 
            // saveFileDialog1
            // 
            this.saveFileDialog1.Filter = "Lua Files|*.lua|Text Files|*.txt|All Files|*.*";
            // 
            // toolTip5
            // 
            this.toolTip5.ToolTipTitle = "Community Server";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(12)))), ((int)(((byte)(12)))));
            this.ClientSize = new System.Drawing.Size(791, 435);
            this.Controls.Add(this.Editor);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.ForeColor = System.Drawing.Color.White;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.RightToLeftLayout = true;
            this.Text = "WarpSploit";
            this.TransparencyKey = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(12)))), ((int)(((byte)(12)))));
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Editor)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.ColorWithAlpha Color2;
        private System.Windows.Forms.AlphaGradientPanel alphaGradientPanel4;
        private System.Windows.Forms.AlphaGradientPanel alphaGradientPanel2;
        private System.Windows.Forms.AlphaGradientPanel alphaGradientPanel3;
        private System.Windows.Forms.AlphaGradientPanel alphaGradientPanel1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.ToolTip toolTip2;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.ToolTip toolTip4;
        private System.Windows.Forms.ToolTip toolTip3;
        private FastColoredTextBoxNS.FastColoredTextBox Editor;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.AlphaGradientPanel alphaGradientPanel5;
        private System.Windows.Forms.ToolTip toolTip5;
        private System.Windows.Forms.TextBox txtChatLog;
        private System.Windows.Forms.TextBox textBox1;
    }
}

