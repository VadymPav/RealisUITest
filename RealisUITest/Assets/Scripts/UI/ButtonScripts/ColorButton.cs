﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ColorButton : MonoBehaviour
{
    public Image image;
    public void ColorSwitch()
    {
        image.color = Random.ColorHSV(0, 1);
    }
}