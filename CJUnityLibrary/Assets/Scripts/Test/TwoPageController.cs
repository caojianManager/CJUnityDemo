using System;
using System.Collections;
using System.Collections.Generic;
using SUIFW;
using UnityEngine;

public class TwoPageController : BaseUIForm
{
    private void Awake()
    {
        CurrentUIType.UIForms_Type = UIFormType.Normal;
       
    }

    // Start is called before the first frame update
    void Start()
    {
        UIMaskMgr.GetInstance().SetMaskWindow(this.gameObject,UIFormLucenyType.Lucency);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    
    
    
}
