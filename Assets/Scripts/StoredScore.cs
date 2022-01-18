using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;

[System.Serializable]
public class StoredScore {

  static private readonly string FileName = "/BestScore.json";

  public string name;
  public int score;

  public void Save() {
    var json = JsonUtility.ToJson(this);
    File.WriteAllText(Application.persistentDataPath + FileName, json);
  }

  static public StoredScore Load() {
    if (!File.Exists(Application.persistentDataPath + FileName)) return new StoredScore();
    var json = File.ReadAllText(Application.persistentDataPath + FileName);
    return JsonUtility.FromJson<StoredScore>(json);
  }

}