using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.Video;

public class Life : MonoBehaviour
{
    private TextMeshPro textField;
    public int numOfLife=3;
    public static Life life;

    // Start is called before the first frame update
    void Start()
    {
        life = this;
        textField = GetComponent<TextMeshPro>();
        if (!textField)
            throw new MissingComponentException("Object must contain a TextMeshPro field!");
      
    }
    private void Update()
    {
        this.textField.text = numOfLife.ToString();
    }

    public void decreaseLife()
    {
        numOfLife--;
    }

    public void addLife()
    {
        numOfLife++;
    }
  

}
    
