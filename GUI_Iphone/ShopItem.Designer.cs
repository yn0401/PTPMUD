namespace GUI_Iphone
{
    partial class ShopItem
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ShopItem));
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges borderEdges1 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges();
            this.img_box1 = new System.Windows.Forms.PictureBox();
            this.bu_lbl_2 = new Bunifu.UI.WinForms.BunifuLabel();
            this.bu_rat1 = new Bunifu.UI.WinForms.BunifuRating();
            this.img_box2 = new System.Windows.Forms.PictureBox();
            this.bu_lbl_1 = new Bunifu.UI.WinForms.BunifuLabel();
            this.bu_btn_but1 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            this.bunifuCheckBox1 = new Bunifu.UI.WinForms.BunifuCheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.img_box1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.img_box2)).BeginInit();
            this.SuspendLayout();
            // 
            // img_box1
            // 
            this.img_box1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.img_box1.Image = ((System.Drawing.Image)(resources.GetObject("img_box1.Image")));
            this.img_box1.Location = new System.Drawing.Point(175, 13);
            this.img_box1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.img_box1.Name = "img_box1";
            this.img_box1.Size = new System.Drawing.Size(45, 36);
            this.img_box1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.img_box1.TabIndex = 0;
            this.img_box1.TabStop = false;
            this.img_box1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // bu_lbl_2
            // 
            this.bu_lbl_2.AllowParentOverrides = false;
            this.bu_lbl_2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.bu_lbl_2.AutoEllipsis = false;
            this.bu_lbl_2.CursorType = null;
            this.bu_lbl_2.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bu_lbl_2.ForeColor = System.Drawing.Color.Black;
            this.bu_lbl_2.Location = new System.Drawing.Point(5, 137);
            this.bu_lbl_2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.bu_lbl_2.Name = "bu_lbl_2";
            this.bu_lbl_2.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.bu_lbl_2.Size = new System.Drawing.Size(61, 19);
            this.bu_lbl_2.TabIndex = 7;
            this.bu_lbl_2.Text = "IPhone 13 ";
            this.bu_lbl_2.TextAlignment = System.Drawing.ContentAlignment.TopLeft;
            this.bu_lbl_2.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.Default;
            this.bu_lbl_2.Click += new System.EventHandler(this.bunifuLabel2_Click);
            // 
            // bu_rat1
            // 
            this.bu_rat1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.bu_rat1.BackColor = System.Drawing.Color.Transparent;
            this.bu_rat1.DisabledEmptyFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(212)))), ((int)(((byte)(212)))));
            this.bu_rat1.DisabledRatedFillColor = System.Drawing.Color.DarkGray;
            this.bu_rat1.EmptyBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(212)))), ((int)(((byte)(212)))));
            this.bu_rat1.EmptyFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(212)))), ((int)(((byte)(212)))));
            this.bu_rat1.HoverBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(217)))), ((int)(((byte)(20)))));
            this.bu_rat1.HoverFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(217)))), ((int)(((byte)(20)))));
            this.bu_rat1.InnerRadius = 2F;
            this.bu_rat1.Location = new System.Drawing.Point(5, 159);
            this.bu_rat1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.bu_rat1.Name = "bu_rat1";
            this.bu_rat1.OuterRadius = 10F;
            this.bu_rat1.RatedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(217)))), ((int)(((byte)(20)))));
            this.bu_rat1.RatedFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(217)))), ((int)(((byte)(20)))));
            this.bu_rat1.ReadOnly = false;
            this.bu_rat1.RightClickToClear = true;
            this.bu_rat1.Size = new System.Drawing.Size(121, 22);
            this.bu_rat1.TabIndex = 8;
            this.bu_rat1.Text = "bunifuRating1";
            this.bu_rat1.Value = 2;
            this.bu_rat1.ValueChanged += new System.EventHandler<Bunifu.UI.WinForms.BunifuRating.ValueChangedEventArgs>(this.bunifuRating1_ValueChanged);
            // 
            // img_box2
            // 
            this.img_box2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.img_box2.Image = ((System.Drawing.Image)(resources.GetObject("img_box2.Image")));
            this.img_box2.Location = new System.Drawing.Point(18, 54);
            this.img_box2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.img_box2.Name = "img_box2";
            this.img_box2.Size = new System.Drawing.Size(200, 69);
            this.img_box2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.img_box2.TabIndex = 9;
            this.img_box2.TabStop = false;
            // 
            // bu_lbl_1
            // 
            this.bu_lbl_1.AllowParentOverrides = false;
            this.bu_lbl_1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.bu_lbl_1.AutoEllipsis = false;
            this.bu_lbl_1.CursorType = null;
            this.bu_lbl_1.Font = new System.Drawing.Font("Segoe UI Semibold", 16F, System.Drawing.FontStyle.Bold);
            this.bu_lbl_1.ForeColor = System.Drawing.Color.Black;
            this.bu_lbl_1.Location = new System.Drawing.Point(20, 19);
            this.bu_lbl_1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.bu_lbl_1.Name = "bu_lbl_1";
            this.bu_lbl_1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.bu_lbl_1.Size = new System.Drawing.Size(46, 30);
            this.bu_lbl_1.TabIndex = 10;
            this.bu_lbl_1.Text = "$779";
            this.bu_lbl_1.TextAlignment = System.Drawing.ContentAlignment.TopLeft;
            this.bu_lbl_1.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.Default;
            // 
            // bu_btn_but1
            // 
            this.bu_btn_but1.AllowAnimations = true;
            this.bu_btn_but1.AllowMouseEffects = true;
            this.bu_btn_but1.AllowToggling = false;
            this.bu_btn_but1.AnimationSpeed = 200;
            this.bu_btn_but1.AutoGenerateColors = false;
            this.bu_btn_but1.AutoRoundBorders = false;
            this.bu_btn_but1.AutoSizeLeftIcon = true;
            this.bu_btn_but1.AutoSizeRightIcon = true;
            this.bu_btn_but1.BackColor = System.Drawing.Color.Transparent;
            this.bu_btn_but1.BackColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(122)))), ((int)(((byte)(183)))));
            this.bu_btn_but1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bu_btn_but1.BackgroundImage")));
            this.bu_btn_but1.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.bu_btn_but1.ButtonText = "Mua";
            this.bu_btn_but1.ButtonTextMarginLeft = 0;
            this.bu_btn_but1.ColorContrastOnClick = 45;
            this.bu_btn_but1.ColorContrastOnHover = 45;
            this.bu_btn_but1.Cursor = System.Windows.Forms.Cursors.Default;
            borderEdges1.BottomLeft = true;
            borderEdges1.BottomRight = true;
            borderEdges1.TopLeft = true;
            borderEdges1.TopRight = true;
            this.bu_btn_but1.CustomizableEdges = borderEdges1;
            this.bu_btn_but1.DialogResult = System.Windows.Forms.DialogResult.None;
            this.bu_btn_but1.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.bu_btn_but1.DisabledFillColor = System.Drawing.Color.Empty;
            this.bu_btn_but1.DisabledForecolor = System.Drawing.Color.Empty;
            this.bu_btn_but1.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton.ButtonStates.Pressed;
            this.bu_btn_but1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.bu_btn_but1.ForeColor = System.Drawing.Color.White;
            this.bu_btn_but1.IconLeft = null;
            this.bu_btn_but1.IconLeftAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bu_btn_but1.IconLeftCursor = System.Windows.Forms.Cursors.Default;
            this.bu_btn_but1.IconLeftPadding = new System.Windows.Forms.Padding(11, 3, 3, 3);
            this.bu_btn_but1.IconMarginLeft = 11;
            this.bu_btn_but1.IconPadding = 10;
            this.bu_btn_but1.IconRight = null;
            this.bu_btn_but1.IconRightAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.bu_btn_but1.IconRightCursor = System.Windows.Forms.Cursors.Default;
            this.bu_btn_but1.IconRightPadding = new System.Windows.Forms.Padding(3, 3, 7, 3);
            this.bu_btn_but1.IconSize = 25;
            this.bu_btn_but1.IdleBorderColor = System.Drawing.Color.Empty;
            this.bu_btn_but1.IdleBorderRadius = 0;
            this.bu_btn_but1.IdleBorderThickness = 0;
            this.bu_btn_but1.IdleFillColor = System.Drawing.Color.Empty;
            this.bu_btn_but1.IdleIconLeftImage = null;
            this.bu_btn_but1.IdleIconRightImage = null;
            this.bu_btn_but1.IndicateFocus = false;
            this.bu_btn_but1.Location = new System.Drawing.Point(155, 145);
            this.bu_btn_but1.Name = "bu_btn_but1";
            this.bu_btn_but1.OnDisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.bu_btn_but1.OnDisabledState.BorderRadius = 20;
            this.bu_btn_but1.OnDisabledState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.bu_btn_but1.OnDisabledState.BorderThickness = 2;
            this.bu_btn_but1.OnDisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.bu_btn_but1.OnDisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.bu_btn_but1.OnDisabledState.IconLeftImage = null;
            this.bu_btn_but1.OnDisabledState.IconRightImage = null;
            this.bu_btn_but1.onHoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(150)))), ((int)(((byte)(255)))));
            this.bu_btn_but1.onHoverState.BorderRadius = 20;
            this.bu_btn_but1.onHoverState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.bu_btn_but1.onHoverState.BorderThickness = 2;
            this.bu_btn_but1.onHoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(150)))), ((int)(((byte)(255)))));
            this.bu_btn_but1.onHoverState.ForeColor = System.Drawing.Color.White;
            this.bu_btn_but1.onHoverState.IconLeftImage = null;
            this.bu_btn_but1.onHoverState.IconRightImage = null;
            this.bu_btn_but1.OnIdleState.BorderColor = System.Drawing.Color.DodgerBlue;
            this.bu_btn_but1.OnIdleState.BorderRadius = 20;
            this.bu_btn_but1.OnIdleState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.bu_btn_but1.OnIdleState.BorderThickness = 2;
            this.bu_btn_but1.OnIdleState.FillColor = System.Drawing.Color.DodgerBlue;
            this.bu_btn_but1.OnIdleState.ForeColor = System.Drawing.Color.White;
            this.bu_btn_but1.OnIdleState.IconLeftImage = null;
            this.bu_btn_but1.OnIdleState.IconRightImage = null;
            this.bu_btn_but1.OnPressedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            this.bu_btn_but1.OnPressedState.BorderRadius = 20;
            this.bu_btn_but1.OnPressedState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.bu_btn_but1.OnPressedState.BorderThickness = 2;
            this.bu_btn_but1.OnPressedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            this.bu_btn_but1.OnPressedState.ForeColor = System.Drawing.Color.White;
            this.bu_btn_but1.OnPressedState.IconLeftImage = null;
            this.bu_btn_but1.OnPressedState.IconRightImage = null;
            this.bu_btn_but1.Size = new System.Drawing.Size(63, 37);
            this.bu_btn_but1.TabIndex = 11;
            this.bu_btn_but1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.bu_btn_but1.TextAlignment = System.Windows.Forms.HorizontalAlignment.Center;
            this.bu_btn_but1.TextMarginLeft = 0;
            this.bu_btn_but1.TextPadding = new System.Windows.Forms.Padding(0);
            this.bu_btn_but1.UseDefaultRadiusAndThickness = true;
            // 
            // bunifuCheckBox1
            // 
            this.bunifuCheckBox1.AllowBindingControlAnimation = true;
            this.bunifuCheckBox1.AllowBindingControlColorChanges = false;
            this.bunifuCheckBox1.AllowBindingControlLocation = true;
            this.bunifuCheckBox1.AllowCheckBoxAnimation = false;
            this.bunifuCheckBox1.AllowCheckmarkAnimation = true;
            this.bunifuCheckBox1.AllowOnHoverStates = true;
            this.bunifuCheckBox1.AutoCheck = true;
            this.bunifuCheckBox1.BackColor = System.Drawing.Color.Transparent;
            this.bunifuCheckBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuCheckBox1.BackgroundImage")));
            this.bunifuCheckBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.bunifuCheckBox1.BindingControlPosition = Bunifu.UI.WinForms.BunifuCheckBox.BindingControlPositions.Right;
            this.bunifuCheckBox1.BorderRadius = 12;
            this.bunifuCheckBox1.Checked = true;
            this.bunifuCheckBox1.CheckState = Bunifu.UI.WinForms.BunifuCheckBox.CheckStates.Checked;
            this.bunifuCheckBox1.Cursor = System.Windows.Forms.Cursors.Default;
            this.bunifuCheckBox1.CustomCheckmarkImage = null;
            this.bunifuCheckBox1.Location = new System.Drawing.Point(71, 137);
            this.bunifuCheckBox1.MinimumSize = new System.Drawing.Size(17, 17);
            this.bunifuCheckBox1.Name = "bunifuCheckBox1";
            this.bunifuCheckBox1.OnCheck.BorderColor = System.Drawing.Color.SpringGreen;
            this.bunifuCheckBox1.OnCheck.BorderRadius = 12;
            this.bunifuCheckBox1.OnCheck.BorderThickness = 2;
            this.bunifuCheckBox1.OnCheck.CheckBoxColor = System.Drawing.Color.SpringGreen;
            this.bunifuCheckBox1.OnCheck.CheckmarkColor = System.Drawing.Color.White;
            this.bunifuCheckBox1.OnCheck.CheckmarkThickness = 2;
            this.bunifuCheckBox1.OnDisable.BorderColor = System.Drawing.Color.LightGray;
            this.bunifuCheckBox1.OnDisable.BorderRadius = 12;
            this.bunifuCheckBox1.OnDisable.BorderThickness = 2;
            this.bunifuCheckBox1.OnDisable.CheckBoxColor = System.Drawing.Color.Transparent;
            this.bunifuCheckBox1.OnDisable.CheckmarkColor = System.Drawing.Color.LightGray;
            this.bunifuCheckBox1.OnDisable.CheckmarkThickness = 2;
            this.bunifuCheckBox1.OnHoverChecked.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            this.bunifuCheckBox1.OnHoverChecked.BorderRadius = 12;
            this.bunifuCheckBox1.OnHoverChecked.BorderThickness = 2;
            this.bunifuCheckBox1.OnHoverChecked.CheckBoxColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            this.bunifuCheckBox1.OnHoverChecked.CheckmarkColor = System.Drawing.Color.White;
            this.bunifuCheckBox1.OnHoverChecked.CheckmarkThickness = 2;
            this.bunifuCheckBox1.OnHoverUnchecked.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            this.bunifuCheckBox1.OnHoverUnchecked.BorderRadius = 12;
            this.bunifuCheckBox1.OnHoverUnchecked.BorderThickness = 1;
            this.bunifuCheckBox1.OnHoverUnchecked.CheckBoxColor = System.Drawing.Color.Transparent;
            this.bunifuCheckBox1.OnUncheck.BorderColor = System.Drawing.Color.DarkGray;
            this.bunifuCheckBox1.OnUncheck.BorderRadius = 12;
            this.bunifuCheckBox1.OnUncheck.BorderThickness = 1;
            this.bunifuCheckBox1.OnUncheck.CheckBoxColor = System.Drawing.Color.Transparent;
            this.bunifuCheckBox1.Size = new System.Drawing.Size(17, 17);
            this.bunifuCheckBox1.Style = Bunifu.UI.WinForms.BunifuCheckBox.CheckBoxStyles.Bunifu;
            this.bunifuCheckBox1.TabIndex = 12;
            this.bunifuCheckBox1.ThreeState = false;
            this.bunifuCheckBox1.ToolTipText = null;
            // 
            // ShopItem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.BackgroundColor = System.Drawing.Color.White;
            this.BorderColor = System.Drawing.Color.Gainsboro;
            this.BorderRadius = 5;
            this.Controls.Add(this.bunifuCheckBox1);
            this.Controls.Add(this.bu_btn_but1);
            this.Controls.Add(this.bu_lbl_1);
            this.Controls.Add(this.img_box2);
            this.Controls.Add(this.bu_rat1);
            this.Controls.Add(this.bu_lbl_2);
            this.Controls.Add(this.img_box1);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "ShopItem";
            this.Size = new System.Drawing.Size(236, 188);
            ((System.ComponentModel.ISupportInitialize)(this.img_box1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.img_box2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox img_box1;
        private Bunifu.UI.WinForms.BunifuLabel bu_lbl_2;
        private Bunifu.UI.WinForms.BunifuRating bu_rat1;
        private System.Windows.Forms.PictureBox img_box2;
        private Bunifu.UI.WinForms.BunifuLabel bu_lbl_1;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton bu_btn_but1;
        private Bunifu.UI.WinForms.BunifuCheckBox bunifuCheckBox1;
    }
}