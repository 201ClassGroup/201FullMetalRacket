using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BlockScript : MonoBehaviour
{
    public int hitPoints;

    public enum StateBlock {full = 3, hurt = 2, broken = 1, broke = 0  };
    public StateBlock blockState;


    // Start is called before the first frame update
    void Start()
    {
        blockState = StateBlock.full;
    }

    // Update is called once per frame
    void Update()
    {
        //this switch case will be where the different materials are applied to the block at certain hit points
        switch(hitPoints)
        {
            case (int)StateBlock.full:
                {
                    break;
                }
            case (int)StateBlock.hurt:
                {
                    break;
                }
            case (int)StateBlock.broken:
                {

                    break;
                }
            case (int)StateBlock.broke:
                {
                    Destroy(gameObject);
                    break;
                }
        }
    }

    public void AddHit()
    {
        hitPoints--;
    }

}
