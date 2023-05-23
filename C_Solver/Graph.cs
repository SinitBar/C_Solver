using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Solver
{
    internal class Graph
    {
        public List<List<double>> Matrix { get; private set; }
        public List<int> Vertexes { get; private set; }
        public Graph(List<List<double>> matrix, List<int> vertexes)
        {
            int size = vertexes.Count;
            if (size == 0)
            {
                size = matrix.Count;
                Vertexes = new List<int>(size);
                for (int i = 0; i < size; i++)
                    Vertexes.Add(i);
            }
            else
            {
                Vertexes = new List<int>(size);
                Vertexes.AddRange(vertexes);
            }

            Matrix = new List<List<double>>(matrix.Count);
            for (int i = 0; i < matrix.Count; i++)
            {
                Matrix.Add(new List<double>());
                Matrix[i].AddRange(matrix[i]);
            }
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

        public double WeightedVertexDegree(int vertexIndex)
        {
            return Matrix[vertexIndex].Sum();
        }

        public double PartialWeightedVertexDegree(int vertexIndex, List<int> vertexIndexes)
        {
            double sum = 0;
            foreach (int vertInd in vertexIndexes)
                sum += Matrix[vertexIndex][vertInd];
            return sum;
        }
    }
}
