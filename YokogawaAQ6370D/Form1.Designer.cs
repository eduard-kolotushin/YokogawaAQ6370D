namespace YokogawaAQ6370D
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
            this.Resolution_value = new System.Windows.Forms.NumericUpDown();
            this.Sweep_settings_groupBox = new System.Windows.Forms.GroupBox();
            this.Step_value = new System.Windows.Forms.NumericUpDown();
            this.Step_label = new System.Windows.Forms.Label();
            this.SensMod_label = new System.Windows.Forms.Label();
            this.SensMod_comboBox = new System.Windows.Forms.ComboBox();
            this.StopWL_value = new System.Windows.Forms.NumericUpDown();
            this.Span_value = new System.Windows.Forms.NumericUpDown();
            this.StartWL_value = new System.Windows.Forms.NumericUpDown();
            this.Span_label = new System.Windows.Forms.Label();
            this.StopWL_label = new System.Windows.Forms.Label();
            this.StartWL_label = new System.Windows.Forms.Label();
            this.Resolution_label = new System.Windows.Forms.Label();
            this.Connection_settings_groupBox = new System.Windows.Forms.GroupBox();
            this.Port_label = new System.Windows.Forms.Label();
            this.Port_value = new System.Windows.Forms.TextBox();
            this.IP_address_label = new System.Windows.Forms.Label();
            this.IP_value = new System.Windows.Forms.MaskedTextBox();
            this.programBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.form1BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.Try_to_connect_button = new System.Windows.Forms.Button();
            this.Response_textArea = new System.Windows.Forms.RichTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.Resolution_value)).BeginInit();
            this.Sweep_settings_groupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Step_value)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.StopWL_value)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Span_value)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.StartWL_value)).BeginInit();
            this.Connection_settings_groupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.programBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.form1BindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // Resolution_value
            // 
            this.Resolution_value.DecimalPlaces = 2;
            this.Resolution_value.Increment = new decimal(new int[] {
            1,
            0,
            0,
            131072});
            this.Resolution_value.Location = new System.Drawing.Point(99, 45);
            this.Resolution_value.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.Resolution_value.Name = "Resolution_value";
            this.Resolution_value.Size = new System.Drawing.Size(72, 20);
            this.Resolution_value.TabIndex = 0;
            // 
            // Sweep_settings_groupBox
            // 
            this.Sweep_settings_groupBox.Controls.Add(this.Step_value);
            this.Sweep_settings_groupBox.Controls.Add(this.Step_label);
            this.Sweep_settings_groupBox.Controls.Add(this.SensMod_label);
            this.Sweep_settings_groupBox.Controls.Add(this.SensMod_comboBox);
            this.Sweep_settings_groupBox.Controls.Add(this.StopWL_value);
            this.Sweep_settings_groupBox.Controls.Add(this.Span_value);
            this.Sweep_settings_groupBox.Controls.Add(this.StartWL_value);
            this.Sweep_settings_groupBox.Controls.Add(this.Span_label);
            this.Sweep_settings_groupBox.Controls.Add(this.StopWL_label);
            this.Sweep_settings_groupBox.Controls.Add(this.StartWL_label);
            this.Sweep_settings_groupBox.Controls.Add(this.Resolution_label);
            this.Sweep_settings_groupBox.Controls.Add(this.Resolution_value);
            this.Sweep_settings_groupBox.Location = new System.Drawing.Point(12, 221);
            this.Sweep_settings_groupBox.Name = "Sweep_settings_groupBox";
            this.Sweep_settings_groupBox.Size = new System.Drawing.Size(177, 177);
            this.Sweep_settings_groupBox.TabIndex = 2;
            this.Sweep_settings_groupBox.TabStop = false;
            this.Sweep_settings_groupBox.Text = "Sweep settings";
            // 
            // Step_value
            // 
            this.Step_value.DecimalPlaces = 1;
            this.Step_value.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.Step_value.Location = new System.Drawing.Point(99, 149);
            this.Step_value.Maximum = new decimal(new int[] {
            1100,
            0,
            0,
            0});
            this.Step_value.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.Step_value.Name = "Step_value";
            this.Step_value.Size = new System.Drawing.Size(72, 20);
            this.Step_value.TabIndex = 15;
            this.Step_value.Value = new decimal(new int[] {
            7,
            0,
            0,
            0});
            // 
            // Step_label
            // 
            this.Step_label.Location = new System.Drawing.Point(6, 149);
            this.Step_label.Name = "Step_label";
            this.Step_label.Size = new System.Drawing.Size(85, 20);
            this.Step_label.TabIndex = 16;
            this.Step_label.Text = "Step (nm)";
            this.Step_label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // SensMod_label
            // 
            this.SensMod_label.Location = new System.Drawing.Point(8, 19);
            this.SensMod_label.Name = "SensMod_label";
            this.SensMod_label.Size = new System.Drawing.Size(85, 20);
            this.SensMod_label.TabIndex = 9;
            this.SensMod_label.Text = "SensMod";
            this.SensMod_label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // SensMod_comboBox
            // 
            this.SensMod_comboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.SensMod_comboBox.FormattingEnabled = true;
            this.SensMod_comboBox.Location = new System.Drawing.Point(99, 19);
            this.SensMod_comboBox.Name = "SensMod_comboBox";
            this.SensMod_comboBox.Size = new System.Drawing.Size(72, 21);
            this.SensMod_comboBox.TabIndex = 10;
            // 
            // StopWL_value
            // 
            this.StopWL_value.DecimalPlaces = 1;
            this.StopWL_value.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.StopWL_value.Location = new System.Drawing.Point(99, 97);
            this.StopWL_value.Maximum = new decimal(new int[] {
            1700,
            0,
            0,
            0});
            this.StopWL_value.Minimum = new decimal(new int[] {
            600,
            0,
            0,
            0});
            this.StopWL_value.Name = "StopWL_value";
            this.StopWL_value.Size = new System.Drawing.Size(72, 20);
            this.StopWL_value.TabIndex = 13;
            this.StopWL_value.Value = new decimal(new int[] {
            1500,
            0,
            0,
            0});
            // 
            // Span_value
            // 
            this.Span_value.DecimalPlaces = 1;
            this.Span_value.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.Span_value.Location = new System.Drawing.Point(99, 123);
            this.Span_value.Maximum = new decimal(new int[] {
            1100,
            0,
            0,
            0});
            this.Span_value.Name = "Span_value";
            this.Span_value.Size = new System.Drawing.Size(72, 20);
            this.Span_value.TabIndex = 12;
            this.Span_value.Value = new decimal(new int[] {
            20,
            0,
            0,
            0});
            // 
            // StartWL_value
            // 
            this.StartWL_value.DecimalPlaces = 1;
            this.StartWL_value.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.StartWL_value.Location = new System.Drawing.Point(99, 71);
            this.StartWL_value.Maximum = new decimal(new int[] {
            1700,
            0,
            0,
            0});
            this.StartWL_value.Minimum = new decimal(new int[] {
            600,
            0,
            0,
            0});
            this.StartWL_value.Name = "StartWL_value";
            this.StartWL_value.Size = new System.Drawing.Size(72, 20);
            this.StartWL_value.TabIndex = 11;
            this.StartWL_value.Tag = "";
            this.StartWL_value.Value = new decimal(new int[] {
            800,
            0,
            0,
            0});
            // 
            // Span_label
            // 
            this.Span_label.Location = new System.Drawing.Point(6, 123);
            this.Span_label.Name = "Span_label";
            this.Span_label.Size = new System.Drawing.Size(85, 20);
            this.Span_label.TabIndex = 8;
            this.Span_label.Text = "Span (nm)";
            this.Span_label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // StopWL_label
            // 
            this.StopWL_label.Location = new System.Drawing.Point(6, 97);
            this.StopWL_label.Name = "StopWL_label";
            this.StopWL_label.Size = new System.Drawing.Size(85, 20);
            this.StopWL_label.TabIndex = 7;
            this.StopWL_label.Text = "StopWL (nm)";
            this.StopWL_label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // StartWL_label
            // 
            this.StartWL_label.Location = new System.Drawing.Point(6, 71);
            this.StartWL_label.Name = "StartWL_label";
            this.StartWL_label.Size = new System.Drawing.Size(85, 20);
            this.StartWL_label.TabIndex = 6;
            this.StartWL_label.Text = "StartWL (nm)";
            this.StartWL_label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Resolution_label
            // 
            this.Resolution_label.Location = new System.Drawing.Point(6, 45);
            this.Resolution_label.Name = "Resolution_label";
            this.Resolution_label.Size = new System.Drawing.Size(85, 20);
            this.Resolution_label.TabIndex = 0;
            this.Resolution_label.Text = "Resolution (nm)";
            this.Resolution_label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Connection_settings_groupBox
            // 
            this.Connection_settings_groupBox.Controls.Add(this.Response_textArea);
            this.Connection_settings_groupBox.Controls.Add(this.Try_to_connect_button);
            this.Connection_settings_groupBox.Controls.Add(this.Port_label);
            this.Connection_settings_groupBox.Controls.Add(this.Port_value);
            this.Connection_settings_groupBox.Controls.Add(this.IP_address_label);
            this.Connection_settings_groupBox.Controls.Add(this.IP_value);
            this.Connection_settings_groupBox.Location = new System.Drawing.Point(12, 12);
            this.Connection_settings_groupBox.Name = "Connection_settings_groupBox";
            this.Connection_settings_groupBox.Size = new System.Drawing.Size(177, 203);
            this.Connection_settings_groupBox.TabIndex = 3;
            this.Connection_settings_groupBox.TabStop = false;
            this.Connection_settings_groupBox.Text = "Connection settings";
            // 
            // Port_label
            // 
            this.Port_label.Location = new System.Drawing.Point(8, 46);
            this.Port_label.Name = "Port_label";
            this.Port_label.Size = new System.Drawing.Size(72, 20);
            this.Port_label.TabIndex = 3;
            this.Port_label.Text = "Port";
            this.Port_label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Port_value
            // 
            this.Port_value.Location = new System.Drawing.Point(84, 46);
            this.Port_value.Name = "Port_value";
            this.Port_value.Size = new System.Drawing.Size(87, 20);
            this.Port_value.TabIndex = 2;
            this.Port_value.Text = "10001";
            this.Port_value.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.Port_value.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Port_value_KeyDown);
            // 
            // IP_address_label
            // 
            this.IP_address_label.Location = new System.Drawing.Point(6, 19);
            this.IP_address_label.Name = "IP_address_label";
            this.IP_address_label.Size = new System.Drawing.Size(72, 20);
            this.IP_address_label.TabIndex = 1;
            this.IP_address_label.Text = "IP address";
            this.IP_address_label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // IP_value
            // 
            this.IP_value.Location = new System.Drawing.Point(84, 19);
            this.IP_value.Mask = "000.000.000.000";
            this.IP_value.Name = "IP_value";
            this.IP_value.Size = new System.Drawing.Size(87, 20);
            this.IP_value.TabIndex = 0;
            this.IP_value.Text = "1270  0  10";
            this.IP_value.TextMaskFormat = System.Windows.Forms.MaskFormat.IncludePromptAndLiterals;
            this.IP_value.KeyDown += new System.Windows.Forms.KeyEventHandler(this.IP_value_KeyDown);
            // 
            // programBindingSource
            // 
            this.programBindingSource.DataSource = typeof(YokogawaAQ6370D.Program);
            // 
            // form1BindingSource
            // 
            this.form1BindingSource.DataSource = typeof(YokogawaAQ6370D.Form1);
            // 
            // Try_to_connect_button
            // 
            this.Try_to_connect_button.Location = new System.Drawing.Point(6, 69);
            this.Try_to_connect_button.Name = "Try_to_connect_button";
            this.Try_to_connect_button.Size = new System.Drawing.Size(165, 30);
            this.Try_to_connect_button.TabIndex = 4;
            this.Try_to_connect_button.Text = "Try to connect";
            this.Try_to_connect_button.UseVisualStyleBackColor = true;
            this.Try_to_connect_button.Click += new System.EventHandler(this.Try_to_connect_button_Click);
            // 
            // Response_textArea
            // 
            this.Response_textArea.Location = new System.Drawing.Point(6, 101);
            this.Response_textArea.Name = "Response_textArea";
            this.Response_textArea.Size = new System.Drawing.Size(165, 96);
            this.Response_textArea.TabIndex = 5;
            this.Response_textArea.Text = "";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(424, 408);
            this.Controls.Add(this.Connection_settings_groupBox);
            this.Controls.Add(this.Sweep_settings_groupBox);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Resolution_value)).EndInit();
            this.Sweep_settings_groupBox.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Step_value)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.StopWL_value)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Span_value)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.StartWL_value)).EndInit();
            this.Connection_settings_groupBox.ResumeLayout(false);
            this.Connection_settings_groupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.programBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.form1BindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.NumericUpDown Resolution_value;
        private System.Windows.Forms.GroupBox Sweep_settings_groupBox;
        private System.Windows.Forms.Label Resolution_label;
        private System.Windows.Forms.Label Span_label;
        private System.Windows.Forms.Label StopWL_label;
        private System.Windows.Forms.Label StartWL_label;
        private System.Windows.Forms.Label SensMod_label;
        private System.Windows.Forms.ComboBox SensMod_comboBox;
        private System.Windows.Forms.BindingSource programBindingSource;
        private System.Windows.Forms.BindingSource form1BindingSource;
        private System.Windows.Forms.NumericUpDown StopWL_value;
        private System.Windows.Forms.NumericUpDown Span_value;
        private System.Windows.Forms.NumericUpDown StartWL_value;
        private System.Windows.Forms.NumericUpDown Step_value;
        private System.Windows.Forms.Label Step_label;
        private System.Windows.Forms.GroupBox Connection_settings_groupBox;
        private System.Windows.Forms.MaskedTextBox IP_value;
        private System.Windows.Forms.Label IP_address_label;
        private System.Windows.Forms.Label Port_label;
        private System.Windows.Forms.TextBox Port_value;
        private System.Windows.Forms.Button Try_to_connect_button;
        private System.Windows.Forms.RichTextBox Response_textArea;
    }
}

