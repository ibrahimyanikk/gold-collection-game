using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playercontroll : MonoBehaviour
{
    // Start is called before the first frame update
    private float hiz = 7f;
    private float altinsayisi = 0f;
    public UnityEngine.UI.Text altinsayi,bitme;
    bool oyuntamam = false;
    bool oyundevam = true;
    private float zamansayaci = 120f;

    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (zamansayaci > 0)
        {
            zamansayaci -= Time.deltaTime;
           // zaman.text = (int)zamansayaci + "";
        }
        float x = Input.GetAxis("Horizontal");
        float y = Input.GetAxis("Vertical");
        x *= Time.deltaTime * hiz;
        y *= Time.deltaTime * hiz;
        transform.Translate(x, 0f, y);
        if((altinsayi.text=="3")&&(zamansayaci>0))
        {
            oyundevam = false;
        }
        if(oyuntamam)
        {
            bitme.text = "WELL DONE";
        }
        else if(oyundevam==false)
        {
            bitme.text = "GAME OVER   TRY AGAIN";
        }
    }

    private void OnCollisionEnter(Collision cls)
    {
        if (cls.gameObject.name.Equals("finish")&&(oyundevam==false))
        {
            oyuntamam = true;
        }
        string objismi = cls.gameObject.name;


        if (cls.gameObject.name.Equals("gold"))
        {
            // Altýn sayýsýný artýr
            altinsayisi += 1;

            // Altýn sayýsýný UI text elemanýnda güncelle
            altinsayi.text = altinsayisi + "";

            // Çarpýþýlan nesneyi yok et
            Destroy(cls.gameObject);
        }
        if (cls.gameObject.name.Equals("Plane"))
        {
            oyundevam = false;
        }
        
        
    }
}
