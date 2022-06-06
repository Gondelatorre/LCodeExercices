

namespace LeetCode.Test._556.Next.Greater.Element.III
{
    internal static class NextGreaterElement
    {
        /*
        Given a positive integer n, find the smallest integer which has exactly the same digits existing in the integer n 
        and is greater in value than n.If no such positive integer exists, return -1.

        Note that the returned integer should fit in 32-bit integer, if there is a valid answer but it does not fit in 32-bit integer, return -1.



        Example 1:

        Input: n = 12
        Output: 21
        Example 2:

        Input: n = 21
        Output: -1


        Constraints:

        1 <= n <= 231 - 1

        */

        public static int Resolve()
        {

            /*
                2147483486
                230241
                101
                12
                21
            
            */

            int n = 2147483486;

            return resolveNextGreaterElement(n);

        }


        private static int resolveNextGreaterElement(int n)
        {
            var a = toArray(n);

            int c = a.Count();
                        

            for (int i = c - 1; i >= 0; i--)
            {
                int[] arr = a.Skip(i).ToArray();

                // inicio de busqueda
                int first = arr[0];

                bool cambio = false;

                Array.Sort(arr);
                
                for (int y = 0; y < arr.Length; y++)
                {
                    if (first < arr[y])
                    {
                        int tp = y;
                        int vp = arr[y];
                        arr[y] = first;
                        while (true)
                        {
                            tp--;
                            if (tp == 0) break;
                            arr[tp] = arr[tp-1];
                            
                        }

                        arr[0] = vp;

                                               
                        cambio = true;
                        break;
                    }
                }

                if (cambio)
                {
                    for (int x = 0; x < arr.Length; x++)
                    {
                        a[i + x] = arr[x];
                    }

                    break;
                }

                //Array.Clear(arr);
            }

               int r = toInt(a);
            if (n == r)
                r = -1;


            return r;
        }

      

        private static int[] toArray(int n)
        {
            
            int[] arr = n.ToString().Select(c => Convert.ToInt32(c)-48).ToArray();

            
            return arr;
        }

        private static int toInt(int[] arr)
        {
            try
            {
                int result = Convert.ToInt32(string.Join("", arr.Select(c => c.ToString())));

                return result;
            }
            catch (Exception)
            {

                return -1;
            }


           
        }
    }


}
