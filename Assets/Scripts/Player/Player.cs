using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public static Player Instance;
    [SerializeField]Material material;

    public void Awake() 
    {
        Instance = this;    
    }
    void Update()
    {
        transform.Rotate(90*Time.deltaTime, 0, 0);
    }

    public void ColorChange()
    {
        material.color = new Color(Random.Range(0, 1f), Random.Range(0, 1f), Random.Range(0, 1f));
    }
}
