namespace TRSimulation
{
    public class ToyRobot
    {
        public int x;
        public int y;
        public string direction;
        public bool placed;

        public ToyRobot()
        {
            x = -1;
            y = -1;
            direction = "";
            placed = false;
        }
        public void Place(int x, int y, string direction)
        {
            this.x = x;
            this.y = y;
            this.direction = direction;
            placed = true;
        }
        public bool Move()
        {
            int newX = x;
            int newY = y;

            switch (direction)
            {
                case "NORTH":
                    newY++;
                    break;
                case "EAST":
                    newX++;
                    break;
                case "SOUTH":
                    newY--;
                    break;
                case "WEST":
                    newX--;
                    break;
            }

            if (IsValidPosition(newX, newY))
            {
                x = newX;
                y = newY;
                return true;
            }
            else
            {
                return false;
            }
        }
        public void Left()
        {
            switch (direction)
            {
                case "NORTH":
                    direction = "WEST";
                    break;
                case "EAST":
                    direction = "NORTH";
                    break;
                case "SOUTH":
                    direction = "EAST";
                    break;
                case "WEST":
                    direction = "SOUTH";
                    break;
            }
        }
        public void Right()
        {
            switch (direction)
            {
                case "NORTH":
                    direction = "EAST";
                    break;
                case "EAST":
                    direction = "SOUTH";
                    break;
                case "SOUTH":
                    direction = "WEST";
                    break;
                case "WEST":
                    direction = "NORTH";
                    break;
            }
            return;
        }
        public bool IsValidPosition(int x, int y)
        {
            return x >= 0 && x <= 4 && y >= 0 && y <= 4;
        }
        public bool IsValidDirection(string direction)
        {
            return direction == "NORTH" || direction == "EAST" || direction == "SOUTH" || direction == "WEST";
        }
    }
}
