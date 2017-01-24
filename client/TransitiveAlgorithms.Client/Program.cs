namespace TransitiveAlgorithms.Client
{
    using System;

    class Program
    {
        static void Main(string[] args)
        {
            TransitiveClosure("Data/GraphToClosure.json");
            Console.WriteLine("----------------");
            Console.WriteLine("Graph (easy):");
            TransitiveReduction("Data/GraphToReduction.json");
            Console.WriteLine("----------------");
            Console.WriteLine("Graph (hard):");
            TransitiveReduction("Data/GraphToReduction2.json");

            Console.ReadKey();
        }

        private static void TransitiveClosure(string path)
        {
            var graph = GraphReader.ReadGraphFromJson(path);
            var closedGraphWithDfs = Closure.DoTransitiveClosureWithDfs(graph);
            var closedGraphWithFloydWarshall = Closure.DoTransitiveClosureWithFloydWarshall(graph);

            Console.WriteLine("Graph:");
            Console.WriteLine(graph.MatrixToString());
            Console.WriteLine("Transitive closure with DFS:");
            Console.WriteLine(closedGraphWithDfs.MatrixToString());
            Console.WriteLine("Transitive closure with Floyd-Warshall:");
            Console.WriteLine(closedGraphWithFloydWarshall.MatrixToString());
        }

        private static void TransitiveReduction(string path)
        {
            var graph = GraphReader.ReadGraphFromJson(path);
            var reducedGraph = Reduction.DoTransitiveReduction(graph);

            Console.WriteLine(graph.MatrixToString());
            Console.WriteLine("Transitive reduction:");
            Console.WriteLine(reducedGraph.MatrixToString());
        }
    }
}
