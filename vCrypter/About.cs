namespace vCrypter
{
    using System;
    using System.ComponentModel;
    using System.Drawing;
    using System.Windows.Forms;
    using vCrypter.Properties;

    public class About : Form
    {
        private Label AuthorLB;
        private IContainer components = null;
        private LinkLabel LinkLabelSphere;
        private LinkLabel LinkLabelValiosTools;
        private PictureBox Picture;
        private Label ProjectLB;
        private Label VersionLB;

        public About()
        {
            this.InitializeComponent();
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing && (this.components != null))
            {
                this.components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            ComponentResourceManager manager = new ComponentResourceManager(typeof(About));
            this.Picture = new PictureBox();
            this.AuthorLB = new Label();
            this.LinkLabelSphere = new LinkLabel();
            this.ProjectLB = new Label();
            this.LinkLabelValiosTools = new LinkLabel();
            this.VersionLB = new Label();
            ((ISupportInitialize) this.Picture).BeginInit();
            base.SuspendLayout();
            this.Picture.BackgroundImageLayout = ImageLayout.Stretch;
            this.Picture.Image = Resources.unknownperson2;
            this.Picture.Location = new Point(12, 12);
            this.Picture.Name = "Picture";
            this.Picture.Size = new Size(0x53, 0x4d);
            this.Picture.SizeMode = PictureBoxSizeMode.StretchImage;
            this.Picture.TabIndex = 0;
            this.Picture.TabStop = false;
            this.AuthorLB.AutoSize = true;
            this.AuthorLB.BackColor = Color.Transparent;
            this.AuthorLB.ForeColor = Color.White;
            this.AuthorLB.Location = new Point(0x65, 12);
            this.AuthorLB.Name = "AuthorLB";
            this.AuthorLB.Size = new Size(0x48, 13);
            this.AuthorLB.TabIndex = 1;
            this.AuthorLB.Text = "Author: Valios";
            this.LinkLabelSphere.AutoSize = true;
            this.LinkLabelSphere.BackColor = Color.Transparent;
            this.LinkLabelSphere.ForeColor = Color.White;
            this.LinkLabelSphere.LinkColor = Color.Gold;
            this.LinkLabelSphere.Location = new Point(0x65, 0x3e);
            this.LinkLabelSphere.Name = "LinkLabelSphere";
            this.LinkLabelSphere.Size = new Size(170, 13);
            this.LinkLabelSphere.TabIndex = 2;
            this.LinkLabelSphere.TabStop = true;
            this.LinkLabelSphere.Text = "http://www.spherecommunity.net/";
            this.ProjectLB.AutoSize = true;
            this.ProjectLB.BackColor = Color.Transparent;
            this.ProjectLB.ForeColor = Color.White;
            this.ProjectLB.Location = new Point(0x65, 0x19);
            this.ProjectLB.Name = "ProjectLB";
            this.ProjectLB.Size = new Size(0x9d, 13);
            this.ProjectLB.TabIndex = 3;
            this.ProjectLB.Text = "Project: SphereCommunityTools";
            this.LinkLabelValiosTools.AutoSize = true;
            this.LinkLabelValiosTools.BackColor = Color.Transparent;
            this.LinkLabelValiosTools.ForeColor = Color.White;
            this.LinkLabelValiosTools.LinkColor = Color.Gold;
            this.LinkLabelValiosTools.Location = new Point(0x65, 0x4b);
            this.LinkLabelValiosTools.Name = "LinkLabelValiosTools";
            this.LinkLabelValiosTools.Size = new Size(190, 13);
            this.LinkLabelValiosTools.TabIndex = 4;
            this.LinkLabelValiosTools.TabStop = true;
            this.LinkLabelValiosTools.Text = "http://code.google.com/p/valiostools/";
            this.VersionLB.AutoSize = true;
            this.VersionLB.BackColor = Color.Transparent;
            this.VersionLB.ForeColor = Color.LightSteelBlue;
            this.VersionLB.Location = new Point(0x65, 0x26);
            this.VersionLB.Name = "VersionLB";
            this.VersionLB.Size = new Size(0x3f, 13);
            this.VersionLB.TabIndex = 5;
            this.VersionLB.Text = "Version: 1.2";
            base.AutoScaleDimensions = new SizeF(6f, 13f);
            base.AutoScaleMode = AutoScaleMode.Font;
            this.BackgroundImage = Resources.LauncherBackground4;
            this.BackgroundImageLayout = ImageLayout.Stretch;
            base.ClientSize = new Size(0x137, 0x66);
            base.Controls.Add(this.VersionLB);
            base.Controls.Add(this.LinkLabelValiosTools);
            base.Controls.Add(this.ProjectLB);
            base.Controls.Add(this.LinkLabelSphere);
            base.Controls.Add(this.AuthorLB);
            base.Controls.Add(this.Picture);
            base.FormBorderStyle = FormBorderStyle.FixedToolWindow;
            base.Icon = (Icon) manager.GetObject("$this.Icon");
            base.Name = "About";
            this.Text = "About";
            ((ISupportInitialize) this.Picture).EndInit();
            base.ResumeLayout(false);
            base.PerformLayout();
        }
    }
}

