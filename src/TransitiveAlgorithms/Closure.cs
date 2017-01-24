using System.Collections.Generic;

namespace TransitiveAlgorithms
{
    public static class Closure
    {
        private static int _size;
        private static int[,] _closedGraph;
        private static List<int>[] _adjacencies;

        public static int[,] DoTransitiveClosureWithDfs(int[,] graph)
        {
            _size = graph.GetLength(0);
            _closedGraph = new int[_size, _size];
            _adjacencies = CreateAdjacencyArray(graph);

            for (int vertice = 0; vertice < _size; vertice++)
            {
                DepthFirstSearch(vertice, vertice);
            }

            return _closedGraph;
        }

        private static List<int>[] CreateAdjacencyArray(int[,] graph)
        {
            var adjacencies = new List<int>[_size];

            for (int vertice = 0; vertice < _size; vertice++)
            {
                adjacencies[vertice] = new List<int>();

                for (int neighbour = 0; neighbour < _size; neighbour++)
                {
                    if (graph[vertice, neighbour] > 0)
                    {
                        adjacencies[vertice].Add(neighbour);
                    }
                }
            }

            return adjacencies;
        }

        private static void DepthFirstSearch(int vertice, int reachableVertice)
        {
            _closedGraph[vertice, reachableVertice] = 1;

            foreach (var neighbour in _adjacencies[reachableVertice])
            {
                if (_closedGraph[vertice, neighbour] == 0)
                {
                    DepthFirstSearch(vertice, neighbour);
                }
            }
        }

        public static int[,] DoTransitiveClosureWithFloydWarshall(int[,] graph)
        {
            _size = graph.GetLength(0);
            _closedGraph = (int[,])graph.Clone();

            FloydWarshall();

            return _closedGraph;
        }

        private static void FloydWarshall()
        {
            for (int i = 0; i < _size; i++)
            {
                for (int j = 0; j < _size; j++)
                {
                    for (int k = 0; k < _size; k++)
                    {
                        _closedGraph[j, k] = _closedGraph[j, k] > 0 ||
                            (_closedGraph[j, i] > 0 && _closedGraph[i, k] > 0) ? 1 : 0;
                    }
                }
            }
        }
    }
}
