using System.Collections;
using System.Collections.Generic;
using System;
using UnityEngine;
using TMPro;



public class CoolDown : MonoBehaviour
{
    private TextMeshPro textField;
    private float number;
    void Start()
    {
        textField = GetComponent<TextMeshPro>();
        if (!textField)
            throw new MissingComponentException("Object must contain a TextMeshPro field!");
    }
    public float GetNumber()
    {
        return this.number;
    }
    public void SetNumber(float newNumber)
    {
        this.number = newNumber;
        this.textField.text = ((int)Math.Round(newNumber)).ToString();
    }
}
