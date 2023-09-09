using System;

class MainClass {
  public static void Main (string[] args) 
  {
    Console.WriteLine ("This is a binary search");

    int[] sortedArray = new int[10] {1,4,6,8,19,21,24,25,30,32};
    int number;
    do
    {
      Console.WriteLine("Enter the number you are searching for")
      string value = Console.ReadLine();
    }
    while(Int32.TryParse(value, out number))
  
    string numberFound = binarySearch(sortedArray, number)
    if(numberFound="-1")
    {
      Console.WriteLine("The number was found");
    }

    else
    {
      Console.WriteLine("The number was not found");
    }

  }

  static string binarySort(int [] sortedArray, int number)
  {
    int minNum = 0;
    int maxNum = sortedArray.Length - 1;

   while (minNum <=maxNum) 
   {
      int mid = (minNum + maxNum) / 2;
      if (number == sortedArray[mid]) 
      {
         return ++mid;
      } 
      else if (number < sortedArray[mid]) 
      {
         max = mid - 1;
      }
      else {
         min = mid + 1;
      }
   }
   return "-1";
}


  }
}
