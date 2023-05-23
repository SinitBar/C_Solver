namespace C_Solver
{
    internal class Solver
    {
        Graph Graph;
        public int AmountOfLayers { get; private set; } // k
        public Solver(string fileContent, int amountOfLayers = 4)
        {
            List<List<double>> matrix = new List<List<double>>();
            List<string> rows = fileContent.Replace('.', ',').Split('\n').ToList();
            try
            {
                for (int i = 0; i < rows.Count; i++)
                {
                    List<double> row = rows[i].Trim(new Char[] { ' ', '\r' }).Split(' ')
                        .Select(n => Convert.ToDouble(n)).ToList();
                    for (int j = 0; j < row.Count; j++)
                        if (row[j] < 0)
                            throw new ArgumentException("elements should be positive");
                    //if (row[j] != 0 && row[j] != 1) 
                    //    throw new ArgumentException("element should be 1 or 0");
                    matrix.Add(row);
                }
                Graph = new Graph(matrix, new());
                this.AmountOfLayers = amountOfLayers;
            }
            catch (Exception exception)
            {
                this.AmountOfLayers = 0;
                matrix = new List<List<double>>();
                Graph = new Graph(matrix, new());
            }
        }

        public List<List<int>> Solve(int k)
        {
            Stack<int> Cm = new Stack<int>(); // vertexes with degree less than current k // См 
            List<int> Clast = new List<int>(); // vertexes not in results // Сост
            Graph graphCopy = new Graph(Graph.Matrix, Graph.Vertexes);
            List<List<int>> C = new List<List<int>>(AmountOfLayers);
            for (int i = 0; i < k; i++)
                C.Add(new List<int>());
            while (k > 1)
            {
                firstStep(k, Cm, graphCopy);
                C[AmountOfLayers - k].AddRange(secondStep(graphCopy));
                k--;
            }
            firstStep(k, Cm, graphCopy);
            C[AmountOfLayers - k] = secondStep(graphCopy, Clast);
            // C and Cm and Clast are done
            // work with Cm
            int Cindex;
            while (Cm.Count > 0)
            {
                int currentVertex = Cm.Pop();
                Cindex = -1;
                for (int i = 0; i < C.Count; i++)
                {
                    if (Graph.PartialWeightedVertexDegree(currentVertex, C[i]) == 0)
                    {
                        if (Cindex < 0)
                            Cindex = i;
                        else
                        {
                            if (C[i].Count < C[Cindex].Count)
                                Cindex = i;
                        }
                    }
                }
                if (Cindex < 0) // then find C with min amount of vertexes
                {
                    Cindex = 0;
                    for (int i = 1; i < C.Count; i++)
                        if (C[i].Count < C[Cindex].Count)
                            Cindex = i;
                }
                C[Cindex].Add(currentVertex);
            }

            // work with Clast
            // for every vertex in Clast select C[i] list to add it
            // selection criteria: min amount of connected vertexes
            for (int i = 0; i < Clast.Count; i++)
            {
                double CiMinConnectionsCount = Graph.PartialWeightedVertexDegree(Clast[i], C[0]); ;
                Cindex = 0;
                for (int j = 1; j < C.Count; j++)
                {
                    double partVectDeg = Graph.PartialWeightedVertexDegree(Clast[i], C[j]);
                    if (partVectDeg < CiMinConnectionsCount ||
                        ((partVectDeg == CiMinConnectionsCount) && (C[Cindex].Count > C[j].Count)))
                    {
                        CiMinConnectionsCount = partVectDeg;
                        Cindex = j;
                    }
                }
                C[Cindex].Add(Clast[i]);
            }
            // end of work with Clast

            for (int i = 0; i < C.Count; i++)
                C[i].Sort();
            return C;
        }

        public void firstStep(int k, Stack<int> Cm, Graph graph)
        {
            for (int i = 0; i < graph.Matrix.Count; i++)
            {
                if (graph.WeightedVertexDegree(i) < k)
                {
                    Cm.Push(graph.Vertexes[i]);
                    graph.removeVertex(i);
                    i = -1;
                }
            }
        }

        public List<int> secondStep(Graph graph, List<int>? Clast = null)
        {
            if (graph.Matrix.Count == 0)
                return graph.Vertexes;

            Graph graphCopy = new Graph(graph.Matrix, graph.Vertexes);
            int indexOfVertexWithMaxDegree;
            do
            {
                indexOfVertexWithMaxDegree = -1;
                double maxVertexDegree = 0;
                for (int i = 0; i < graphCopy.Matrix.Count; i++)
                {
                    double currentVertexDegree = graphCopy.WeightedVertexDegree(i);
                    if (currentVertexDegree > maxVertexDegree)
                    {
                        maxVertexDegree = currentVertexDegree;
                        indexOfVertexWithMaxDegree = i;
                    }
                }
                if (indexOfVertexWithMaxDegree == -1)
                    break;
                int removedVertex = graphCopy.removeVertex(indexOfVertexWithMaxDegree);
                if (Clast != null)
                    Clast.Add(removedVertex);
            } while (indexOfVertexWithMaxDegree >= 0);
            graph.removeVertexes(graphCopy.Vertexes);

            return graphCopy.Vertexes;
        }
    }
}
