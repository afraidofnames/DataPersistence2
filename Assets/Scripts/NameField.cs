using UnityEngine;
using UnityEngine.UI;

public class NameField : MonoBehaviour {

  private InputField Field;

  // Start is called before the first frame update
  void Start() {
    Field = GetComponent<InputField>();
    
  }

  public void UpdateName() {
    PersistenceManager.Instance.playerName = Field.text;
  }
  
}
