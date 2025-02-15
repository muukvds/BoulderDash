class LevelData
{
    public static int Level_width = 40;
    public static int Level_height = 22;

    public char[,] GetLevel(int level)
    {
        switch (level)
        {
            case 1:
                return Level1;
            case 2:
                return Level2;
            case 3:
                return Level3;
            default:
                return null;
        }
    }

    public static char[,] Level1 = new char[22, 40]
    {
        { 'S','S','S','S','S','S','S','S','S','S','S','S','S','S','S','S','S','S','S','S','S','S','S','S','S','S','S','S','S','S','S','S','S','S','S','S','S','S','S','S' },
        { 'S','M','M','M','M','M','M',' ','M','M','D','M','B','M','M','M','M','M','M','B','M','B','M','M','M','M','M','M','M',' ','M','M','M','M','B','M','M','M','M','S' },
        { 'S','M','B','R','B','M','M','H','M','M','M',' ','M','M','M','M','M','M','M','M','M','B','D','M','M','B','M','M','M','M',' ','M','M','M','M','M',' ','M','M','S' },
        { 'S','M','M','M','M','M','M','H','M','M','T',' ','M','M',' ','M','M','M','M','M','B','M','B','M','M','B','M','M','M','M','M','M','M','M','B','M','M','M','M','S' },
        { 'S','B','M',' ','D','M','M','H','M','M','M','M','M','M','B','M','M','M','M','M','M','B','M','M','B','M','M','M','M','B','M','M','M','B','M','M','M','M','M','S' },
        { 'S','B','M','B','B','M','M','M','M','M','M','M','M','M','B','B','M','M','B','M','M','M','M','M','M','M','M','B','M','M','M','M','M','M','B','M','B',' ','M','S' },
        { 'S','M','M','M','B','M','M','B','M','M','M','M','M','M','M','M','B','M','M','M','M','M','B','M',' ','B','M','M','M','M','M','M','M','M','B','M','B','B','M','S' },
        { 'S','W','W','W','W','W','W','W','W','W','W','W','W','W','W','W','W','W','W','W','W','W','W','W','W','W','W','W','W','W','W','M','M','M','B','M','M','B','M','S' },
        { 'S','M',' ','M','M','M','B','M','M','D','M',' ','M','M','B','M','B','M','M','M','M','M','M','M','M','M','M','D','M','B',' ','M','M','M','M','M','M','B','M','S' },
        { 'S','M','M','D','M','M','M','M','M','B','M','M','M','M','M',' ','M','M','M','M','M','M','M','M','B',' ',' ','B','M','M','D','M','M','M','M','B','M','M','M','S' },
        { 'S','M','M','M','B','M','M','B','M','B','M','M','M','M','M','M','M','M','M','M','M','M','M','M','B','B','M','B','M','M','B','M','M','M','M','M','M','M','M','S' },
        { 'S','M',' ','M','M','M','M','M','B','M','M','T','M','M','M','M','M','B','B',' ','M','M','M','M','M','M','M','B','M','M','B','M','D','M','M','M','M',' ','M','S' },
        { 'S','M','B','M','M',' ','M','M','B','M','M','M','M','M','M','M','M','B','M','B','D','M','M','D','M','M','M','M','B','M','M','M','B','M','M','D','M','B','M','S' },
        { 'S','M','D','B','M','M','M','M','M','M','M','M','M','M','M','M','M','M','B','B','B','M','M','B','M','M','M','M','M','M','M','M','D','M','M','M','M','M','B','S' },
        { 'S','H','H','H','H','H','H','H','H','W','W','W','W','W','W','W','W','W','W','W','W','W','W','W','W','W','W','W','W','W','W','W','W','W','W','W','W','W','W','S' },
        { 'S',' ',' ','M','M','M','M','M','M','M','M','M',' ','M','M','M','D','M','M','M','M','B','M','M','M','M','M','B','M','M','M','B','M','M','M','M','M','M','M','S' },
        { 'S','B',' ','M','M','M','M','M','M','M','M','M','B','B','M','M','B','M','M','M','M','M','M','M','M','B','M','M','M','M','M','M','B','M','B',' ','M','M','E','S' },
        { 'S','M','B','M','M','B','M','M','M','M','M','M','M','M','B','M','M','M','M','M','B','M',' ',' ','M','M','M','M','D','M','M','M','B','M','B','B','M','M','M','S' },
        { 'S','M','M','M','M','B','D','M','M',' ','M','M','M','M','M','M','M','M','B','M','M','M','M','M','M','B','M','B','D','M','M','M','M','M','M','B','M','M','M','S' },
        { 'S','M','M','M',' ','M','M',' ','M','B','M','M','B','M','B','B','M','M','M','M','T','M','M','M','M','B','M','B','D','M','M','M','M','M','M','B','M','M','B','S' },
        { 'S','M','D','M','M','M','M','B','M','M','M','M','M',' ','M','M','M','M','M','M','M','M','M',' ','M','B','M','M','B','M','M','M','M','B','M','M','M','B','M','S' },
        { 'S','S','S','S','S','S','S','S','S','S','S','S','S','S','S','S','S','S','S','S','S','S','S','S','S','S','S','S','S','S','S','S','S','S','S','S','S','S','S','S' }
    };

    public static char[,] Level2 = new char[22, 40]
    {
        {'S','S','S','S','S','S','S','S','S','S','S','S','S','S','S','S','S','S','S','S','S','S','S','S','S','S','S','S','S','S','S','S','S','S','S','S','S','S','S','S' },
        {'S','M','B','M','M','B','M','M','W','M','B','M','M','M','D','M','W','M','M','M','T','M','B','M','W',' ','M','M','M','M','M','M','W','M','M','B','B','M','M','S' },
        {'S','M','M','M','M','M','M','M','W','M','M','M','M','M','M',' ','W','H',' ','M',' ','M','M','M','W',' ','M','M',' ','M','M','M','W','M','M','M','M',' ','M','S' },
        {'S',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ','B',' ','B','B',' ',' ',' ',' ',' ',' ','B',' ',' ','D',' ',' ',' ',' ',' ',' ',' ',' ','B',' ','S' },
        {'S','D','M','M','M','M','M','M','W','M','B','M','M','M','M','B','W','M','B','M',' ','M','M',' ','W','M','M','B','M','M','D','M','W','M','M','B','H','B','M','S' },
        {'S','M','M','M','M','M','M','M','W','M','B','M','M','M','M','B','W','M','B','M',' ',' ','M','M','W','M','M','M','M','M','B','M','W','M','M','H','T','H','M','S' },
        {'S','W','W','W','W','W','W','W','W','W','W','W','W','W','W','W','W','W','W','B',' ','W','W','W','W','W','W','W','W','W','W','W','W','W','W','H','H','H','W','S' },
        {'S','M','M','M','M','B','B','M','W','M','M',' ','M','M','M','M','W','M','M','M',' ','M','M','B','W','M','M','M','M',' ','M','M','W','M','M','M','M','M',' ','S' },
        {'S','M','M','M','M','M','M','M','W','M','M',' ','M','M','M','M','W','M','M','B',' ','M','M','M','W','M','M','M','M','B','M',' ','W','M','M','M','M','M','B','S' },
        {'S',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ','B',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ','B',' ',' ',' ',' ',' ',' ',' ',' ','B','S' },
        {'S','B','M','M','B','M','M','M','W','M','M','M','M','B','M','M','W','M','M','B','S','M','M','M','W','M','M','M','M','M','M','D','W',' ','M','M','M','M','M','S' },
        {'S','B','M','M','M','M','B','M','W','M','M','B','M','M','B','M','W','M','M','M',' ','M',' ',' ','W','M','M','M','M','M','M','M','W','B','M','M','M','B','M','S' },
        {'S','M','B','M','M','M','M','M','W','M','M','M','B','M','M','M','W','M','M','M',' ','M','B','B','W','M','M','M','M','M','M','M','W','B','B','M','M','B','M','S' },
        {'S','W','W','W','W','W','W','W','W','W','W','W','W','W','W','W','W','W','W','W',' ','W','W','W','W','W','W','W','W','W','W','W','W','W','W','W','W','W','W','S' },
        {'S','B','M',' ','F',' ','M','M','W','M','M','M','M','B','M','B','W','M','M','M',' ','M','M','M','W','M','B','D','M','M','B','M','W','M','M','M','M','M','M','S' },
        {'S','M','M','M','M','M',' ','M','W',' ','M','M','M','M','M','M','W','M','M',' ',' ','M','M','M','W',' ','M','M',' ','M','M','M','W','M',' ','M',' ',' ','M','S' },
        {'S','T',' ',' ',' ',' ',' ',' ',' ','B',' ',' ',' ',' ',' ',' ',' ',' ',' ','D',' ',' ',' ',' ',' ',' ',' ',' ','B',' ',' ',' ',' ',' ','B',' ','B','B',' ','S' },
        {'S','D','M','M',' ','M','B','M','W','B','M','M','M','M','B','M','W','M','B','M',' ','M','M','B','W','M','B','M','B','M','M','M','W','M','M','M','M','M','M','S' },
        {'S','M','M','M','M','M','B','M','W','B','M','M','D','M','M','M','W','M','M','M',' ',' ','M','M','W','M','M','B','M','M','M','M','W','M','M','M',' ',' ',' ','S' },
        {'S','M','D','M','M','M','B',' ','W','M','M',' ','M','M','M','M','W','M','R','D','B','B','M','M','W','M',' ','M','M','M','M','M','W','M','M','M','B','B','B','S' },
        {'S','M','B','M','M','M','M','B','W','M','M','B','M','M','B','M','W','M','S','M','B','M','M','M','W','M','M','M','M','B','M','B','W','M','M','M','M','B','M','S' },
        {'S','S','S','S','S','S','S','S','S','S','S','S','S','S','S','S','S','S','S','S','S','S','S','S','S','S','S','S','S','S','S','S','S','S','S','S','S','S','S','S' },
    };

    public static char[,] Level3 = new char[22, 40]
    {
        { 'S','S','S','S','S','S','S','S','S','S','S','S','S','S','S','S','S','S','S','S','S','S','S','S','S','S','S','S','S','S','S','S','S','S','S','S','S','S','S','S' },
        { 'S',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ','S' },
        { 'S',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ','S' },
        { 'S',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ','S' },
        { 'S',' ',' ','B','B','T',' ',' ',' ','B','B','B',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ','S' },
        { 'S',' ','M','M','M','M','M',' ','M','M','M','M','M','M','H','H','H','H','H','H','H','H','H','H','H','H',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ','S' },
        { 'S',' ','M',' ',' ',' ','M',' ','M',' ','T',' ','M','M','H','H',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ','S' },
        { 'S',' ','M',' ',' ',' ','M',' ','M',' ',' ',' ','M','M','H',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ','S' },
        { 'S',' ','M','F',' ',' ','M',' ','M','F',' ','M','M','M','H',' ',' ',' ',' ',' ',' ',' ','R',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ','S' },
        { 'S',' ','M',' ',' ',' ','M',' ','M',' ',' ',' ','M','M','H',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ','S' },
        { 'S',' ','M',' ',' ',' ','M',' ','M',' ',' ',' ','M','M','H',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ','S' },
        { 'S',' ','M','M','M','M','M',' ','M','M','M','M','M','M',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ','S' },
        { 'S',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ','S' },
        { 'S',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ','S' },
        { 'S',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ','S' },
        { 'S',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ','S' },
        { 'S',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ','S' },
        { 'S',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ','S' },
        { 'S',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ','S' },
        { 'S',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ','S' },
        { 'S',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ','S' },
        { 'S','S','S','S','S','S','S','S','S','S','S','S','S','S','S','S','S','S','S','S','S','S','S','S','S','S','S','S','S','S','S','S','S','S','S','S','S','S','S','S' }
    };
}

