using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PersistenceManager : MonoBehaviour {
  static public PersistenceManager Instance;

  public string playerName;

  public StoredScore bestScore;

  private void Awake() {
    if (Instance != null) {
      Destroy(gameObject);
      return;
    } else {
      Instance = this;
      DontDestroyOnLoad(gameObject);
      bestScore = StoredScore.Load();
    }
  }

}
