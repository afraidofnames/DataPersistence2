#if UNITY_EDITOR
using UnityEditor;
#endif
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class MenuManager : MonoBehaviour {

  public Text highScoreText;

  private void Start() {
    var bestScore = PersistenceManager.Instance.bestScore;
    highScoreText.text = "Best Score: " + bestScore.name + " " + bestScore.score;
  }

  public void StartGame() {
    SceneManager.LoadScene("main");
  }

  public void Quit() {
#if UNITY_EDITOR
    EditorApplication.ExitPlaymode();
#else
    Application.Quit();
#endif
  }

}
