using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;



namespace Dama_Oyunu2
{
    public partial class Form1 : Form
    {
        private Panel[,] squares = new Panel[8, 8];
        private Label[,] pieces = new Label[8, 8];

        private Label selectedPiece = null;
        private int selectedRow = -1;
        private int selectedCol = -1;

        private bool isBlackTurn = true;
        private int blackScore = 0;
        private int whiteScore = 0;

        public Form1()
        {
            InitializeComponent();
            CreateBoard();
            PlacePieces();
        }

        private void Form1_Load(object sender, EventArgs e)
        { }
        // Form yüklendiğinde çalışacak kodlar buraya yazılabilir.

        private void CreateBoard()
        {
            int tileSize = 70;

            for (int row = 0; row < 8; row++)
            {
                for (int col = 0; col < 8; col++)
                {
                    Panel panel = new Panel();
                    panel.Size = new Size(tileSize, tileSize);
                    panel.Location = new Point(col * tileSize, row * tileSize);
                    panel.BackColor = (row + col) % 2 == 0 ? Color.White : Color.Black;
                    panel.BorderStyle = BorderStyle.FixedSingle;
                    panel.Click += Panel_Click;
                    panel.Tag = (row, col);

                    this.Controls.Add(panel);
                    squares[row, col] = panel;
                }
            }

            this.ClientSize = new Size(8 * tileSize, 8 * tileSize);
        }

        private void PlacePieces()
        {
            for (int row = 1; row < 3; row++)
                for (int col = 0; col < 8; col++)
                    CreatePiece(row, col, "white");

            for (int row = 5; row < 7; row++)
                for (int col = 0; col < 8; col++)
                    CreatePiece(row, col, "black");

            for (int row = 3; row < 5; row++)
                for (int col = 0; col < 8; col++)
                {
                    if (pieces[row, col] != null)
                    {
                        squares[row, col].Controls.Remove(pieces[row, col]);
                        pieces[row, col] = null;
                    }
                }
        }

        private void CreatePiece(int row, int col, string color)
        {
            Label piece = new Label();
            piece.Text = color == "black" ? "●" : "○";
            piece.ForeColor = color == "black" ? Color.Red : Color.Green;
            piece.Font = new Font(FontFamily.GenericSansSerif, 30, FontStyle.Bold);
            piece.TextAlign = ContentAlignment.MiddleCenter;
            piece.Dock = DockStyle.Fill;
            piece.Click += Piece_Click;

            piece.Tag = (row, col, color, false); // 4'lük tuple

            squares[row, col].Controls.Add(piece);
            pieces[row, col] = piece;
        }

        private void Piece_Click(object sender, EventArgs e)
        {
            Label clickedPiece = sender as Label;
            if (clickedPiece == null)
                return;

            var (_, _, color, _) = (ValueTuple<int, int, string, bool>)clickedPiece.Tag;
            bool isBlackPiece = color == "black";

            if (isBlackTurn != isBlackPiece)
                return;

            if (selectedPiece != null)
                selectedPiece.BackColor = Color.Transparent;

            selectedPiece = clickedPiece;
            var (row, col, _, _) = (ValueTuple<int, int, string, bool>)selectedPiece.Tag;
            selectedRow = row;
            selectedCol = col;

            selectedPiece.BackColor = Color.Yellow;
        }

        private void Panel_Click(object sender, EventArgs e)
        {
            if (selectedPiece == null)
                return;

            Panel targetPanel = sender as Panel;
            var (targetRow, targetCol) = FindPanelPosition(targetPanel);

            bool captured;
            int capRow, capCol;

            if (!IsValidMove(selectedRow, selectedCol, targetRow, targetCol, out captured, out capRow, out capCol))
                return;

            if (captured)
            {
                var middlePiece = pieces[capRow, capCol];
                if (middlePiece != null)
                {
                    var (_, _, middleColor, _) = (ValueTuple<int, int, string, bool>)middlePiece.Tag;
                    if (middleColor == "black") whiteScore++;
                    else blackScore++;

                    squares[capRow, capCol].Controls.Remove(middlePiece);
                    pieces[capRow, capCol] = null;

                    CheckWin();
                }
            }

            squares[targetRow, targetCol].Controls.Add(selectedPiece);
            pieces[targetRow, targetCol] = selectedPiece;
            pieces[selectedRow, selectedCol] = null;

            var (_, _, selectedColor, _) = (ValueTuple<int, int, string, bool>)selectedPiece.Tag;

            if ((selectedColor == "black" && targetRow == 0) || (selectedColor == "white" && targetRow == 7))
            {
                selectedPiece.Text = "♛";
                selectedPiece.Tag = (targetRow, targetCol, selectedColor, true);
            }
            else
            {
                selectedPiece.Tag = (targetRow, targetCol, selectedColor, false);
            }

            selectedPiece.BackColor = Color.Transparent;
            selectedPiece = null;

            if (!captured)
                isBlackTurn = !isBlackTurn;
        }

        private bool IsValidMove(int fromRow, int fromCol, int toRow, int toCol, out bool captured, out int capRow, out int capCol)
        {
            captured = false;
            capRow = -1;
            capCol = -1;

            if (toRow < 0 || toRow >= 8 || toCol < 0 || toCol >= 8)
                return false;

            if (pieces[toRow, toCol] != null)
                return false;

            var (_, _, color, isQueen) = (ValueTuple<int, int, string, bool>)selectedPiece.Tag;

            int rowDiff = toRow - fromRow;
            int colDiff = toCol - fromCol;

            if (!isQueen)
            {
                if ((Math.Abs(rowDiff) == 1 && colDiff == 0) || (rowDiff == 0 && Math.Abs(colDiff) == 1))
                    return true;

                if ((Math.Abs(rowDiff) == 2 && colDiff == 0) || (rowDiff == 0 && Math.Abs(colDiff) == 2))
                {
                    int midRow = (fromRow + toRow) / 2;
                    int midCol = (fromCol + toCol) / 2;
                    var middle = pieces[midRow, midCol];

                    if (middle != null)
                    {
                        var (_, _, midColor, _) = (ValueTuple<int, int, string, bool>)middle.Tag;
                        if (midColor != color)
                        {
                            captured = true;
                            capRow = midRow;
                            capCol = midCol;
                            return true;
                        }
                    }
                }

                return false;
            }

            if (fromRow == toRow || fromCol == toCol)
            {
                int stepRow = Math.Sign(rowDiff);
                int stepCol = Math.Sign(colDiff);

                int r = fromRow + stepRow;
                int c = fromCol + stepCol;
                bool foundOpponent = false;

                while (r != toRow || c != toCol)
                {
                    if (pieces[r, c] != null)
                    {
                        var (_, _, midColor, _) = (ValueTuple<int, int, string, bool>)pieces[r, c].Tag;

                        if (midColor == color)
                            return false;

                        if (foundOpponent)
                            return false;

                        foundOpponent = true;
                        capRow = r;
                        capCol = c;
                    }

                    r += stepRow;
                    c += stepCol;
                }

                captured = foundOpponent;
                return true;
            }

            return false;
        }

        private (int row, int col) FindPanelPosition(Panel panel)
        {
            for (int row = 0; row < 8; row++)
                for (int col = 0; col < 8; col++)
                    if (squares[row, col] == panel)
                        return (row, col);
            return (-1, -1);
        }

        private void CheckWin()
        {
            int blackCount = 0, whiteCount = 0;

            for (int row = 0; row < 8; row++)
                for (int col = 0; col < 8; col++)
                    if (pieces[row, col] != null)
                    {
                        var (_, _, color, _) = (ValueTuple<int, int, string, bool>)pieces[row, col].Tag;
                        if (color == "black") blackCount++;
                        else if (color == "white") whiteCount++;
                    }

            if (blackCount == 0)
            {
                MessageBox.Show("Beyaz Oyuncu Kazandı! Skor: " + whiteScore);
                Application.Exit();
            }
            else if (whiteCount == 0)
            {
                MessageBox.Show("Siyah Oyuncu Kazandı! Skor: " + blackScore);
                Application.Exit();
            }
        }
    }
}


