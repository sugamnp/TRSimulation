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
                    giveRobotFace();
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
                giveRobotFace();
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
            clearGrid();
            messageLabel.Text = $"Toy robot placed at {robot.x},{robot.y},{robot.direction}";
            giveRobotFace();
        }

        private void RightButton_Click(object sender, EventArgs e)
        {
            if (!robot.placed)
            {
                messageLabel.Text = "Toy robot has not been placed yet.";
                return;
            }
            robot.Right();
            clearGrid();
            messageLabel.Text = $"Toy robot placed at {robot.x},{robot.y},{robot.direction}";
            giveRobotFace();

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
                    cell.Value = null; // Change to default color
                }
            }
        }

        private void giveRobotFace()
        {
            if (robot.direction == "EAST")
            {
                gridDataGridView.Rows[robot.x].Cells[robot.y].Value = "└[∴]┘";
            }
            else if (robot.direction == "WEST")
            {
                gridDataGridView.Rows[robot.x].Cells[robot.y].Value = "└[∵]┘";

            }
            else if (robot.direction == "NORTH")
            {
                gridDataGridView.Rows[robot.x].Cells[robot.y].Value = "[┐∵]┘";

            }
            else
            {
                gridDataGridView.Rows[robot.x].Cells[robot.y].Value = "└[∵┌]";
            }
        }
    }
}
