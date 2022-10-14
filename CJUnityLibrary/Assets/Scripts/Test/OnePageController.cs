using System;
using System.Collections;
using System.Collections.Generic;
using SUIFW;
using UnityEngine;

public class OnePageController : BaseUIForm
{
    private void Awake()
    {
        CurrentUIType.UIForms_Type = UIFormType.Normal;
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void clickButton()
    {
        OpenUIForm("TwoPageController");
    }


    public void ClickTopButton()
    {
        CloseUIForm();
    }
}
