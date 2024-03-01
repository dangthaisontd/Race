using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public int positonCar;
    public int lapsCar;
    public int coinCar=0;
    public float km;
    // Start is called before the first frame update
    private static GameManager _instace;
    public static GameManager Instance
    {
        get { return _instace; }
        set { _instace = value; }
    }
    void Start()
    {
        _instace = this;
    }
    // Update is called once per frame
    void Update()
    {
        
    }
    public void SetCoinCar()
    {
        coinCar += 1;
    }
    public void SetLapsCar()
    {
        lapsCar += 1;
    }
}
