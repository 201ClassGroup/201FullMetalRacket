using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BlockScript : MonoBehaviour
{
    public int hitPoints;

    public enum StateBlock {full = 2, broken = 1, broke = 0  };
    public StateBlock blockState;

    [Tooltip("This uses 3 Materials for the state of the block, Full, half, about to break")]
    public Material[] blockStateMaterials;

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
                   // if (blockStateMaterials[2] != null)
                    //    gameObject.GetComponent<MeshRenderer>().material = blockStateMaterials[2];
                    break;
                }
            case (int)StateBlock.broken:
                {
                    if (blockStateMaterials[0] != null)
                        gameObject.GetComponent<MeshRenderer>().material = blockStateMaterials[0];
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

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Ball"))
        {
            AddHit();
        }
    }

}
