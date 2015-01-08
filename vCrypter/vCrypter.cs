namespace vCrypter
{
    using System;
    using System.ComponentModel;
    using System.Drawing;
    using System.Windows.Forms;
    using vCrypter.Properties;

    public class vCrypter : Form
    {
        private Button CalculateCKeys;
        private Button CalculateECKeys;
        private TextBox CBuild;
        private Label CBuildLB;
        private TextBox CKeys;
        private TextBox CMajor;
        private Label CMajorLB;
        private TextBox CMinor;
        private Label CMinorLB;
        private IContainer components = null;
        private TextBox CRevision;
        private Label CRevisionLB;
        private TextBox ECBuild;
        private Label ECBuildLB;
        private TextBox ECKeys;
        private TextBox ECMajor;
        private Label ECMajorLB;
        private TextBox ECMinor;
        private Label ECMinorLB;
        private TextBox ECRevision;
        private Label ECRevisionLB;
        private GroupBox GroupBoxCEncryption;
        private GroupBox GroupBoxClassic;
        private GroupBox GroupBoxECEncryption;
        private GroupBox GroupBoxEnhanced;
        private LinkLabel LinkLabelAbout;
        private Panel panel1;
        private Panel panel2;
        private RadioButton RadioButtonCBlow;
        private RadioButton RadioButtonCBlowTwo;
        private RadioButton RadioButtonCNoEncryption;
        private RadioButton RadioButtonCTwo;
        private RadioButton RadioButtonECBlow;
        private RadioButton RadioButtonECBlowTwo;
        private RadioButton RadioButtonECNoEncryption;
        private RadioButton RadioButtonECTwo;
        private Label VersionLB;

        public vCrypter()
        {
            this.InitializeComponent();
            base.ActiveControl = this.CMajorLB;
        }

        private void CalculateCKeys_Click(object sender, EventArgs e)
        {
            string str;
            string str5;
            uint num2 = Convert.ToUInt32(Convert.ToInt32(this.CMajor.Text).ToString("X"), 0x10);
            uint num4 = Convert.ToUInt32(Convert.ToInt32(this.CMinor.Text).ToString("X"), 0x10);
            uint num6 = Convert.ToUInt32(Convert.ToInt32(this.CBuild.Text).ToString("X"), 0x10);
            uint num7 = Convert.ToUInt32(this.CRevision.Text, 0x10);
            uint num8 = ((num2 << 0x17) | (num4 << 14)) | (num6 << 4);
            num8 ^= (num6 * num6) << 9;
            num8 ^= num4 * num4;
            num8 ^= (uint) ((num4 * 11) << 0x18);
            num8 ^= (uint) ((num6 * 7) << 0x13);
            num8 ^= 0x2c13a5fd;
            uint num9 = ((num2 << 0x16) | (num6 << 13)) | (num4 << 3);
            num9 ^= (uint) (((num6 * num6) * 3) << 10);
            num9 ^= num4 * num4;
            num9 ^= (uint) ((num4 * 13) << 0x17);
            num9 ^= (uint) ((num6 * 7) << 0x12);
            num9 ^= 0xa31d527f;
            if (this.RadioButtonCNoEncryption.Checked)
            {
                str = "ENC_NONE";
                str5 = this.CMajor.Text + this.CMinor.Text + this.CBuild.Text + this.CRevision.Text + " 0" + num8.ToString("X") + " 0" + num9.ToString("X") + " " + str + " // " + this.CMajor.Text + "." + this.CMinor.Text + "." + this.CBuild.Text + "." + this.CRevision.Text;
                this.CKeys.Text = str5;
            }
            else if (this.RadioButtonCBlow.Checked)
            {
                str = "ENC_BFISH";
                str5 = this.CMajor.Text + this.CMinor.Text + this.CBuild.Text + this.CRevision.Text + " 0" + num8.ToString("X") + " 0" + num9.ToString("X") + " " + str + " // " + this.CMajor.Text + "." + this.CMinor.Text + "." + this.CBuild.Text + "." + this.CRevision.Text;
                this.CKeys.Text = str5;
            }
            else if (this.RadioButtonCBlowTwo.Checked)
            {
                str = "ENC_BTFISH";
                str5 = this.CMajor.Text + this.CMinor.Text + this.CBuild.Text + this.CRevision.Text + " 0" + num8.ToString("X") + " 0" + num9.ToString("X") + " " + str + " // " + this.CMajor.Text + "." + this.CMinor.Text + "." + this.CBuild.Text + "." + this.CRevision.Text;
                this.CKeys.Text = str5;
            }
            else if (this.RadioButtonCTwo.Checked)
            {
                str = "ENC_TFISH";
                str5 = this.CMajor.Text + this.CMinor.Text + this.CBuild.Text + this.CRevision.Text + " 0" + num8.ToString("X") + " 0" + num9.ToString("X") + " " + str + " // " + this.CMajor.Text + "." + this.CMinor.Text + "." + this.CBuild.Text + "." + this.CRevision.Text;
                this.CKeys.Text = str5;
            }
        }

        private void CalculateECKeys_Click(object sender, EventArgs e)
        {
            string str;
            string str4;
            uint num = 0x43;
            uint num3 = Convert.ToUInt32(Convert.ToInt32(this.ECMinor.Text).ToString("X"), 0x10);
            uint num5 = Convert.ToUInt32(Convert.ToInt32(this.ECBuild.Text).ToString("X"), 0x10);
            uint num6 = Convert.ToUInt32(this.ECRevision.Text, 0x10);
            uint num7 = ((num << 0x17) | (num3 << 14)) | (num5 << 4);
            num7 ^= (num5 * num5) << 9;
            num7 ^= num3 * num3;
            num7 ^= (uint) ((num3 * 11) << 0x18);
            num7 ^= (uint) ((num5 * 7) << 0x13);
            num7 ^= 0x2c13a5fd;
            uint num8 = ((num << 0x16) | (num5 << 13)) | (num3 << 3);
            num8 ^= (uint) (((num5 * num5) * 3) << 10);
            num8 ^= num3 * num3;
            num8 ^= (uint) ((num3 * 13) << 0x17);
            num8 ^= (uint) ((num5 * 7) << 0x12);
            num8 ^= 0xa31d527f;
            if (this.RadioButtonECNoEncryption.Checked)
            {
                str = "ENC_NONE";
                str4 = "0679" + this.ECMinor.Text + this.ECBuild.Text + this.ECRevision.Text + " 0" + num7.ToString("X") + " 0" + num8.ToString("X") + " " + str + " // " + this.ECMajor.Text + "." + this.ECMinor.Text + "." + this.ECBuild.Text + "." + this.ECRevision.Text;
                this.ECKeys.Text = str4;
            }
            else if (this.RadioButtonECBlow.Checked)
            {
                str = "ENC_BFISH";
                str4 = "0679" + this.ECMinor.Text + this.ECBuild.Text + this.ECRevision.Text + " 0" + num7.ToString("X") + " 0" + num8.ToString("X") + " " + str + " // " + this.ECMajor.Text + "." + this.ECMinor.Text + "." + this.ECBuild.Text + "." + this.ECRevision.Text;
                this.ECKeys.Text = str4;
            }
            else if (this.RadioButtonECBlowTwo.Checked)
            {
                str = "ENC_BTFISH";
                str4 = "0679" + this.ECMinor.Text + this.ECBuild.Text + this.ECRevision.Text + " 0" + num7.ToString("X") + " 0" + num8.ToString("X") + " " + str + " // " + this.ECMajor.Text + "." + this.ECMinor.Text + "." + this.ECBuild.Text + "." + this.ECRevision.Text;
                this.ECKeys.Text = str4;
            }
            else if (this.RadioButtonECTwo.Checked)
            {
                str = "ENC_TFISH";
                str4 = "0679" + this.ECMinor.Text + this.ECBuild.Text + this.ECRevision.Text + " 0" + num7.ToString("X") + " 0" + num8.ToString("X") + " " + str + " // " + this.ECMajor.Text + "." + this.ECMinor.Text + "." + this.ECBuild.Text + "." + this.ECRevision.Text;
                this.ECKeys.Text = str4;
            }
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
            ComponentResourceManager manager = new ComponentResourceManager(typeof(vCrypter.vCrypter));
            this.CMajor = new TextBox();
            this.CMajorLB = new Label();
            this.CMinorLB = new Label();
            this.CBuildLB = new Label();
            this.CRevisionLB = new Label();
            this.CMinor = new TextBox();
            this.CBuild = new TextBox();
            this.CRevision = new TextBox();
            this.CalculateCKeys = new Button();
            this.GroupBoxClassic = new GroupBox();
            this.CKeys = new TextBox();
            this.GroupBoxCEncryption = new GroupBox();
            this.RadioButtonCTwo = new RadioButton();
            this.RadioButtonCBlowTwo = new RadioButton();
            this.RadioButtonCBlow = new RadioButton();
            this.RadioButtonCNoEncryption = new RadioButton();
            this.panel1 = new Panel();
            this.LinkLabelAbout = new LinkLabel();
            this.VersionLB = new Label();
            this.panel2 = new Panel();
            this.GroupBoxEnhanced = new GroupBox();
            this.ECMajorLB = new Label();
            this.ECMajor = new TextBox();
            this.ECMinorLB = new Label();
            this.ECBuildLB = new Label();
            this.ECRevisionLB = new Label();
            this.ECMinor = new TextBox();
            this.ECBuild = new TextBox();
            this.ECRevision = new TextBox();
            this.CalculateECKeys = new Button();
            this.GroupBoxECEncryption = new GroupBox();
            this.RadioButtonECTwo = new RadioButton();
            this.RadioButtonECBlowTwo = new RadioButton();
            this.RadioButtonECBlow = new RadioButton();
            this.RadioButtonECNoEncryption = new RadioButton();
            this.ECKeys = new TextBox();
            this.GroupBoxClassic.SuspendLayout();
            this.GroupBoxCEncryption.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.GroupBoxEnhanced.SuspendLayout();
            this.GroupBoxECEncryption.SuspendLayout();
            base.SuspendLayout();
            this.CMajor.Font = new Font("Consolas", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.CMajor.ForeColor = Color.Crimson;
            this.CMajor.Location = new Point(7, 0x29);
            this.CMajor.MaxLength = 3;
            this.CMajor.Name = "CMajor";
            this.CMajor.Size = new Size(0x31, 0x17);
            this.CMajor.TabIndex = 0;
            this.CMajor.Text = "00";
            this.CMajor.TextAlign = HorizontalAlignment.Center;
            this.CMajorLB.AutoSize = true;
            this.CMajorLB.Font = new Font("Microsoft Sans Serif", 8.25f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.CMajorLB.Location = new Point(6, 0x19);
            this.CMajorLB.Name = "CMajorLB";
            this.CMajorLB.Size = new Size(0x21, 13);
            this.CMajorLB.TabIndex = 10;
            this.CMajorLB.Text = "Major";
            this.CMinorLB.AutoSize = true;
            this.CMinorLB.Font = new Font("Microsoft Sans Serif", 8.25f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.CMinorLB.Location = new Point(0x3d, 0x19);
            this.CMinorLB.Name = "CMinorLB";
            this.CMinorLB.Size = new Size(0x21, 13);
            this.CMinorLB.TabIndex = 11;
            this.CMinorLB.Text = "Minor";
            this.CBuildLB.AutoSize = true;
            this.CBuildLB.Font = new Font("Microsoft Sans Serif", 8.25f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.CBuildLB.Location = new Point(0x74, 0x19);
            this.CBuildLB.Name = "CBuildLB";
            this.CBuildLB.Size = new Size(30, 13);
            this.CBuildLB.TabIndex = 12;
            this.CBuildLB.Text = "Build";
            this.CRevisionLB.AutoSize = true;
            this.CRevisionLB.Font = new Font("Microsoft Sans Serif", 8.25f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.CRevisionLB.Location = new Point(0xab, 0x19);
            this.CRevisionLB.Name = "CRevisionLB";
            this.CRevisionLB.Size = new Size(0x30, 13);
            this.CRevisionLB.TabIndex = 13;
            this.CRevisionLB.Text = "Revision";
            this.CMinor.Font = new Font("Consolas", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.CMinor.ForeColor = Color.Crimson;
            this.CMinor.Location = new Point(0x3e, 0x29);
            this.CMinor.MaxLength = 3;
            this.CMinor.Name = "CMinor";
            this.CMinor.Size = new Size(0x31, 0x17);
            this.CMinor.TabIndex = 14;
            this.CMinor.Text = "00";
            this.CMinor.TextAlign = HorizontalAlignment.Center;
            this.CBuild.Font = new Font("Consolas", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.CBuild.ForeColor = Color.Crimson;
            this.CBuild.Location = new Point(0x75, 0x29);
            this.CBuild.MaxLength = 3;
            this.CBuild.Name = "CBuild";
            this.CBuild.Size = new Size(0x31, 0x17);
            this.CBuild.TabIndex = 15;
            this.CBuild.Text = "00";
            this.CBuild.TextAlign = HorizontalAlignment.Center;
            this.CRevision.Font = new Font("Consolas", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.CRevision.ForeColor = Color.Crimson;
            this.CRevision.Location = new Point(0xac, 0x29);
            this.CRevision.MaxLength = 3;
            this.CRevision.Name = "CRevision";
            this.CRevision.Size = new Size(0x31, 0x17);
            this.CRevision.TabIndex = 0x10;
            this.CRevision.Text = "00";
            this.CRevision.TextAlign = HorizontalAlignment.Center;
            this.CalculateCKeys.Font = new Font("Microsoft Sans Serif", 8.25f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.CalculateCKeys.Location = new Point(7, 0x43);
            this.CalculateCKeys.Name = "CalculateCKeys";
            this.CalculateCKeys.Size = new Size(0xd6, 0x1b);
            this.CalculateCKeys.TabIndex = 0x19;
            this.CalculateCKeys.Text = "Calculate Keys";
            this.CalculateCKeys.UseVisualStyleBackColor = true;
            this.CalculateCKeys.Click += new EventHandler(this.CalculateCKeys_Click);
            this.GroupBoxClassic.BackColor = Color.Transparent;
            this.GroupBoxClassic.Controls.Add(this.CMajorLB);
            this.GroupBoxClassic.Controls.Add(this.CMajor);
            this.GroupBoxClassic.Controls.Add(this.CMinorLB);
            this.GroupBoxClassic.Controls.Add(this.CBuildLB);
            this.GroupBoxClassic.Controls.Add(this.CRevisionLB);
            this.GroupBoxClassic.Controls.Add(this.CMinor);
            this.GroupBoxClassic.Controls.Add(this.CBuild);
            this.GroupBoxClassic.Controls.Add(this.CRevision);
            this.GroupBoxClassic.Controls.Add(this.CalculateCKeys);
            this.GroupBoxClassic.Font = new Font("Microsoft Sans Serif", 14.25f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.GroupBoxClassic.ForeColor = SystemColors.ControlDarkDark;
            this.GroupBoxClassic.Location = new Point(12, 12);
            this.GroupBoxClassic.Name = "GroupBoxClassic";
            this.GroupBoxClassic.Size = new Size(230, 0x68);
            this.GroupBoxClassic.TabIndex = 0x25;
            this.GroupBoxClassic.TabStop = false;
            this.GroupBoxClassic.Text = "Classic Client";
            this.CKeys.Font = new Font("Consolas", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.CKeys.ForeColor = Color.Crimson;
            this.CKeys.Location = new Point(12, 0x7a);
            this.CKeys.Name = "CKeys";
            this.CKeys.ReadOnly = true;
            this.CKeys.Size = new Size(480, 0x17);
            this.CKeys.TabIndex = 0x27;
            this.CKeys.TextAlign = HorizontalAlignment.Center;
            this.GroupBoxCEncryption.BackColor = Color.Transparent;
            this.GroupBoxCEncryption.Controls.Add(this.RadioButtonCTwo);
            this.GroupBoxCEncryption.Controls.Add(this.RadioButtonCBlowTwo);
            this.GroupBoxCEncryption.Controls.Add(this.RadioButtonCBlow);
            this.GroupBoxCEncryption.Controls.Add(this.RadioButtonCNoEncryption);
            this.GroupBoxCEncryption.Font = new Font("Microsoft Sans Serif", 14.25f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.GroupBoxCEncryption.ForeColor = SystemColors.ControlDarkDark;
            this.GroupBoxCEncryption.Location = new Point(0xf8, 12);
            this.GroupBoxCEncryption.Name = "GroupBoxCEncryption";
            this.GroupBoxCEncryption.Size = new Size(0xf4, 0x68);
            this.GroupBoxCEncryption.TabIndex = 0x26;
            this.GroupBoxCEncryption.TabStop = false;
            this.GroupBoxCEncryption.Text = "Encryption Type";
            this.RadioButtonCTwo.AutoSize = true;
            this.RadioButtonCTwo.Checked = true;
            this.RadioButtonCTwo.Font = new Font("Microsoft Sans Serif", 8.25f, FontStyle.Bold, GraphicsUnit.Point, 0);
            this.RadioButtonCTwo.Location = new Point(0x99, 70);
            this.RadioButtonCTwo.Name = "RadioButtonCTwo";
            this.RadioButtonCTwo.Size = new Size(0x45, 0x11);
            this.RadioButtonCTwo.TabIndex = 3;
            this.RadioButtonCTwo.TabStop = true;
            this.RadioButtonCTwo.Text = "Twofish";
            this.RadioButtonCTwo.UseVisualStyleBackColor = true;
            this.RadioButtonCBlowTwo.AutoSize = true;
            this.RadioButtonCBlowTwo.Font = new Font("Microsoft Sans Serif", 8.25f, FontStyle.Bold, GraphicsUnit.Point, 0);
            this.RadioButtonCBlowTwo.Location = new Point(0x10, 70);
            this.RadioButtonCBlowTwo.Name = "RadioButtonCBlowTwo";
            this.RadioButtonCBlowTwo.Size = new Size(0x83, 0x11);
            this.RadioButtonCBlowTwo.TabIndex = 2;
            this.RadioButtonCBlowTwo.Text = "Blowfish + Twofish";
            this.RadioButtonCBlowTwo.UseVisualStyleBackColor = true;
            this.RadioButtonCBlow.AutoSize = true;
            this.RadioButtonCBlow.Font = new Font("Microsoft Sans Serif", 8.25f, FontStyle.Bold, GraphicsUnit.Point, 0);
            this.RadioButtonCBlow.Location = new Point(0x99, 0x25);
            this.RadioButtonCBlow.Name = "RadioButtonCBlow";
            this.RadioButtonCBlow.Size = new Size(0x48, 0x11);
            this.RadioButtonCBlow.TabIndex = 1;
            this.RadioButtonCBlow.Text = "Blowfish";
            this.RadioButtonCBlow.UseVisualStyleBackColor = true;
            this.RadioButtonCNoEncryption.AutoSize = true;
            this.RadioButtonCNoEncryption.Font = new Font("Microsoft Sans Serif", 8.25f, FontStyle.Bold, GraphicsUnit.Point, 0);
            this.RadioButtonCNoEncryption.Location = new Point(0x10, 0x25);
            this.RadioButtonCNoEncryption.Name = "RadioButtonCNoEncryption";
            this.RadioButtonCNoEncryption.Size = new Size(0x69, 0x11);
            this.RadioButtonCNoEncryption.TabIndex = 0;
            this.RadioButtonCNoEncryption.Text = "No Encryption";
            this.RadioButtonCNoEncryption.UseVisualStyleBackColor = true;
            this.panel1.BackColor = Color.White;
            this.panel1.BackgroundImage = Resources.LauncherBackground2;
            this.panel1.BackgroundImageLayout = ImageLayout.Stretch;
            this.panel1.Controls.Add(this.LinkLabelAbout);
            this.panel1.Controls.Add(this.VersionLB);
            this.panel1.Controls.Add(this.GroupBoxClassic);
            this.panel1.Controls.Add(this.GroupBoxCEncryption);
            this.panel1.Controls.Add(this.CKeys);
            this.panel1.Location = new Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new Size(0x1f8, 0x9a);
            this.panel1.TabIndex = 0x29;
            this.LinkLabelAbout.AutoSize = true;
            this.LinkLabelAbout.BackColor = Color.Transparent;
            this.LinkLabelAbout.Font = new Font("Microsoft Sans Serif", 8.25f, FontStyle.Bold, GraphicsUnit.Point, 0);
            this.LinkLabelAbout.LinkColor = Color.Yellow;
            this.LinkLabelAbout.Location = new Point(0x1dd, 5);
            this.LinkLabelAbout.Name = "LinkLabelAbout";
            this.LinkLabelAbout.Size = new Size(14, 13);
            this.LinkLabelAbout.TabIndex = 0x29;
            this.LinkLabelAbout.TabStop = true;
            this.LinkLabelAbout.Text = "?";
            this.LinkLabelAbout.LinkClicked += new LinkLabelLinkClickedEventHandler(this.LinkLabelAbout_LinkClicked);
            this.VersionLB.AutoSize = true;
            this.VersionLB.BackColor = Color.Transparent;
            this.VersionLB.ForeColor = Color.White;
            this.VersionLB.Location = new Point(0x195, 5);
            this.VersionLB.Name = "VersionLB";
            this.VersionLB.Size = new Size(0x3f, 13);
            this.VersionLB.TabIndex = 40;
            this.VersionLB.Text = "Version: 1.2";
            this.panel2.BackColor = Color.White;
            this.panel2.BackgroundImage = Resources.LauncherBackground4;
            this.panel2.BackgroundImageLayout = ImageLayout.Stretch;
            this.panel2.Controls.Add(this.GroupBoxEnhanced);
            this.panel2.Controls.Add(this.GroupBoxECEncryption);
            this.panel2.Controls.Add(this.ECKeys);
            this.panel2.Location = new Point(0, 0x99);
            this.panel2.Name = "panel2";
            this.panel2.Size = new Size(0x1f8, 0x9a);
            this.panel2.TabIndex = 0x2a;
            this.GroupBoxEnhanced.BackColor = Color.Transparent;
            this.GroupBoxEnhanced.Controls.Add(this.ECMajorLB);
            this.GroupBoxEnhanced.Controls.Add(this.ECMajor);
            this.GroupBoxEnhanced.Controls.Add(this.ECMinorLB);
            this.GroupBoxEnhanced.Controls.Add(this.ECBuildLB);
            this.GroupBoxEnhanced.Controls.Add(this.ECRevisionLB);
            this.GroupBoxEnhanced.Controls.Add(this.ECMinor);
            this.GroupBoxEnhanced.Controls.Add(this.ECBuild);
            this.GroupBoxEnhanced.Controls.Add(this.ECRevision);
            this.GroupBoxEnhanced.Controls.Add(this.CalculateECKeys);
            this.GroupBoxEnhanced.Font = new Font("Microsoft Sans Serif", 14.25f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.GroupBoxEnhanced.ForeColor = SystemColors.AppWorkspace;
            this.GroupBoxEnhanced.Location = new Point(12, 12);
            this.GroupBoxEnhanced.Name = "GroupBoxEnhanced";
            this.GroupBoxEnhanced.Size = new Size(230, 0x68);
            this.GroupBoxEnhanced.TabIndex = 0x25;
            this.GroupBoxEnhanced.TabStop = false;
            this.GroupBoxEnhanced.Text = "Enhanced Client";
            this.ECMajorLB.AutoSize = true;
            this.ECMajorLB.Font = new Font("Microsoft Sans Serif", 8.25f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.ECMajorLB.Location = new Point(6, 0x19);
            this.ECMajorLB.Name = "ECMajorLB";
            this.ECMajorLB.Size = new Size(0x21, 13);
            this.ECMajorLB.TabIndex = 10;
            this.ECMajorLB.Text = "Major";
            this.ECMajor.Font = new Font("Consolas", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.ECMajor.ForeColor = Color.Crimson;
            this.ECMajor.Location = new Point(7, 0x29);
            this.ECMajor.MaxLength = 4;
            this.ECMajor.Name = "ECMajor";
            this.ECMajor.ReadOnly = true;
            this.ECMajor.Size = new Size(0x31, 0x17);
            this.ECMajor.TabIndex = 0;
            this.ECMajor.Text = "4";
            this.ECMajor.TextAlign = HorizontalAlignment.Center;
            this.ECMinorLB.AutoSize = true;
            this.ECMinorLB.Font = new Font("Microsoft Sans Serif", 8.25f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.ECMinorLB.Location = new Point(0x3d, 0x19);
            this.ECMinorLB.Name = "ECMinorLB";
            this.ECMinorLB.Size = new Size(0x21, 13);
            this.ECMinorLB.TabIndex = 11;
            this.ECMinorLB.Text = "Minor";
            this.ECBuildLB.AutoSize = true;
            this.ECBuildLB.Font = new Font("Microsoft Sans Serif", 8.25f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.ECBuildLB.Location = new Point(0x74, 0x19);
            this.ECBuildLB.Name = "ECBuildLB";
            this.ECBuildLB.Size = new Size(30, 13);
            this.ECBuildLB.TabIndex = 12;
            this.ECBuildLB.Text = "Build";
            this.ECRevisionLB.AutoSize = true;
            this.ECRevisionLB.Font = new Font("Microsoft Sans Serif", 8.25f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.ECRevisionLB.Location = new Point(0xab, 0x19);
            this.ECRevisionLB.Name = "ECRevisionLB";
            this.ECRevisionLB.Size = new Size(0x30, 13);
            this.ECRevisionLB.TabIndex = 13;
            this.ECRevisionLB.Text = "Revision";
            this.ECMinor.Font = new Font("Consolas", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.ECMinor.ForeColor = Color.Crimson;
            this.ECMinor.Location = new Point(0x3e, 0x29);
            this.ECMinor.MaxLength = 4;
            this.ECMinor.Name = "ECMinor";
            this.ECMinor.Size = new Size(0x31, 0x17);
            this.ECMinor.TabIndex = 14;
            this.ECMinor.Text = "00";
            this.ECMinor.TextAlign = HorizontalAlignment.Center;
            this.ECBuild.Font = new Font("Consolas", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.ECBuild.ForeColor = Color.Crimson;
            this.ECBuild.Location = new Point(0x75, 0x29);
            this.ECBuild.MaxLength = 4;
            this.ECBuild.Name = "ECBuild";
            this.ECBuild.Size = new Size(0x31, 0x17);
            this.ECBuild.TabIndex = 15;
            this.ECBuild.Text = "00";
            this.ECBuild.TextAlign = HorizontalAlignment.Center;
            this.ECRevision.Font = new Font("Consolas", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.ECRevision.ForeColor = Color.Crimson;
            this.ECRevision.Location = new Point(0xac, 0x29);
            this.ECRevision.MaxLength = 4;
            this.ECRevision.Name = "ECRevision";
            this.ECRevision.Size = new Size(0x31, 0x17);
            this.ECRevision.TabIndex = 0x10;
            this.ECRevision.Text = "00";
            this.ECRevision.TextAlign = HorizontalAlignment.Center;
            this.CalculateECKeys.Font = new Font("Microsoft Sans Serif", 8.25f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.CalculateECKeys.ForeColor = SystemColors.ControlDarkDark;
            this.CalculateECKeys.Location = new Point(6, 0x43);
            this.CalculateECKeys.Name = "CalculateECKeys";
            this.CalculateECKeys.Size = new Size(0xd7, 0x1b);
            this.CalculateECKeys.TabIndex = 0x19;
            this.CalculateECKeys.Text = "Calculate Keys";
            this.CalculateECKeys.UseVisualStyleBackColor = true;
            this.CalculateECKeys.Click += new EventHandler(this.CalculateECKeys_Click);
            this.GroupBoxECEncryption.BackColor = Color.Transparent;
            this.GroupBoxECEncryption.Controls.Add(this.RadioButtonECTwo);
            this.GroupBoxECEncryption.Controls.Add(this.RadioButtonECBlowTwo);
            this.GroupBoxECEncryption.Controls.Add(this.RadioButtonECBlow);
            this.GroupBoxECEncryption.Controls.Add(this.RadioButtonECNoEncryption);
            this.GroupBoxECEncryption.Font = new Font("Microsoft Sans Serif", 14.25f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.GroupBoxECEncryption.ForeColor = SystemColors.AppWorkspace;
            this.GroupBoxECEncryption.Location = new Point(0xf8, 12);
            this.GroupBoxECEncryption.Name = "GroupBoxECEncryption";
            this.GroupBoxECEncryption.Size = new Size(0xf4, 0x68);
            this.GroupBoxECEncryption.TabIndex = 0x26;
            this.GroupBoxECEncryption.TabStop = false;
            this.GroupBoxECEncryption.Text = "Encryption Type";
            this.RadioButtonECTwo.AutoSize = true;
            this.RadioButtonECTwo.Checked = true;
            this.RadioButtonECTwo.Font = new Font("Microsoft Sans Serif", 8.25f, FontStyle.Bold, GraphicsUnit.Point, 0);
            this.RadioButtonECTwo.Location = new Point(0x99, 70);
            this.RadioButtonECTwo.Name = "RadioButtonECTwo";
            this.RadioButtonECTwo.Size = new Size(0x45, 0x11);
            this.RadioButtonECTwo.TabIndex = 3;
            this.RadioButtonECTwo.TabStop = true;
            this.RadioButtonECTwo.Text = "Twofish";
            this.RadioButtonECTwo.UseVisualStyleBackColor = true;
            this.RadioButtonECBlowTwo.AutoSize = true;
            this.RadioButtonECBlowTwo.Font = new Font("Microsoft Sans Serif", 8.25f, FontStyle.Bold, GraphicsUnit.Point, 0);
            this.RadioButtonECBlowTwo.Location = new Point(0x10, 70);
            this.RadioButtonECBlowTwo.Name = "RadioButtonECBlowTwo";
            this.RadioButtonECBlowTwo.Size = new Size(0x83, 0x11);
            this.RadioButtonECBlowTwo.TabIndex = 2;
            this.RadioButtonECBlowTwo.Text = "Blowfish + Twofish";
            this.RadioButtonECBlowTwo.UseVisualStyleBackColor = true;
            this.RadioButtonECBlow.AutoSize = true;
            this.RadioButtonECBlow.Font = new Font("Microsoft Sans Serif", 8.25f, FontStyle.Bold, GraphicsUnit.Point, 0);
            this.RadioButtonECBlow.Location = new Point(0x99, 0x25);
            this.RadioButtonECBlow.Name = "RadioButtonECBlow";
            this.RadioButtonECBlow.Size = new Size(0x48, 0x11);
            this.RadioButtonECBlow.TabIndex = 1;
            this.RadioButtonECBlow.Text = "Blowfish";
            this.RadioButtonECBlow.UseVisualStyleBackColor = true;
            this.RadioButtonECNoEncryption.AutoSize = true;
            this.RadioButtonECNoEncryption.Font = new Font("Microsoft Sans Serif", 8.25f, FontStyle.Bold, GraphicsUnit.Point, 0);
            this.RadioButtonECNoEncryption.Location = new Point(0x10, 0x25);
            this.RadioButtonECNoEncryption.Name = "RadioButtonECNoEncryption";
            this.RadioButtonECNoEncryption.Size = new Size(0x69, 0x11);
            this.RadioButtonECNoEncryption.TabIndex = 0;
            this.RadioButtonECNoEncryption.Text = "No Encryption";
            this.RadioButtonECNoEncryption.UseVisualStyleBackColor = true;
            this.ECKeys.Font = new Font("Consolas", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.ECKeys.Location = new Point(12, 0x7a);
            this.ECKeys.Name = "ECKeys";
            this.ECKeys.ReadOnly = true;
            this.ECKeys.Size = new Size(480, 0x17);
            this.ECKeys.TabIndex = 0x27;
            this.ECKeys.TextAlign = HorizontalAlignment.Center;
            base.AutoScaleDimensions = new SizeF(6f, 13f);
            base.AutoScaleMode = AutoScaleMode.Font;
            this.BackgroundImage = Resources.LauncherBackground2;
            this.BackgroundImageLayout = ImageLayout.Stretch;
            base.ClientSize = new Size(0x1f8, 0x133);
            base.Controls.Add(this.panel2);
            base.Controls.Add(this.panel1);
            base.FormBorderStyle = FormBorderStyle.FixedSingle;
            base.Icon = (Icon) manager.GetObject("$this.Icon");
            base.MaximizeBox = false;
            base.Name = "vCrypter";
            this.Text = "vCrypter 2012";
            this.GroupBoxClassic.ResumeLayout(false);
            this.GroupBoxClassic.PerformLayout();
            this.GroupBoxCEncryption.ResumeLayout(false);
            this.GroupBoxCEncryption.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.GroupBoxEnhanced.ResumeLayout(false);
            this.GroupBoxEnhanced.PerformLayout();
            this.GroupBoxECEncryption.ResumeLayout(false);
            this.GroupBoxECEncryption.PerformLayout();
            base.ResumeLayout(false);
        }

        private void LinkLabelAbout_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            new About().Show();
        }
    }
}

