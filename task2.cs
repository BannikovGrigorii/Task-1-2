using System;

namespace Practice
{
  class Program2
  {
    struct SequenceInfo
    {
      public SequenceInfo(int begin, int end, int length)
      {
        this.begin_index = begin;
        this.end_index = end;
        this.length = length;
      }

      public int begin_index;
      public int end_index;
      public int length;
    };

    public static void Main(String[] args)
    {
      Console.Write("Введите число: ");
      int seq_value = int.Parse(Console.ReadLine());

      int[] arr = new int[100];
      Random rand = new Random();

      for (int i = 0; i < arr.Length; i++)
      {
        arr[i] = rand.Next(0, 100);
      }

      SequenceInfo info = getSequenceOf(arr, seq_value);
      if (info.length == 0)
      {
        Console.WriteLine("Последовательности не найдено");
      }
      else
      {
        Console.WriteLine($"Индекс начала: {info.begin_index}");
        Console.WriteLine($"Индекс конца: {info.end_index}");
        Console.WriteLine($"Максимальная длина последовательности: {info.length}");
      }
    }

    private static SequenceInfo getSequenceOf(int[] arr, int value)
    {
      int begin = 0;
      int end = 0;
      int length = 0;
      int curr_length = 0;
      int curr_start = 0;

      for (int i = 0; i < arr.Length; i++)
      {
        if (arr[i] == value)
        {
          if (curr_length == 0)
          {
            curr_start = i;
          }
          curr_length++;
        }
        else
        {
          if (curr_length > length)
          {
            length = curr_length;
            begin = curr_start;
            end = i - 1;
          }
          curr_length = 0;
        }
      }

      return new SequenceInfo(begin, end, length);
    }
  }
}

