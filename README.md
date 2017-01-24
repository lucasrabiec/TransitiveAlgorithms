# Transitive Algorithms
- Transitive Closure (DFS and Floyd-Warshall).
- Transitive Reduction (Path Matrix).

## Transitive Closure
Transitive closure finds additional connection between two vertices.  
For example, if graph has connection such as 0 -> 1 -> 2 then algorithm add another connection 0 -> 2.  
Look at the picture below.

![Transitive closure](TransitiveAlgorithms/client/TransitiveAlgorithms.Client/Data/TransitiveClosure.png)

### 1. Method with DFS (Depth First Search)
If you use method with DFS you receive two additional connections 0 -> 0 and 2 -> 2.
Complexity: O(V^2)

### 2. Method with Floyd-Warshall
Floyd-Warshall algorithm doesn't finds thats self-connections, but it have O(V^3) complexity.  