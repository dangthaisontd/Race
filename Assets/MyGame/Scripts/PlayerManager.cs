using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class PlayerManager : MonoBehaviour
{
    private bool isColider=false;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnTriggerEnter(Collider other)
    {
        if ((other.gameObject.name == "Finish")&&(isColider==false))
        {
            GameManager.Instance.SetLapsCar();
            isColider = true;
        }
    }
    private void OnTriggerExit(Collider other)
    {
        Invoke("Reset", 1);   
    }
    private void Reset()
    {
        isColider = false;
    }
    private void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.tag=="Coin")
        {
            GameManager.Instance.SetCoinCar();
            Destroy(collision.gameObject);
        }
        
    }
      
}
