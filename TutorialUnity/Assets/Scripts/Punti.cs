using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Punti : MonoBehaviour
{
    public static int valorePunti;
    
    // Start is called before the first frame update
    void Start()
    {
        valorePunti = 0;
    }
    
    public void OnTriggerEnter2D (Collider2D collision)
    {
        if (collision.name.Contains("Carne")) {

            valorePunti++;
            collision.gameObject.SetActive(false);
            
        }
    }
    
    // Update is called once per frame
    void Update()
    {
       
       
        GetComponent<Text>().text = valorePunti.ToString();


    }
}
