using System;
using System.Collections.Generic;
using System.Text;

namespace SudokuSolver
{
    class Sudoku
    {
		public int[,] Zagonetka { set; get; }

		public List<int> PronadiKandidate(int redak, int stupac)
		{
			List<int> kandidati = new List<int>();
			int velicina = Zagonetka.GetLength(0);

			for (int broj = 1; broj <= velicina; broj++)
			{
				bool nijeKandidat = false;

				for (int i = 0; i < velicina; i++)
				{
					if (Zagonetka[redak, i] == broj ||
						Zagonetka[i, stupac] == broj)
					{
						nijeKandidat = true;
						break;
					}
				}
				if (!nijeKandidat)
                    kandidati.Add(broj);
			}
			return kandidati;
		}

		public bool RijesiSudoku()
		{
			int redak = -1;
			int stupac = -1;
			int velicina = Zagonetka.GetLength(0);
			List<int> kandidati = new List<int>();

			for (int i = 0; i < velicina; i++)
			{
				bool jediniKandidat = false;
				for (int j = 0; j < velicina; j++)
				{
					if (Zagonetka[i, j] == 0)
					{
						List<int> noviKandidati = PronadiKandidate(i, j);
						if (redak < 0 ||
							noviKandidati.Count < kandidati.Count)
						{
							redak = i;
							stupac = j;
							kandidati = noviKandidati;
						}
						if (kandidati.Count == 1)
						{
							jediniKandidat = true;
							break;
						}
					}
				}
				if (jediniKandidat)
					break;
			}

			if (redak < 0)
			{
				return true;
			}
			
			else
				for (int i = 0; i < kandidati.Count; i++)
                {
					Zagonetka[redak, stupac] = kandidati[i];

					if (RijesiSudoku())
					{
						return true;
					}
					else Zagonetka[redak, stupac] = 0;
                }
			return false;
		}

		public void IspisiSudoku()
		{
			int velicina = Zagonetka.GetLength(0);
			for (int redak = 0; redak < velicina; redak++)
			{
				for (int stupac = 0; stupac < velicina; stupac++)
				{
					Console.Write(Zagonetka[redak, stupac]);
					Console.Write(" ");
				}
				Console.Write("\n");
			}
		}

	}
}
