﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LoadChildName : MonoBehaviour
{
    public String_SO selectedChildSO;

    // Start is called before the first frame update
    void Update()
    {
        this.GetComponent<Text>().text = selectedChildSO.currentString;
    }
    
}
