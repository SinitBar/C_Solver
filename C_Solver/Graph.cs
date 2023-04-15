using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Solver
{
    internal class Graph
    {
        public List<List<int>> Matrix { get; private set; }
        public List<int> Vertexes { get; private set; }
        public Graph(List<List<int>> matr, List<int> vertexes)
        {
            if (vertexes.Count == 0) // first create time
            {
                for (int i = 0; i < matr.Count; i++)
                    vertexes.Add(i);
            }

            Matrix = new List<List<int>> (matr.Count);
            for (int i = 0; i < matr.Count; i++) 
            { 
                Matrix.Add(new List<int>());
                Matrix[i].AddRange(matr[i]);
            }
            Vertexes = new List<int>(vertexes.Count);
            Vertexes.AddRange(vertexes);
        }
        public int removeVertex(int vertexIndex)
        {
            int removedVertex = Vertexes[vertexIndex];
            Matrix.RemoveAt(vertexIndex);
            Vertexes.RemoveAt(vertexIndex);
            for (int i = 0; i < Matrix.Count; i++)
                Matrix[i].RemoveAt(vertexIndex);
            return removedVertex;
        }

        public void removeVertexes(List<int> vertexes)
        {
            for (int i = 0; i < vertexes.Count; i++)
            {
                int index = Vertexes.FindIndex(c => c == vertexes[i]);
                Matrix.RemoveAt(index);
                Vertexes.RemoveAt(index);
                for (int j = 0; j < Matrix.Count; j++)
                    Matrix[j].RemoveAt(index);
            }
        }

        public int vertexDegree (int vertexIndex)
        {
            return Matrix[vertexIndex].Sum();
        }

        public int partialVertexDegree(int vertexIndex, List<int> vertexIndexes)
        {
            int sum = 0;
            foreach (int vertInd in vertexIndexes)
                sum += Matrix[vertexIndex][vertInd];
            return sum;
        }
    }
}
