namespace TRSimulation
{
    public partial class MainForm : Form
    {
        ToyRobot robot = new ToyRobot();
        public MainForm()
        {
            InitializeComponent();
        }
        private void PlaceButton_Click(object sender, EventArgs e)
        {
            string input = placeInputTextBox.Text.Trim();
            string[] parts = input.Split(',');

            // input validation
            if (parts.Length == 3 && int.TryParse(parts[0], out int a) && int.TryParse(parts[1], out int b) && robot.IsValidDirection(parts[2].ToUpper()))
            {
                string direction = parts[2].ToUpper();

                if (robot.IsValidPosition(a, b))
                {
                    clearGrid();
                    robot.Place(a,b, direction);
                    gridDataGridView.Rows[robot.x].Cells[robot.y].Style.BackColor = Color.Red;
                    messageLabel.Text = $"Toy robot placed at {robot.x},{robot.y},{direction}";
                }
                else
                {
                    messageLabel.Text = "Invalid position";
                }
            }
            else
            {
                messageLabel.Text = "Invalid format: X,Y,DIRECTION";
            }
        }
        private void MoveButton_Click(object sender, EventArgs e)
        {
            if (!robot.placed)
            {
                messageLabel.Text = "Toy robot has not been placed yet.";
                return;
            }
            if (robot.Move())
            {
                clearGrid();
                gridDataGridView.Rows[robot.x].Cells[robot.y].Style.BackColor = Color.Red; 
                messageLabel.Text = $"Toy robot placed at {robot.x},{robot.y},{robot.direction}";
            }
            else
            {
                messageLabel.Text = "Cant Move Further";

            }
        }
        private void ReportButton_Click(object sender, EventArgs e)
        {
           messageLabel.Text = $"Toy robot placed at {robot.x},{robot.y},{robot.direction}";
        }
        private void LeftButton_Click(object sender, EventArgs e)
        {
            if (!robot.placed)
            {
                messageLabel.Text = "Toy robot has not been placed yet.";
                return;
            }
            robot.Left();
        }
        private void RightButton_Click(object sender, EventArgs e)
        {
            if (!robot.placed)
            {
                messageLabel.Text = "Toy robot has not been placed yet.";
                return;
            }
            robot.Right();
        }
        private void ExitButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private void clearGrid()
        {
            foreach (DataGridViewRow row in gridDataGridView.Rows)
            {
                foreach (DataGridViewCell cell in row.Cells)
                {
                    cell.Style.BackColor = Color.White; // Change to default color
                }
            }
        }
    }
}
