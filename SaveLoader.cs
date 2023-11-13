using Newtonsoft.Json;
using System.Collections.Generic;
using UnityEngine;

namespace MLALib
{
    public static class SaveLoader
    {
        public static T LoadItem<T>(string key)
        {
            string json = PlayerPrefs.GetString(key);
            return JsonConvert.DeserializeObject<T>(json);
        }

        public static void SaveItem<T>(T item, string key)
        {
            string json = JsonConvert.SerializeObject(item);
            PlayerPrefs.SetString(key, json);
            PlayerPrefs.Save();
        }

        public static void SaveItems<T>(List<T> items, string key)
        {
            string json = JsonConvert.SerializeObject(items);
            PlayerPrefs.SetString(key, json);
            PlayerPrefs.Save();
        }

        public static List<T> LoadItems<T>(string key)
        {
            string json = PlayerPrefs.GetString(key);
            return JsonConvert.DeserializeObject<List<T>>(json);
        }
    }
}
