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
        private void MakeaMove(int row, int col)
        {
            Console.WriteLine("Klick!"); 

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


        // Ny metod för testknappen
        private void TestButtonClick()
        {
            Console.WriteLine("Button clicked!"); // Detta borde loggas i konsolen
        }



        //
        //------------------------------------------------------------------------------
        //------------------------------------------------------------------------------
        //------------------------------------------------------------------------------
        //

        // NY KOD SOM INTE ANVÄNDS ÄNNU - FELSÖK FÖRST ATT MAN KAN KLICKA
        // Funktion för att kolla om någon har vunnit
        // Bör anropas innuti MakeaMove framöver
        private char CheckWinner()
        {
            // Kontrollera rader (3 av samma av antingen X eller O och ej tom ' ')
            for (int row = 0; row < 3; row++)
            {
                if (board[row, 0] == board[row, 1] && board[row, 1] == board[row, 2] && board[row, 0] != ' ')
                {
                    return board[row, 0]; // Returnera vinnaren ('X' eller 'O')
                }
            }

            // Kontrollera kolumner
            for (int col = 0; col < 3; col++)
            {
                if (board[0, col] == board[1, col] && board[1, col] == board[2, col] && board[0, col] != ' ')
                {
                    return board[0, col];
                }
            }

            // Kontrollera diagonaler
            // Diagonal neråt
            if (board[0, 0] == board[1, 1] && board[1, 1] == board[2, 2] && board[0, 0] != ' ')
            {
                return board[0, 0];
            }
            // Diagonal uppåt
            if (board[0, 2] == board[1, 1] && board[1, 1] == board[2, 0] && board[0, 2] != ' ')
            {
                return board[0, 2];
            }

            // Ingen vinnare ännu
            return ' ';
        }


        // Funktion för att kolla om det är oavgjort
        // Bör anropas innuti MakeaMove framöver

        private bool CheckDraw()
        {
            // Om någon ruta är tom, så är det inte oavgjort
            for (int row = 0; row < 3; row++)
            {
                for (int col = 0; col < 3; col++)
                {
                    if (board[row, col] == ' ')
                    {
                        return false; //Brädet är inte fullt
                    }
                }
            }

            // Om alla rutor är fyllda, är det oavgjort
            return true;
        }


    }
}
