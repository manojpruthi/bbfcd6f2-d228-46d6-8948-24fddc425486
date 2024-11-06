using System;
using System.Collections.Generic;
using System.Linq;

namespace LongestIncreasingSequence {
 
  class Program {
   
    static void Main(string[] args) {
      Console.WriteLine(" Enter your sequence:");
      string inpSequenceStr = Console.ReadLine();

      // converting input string sequence into int array using select linq function
      int[] inpSeqArray = inpSequenceStr.Split(' ').Select(x =>Convert.ToInt32(x)).ToArray();

      LongIncSequence longIncSequenceObj = new LongIncSequence();
      // function to create longest increasing sequence
      List <int> longIncSeqList = longIncSequenceObj.FindLongIncSequence(inpSeqArray);

      // displaying list of longest increasing sequence as a string to get desired output using string.join
      Console.WriteLine("The longest increasing subsequence is: " + string.Join(" ", longIncSeqList));
    }
  }
}
