using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PowerUpScript : MonoBehaviour
{
    public int powerUpType;

    // Start is called before the first frame update
    void Start()
    {
        powerUpType = (int)Random.Range(1,5);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public int GetPowerUpType()
    {
        return powerUpType;
    }

}
