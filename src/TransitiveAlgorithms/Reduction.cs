namespace TransitiveAlgorithms
{
    public static class Reduction
    {
        private static int _size;

        public static int[,] DoTransitiveReduction(int[,] graph)
        {
            _size = graph.GetLength(0);
            var pathMatrix = CreatePathMatrix(graph);
            var reducedGraph = TransitiveReduction(pathMatrix);

            return reducedGraph;
        }

        private static int[,] CreatePathMatrix(int[,] graph)
        {
            var pathMatrix = (int[,])graph.Clone();

            for (int i = 0; i < _size; i++)
            {
                for (int j = 0; j < _size; j++)
                {
                    if (i == j)
                    {
                        continue;
                    }

                    if (pathMatrix[j, i] > 0)
                    {
                        for (int k = 0; k < _size; k++)
                        {
                            if (pathMatrix[j, k] == 0)
                            {
                                pathMatrix[j, k] = pathMatrix[i, k];
                            }
                        }
                    }
                }
            }

            return pathMatrix;
        }

        private static int[,] TransitiveReduction(int[,] pathMatrix)
        {
            var reducedGraph = (int[,])pathMatrix.Clone();

            for (int i = 0; i < _size; i++)
            {
                for (int j = 0; j < _size; j++)
                {
                    if (reducedGraph[j, i] > 0)
                    {
                        for (int k = 0; k < _size; k++)
                        {
                            if (reducedGraph[i, k] > 0)
                            {
                                reducedGraph[j, k] = 0;
                            }
                        }
                    }
                }
            }

            return reducedGraph;
        }
    }
}
