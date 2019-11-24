using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System;
using System.Globalization;

namespace CryptoSteganography.Extensions.Json
{
  /// <summary>
  /// Json Extension
  /// </summary>
  public static class Attribute
  {
    /// <summary>
    /// To String Array
    /// </summary>
    /// <param name="value"></param>
    /// <returns></returns>
    public static string[] ToStringArray(this string value)
    {
      return JsonConvert.DeserializeObject<string[]>(value, Converter.Settings);
    }

    /// <summary>
    /// 
    /// </summary>
    /// <typeparam name="T"></typeparam>
    /// <param name="array"></param>
    /// <returns></returns>
    public static string[] Shuffle(this string[] array)
    {
      Random random = new Random();

      int n = array.Length;
      while (n > 1)
      {
        int k = random.Next(n--);
        string temp = array[n];
        array[n] = array[k];
        array[k] = temp;
      }

      return array;
    }
  }

  /// <summary>
  /// Converter
  /// </summary>
  internal static class Converter
  {
    public static readonly JsonSerializerSettings Settings = new JsonSerializerSettings
    {
      MetadataPropertyHandling = MetadataPropertyHandling.Ignore,
      DateParseHandling = DateParseHandling.None,
      Converters =
            {
                new IsoDateTimeConverter { DateTimeStyles = DateTimeStyles.AssumeUniversal }
            },
    };
  }
}
