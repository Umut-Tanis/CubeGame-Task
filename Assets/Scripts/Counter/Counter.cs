using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

[System.Serializable]
public class Counter : MonoBehaviour
{
    public int counterValue = 0;

    public static Counter Instance;
    
    public TMP_Text tmpText;

    public void Awake() 
    {
        Instance = this;    
    }

    public void IncreaseCounter()
    {
        counterValue += 1;
        tmpText.text = counterValue.ToString();
        Player.Instance.ColorChange();
        Camera.main.backgroundColor = new Color(Random.Range(0, 1f), Random.Range(0, 1f), Random.Range(0, 1f));
    }
}
