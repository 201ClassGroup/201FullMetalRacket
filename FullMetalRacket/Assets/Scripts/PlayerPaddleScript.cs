using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerPaddleScript : MonoBehaviour
{
    public Rigidbody2D tempBall;
    public int powerUpAffect;

    public float powerUpTimer = 0;

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
                    if (powerUpTimer < 10f)
                    {
                        powerUpTimer += Time.deltaTime;
                        BigPaddlePowerUp();
                    }
                    else
                    {
                        ResetTimer();
                        this.transform.localScale = new Vector3(3, 1, 1);

                    }
                    break;
                }
            case 2:
                {
                    ShootExtraBall();
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
            default:
                {
                    powerUpTimer = 0;
                    break;
                }
        }


    }

    void ShootExtraBall()
    {
        if (Input.GetKeyDown(KeyCode.S) && GetComponent<Move>().typeOfControl == Enums.KeyGroups.WASD)
        {
            Rigidbody2D clone;
            clone = Instantiate(tempBall, transform.position, transform.rotation);
            powerUpAffect = 0;
        }
        else if (Input.GetKeyDown(KeyCode.DownArrow) && GetComponent<Move>().typeOfControl == Enums.KeyGroups.ArrowKeys)
        {
            Rigidbody2D clone;
            clone = Instantiate(tempBall, new Vector3 (transform.position.x, transform.position.y-1, transform.position.z), transform.rotation);
            powerUpAffect = 0;
        }

    }

    void BigPaddlePowerUp()
    {

        this.transform.localScale = new Vector3(5, 1, 1);
        
    }

    void ResetTimer()
    {
        powerUpTimer = 0;
        powerUpAffect = 0;
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
