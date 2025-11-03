namespace PostmanCloneUI
{
    partial class Dashboard
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
            formHeader = new Label();
            apiLabel = new Label();
            apiText = new TextBox();
            callApi = new Button();
            resultsLabel = new Label();
            resultsText = new TextBox();
            statusStrip = new StatusStrip();
            systemStatus = new ToolStripStatusLabel();
            statusStrip.SuspendLayout();
            SuspendLayout();
            // 
            // formHeader
            // 
            formHeader.AutoSize = true;
            formHeader.Font = new Font("Segoe UI", 25.8000011F, FontStyle.Regular, GraphicsUnit.Point, 0);
            formHeader.Location = new Point(95, 64);
            formHeader.Name = "formHeader";
            formHeader.Size = new Size(317, 60);
            formHeader.TabIndex = 0;
            formHeader.Text = "Postman Clone";
            // 
            // apiLabel
            // 
            apiLabel.AutoSize = true;
            apiLabel.Location = new Point(95, 176);
            apiLabel.Name = "apiLabel";
            apiLabel.Size = new Size(69, 41);
            apiLabel.TabIndex = 1;
            apiLabel.Text = "API:";
            // 
            // apiText
            // 
            apiText.BorderStyle = BorderStyle.FixedSingle;
            apiText.Location = new Point(170, 170);
            apiText.Name = "apiText";
            apiText.Size = new Size(603, 47);
            apiText.TabIndex = 2;
            // 
            // callApi
            // 
            callApi.Location = new Point(779, 169);
            callApi.Name = "callApi";
            callApi.Size = new Size(75, 47);
            callApi.TabIndex = 3;
            callApi.Text = "Go";
            callApi.UseVisualStyleBackColor = true;
            callApi.Click += callApi_Click;
            // 
            // resultsLabel
            // 
            resultsLabel.AutoSize = true;
            resultsLabel.Location = new Point(95, 251);
            resultsLabel.Name = "resultsLabel";
            resultsLabel.Size = new Size(111, 41);
            resultsLabel.TabIndex = 4;
            resultsLabel.Text = "Results";
            // 
            // resultsText
            // 
            resultsText.BackColor = Color.White;
            resultsText.BorderStyle = BorderStyle.FixedSingle;
            resultsText.Location = new Point(95, 304);
            resultsText.Multiline = true;
            resultsText.Name = "resultsText";
            resultsText.ReadOnly = true;
            resultsText.ScrollBars = ScrollBars.Both;
            resultsText.Size = new Size(759, 467);
            resultsText.TabIndex = 5;
            // 
            // statusStrip
            // 
            statusStrip.BackColor = Color.White;
            statusStrip.ImageScalingSize = new Size(20, 20);
            statusStrip.Items.AddRange(new ToolStripItem[] { systemStatus });
            statusStrip.Location = new Point(0, 830);
            statusStrip.Name = "statusStrip";
            statusStrip.Size = new Size(953, 37);
            statusStrip.TabIndex = 6;
            statusStrip.Text = "System status";
            // 
            // systemStatus
            // 
            systemStatus.BackColor = Color.White;
            systemStatus.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            systemStatus.Name = "systemStatus";
            systemStatus.Size = new Size(76, 31);
            systemStatus.Text = "Ready";
            // 
            // Dashboard
            // 
            AutoScaleDimensions = new SizeF(17F, 41F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(953, 867);
            Controls.Add(statusStrip);
            Controls.Add(resultsText);
            Controls.Add(resultsLabel);
            Controls.Add(callApi);
            Controls.Add(apiText);
            Controls.Add(apiLabel);
            Controls.Add(formHeader);
            Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Margin = new Padding(6);
            Name = "Dashboard";
            Text = "Postman Clone by Ivan F";
            statusStrip.ResumeLayout(false);
            statusStrip.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label formHeader;
        private Label apiLabel;
        private TextBox apiText;
        private Button callApi;
        private Label resultsLabel;
        private TextBox resultsText;
        private StatusStrip statusStrip;
        private ToolStripStatusLabel systemStatus;
    }
}
