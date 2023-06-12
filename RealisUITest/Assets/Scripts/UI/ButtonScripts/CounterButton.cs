using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class CounterButton : MonoBehaviour
{
    private int counter = 0;
    public TextMeshProUGUI text;

    private void Start()
    {
        text.text = counter.ToString();
    }

    public void IncreaseCounter()
    {
        counter++;
        text.text = counter.ToString();
    }
}
