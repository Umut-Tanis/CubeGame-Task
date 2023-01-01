using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameButton : MonoBehaviour
{
    public bool isHit;
    public Counter counter;

    public void OnButtonClick()
    {
        if (Mathf.Abs(Player.Instance.transform.rotation.eulerAngles.x) <= 15 && !isHit)
        {
            StartCoroutine("ResetHit");
            counter.IncreaseCounter();
        }
    }

    public IEnumerable ResetHit()
    {
        yield return new WaitForSeconds(0.05f);
        isHit = false;
    }

}