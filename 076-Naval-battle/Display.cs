using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _076_Naval_battle
{
    class Display
    {

        public int Top {get; private set;}
        public int Left {get; private set;}
        public int Width {get; private set;}
        public int Height {get; private set;}

        private Coordinates _cursor;

        public Display(int left, int top, int width, int height)
        {
            Top = top;
            Left = left;
            Width = width;
            Height = height;

            InitializeDisplay();
            _cursor = new Coordinates(width / 2, height / 2);
        }

        public void RenderSector(Coordinates location, SectorState state, bool highlight = false)
        {
            if (highlight)
                SetHighlightColors();
            else
                SetStdColors();

            Console.SetCursorPosition(Left + 1 + location.X, Top + 1 + location.Y);
            Console.Write(Symbol(state));
        }

        public void RenderMap(SectorState[,] map)
        {
            for (int y = 0; y < map.GetLength(1); y++)
            {
                for (int x = 0; x < map.GetLength(0); x++)
                {
                    RenderSector(new Coordinates(x, y), map[x,y]);
                }
            }
        }

        private void InitializeDisplay()
        {
            // https://en.wikipedia.org/wiki/Box-drawing_character

            int right = Left + Width + 1;
            int bottom = Top + Height + 1;

            SetStdColors();
            Console.SetCursorPosition(Left, Top);
            Console.Write('╔');

            Console.SetCursorPosition(right, Top);
            Console.Write('╗');

            Console.SetCursorPosition(Left, bottom);
            Console.Write('╚');

            Console.SetCursorPosition(right, bottom);
            Console.Write('╝');

            for (int x = 0; x < Width; x++)
            {
                Console.SetCursorPosition(Left + x + 1, Top);
                Console.Write('═');
                Console.SetCursorPosition(Left + x + 1, bottom);
                Console.Write('═');
            }            
            
            for (int y = 0; y < Height; y++)
            {
                Console.SetCursorPosition(Left, Top + y + 1);
                Console.Write('║');
                Console.SetCursorPosition(right, Top + y + 1);
                Console.Write('║');
            }

            for (int x = 0; x < Width; x++)
            {
                for (int y = 0; y < Height; y++)
                {
                    Console.SetCursorPosition(Left + x + 1, Top + y + 1);
                    Console.Write(' ');
                }
            }
        }

        public void RenderScore(string message, bool highlight)
        {
            if (highlight)
                SetHighlightColors();
            else
                SetStdColors();

            Console.SetCursorPosition(Left + 1, Top + Height + 3);
            Console.Write(message);
        }

        private void SetStdColors()
        {
            Console.ForegroundColor = ConsoleColor.White;
            Console.BackgroundColor = ConsoleColor.Black;
        }

        private void SetHighlightColors()
        {
            Console.ForegroundColor = ConsoleColor.Black;
            Console.BackgroundColor = ConsoleColor.Yellow;
        }

        private char Symbol(SectorState state)
        {
            switch (state)
            {
                case SectorState.Ship:
                    return '█';
                case SectorState.Water:
                    return ' ';
                case SectorState.Shot:
                    return '-';
                case SectorState.Wreck:
                    return '#';
                default:
                    return '?';
            }
        }

        public Coordinates GetLocationFromKbd(SectorState[,] map)
        {
            //listen to keyboard, update cursor position, on space return

            while (true)
            {
                RenderSector(_cursor, map[_cursor.X, _cursor.Y], true);

                ConsoleKeyInfo keyInfo = Console.ReadKey(true);
                Coordinates newCursor = new Coordinates(_cursor.X, _cursor.Y);
                
                RenderSector(newCursor, map[newCursor.X, newCursor.Y], true);

                switch (keyInfo.Key)
                {
                    case ConsoleKey.UpArrow:
                        newCursor.Y--;
                        break;
                    case ConsoleKey.DownArrow:
                        newCursor.Y++;
                        break;
                    case ConsoleKey.LeftArrow:
                        newCursor.X--;
                        break;
                    case ConsoleKey.RightArrow:
                        newCursor.X++;
                        break;

                    case ConsoleKey.Spacebar:
                        return _cursor;

                    default:
                        continue;
                }

                //check if new cursor is valid
                if (IsValidLocation(newCursor)) {
                    //remove highlight
                    RenderSector(_cursor, map[_cursor.X, _cursor.Y]);

                    //store new cursor position
                    _cursor = newCursor;
                    
                }
            }
        }

        public bool IsValidLocation(Coordinates location)
        {
            return location.X >= 0 && location.X < Width && location.Y >= 0 && location.Y < Height;
        }
    }
}
