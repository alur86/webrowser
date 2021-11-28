
namespace WebBrowser
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.buttonGo = new System.Windows.Forms.Button();
            this.textURL = new System.Windows.Forms.TextBox();
            this.webBrowser1 = new System.Windows.Forms.WebBrowser();
            this.menuStrip2 = new System.Windows.Forms.MenuStrip();
            this.moreToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.homeMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.forwardMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.backMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.refreshMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.searchMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.stopMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
            this.exitToolItem = new System.Windows.Forms.ToolStripMenuItem();
            this.labelURL = new System.Windows.Forms.Label();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.menuStrip2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonGo
            // 
            this.buttonGo.Location = new System.Drawing.Point(691, 1);
            this.buttonGo.Name = "buttonGo";
            this.buttonGo.Size = new System.Drawing.Size(75, 23);
            this.buttonGo.TabIndex = 1;
            this.buttonGo.Text = "Go";
            this.buttonGo.UseVisualStyleBackColor = true;
            this.buttonGo.Click += new System.EventHandler(this.buttonGo_Click);
            this.buttonGo.Enter += new System.EventHandler(this.buttonGo_Click);
            this.buttonGo.KeyDown += new System.Windows.Forms.KeyEventHandler(this.buttonGo_KeyDown);
            // 
            // textURL
            // 
            this.textURL.Location = new System.Drawing.Point(146, 3);
            this.textURL.Name = "textURL";
            this.textURL.Size = new System.Drawing.Size(539, 20);
            this.textURL.TabIndex = 2;
            this.textURL.Validating += new System.ComponentModel.CancelEventHandler(this.textURL_Validating);
            // 
            // webBrowser1
            // 
            this.webBrowser1.Location = new System.Drawing.Point(0, 27);
            this.webBrowser1.MinimumSize = new System.Drawing.Size(20, 20);
            this.webBrowser1.Name = "webBrowser1";
            this.webBrowser1.ScriptErrorsSuppressed = true;
            this.webBrowser1.Size = new System.Drawing.Size(800, 422);
            this.webBrowser1.TabIndex = 3;
            this.webBrowser1.DocumentCompleted += new System.Windows.Forms.WebBrowserDocumentCompletedEventHandler(this.webBrowser1_DocumentCompleted);
            // 
            // menuStrip2
            // 
            this.menuStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.moreToolStripMenuItem});
            this.menuStrip2.Location = new System.Drawing.Point(0, 0);
            this.menuStrip2.Name = "menuStrip2";
            this.menuStrip2.Size = new System.Drawing.Size(800, 24);
            this.menuStrip2.TabIndex = 4;
            this.menuStrip2.Text = "menuStrip2";
            // 
            // moreToolStripMenuItem
            // 
            this.moreToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.homeMenuItem,
            this.forwardMenuItem,
            this.backMenuItem,
            this.refreshMenuItem,
            this.searchMenuItem,
            this.stopMenuItem,
            this.toolStripMenuItem1,
            this.exitToolItem});
            this.moreToolStripMenuItem.Name = "moreToolStripMenuItem";
            this.moreToolStripMenuItem.Size = new System.Drawing.Size(77, 20);
            this.moreToolStripMenuItem.Text = "Navigation";
            // 
            // homeMenuItem
            // 
            this.homeMenuItem.Name = "homeMenuItem";
            this.homeMenuItem.Size = new System.Drawing.Size(117, 22);
            this.homeMenuItem.Text = "Home";
            this.homeMenuItem.Click += new System.EventHandler(this.homeMenuItem_Click);
            // 
            // forwardMenuItem
            // 
            this.forwardMenuItem.Name = "forwardMenuItem";
            this.forwardMenuItem.Size = new System.Drawing.Size(117, 22);
            this.forwardMenuItem.Text = "Forward";
            this.forwardMenuItem.Click += new System.EventHandler(this.forwardMenuItem_Click);
            // 
            // backMenuItem
            // 
            this.backMenuItem.Name = "backMenuItem";
            this.backMenuItem.Size = new System.Drawing.Size(117, 22);
            this.backMenuItem.Text = "Back";
            this.backMenuItem.Click += new System.EventHandler(this.backMenuItem_Click);
            // 
            // refreshMenuItem
            // 
            this.refreshMenuItem.Name = "refreshMenuItem";
            this.refreshMenuItem.Size = new System.Drawing.Size(117, 22);
            this.refreshMenuItem.Text = "Refresh";
            this.refreshMenuItem.Click += new System.EventHandler(this.refreshMenuItem_Click);
            // 
            // searchMenuItem
            // 
            this.searchMenuItem.Name = "searchMenuItem";
            this.searchMenuItem.Size = new System.Drawing.Size(117, 22);
            this.searchMenuItem.Text = "Search";
            // 
            // stopMenuItem
            // 
            this.stopMenuItem.Name = "stopMenuItem";
            this.stopMenuItem.Size = new System.Drawing.Size(117, 22);
            this.stopMenuItem.Text = "Stop";
            this.stopMenuItem.Click += new System.EventHandler(this.stopMenuItem_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(114, 6);
            // 
            // exitToolItem
            // 
            this.exitToolItem.Name = "exitToolItem";
            this.exitToolItem.Size = new System.Drawing.Size(117, 22);
            this.exitToolItem.Text = "Exit";
            this.exitToolItem.Click += new System.EventHandler(this.exitToolItem_Click);
            // 
            // labelURL
            // 
            this.labelURL.AutoSize = true;
            this.labelURL.Location = new System.Drawing.Point(108, 6);
            this.labelURL.Name = "labelURL";
            this.labelURL.Size = new System.Drawing.Size(32, 13);
            this.labelURL.TabIndex = 5;
            this.labelURL.Text = "URL:";
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.labelURL);
            this.Controls.Add(this.webBrowser1);
            this.Controls.Add(this.textURL);
            this.Controls.Add(this.buttonGo);
            this.Controls.Add(this.menuStrip2);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.menuStrip2.ResumeLayout(false);
            this.menuStrip2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button buttonGo;
        private System.Windows.Forms.TextBox textURL;
        private System.Windows.Forms.WebBrowser webBrowser1;
        private System.Windows.Forms.MenuStrip menuStrip2;
        private System.Windows.Forms.ToolStripMenuItem moreToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem homeMenuItem;
        private System.Windows.Forms.ToolStripMenuItem forwardMenuItem;
        private System.Windows.Forms.ToolStripMenuItem backMenuItem;
        private System.Windows.Forms.ToolStripMenuItem refreshMenuItem;
        private System.Windows.Forms.ToolStripMenuItem stopMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem exitToolItem;
        private System.Windows.Forms.ToolStripMenuItem searchMenuItem;
        private System.Windows.Forms.Label labelURL;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}

