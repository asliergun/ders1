using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class merhabadunya : MonoBehaviour
{
    public GameObject[] kupler;
    string ad = "Asli";
    int rasgelesayi;
    int sayi1, sayi2;
    string[] dersler = { "algoritma", "web tasarým", "oyun programlama", "matematik", "veri tabani" };
    string[] renkler = { "red", "yellow", "blue", "green" };
    // Start is called before the first frame update
    void Start()
    {
        sayi1 = 5;
        sayi2 = 7;
        
        // Debug.Log("Merhaba Dunya  "+ad);
       // Debug.Log("Toplama iþlemi sonucu: " + (sayi1 + sayi2));
      /* for(int i=0;i<dersler.Length;i++)
        {
            Debug.Log(dersler[i]);
        }
      
       foreach(string ders in dersler)
        {
            Debug.Log(ders);
        }
      */
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Space))
        {
            Debug.Log("Space basýldý");
            foreach (var kup in kupler)
            {
                rasgelesayi = Random.Range(0, renkler.Length);
                switch (rasgelesayi)
                {
                    case 0:
                        kup.GetComponent<MeshRenderer>().material.color = Color.red;
                        break;
                    case 1:
                        kup.GetComponent<MeshRenderer>().material.color = Color.yellow;
                        break;
                    case 2:
                        kup.GetComponent<MeshRenderer>().material.color = Color.blue;
                        break;
                    case 3:
                        kup.GetComponent<MeshRenderer>().material.color = Color.green;
                        break;


                }
            }

        }

    }
}
