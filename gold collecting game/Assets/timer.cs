using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class timer : MonoBehaviour
{
    // Start is called before the first frame update
    float zamansayaci = 120f;
    public UnityEngine.UI.Text zaman,bitme;
    bool oyundevam = true;
    
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (zamansayaci > 0)
        {
            zamansayaci -= Time.deltaTime;
            zaman.text = (int)zamansayaci + "";
        }
        else
        {
            bitme.text = "GAME OVER";
            oyundevam = false;
        }
    }
}
