using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms_2.Graphs
{
    public class Digraph
    {
        private List<int>[] adj;
        private int N;
        private int edgeCount = 0;
        private int[] inDegree;
        private int[] outDegree;
        public Digraph(int n)
        {
            N = n;
            adj = new List<int>[n];
            inDegree = new int[n];
            outDegree = new int[n];
            BootstrapGraph();
        }

        private void BootstrapGraph()
        {
            for (int i = 0; i < N; i++)
            {
                adj[i] = new List<int>();
                inDegree[i] = 0;
                outDegree[i] = 0;
            }
        }

        public int V()
        {
            return N;
        }

        public int E()
        {
            return edgeCount;
        }

        public void AddEdge(int v, int w)
        {
            if (!adj[v].Contains(w))
            {
                adj[v].Add(w);
                outDegree[v] = outDegree[v] + 1;
                inDegree[w] = inDegree[w] + 1;
                edgeCount++;
            }
        }

        public int InDegree(int v)
        {
            return inDegree[v];
        }

        public int OutDegree(int v)
        {
            return outDegree[v];
        }
        public List<int> AdjEdges(int v)
        {
            return adj[v];
        }
    }
}
