namespace TRSimulation
{
    partial class MainForm
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.DataGridView gridDataGridView;
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }
        private void InitializeComponent()
        {
            placeInputTextBox = new System.Windows.Forms.TextBox();
            placeButton = new System.Windows.Forms.Button();
            moveButton = new System.Windows.Forms.Button();
            reportButton = new System.Windows.Forms.Button();
            exitButton = new System.Windows.Forms.Button();
            leftButton = new System.Windows.Forms.Button();
            rightButton = new System.Windows.Forms.Button();
            gridDataGridView = new System.Windows.Forms.DataGridView();
            messageLabel = new System.Windows.Forms.Label();
            northLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)gridDataGridView).BeginInit();
            SuspendLayout();
            
            // placeInputTextBox
            placeInputTextBox.Location = new System.Drawing.Point(12, 12);
            placeInputTextBox.Name = "placeInputTextBox";
            placeInputTextBox.Size = new System.Drawing.Size(75, 20);
            placeInputTextBox.TabIndex = 0;
            
            // placeButton           
            placeButton.Location = new System.Drawing.Point(93, 10);
            placeButton.Name = "placeButton";
            placeButton.Size = new System.Drawing.Size(75, 23);
            placeButton.TabIndex = 1;
            placeButton.Text = "PLACE";
            placeButton.UseVisualStyleBackColor = true;
            placeButton.Click += PlaceButton_Click;
            
            // moveButton          
            moveButton.Location = new System.Drawing.Point(12, 41);
            moveButton.Name = "moveButton";
            moveButton.Size = new System.Drawing.Size(75, 23);
            moveButton.TabIndex = 2;
            moveButton.Text = "MOVE";
            moveButton.UseVisualStyleBackColor = true;
            moveButton.Click += MoveButton_Click;
            
            // reportButton          
            reportButton.Location = new System.Drawing.Point(93, 41);
            reportButton.Name = "reportButton";
            reportButton.Size = new System.Drawing.Size(75, 23);
            reportButton.TabIndex = 3;
            reportButton.Text = "REPORT";
            reportButton.UseVisualStyleBackColor = true;
            reportButton.Click += ReportButton_Click;
            
            // leftButton         
            leftButton.Location = new System.Drawing.Point(93, 70);
            leftButton.Name = "leftButton";
            leftButton.Size = new System.Drawing.Size(75, 23);
            leftButton.TabIndex = 5;
            leftButton.Text = "LEFT";
            leftButton.UseVisualStyleBackColor = true;
            leftButton.Click += LeftButton_Click;
            
            // rightButton 
            rightButton.Location = new System.Drawing.Point(12, 99);
            rightButton.Name = "rightButton";
            rightButton.Size = new System.Drawing.Size(75, 23);
            rightButton.TabIndex = 6;
            rightButton.Text = "RIGHT";
            rightButton.UseVisualStyleBackColor = true;
            rightButton.Click += RightButton_Click;          

            // exitButton
            exitButton.Location = new System.Drawing.Point(12, 70);
            exitButton.Name = "exitButton";
            exitButton.Size = new System.Drawing.Size(75, 23);
            exitButton.TabIndex = 4;
            exitButton.Text = "EXIT";
            exitButton.UseVisualStyleBackColor = true;
            exitButton.Click += ExitButton_Click;

            // gridDataGridView
            gridDataGridView.Location = new System.Drawing.Point(12, 128);
            gridDataGridView.Name = "gridDataGridView";
            gridDataGridView.ScrollBars = System.Windows.Forms.ScrollBars.None;
            gridDataGridView.Size = new System.Drawing.Size(125, 125);
            gridDataGridView.GridColor = Color.OrangeRed;
            gridDataGridView.DefaultCellStyle.Font = new Font("Arial", 6, FontStyle.Bold); 
            gridDataGridView.RowCount = 5; // 5x5 grid
            gridDataGridView.ColumnCount = 5;

            // Set the row height and column width
            for (int i = 0; i < gridDataGridView.RowCount; i++)
            {
                gridDataGridView.Rows[i].Height = gridDataGridView.Height / gridDataGridView.RowCount + 4;
                gridDataGridView.Rows[i].Resizable = DataGridViewTriState.False;

            }

            for (int j = 0; j < gridDataGridView.ColumnCount; j++)
            {
                gridDataGridView.Columns[j].Width = gridDataGridView.Width / gridDataGridView.ColumnCount + 4;
                gridDataGridView.Columns[j].Resizable = DataGridViewTriState.False;
            }

            // Disable cell selection and header visibility
            gridDataGridView.ColumnHeadersVisible = false;
            gridDataGridView.RowHeadersVisible = false;
            gridDataGridView.ReadOnly = true;
            gridDataGridView.Enabled = false;

            // messageLabel
            messageLabel.AutoSize = true;
            messageLabel.Location = new System.Drawing.Point(12, 256);
            messageLabel.Name = "messageLabel";
            messageLabel.Size = new System.Drawing.Size(35, 13);
            messageLabel.TabIndex = 8;
            messageLabel.Text = "robot not placed";

            // northLabel
            northLabel.AutoSize = true;
            northLabel.Location = new System.Drawing.Point(137, 175);
            northLabel.Name = "North";
            northLabel.Size = new System.Drawing.Size(35, 13);
            northLabel.TabIndex = 8;
            northLabel.Text = "North->";

            // MainForm 
            AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(180, 278);
            Controls.Add(messageLabel);
            Controls.Add(northLabel);
            Controls.Add(reportButton);
            Controls.Add(gridDataGridView);
            Controls.Add(rightButton);
            Controls.Add(leftButton);
            Controls.Add(exitButton);
            Controls.Add(reportButton);
            Controls.Add(moveButton);
            Controls.Add(placeButton);
            Controls.Add(placeInputTextBox);
            Name = "MainForm";
            Text = "Toy Robot Simulator";
            ((System.ComponentModel.ISupportInitialize)gridDataGridView).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        private System.Windows.Forms.TextBox placeInputTextBox;
        private System.Windows.Forms.Button placeButton;
        private System.Windows.Forms.Button moveButton;
        private System.Windows.Forms.Button reportButton;
        private System.Windows.Forms.Button leftButton;
        private System.Windows.Forms.Button rightButton;
        private System.Windows.Forms.Button exitButton;
        private System.Windows.Forms.Label messageLabel;
        private System.Windows.Forms.Label northLabel;

    }
}
