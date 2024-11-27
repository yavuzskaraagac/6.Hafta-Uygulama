using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SatrancTahtasi
{
    class ChessBoard
    {
        // Satranç tahtası 8x8 boyutunda, her bir kareyi string olarak temsil ediyoruz
        private string[,] board = new string[8, 8];

        // Satranç tahtasında her bir kareyi temsil eden indeksleyici
        public string this[int row, int col]
        {
            get
            {
                // Geçersiz bir kareye erişim kontrolü
                if (row < 0 || row >= 8 || col < 0 || col >= 8)
                {
                    throw new ArgumentOutOfRangeException("Geçersiz bir kareye erişim.");
                }
                return board[row, col];
            }
            set
            {
                // Geçersiz bir kareye erişim kontrolü
                if (row < 0 || row >= 8 || col < 0 || col >= 8)
                {
                    throw new ArgumentOutOfRangeException("Geçersiz bir kareye taş yerleştirilmeye çalışılıyor.");
                }
                board[row, col] = value; // Taşı belirtilen kareye yerleştir
            }
        }

        // Satranç tahtasını yazdırma fonksiyonu (isteğe bağlı)
        public void PrintBoard()
        {
            for (int i = 0; i < 8; i++)
            {
                for (int j = 0; j < 8; j++)
                {
                    Console.Write(board[i, j] == null ? "[ ]" : $"[{board[i, j]}]");
                }
                Console.WriteLine();
            }
        }
    }

    class Program
    {
        static void Main()
        {
            // Satranç tahtasını oluşturuyoruz
            ChessBoard chessBoard = new ChessBoard();

            try
            {
                // İndeksleyici ile taşları yerleştiriyoruz
                chessBoard[0, 0] = "Rook";  // A1 karesi, Kale
                chessBoard[0, 1] = "Knight"; // B1 karesi, At
                chessBoard[0, 2] = "Bishop"; // C1 karesi, Fil

                // Satranç tahtasını yazdırıyoruz
                chessBoard.PrintBoard();

                // Geçersiz bir kareye erişmeye çalışıyoruz
                Console.WriteLine(chessBoard[8, 8]); // Bu geçersiz bir erişim
            }
            catch (ArgumentOutOfRangeException ex)
            {
                Console.WriteLine(ex.Message); // Geçersiz kareye erişim hatasını yakalıyoruz
                Console.ReadKey();
            }
        }
    }
}
