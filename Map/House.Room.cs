namespace OOPAdventure;

public partial class House
{
    private int CalculateRoomIndex(int column, int row)
    {
        return Math.Clamp(column, -1, Width) + Math.Clamp(row, -1, Height) * Width;
    }

    public void CreateRooms(int width, int height)
    {
        Width = Math.Clamp(width, 2, 10);
        Height = Math.Clamp(height, 2, 10);

        var total = Width * Height;

        Rooms = new Room[total];

        for (int i = 0; i < total; i++)
        {
            var tmpRoom = new Room();

            var column = i % Width;
            var row = i / Width;
            
            tmpRoom.Name = string.Format(Text.Language.DefaultRoomName, i, column, row);

            if (column < Width - 1)
            {
                tmpRoom.Neighbors[Directions.East] = CalculateRoomIndex(column + 1, row);
            }
            
            if (column > 0)
            {
                tmpRoom.Neighbors[Directions.West] = CalculateRoomIndex(column - 1, row);
            }
            
            if (row < height - 1)
            {
                tmpRoom.Neighbors[Directions.South] = CalculateRoomIndex(column, row + 1);
            }
            
            if (row > 0)
            {
                tmpRoom.Neighbors[Directions.North] = CalculateRoomIndex(column, row - 1);
            }

            Rooms[i] = tmpRoom;
        }
    }
}