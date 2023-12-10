using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BackgroundView : MonoBehaviour
{
   [SerializeField] private RawImage _img;
   [SerializeField] private float _x, _y;
  

    // Update is called once per frame below is code to move our image at our designated speed either across the y or x axis.
    void Update()
    {
        _img.uvRect = new Rect(_img.uvRect.position + new Vector2(_x, _y) * Time.deltaTime, _img.uvRect.size);
   
    }
}
