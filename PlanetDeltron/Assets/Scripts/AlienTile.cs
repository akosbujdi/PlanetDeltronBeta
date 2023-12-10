using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;

public class AlienTile : MonoBehaviour
{
    private float offset = 1.5f;
    private int rotation = 270;
    private Vector3 startPos;
    public GameObject alien;
    public GameObject parent;
    public int seconds;
    // Start is called before the first frame update
    void Start()
    {
        float randomVal = Random.Range(-offset, offset);
        if (transform.rotation.eulerAngles.y == 90)
        {
            rotation = 270;
            startPos = parent.transform.position + new Vector3(0, 0.6f, randomVal);
        } else
        {
            rotation = 180;
            startPos = parent.transform.position + new Vector3(randomVal, 0.6f, 0);
        }
        Instantiate(alien,startPos,Quaternion.Euler(0,rotation,0));
    }

    // Update is called once per frame
    void Update()
    {
    }
}
