using System;

namespace GameOfLife{
    public class LifeEngine{
        public int CurrentGeneration { get; private set; }
        private bool[,] field;
        private readonly int rows;
        private readonly int columns;

        public LifeEngine(int rows, int columns, int density){
            this.rows = rows;
            this.columns = columns;
            field = new bool[columns, rows];
            Random random = new Random();
            for (int x = 0; x < columns; x++)
                for (int y = 0; y < rows; y++)
                    field[x, y] = random.Next(density) == 0;
        }

        public void NextGeneration(){
            var newField = new bool[columns, rows];
            for (int x = 0; x < columns; x++){
                for (int y = 0; y < rows; y++){
                    var NeighboursCount = CountNeighbours(x, y);
                    var hasLife = field[x, y];
                    if (!hasLife && NeighboursCount == 3)
                        newField[x, y] = true;
                    else if (hasLife && (NeighboursCount < 2 || NeighboursCount > 3))
                        newField[x, y] = false;
                    else
                        newField[x, y] = field[x, y];
                }
            }
            field = newField;
            CurrentGeneration++;
        }

        public bool[,] GetCrGeneration(){
            var result = new bool[columns, rows];
            for(int x = 0; x < columns; x++){
                for(int y = 0; y < rows; y++){
                    result[x, y] = field[x, y];
                }
            }
            return result;
        }

        private int CountNeighbours(int x, int y){
            int count = 0;
            for (int i = -1; i < 2; i++){
                for (int j = -1; j < 2; j++){
                    int col = (x + i + columns) % columns;
                    int row = (y + j + rows) % rows;
                    bool selfCheck = col == x && row == y;
                    bool hasLife = field[col, row];
                    if (hasLife && !selfCheck) count++;
                }
            }
            return count;
        }

        private bool ValidPosition(int x, int y){
            return x >= 0 && y >= 0 && x < columns && y < rows;
        }

        private void UpdateCell(int x, int y, bool state){
            if (ValidPosition(x,y)) field[x, y] = state;
        }

        public void AddCell(int x, int y){
            UpdateCell(x, y, true);
        }
        public void RemoveCell(int x, int y){
            UpdateCell(x, y, false);
        }
    }
}
