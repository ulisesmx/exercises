using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
class Solution {

    static void Main(String[] args) {
        int N = Convert.ToInt32(Console.ReadLine());
        for(int i = 1; i <= 10; i++){
            String line = String.Format("{0} x {1} = {2}", N, i, i * N);
            Console.WriteLine(line);
        }
    }
}
