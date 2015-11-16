using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms_2.Graphs
{
    public class Edge : IComparable<Edge>
    {
        private int v;
        private int w;
        private double weight;

        public Edge(int v, int w, int weight)
        {
            this.v = v;
            this.w = w;
            this.weight = weight;
        }

        public int Either()
        {
            return v;
        }

        public int Other(int v)
        {
            if (this.v == v) return w;
            return v;
        }

        public int CompareTo(Edge that)
        {
            if (this.weight < that.weight) return -1;
            else if(this.weight > that.weight) return 1;
            else return 0;

        }
    }
    public class EdgeWeightedGraph
    {
        private List<Edge>[] adjs;
        private int n = 0;
        private int e = 0;

        public EdgeWeightedGraph(int n)
        {
            adjs = new List<Edge>[n];
            for (int i = 0; i < n; i++)
            {
                adjs[i] = new List<Edge>();
            }
            this.n = n;
        }

        public void addEdge(Edge e)
        {
            int v = e.Either();
            int w = e.Other(v);
            adjs[v].Add(e);
            adjs[w].Add(e);
            this.e++;
        }

        public int V()
        {
            return n;
        }

        public int E()
        {
            return e;
        }
    }
}
