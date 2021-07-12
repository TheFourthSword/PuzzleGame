using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlaceChecker : MonoBehaviour
{
    private PuzzleCheckerLvl1 PuzzleCheckerLvl1;

    //immediately start the puzzlechecker
    private void Start()
    {
        PuzzleCheckerLvl1 = FindObjectOfType<PuzzleCheckerLvl1>();
    }

    //the puzzle is automatically not solved
    public int RightSpot;
    public bool PuzzlePartSolved = false;
    //if the gameobject enters the right trigger area, it will be marked that that part of the puzzle is solved
    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.layer == 8)
        {
            if(other.gameObject.GetComponent <FirstLevelCube>().Place == RightSpot )
            {
                PuzzlePartSolved = true;
                PuzzleCheckerLvl1.SsolveChecker();
            }
        }
    }

    //if the correct object is removed from its trigger, the solve will be marked false
    private void OnTriggerExit(Collider other)
    {
        if(PuzzlePartSolved == true)
        {
            PuzzlePartSolved = false;
        }
    }

}
