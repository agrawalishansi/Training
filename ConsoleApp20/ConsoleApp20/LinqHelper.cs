using System;
using System.Collections.Generic;

namespace ConsoleApp20
{
  public static class LinqHelper
  {
    #region FilterSimple
    
    public static IEnumerable<T> FilterSimple<T>(this IEnumerable<T> source, Func<T, bool> predicate)
    {
      var result = new List<T>();

      foreach (var item in source) {
        if (predicate(item)) {
          result.Add(item);
        }
      }

      return result;
    }
    #endregion

    #region Filter
    
    public static IEnumerable<T> Filter<T>(this IEnumerable<T> source, Func<T, bool> predicate)
    {
      foreach (var item in source) {
        if (predicate(item)) {
          yield return item;
        }
      }
    }
    #endregion
  }
}
