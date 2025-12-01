namespace Music_Concert
{
    public partial class FormMain : Form
    {
        int m_ticketPrice = 50;
        // Start Sim with 0 dollars
        int m_totalTicketsSold = 0;
        // Number of Tickets
        int m_numberofTickets = 1;
        // Total tickets sold
        int m_totalTicketSale = 0;
        public FormMain()
        {
            InitializeComponent();
        }

        private void FormMain_Load(object sender, EventArgs e)
        {

        }

        private void buttonBuyConcertTicket_Click(object sender, EventArgs e)
        {
            //Set the number of tickets in the text box to the m_numberofTickets variable before calculating total sales.
            //We have to change the data type of text to int tom move the data from this textbox to our int variable.
            // All this line is doing is getting the number of tickets for this sale from our GUI.
            //So this line wouldn't be good to move since it interacts with the GUI>
            m_numberofTickets = int.Parse(textboxNumberofTickets.Text);
            // Lets get a total sales price by using our business logic DLL.
            //Since calculations do not interact with the GUI directly.
            //This line does not interact with the GUI so it is good to move to business logic later.
            
            //Create an object of the class so we can use that object.
            BusinessLogic.Transactions object_transactions = new BusinessLogic.Transactions();
            m_totalTicketSale = object_transactions.CalculateTotalTicketSale(m_numberofTickets, m_ticketPrice);
            // Every time someone buys a ticket our label of total ticket should increase by the total ticket price.
            // Buy Concert Ticket Button
            m_totalTicketsSold = m_totalTicketsSold + m_totalTicketSale;
            // Let's update display the total ticket sold in the lablel ticket display.
            labelTicketDisplay.Text = m_totalTicketsSold.ToString();
            

        }
    }
}
