using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace quickUnion
{
    class quickUnion
    {
        private int[] id;
        public quickUnion(int N)
        {
            id=new int[N];
            for (int i = 0; i < N; i++)
			{
                id[i]=i;
			 
			}


        }
        public int root(int i)
        {
            while (i != id[i])
            {
                i = id[i];
            }
            return i;
        }

        public bool connected(int p, int q)
        {
            return root(p) == root(q);
        }

        public void union(int p, int q)
        {
            int qroot = root(q);
            int proot = root(p);

            id[qroot] = proot;

        }




    }
}
