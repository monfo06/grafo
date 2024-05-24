using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace grafo
{
	public partial class Form1 : Form
	{
		private grafo<string> graf;

		public Form1()
		{
			InitializeComponent();
			graf = new grafo<string>();
		}
		private void pulire()
		{

			primo.Text = string.Empty;
			secondo.Text = string.Empty;
			nodo.Text = string.Empty;
			textBox1.Text = string.Empty;
			mod1.Text = string.Empty;
			mod2.Text = string.Empty;
			textBox2.Text = string.Empty;
		}
		private void ImportaGrafoDaFile(string filePath)
		{
			try
			{
				if (!File.Exists(filePath))
				{
					MessageBox.Show("Il file non esiste.");
					return;
				}

				using (StreamReader sr = new StreamReader(filePath))
				{
					string line;
					while ((line = sr.ReadLine()) != null)
					{
						string[] parts = line.Split(' ');
						if (parts.Length == 2)
						{
							string fromNode = parts[0];
							string toNode = parts[1];

							if (graf.trovanodo(fromNode) == null)
							{
								graf.creazionenodo(fromNode);
							}
							if (graf.trovanodo(toNode) == null)
							{
								graf.creazionenodo(toNode);
							}
							graf.creazionearco(graf.trovanodo(fromNode), graf.trovanodo(toNode));
						}
						else
						{
							MessageBox.Show($"Formato non valido nella riga: {line}");
						}
					}
				}

				AggiornaListBox();
			}
			catch (Exception ex)
			{
				MessageBox.Show($"Si è verificato un errore durante l'importazione del grafo: {ex.Message}");
			}
		}
		private void EsportaGrafo(string filePath)
		{
			try
			{
				using (StreamWriter sw = new StreamWriter(filePath))
				{
					foreach (var nodo in graf.OttieniNodi())
					{
						foreach (var arco in nodo.Succ) // assuming 'Succ' is the list of successors
						{
							string fromNode = nodo.Valore;
							string toNode = arco.Valore; // assuming 'arco' is a node in 'Succ'
							sw.WriteLine($"{fromNode} {toNode}");
						}
					}
				}
				MessageBox.Show("Il grafo è stato esportato con successo.");
			}
			catch (Exception ex)
			{
				MessageBox.Show($"Si è verificato un errore durante l'esportazione del grafo: {ex.Message}");
			}
		}


		private void aggiugiarco_Click(object sender, EventArgs e)
		{
			string valorePrimo = primo.Text;
			string valoreSecondo = secondo.Text;

			nodo<string> nodoPrimo = graf.trovanodo(valorePrimo);
			nodo<string> nodoSecondo = graf.trovanodo(valoreSecondo);

			if (nodoPrimo != null && nodoSecondo != null)
			{
				if (!graf.arcoesiste(nodoPrimo, nodoSecondo))
				{
					graf.creazionearco(nodoPrimo, nodoSecondo);
					AggiornaListBox();
				}
				else
				{
					MessageBox.Show("L'arco esiste già.");
				}
			}
			else
			{
				MessageBox.Show("Uno o entrambi i nodi non esistono.");
			}
			pulire();
		}

		private void AggiornaListBox()
		{
			listBox1.Items.Clear();
			foreach (var nodo in graf.OttieniNodi())
			{
				string succStr = string.Join(", ", nodo.Succ.Select(n => n.Valore));
				listBox1.Items.Add($"{nodo.Valore} -> {succStr}");
			}
			pulire();
		}

		private void aggiugival_Click(object sender, EventArgs e)
		{
			if (nodo.Text.Length>0){
				string valoreNodo = nodo.Text;
				if (graf.trovanodo(valoreNodo) == null)
				{
					graf.creazionenodo(valoreNodo);
					AggiornaListBox();
				}
				else
				{
					MessageBox.Show("Il nodo esiste già.");
				}
			}else
			{
				MessageBox.Show("inserire almeno un carattere per il nome del nodo");
			}
			
			
			pulire();
		}

		private void toglinodo_Click(object sender, EventArgs e)
		{
			string valoreNodo = nodo.Text;
			nodo<string> nodoDaRimuovere = graf.trovanodo(valoreNodo);
			if (nodoDaRimuovere != null)
			{
				graf.rimuoviNodo(nodoDaRimuovere);
				AggiornaListBox();
			}
			else
			{
				MessageBox.Show("Il nodo non esiste.");
			}
			pulire();
		}

		private void togliarco_Click(object sender, EventArgs e)
		{
			string valorePrimo = primo.Text;
			string valoreSecondo = secondo.Text;

			nodo<string> nodoPrimo = graf.trovanodo(valorePrimo);
			nodo<string> nodoSecondo = graf.trovanodo(valoreSecondo);

			if (nodoPrimo != null && nodoSecondo != null)
			{
				if (graf.arcoesiste(nodoPrimo, nodoSecondo))
				{
					graf.rimuoviArco(nodoPrimo, nodoSecondo);
					AggiornaListBox();
				}
				else
				{
					MessageBox.Show("L'arco non esiste.");
				}
			}
			else
			{
				MessageBox.Show("Uno o entrambi i nodi non esistono.");
			}
			pulire();
		}

		private void ampiezza_Click(object sender, EventArgs e)
		{
			string valoreNodo = textBox1.Text;
			nodo<string> inizioNodo = graf.trovanodo(valoreNodo);

			if (inizioNodo != null)
			{
				List<string> visita = graf.BFS(inizioNodo);
				MessageBox.Show("Visita in ampiezza: " + string.Join(", ", visita));
			}
			else
			{
				MessageBox.Show("Il nodo di partenza non esiste.");
			}
			pulire();
		}

		private void profondita_Click(object sender, EventArgs e)
		{
			string valoreNodo = textBox1.Text;
			nodo<string> inizioNodo = graf.trovanodo(valoreNodo);

			if (inizioNodo != null)
			{
				List<string> visita = graf.DFS(inizioNodo);
				MessageBox.Show("Visita in profondità: " + string.Join(", ", visita));
			}
			else
			{
				MessageBox.Show("Il nodo di partenza non esiste.");
			}
			pulire();
		}

		private void mod_Click(object sender, EventArgs e)
		{
			string valorePrimo = primo.Text;
			string valoreSecondo = secondo.Text;
			string nuovoPrimo = mod1.Text;
			string nuovoSecondo = mod2.Text;

			nodo<string> nodoPrimo = graf.trovanodo(valorePrimo);
			nodo<string> nodoSecondo = graf.trovanodo(valoreSecondo);
			nodo<string> nuovoNodoPrimo = graf.trovanodo(nuovoPrimo);
			nodo<string> nuovoNodoSecondo = graf.trovanodo(nuovoSecondo);

			if (nodoPrimo != null && nodoSecondo != null && nuovoNodoPrimo != null && nuovoNodoSecondo != null)
			{
				if (graf.arcoesiste(nodoPrimo, nodoSecondo))
				{
					graf.rimuoviArco(nodoPrimo, nodoSecondo);
					graf.creazionearco(nuovoNodoPrimo, nuovoNodoSecondo);
					AggiornaListBox();
				}
				else
				{
					MessageBox.Show("L'arco da modificare non esiste.");
				}
			}
			else
			{
				MessageBox.Show("Uno o più nodi non esistono.");
			}
			pulire();
		}



		private void strpiul_Click(object sender, EventArgs e)
		{
			string valoreNodo = textBox1.Text;
			nodo<string> inizioNodo = graf.trovanodo(valoreNodo);

			if (inizioNodo != null)
			{
				try
				{
					string stringalunga = graf.trovastringapiuLunga(inizioNodo);
					MessageBox.Show($"Stringa più lunga raggiungibile: {stringalunga}");
				}
				catch (InvalidOperationException ex)
				{
					MessageBox.Show(ex.Message);
				}
			}
			else
			{
				MessageBox.Show("Il nodo di partenza non esiste.");
			}
			pulire();
		}

		private void divisibilita_Click_1(object sender, EventArgs e)
		{
			try
			{
				int count = graf.ContaNodiDivisibiliPer(Convert.ToInt32(textBox1.Text));
				MessageBox.Show($"Nodi divisibili: {count}");
			}
			catch (InvalidOperationException ex)
			{
				MessageBox.Show(ex.Message);
			}
			pulire();
		}

		private void importa_Click(object sender, EventArgs e)
		{
			ImportaGrafoDaFile(textBox2.Text);
			pulire();
		}

		private void button2_Click(object sender, EventArgs e)
		{
			EsportaGrafo(textBox2.Text);
			pulire();
		}
	}
}


