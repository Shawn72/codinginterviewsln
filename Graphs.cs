using System.Collections;
using System.Collections.Generic;

namespace Datastructures
{
    /*
     Time Complexity: O(V+E) where V is number of vertices in the graph and E is number of edges in the graph.
    Space Compelxity: O(V).There can be atmost V elements in the queue. So the space needed is O(V).
     */

    // directed graph using adjacency listrepresentation
    public class Graph
    {
        private int V; // Number of vertices
        private LinkedList<int>[] adj; //Adjacency List: linked list

        // graph constructor
       public Graph(int v)
        {
            V = v;
            adj = new LinkedList<int>[v];
            for (int i = 0; i < v; ++i)
                adj[i] = new LinkedList<int>();
        }

        // add an edge into the graph
        public void addEdge(int v, int w)
        {
            //v: vertex, w: node value at that vertex
            adj[v].AddLast(w);
        }

        // prints BFS traversal from a given source s:: Breadth First Search
        public bool _isReachable(int s, int d)
        {
            // LinkedList<int> temp = new LinkedList<int>();

            // Mark all the vertices as not visited(By default set as false)
            bool[] visited = new bool[V];

            // create a queue for BFS
            LinkedList<int> queue = new LinkedList<int>();

            // Mark the current node as visited and enqueue it
            visited[s] = true;
            queue.AddLast(s);

            // 'i' will be used to get all adjacent vertices of a vertex
            IEnumerator i;
            while (queue.Count != 0)
            {
                // Dequeue a vertex from queue and print it
                s = queue.First.Value;
                queue.RemoveFirst();
                int n;
                i = adj[s].GetEnumerator();

                // Get all adjacent vertices of the dequeued vertex s
                // If a adjacent has not been visited, then mark it visited and enqueue it
                while (i.MoveNext())
                {
                    n = (int)i.Current;

                    // If this adjacent node is the destination node, then return true
                    if (n == d)
                        return true;

                    // Else, continue to do BFS
                    if (!visited[n])
                    {
                        visited[n] = true;
                        queue.AddLast(n);
                    }
                }
            }

            // If BFS is complete without visited d
            return false;
        }
    }
}
