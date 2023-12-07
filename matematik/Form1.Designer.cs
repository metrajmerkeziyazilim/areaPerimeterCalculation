namespace matematik
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
            squareMenu = new Button();
            rectangleMenu = new Button();
            circleMenu = new Button();
            calculationTitle = new Label();
            firstEdgeBox = new TextBox();
            firstEdgeLabel = new Label();
            AreaTitle = new Label();
            areaResult = new Label();
            PerimeterTitle = new Label();
            perimeterResult = new Label();
            squareCalculationButton = new Button();
            secondEdgeLabel = new Label();
            secondEdgeBox = new TextBox();
            panel1 = new Panel();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // squareMenu
            // 
            squareMenu.Font = new Font("Verdana", 9F, FontStyle.Bold, GraphicsUnit.Point);
            squareMenu.Location = new Point(48, 50);
            squareMenu.Name = "squareMenu";
            squareMenu.Size = new Size(123, 31);
            squareMenu.TabIndex = 0;
            squareMenu.Text = "Kare";
            squareMenu.UseVisualStyleBackColor = true;
            squareMenu.Click += button1_Click;
            // 
            // rectangleMenu
            // 
            rectangleMenu.Font = new Font("Verdana", 9F, FontStyle.Bold, GraphicsUnit.Point);
            rectangleMenu.Location = new Point(229, 50);
            rectangleMenu.Name = "rectangleMenu";
            rectangleMenu.Size = new Size(123, 31);
            rectangleMenu.TabIndex = 1;
            rectangleMenu.Text = "Dikdörtgen";
            rectangleMenu.UseVisualStyleBackColor = true;
            rectangleMenu.Click += rectangleMenu_Click;
            // 
            // circleMenu
            // 
            circleMenu.Font = new Font("Verdana", 9F, FontStyle.Bold, GraphicsUnit.Point);
            circleMenu.Location = new Point(412, 50);
            circleMenu.Name = "circleMenu";
            circleMenu.Size = new Size(123, 31);
            circleMenu.TabIndex = 2;
            circleMenu.Text = "Daire";
            circleMenu.UseVisualStyleBackColor = true;
            circleMenu.Click += circleMenu_Click;
            // 
            // calculationTitle
            // 
            calculationTitle.AutoSize = true;
            calculationTitle.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            calculationTitle.Location = new Point(54, 118);
            calculationTitle.Name = "calculationTitle";
            calculationTitle.Size = new Size(68, 30);
            calculationTitle.TabIndex = 3;
            calculationTitle.Text = "label1";
            // 
            // firstEdgeBox
            // 
            firstEdgeBox.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            firstEdgeBox.Location = new Point(253, 54);
            firstEdgeBox.Name = "firstEdgeBox";
            firstEdgeBox.Size = new Size(135, 29);
            firstEdgeBox.TabIndex = 4;
            // 
            // firstEdgeLabel
            // 
            firstEdgeLabel.AutoSize = true;
            firstEdgeLabel.Font = new Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Point);
            firstEdgeLabel.Location = new Point(32, 54);
            firstEdgeLabel.Name = "firstEdgeLabel";
            firstEdgeLabel.Size = new Size(133, 30);
            firstEdgeLabel.TabIndex = 5;
            firstEdgeLabel.Text = "Birinci Kenar";
            // 
            // AreaTitle
            // 
            AreaTitle.AutoSize = true;
            AreaTitle.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            AreaTitle.Location = new Point(32, 141);
            AreaTitle.Name = "AreaTitle";
            AreaTitle.Size = new Size(66, 30);
            AreaTitle.TabIndex = 6;
            AreaTitle.Text = "Alan :";
            // 
            // areaResult
            // 
            areaResult.AutoSize = true;
            areaResult.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            areaResult.Location = new Point(104, 141);
            areaResult.Name = "areaResult";
            areaResult.Size = new Size(24, 30);
            areaResult.TabIndex = 7;
            areaResult.Text = "0";
            // 
            // PerimeterTitle
            // 
            PerimeterTitle.AutoSize = true;
            PerimeterTitle.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            PerimeterTitle.Location = new Point(32, 183);
            PerimeterTitle.Name = "PerimeterTitle";
            PerimeterTitle.Size = new Size(66, 30);
            PerimeterTitle.TabIndex = 8;
            PerimeterTitle.Text = "Alan :";
            // 
            // perimeterResult
            // 
            perimeterResult.AutoSize = true;
            perimeterResult.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            perimeterResult.Location = new Point(104, 183);
            perimeterResult.Name = "perimeterResult";
            perimeterResult.Size = new Size(24, 30);
            perimeterResult.TabIndex = 9;
            perimeterResult.Text = "0";
            // 
            // squareCalculationButton
            // 
            squareCalculationButton.Font = new Font("Verdana", 9F, FontStyle.Bold, GraphicsUnit.Point);
            squareCalculationButton.Location = new Point(253, 182);
            squareCalculationButton.Name = "squareCalculationButton";
            squareCalculationButton.Size = new Size(117, 31);
            squareCalculationButton.TabIndex = 10;
            squareCalculationButton.Text = "Hesapla";
            squareCalculationButton.UseVisualStyleBackColor = true;
            squareCalculationButton.Click += squareCalculationButton_Click;
            // 
            // secondEdgeLabel
            // 
            secondEdgeLabel.AutoSize = true;
            secondEdgeLabel.Font = new Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Point);
            secondEdgeLabel.Location = new Point(32, 90);
            secondEdgeLabel.Name = "secondEdgeLabel";
            secondEdgeLabel.Size = new Size(124, 30);
            secondEdgeLabel.TabIndex = 11;
            secondEdgeLabel.Text = "İkinci Kenar";
            secondEdgeLabel.Visible = false;
            // 
            // secondEdgeBox
            // 
            secondEdgeBox.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            secondEdgeBox.Location = new Point(253, 91);
            secondEdgeBox.Name = "secondEdgeBox";
            secondEdgeBox.Size = new Size(135, 29);
            secondEdgeBox.TabIndex = 12;
            secondEdgeBox.Visible = false;
            // 
            // panel1
            // 
            panel1.Controls.Add(firstEdgeLabel);
            panel1.Controls.Add(secondEdgeBox);
            panel1.Controls.Add(firstEdgeBox);
            panel1.Controls.Add(secondEdgeLabel);
            panel1.Controls.Add(AreaTitle);
            panel1.Controls.Add(squareCalculationButton);
            panel1.Controls.Add(areaResult);
            panel1.Controls.Add(perimeterResult);
            panel1.Controls.Add(PerimeterTitle);
            panel1.Location = new Point(48, 151);
            panel1.Name = "panel1";
            panel1.Size = new Size(457, 311);
            panel1.TabIndex = 13;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveBorder;
            ClientSize = new Size(588, 527);
            Controls.Add(panel1);
            Controls.Add(calculationTitle);
            Controls.Add(circleMenu);
            Controls.Add(rectangleMenu);
            Controls.Add(squareMenu);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button squareMenu;
        private Button rectangleMenu;
        private Button circleMenu;
        private Label calculationTitle;
        private TextBox firstEdgeBox;
        private Label firstEdgeLabel;
        private Label AreaTitle;
        private Label areaResult;
        private Label PerimeterTitle;
        private Label perimeterResult;
        private Button squareCalculationButton;
        private Label secondEdgeLabel;
        private TextBox secondEdgeBox;
        private Panel panel1;
    }
}