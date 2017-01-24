# Transitive Algorithms
- Transitive Closure (DFS and Floyd-Warshall).
- Transitive Reduction (Path Matrix).

## Transitive Closure
Transitive closure finds additional connection between two vertices.  
For example, if graph has connection such as 0 -> 1 -> 2 then algorithm add another connection 0 -> 2.  

### 1. Method with DFS (Depth First Search)
If you use method with DFS you receive two additional connections 0 -> 0 and 2 -> 2.  
Time complexity: O(V^2)

### 2. Method with Floyd-Warshall
Floyd-Warshall algorithm doesn't finds thats self-connections, but it have O(V^3) time complexity.  
  
Look at the picture below for better comprehesion of this issues.

![Transitive closure](client/TransitiveAlgorithms.Client/Data/TransitiveClosure.png)
#

## Transitive Reduction
Transitive reduction removes redundant connections. This library uses an additional method which transforms graph into a path matrix.  
Without this method algorithm doesn't remove 0 -> 1 connection in example called ***Hard***.

![Transitive closure](client/TransitiveAlgorithms.Client/Data/TransitiveReduction.png)
