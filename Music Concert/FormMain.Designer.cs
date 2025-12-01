namespace Music_Concert
{
    partial class FormMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            buttonBuyConcertTicket = new Button();
            labelNumberofTickets = new Label();
            textboxNumberofTickets = new TextBox();
            labelDiscTotalTickets = new Label();
            labelTicketNumberDisplay = new Label();
            labelTicketDisplay = new Label();
            dateTimePicker1 = new DateTimePicker();
            label1 = new Label();
            SuspendLayout();
            // 
            // buttonBuyConcertTicket
            // 
            buttonBuyConcertTicket.BackColor = Color.FromArgb(192, 192, 255);
            buttonBuyConcertTicket.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            buttonBuyConcertTicket.ForeColor = Color.Blue;
            buttonBuyConcertTicket.Location = new Point(108, 359);
            buttonBuyConcertTicket.Name = "buttonBuyConcertTicket";
            buttonBuyConcertTicket.Size = new Size(315, 76);
            buttonBuyConcertTicket.TabIndex = 0;
            buttonBuyConcertTicket.Text = "Buy Concert Ticket";
            buttonBuyConcertTicket.UseVisualStyleBackColor = false;
            buttonBuyConcertTicket.Click += buttonBuyConcertTicket_Click;
            // 
            // labelNumberofTickets
            // 
            labelNumberofTickets.AutoSize = true;
            labelNumberofTickets.BackColor = Color.FromArgb(192, 192, 255);
            labelNumberofTickets.ForeColor = Color.Blue;
            labelNumberofTickets.Location = new Point(36, 209);
            labelNumberofTickets.Name = "labelNumberofTickets";
            labelNumberofTickets.Size = new Size(261, 41);
            labelNumberofTickets.TabIndex = 1;
            labelNumberofTickets.Text = "Number of Tickets";
            // 
            // textboxNumberofTickets
            // 
            textboxNumberofTickets.BackColor = Color.FromArgb(192, 192, 255);
            textboxNumberofTickets.ForeColor = Color.Blue;
            textboxNumberofTickets.Location = new Point(380, 209);
            textboxNumberofTickets.Name = "textboxNumberofTickets";
            textboxNumberofTickets.Size = new Size(121, 47);
            textboxNumberofTickets.TabIndex = 2;
            textboxNumberofTickets.Text = "1";
            // 
            // labelDiscTotalTickets
            // 
            labelDiscTotalTickets.AutoSize = true;
            labelDiscTotalTickets.BackColor = Color.FromArgb(192, 192, 255);
            labelDiscTotalTickets.ForeColor = Color.Blue;
            labelDiscTotalTickets.Location = new Point(36, 546);
            labelDiscTotalTickets.Name = "labelDiscTotalTickets";
            labelDiscTotalTickets.Size = new Size(212, 41);
            labelDiscTotalTickets.TabIndex = 3;
            labelDiscTotalTickets.Text = "Total Tickets  $";
            // 
            // labelTicketNumberDisplay
            // 
            labelTicketNumberDisplay.AutoSize = true;
            labelTicketNumberDisplay.Location = new Point(307, 611);
            labelTicketNumberDisplay.Name = "labelTicketNumberDisplay";
            labelTicketNumberDisplay.Size = new Size(0, 41);
            labelTicketNumberDisplay.TabIndex = 4;
            // 
            // labelTicketDisplay
            // 
            labelTicketDisplay.AutoSize = true;
            labelTicketDisplay.BackColor = Color.FromArgb(192, 192, 255);
            labelTicketDisplay.ForeColor = Color.Blue;
            labelTicketDisplay.Location = new Point(324, 546);
            labelTicketDisplay.Name = "labelTicketDisplay";
            labelTicketDisplay.Size = new Size(34, 41);
            labelTicketDisplay.TabIndex = 5;
            labelTicketDisplay.Text = "0";
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.CalendarForeColor = Color.RoyalBlue;
            dateTimePicker1.CalendarMonthBackground = Color.FromArgb(192, 192, 255);
            dateTimePicker1.CalendarTitleBackColor = Color.FromArgb(192, 192, 255);
            dateTimePicker1.CalendarTitleForeColor = Color.Blue;
            dateTimePicker1.Location = new Point(12, 42);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(492, 47);
            dateTimePicker1.TabIndex = 6;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.FromArgb(192, 192, 255);
            label1.Font = new Font("Segoe Script", 20.1F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.RoyalBlue;
            label1.Location = new Point(1001, 492);
            label1.Name = "label1";
            label1.Size = new Size(967, 111);
            label1.TabIndex = 7;
            label1.Text = "Brandy and Monica Tour";
            // 
            // FormMain
            // 
            AutoScaleDimensions = new SizeF(17F, 41F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(2747, 1126);
            Controls.Add(label1);
            Controls.Add(dateTimePicker1);
            Controls.Add(labelTicketDisplay);
            Controls.Add(labelTicketNumberDisplay);
            Controls.Add(labelDiscTotalTickets);
            Controls.Add(textboxNumberofTickets);
            Controls.Add(labelNumberofTickets);
            Controls.Add(buttonBuyConcertTicket);
            Name = "FormMain";
            Text = "Concert Ticket Manager";
            Load += FormMain_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button buttonBuyConcertTicket;
        private Label labelNumberofTickets;
        private TextBox textboxNumberofTickets;
        private Label labelDiscTotalTickets;
        private Label labelTicketNumberDisplay;
        private Label labelTicketDisplay;
        private DateTimePicker dateTimePicker1;
        private Label label1;
    }
}
