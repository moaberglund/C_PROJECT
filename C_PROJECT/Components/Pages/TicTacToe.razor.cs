namespace C_PROJECT.Components.Pages
{
    public partial class TicTacToe
    {
        // skapa bädet
        char[,] board = {
                { ' ', ' ', ' '},
                { ' ', ' ', ' ' },
                { ' ', ' ', ' ' } };
        
        // skapa spelare
        char player = 'X';

        public TicTacToe() { }



        // Funktionen för att göra ett drag
        // Gör asynkron => async Task
        private async Task MakeaMove(int row, int col)
        {
            // Kolla om ruta är ledig
            if (board[row, col] != ' ')
            {
                return; //Gör ingenting om upptagen
            }

            // sätt spelarens tecken i rutan
            board[row, col] = player;

            // Växla mellan spelare
            // om player är x, då blir nästa o, annars x
            player = player == 'X' ? 'O' : 'X';

            //Uppdatera gränssnitt
            StateHasChanged();

        }

        // Funktion för att starta om spelet
        private void RestartGame()
        {
    
        }
    }
}
