using System.Collections;
using System.Collections.Generic;
using SUIFW;
using UnityEngine;

public class GameStart : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        UIManager.GetInstance().ShowUIForms("OnePageController");
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
