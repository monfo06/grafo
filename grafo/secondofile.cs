using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace grafo
{
	public class nodo<T>
	{
		public T Valore { get; set; }
		public List<nodo<T>> Succ { get; set; }

		public nodo(T value)
		{
			Valore = value;
			Succ = new List<nodo<T>>();
		}
	}

	public class grafo<T>
	{
		private List<nodo<T>> nodes;

		public grafo()
		{
			nodes = new List<nodo<T>>();
		}

		public void creazionenodo(T valore)
		{
			nodo<T> nuovoNodo = new nodo<T>(valore);
			nodes.Add(nuovoNodo);
		}

		public void creazionearco(nodo<T> DA, nodo<T> A)
		{
			if (DA != null && A != null && nodes.Contains(DA) && nodes.Contains(A))
			{
				DA.Succ.Add(A);
			}
		}

		public void rimuoviNodo(nodo<T> nodo)
		{
			if (nodes.Contains(nodo))
			{
				nodes.Remove(nodo);
				foreach (var n in nodes)
				{
					n.Succ.Remove(nodo);
				}
			}
		}

		public void rimuoviArco(nodo<T> DA, nodo<T> A)
		{
			if (DA != null && A != null)
			{
				DA.Succ.Remove(A);
			}
		}

		public nodo<T> trovanodo(T valore)
		{
			return nodes.Find(n => n.Valore.Equals(valore));
		}

		public bool arcoesiste(nodo<T> DA, nodo<T> A)
		{
			return DA.Succ.Contains(A);
		}

		public IEnumerable<nodo<T>> OttieniNodi()
		{
			return nodes;
		}

		public List<T> BFS(nodo<T> inizio)
		{
			List<T> visita = new List<T>();
			Queue<nodo<T>> queue = new Queue<nodo<T>>();
			HashSet<nodo<T>> visitato = new HashSet<nodo<T>>();

			queue.Enqueue(inizio);
			visitato.Add(inizio);

			while (queue.Count > 0)
			{
				nodo<T> current = queue.Dequeue();
				visita.Add(current.Valore);

				foreach (var vicini in current.Succ)
				{
					if (!visitato.Contains(vicini))
					{
						visitato.Add(vicini);
						queue.Enqueue(vicini);
					}
				}
			}

			return visita;
		}

		public List<T> DFS(nodo<T> inizio)
		{
			List<T> visita = new List<T>();
			Stack<nodo<T>> stack = new Stack<nodo<T>>();
			HashSet<nodo<T>> visitato = new HashSet<nodo<T>>();

			stack.Push(inizio);
			visitato.Add(inizio);

			while (stack.Count > 0)
			{
				nodo<T> current = stack.Pop();
				visita.Add(current.Valore);

				foreach (var vicini in current.Succ)
				{
					if (!visitato.Contains(vicini))
					{
						visitato.Add(vicini);
						stack.Push(vicini);
					}
				}
			}

			return visita;
		}
		public int ContaNodiDivisibiliPer(int val)
		{
			

			int count = 0;
			foreach (var nodo in nodes)
			{
				try
				{
					int valore = Convert.ToInt32(nodo.Valore);
					if (valore % val == 0)
					{
						count++;
					}
				}
				catch (Exception e )
				{
					MessageBox.Show("");
				}
				
			}
			return count;
		}
		
		public string trovastringapiuLunga(nodo<T> inizio)
		{
			if (typeof(T) != typeof(string))
			{
				throw new InvalidOperationException("Il tipo del nodo non è string");
			}

			string stringalunga = (string)(object)inizio.Valore;
			HashSet<nodo<T>> visitato = new HashSet<nodo<T>>();
			Stack<nodo<T>> stack = new Stack<nodo<T>>();

			stack.Push(inizio);
			visitato.Add(inizio);

			while (stack.Count > 0)
			{
				nodo<T> current = stack.Pop();
				string currentValue = (string)(object)current.Valore;
				if (currentValue.Length > stringalunga.Length)
				{
					stringalunga = currentValue;
				}

				foreach (var vicini in current.Succ)
				{
					if (!visitato.Contains(vicini))
					{
						visitato.Add(vicini);
						stack.Push(vicini);
					}
				}
			}

			return stringalunga;
		}


	}
}
