using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerPaddleScript : MonoBehaviour
{

    public int powerUpAffect;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        switch (powerUpAffect)
        {
            case 1:
                {
                    break;
                }
            case 2:
                {
                    break;
                }
            case 3:
                {
                    break;
                }
            case 4:
                {
                    break;
                }
            case 5:
                {
                    break;
                }
        }


    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("PowerUp"))
        {
            Debug.Log("Got Power up");
            PowerUpScript collectedPowerUp = collision.gameObject.GetComponent<PowerUpScript>();
            this.powerUpAffect = collectedPowerUp.GetPowerUpType();
            Destroy(collectedPowerUp.gameObject);
        }

    }

}
