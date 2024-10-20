namespace tictactoe_
{
    public partial class Form1 : Form
    {
        private int x = 12, y = 12;
        private Button[,] buttons = new Button[3, 3];
        private int player;
        bool flag = false;
        public Form1()
        {
            InitializeComponent();
            this.Height = 700;
            this.Width = 900;
            player = 1;
            label1.Text = "Текущий ход: Игрок 1";
            for (int i = 0; i < buttons.Length / 3; i++)
            {
                for (int j = 0; j < buttons.Length / 3; j++)
                {
                    buttons[i, j] = new Button();
                    buttons[i, j].Size = new Size(200, 200);
                }
            }

        }

        private void rulesButton_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Игроки ходят поочередно.\r\nОдин игрок играет крестиками, другой — ноликами.\r\nИгрок не может сделать ход вне своего хода.\r\n");
        }

        private void restartButton_Click(object sender, EventArgs e)
        {

        }
    }
}
