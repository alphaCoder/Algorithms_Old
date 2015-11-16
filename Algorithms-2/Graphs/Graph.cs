using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms_2.Graphs
{
    public class Graph
    {
        private List<int>[] adj;
        private int N;
        private int edgeCount = 0;
        private int[] degree;
        
        public Graph(int n)
        {
            N = n;
            adj = new List<int>[n];
            degree = new int[n];
            BootstrapGraph();
        }

        private void BootstrapGraph()
        {
            for (int i = 0; i < N; i++)
            {
                adj[i] = new List<int>();
                degree[i] = 0;
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
                adj[w].Add(v);
                degree[v] = degree[v] + 1;
                degree[w] = degree[w] + 1;
                edgeCount++;
            }
        }

        public int Degree(int v)
        {
            return degree[v];
        }
        
        public List<int> AdjEdges(int v)
        {
            return adj[v];
        }
    }
}
