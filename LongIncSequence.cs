using System;
using System.Collections.Generic;

namespace LongestIncreasingSequence {

  internal class LongIncSequence {
    // This is the function to find the longest increasing subsequence from the input sequence
    internal List <int> FindLongIncSequence(int[] inpSeqArray) {
      // calculating input array length
      int inpArrayLength = inpSeqArray.Length;

      // Initialize the array with same length as input array
      int[] intialArray = new int[inpArrayLength];

      //Traversing this array to input array length and store 1
      for (int i = 0; i < inpArrayLength; i++) {
        intialArray[i] = 1;
      }

      // Here we are storing   indices of input array (previous indices) in longest increasing sequence
      int[] seqArray = new int[inpArrayLength];
      for (int i = 0; i < inpArrayLength; i++) {
        seqArray[i] = i;
      }

      // Traverse intialArray and seqArray arrays
      for (int i = 0; i < inpArrayLength; i++) {
        //Rather than storing complete longest increasing sequence we are storing indicies to create a Longest increasing sequence if we store whole squence we need to create multiple sequence and there will be wastage of memory
        for (int prev = 0; prev < i; prev++) {
          if (inpSeqArray[prev] < inpSeqArray[i] && 1 + intialArray[prev] > intialArray[i]) {
            intialArray[i] = 1 + intialArray[prev];
            seqArray[i] = prev;
          }
        }
      }

      // Here we are finding the index of the last element in the Longest increasing sequence
      int ans = -1;
      int ansInd = -1;
      for (int i = 0; i < inpArrayLength; i++) {
        if (intialArray[i] > ans) {
          ans = intialArray[i];
          ansInd = i;
        }
      }

      // Construct the output longest incresing sequence using seq array
      List <int> longIncSeqList = new List <int> ();
      longIncSeqList.Add(inpSeqArray[ansInd]);
      while (seqArray[ansInd] != ansInd) {
        ansInd = seqArray[ansInd];
        longIncSeqList.Add(inpSeqArray[ansInd]);
      }

      // Reversing the longest Inc Sequence List  to get the correct sequence
      longIncSeqList.Reverse();
      return longIncSeqList;
    }
  }
}
