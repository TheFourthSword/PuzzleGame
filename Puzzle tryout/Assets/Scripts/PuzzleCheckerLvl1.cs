using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PuzzleCheckerLvl1 : MonoBehaviour
{
    [SerializeField] private PlaceChecker[] WhereAmI;
    [SerializeField] private int WhichScene;

    public void SsolveChecker()
    {
        //if the check is ture, console will print "puzzle solved" and start the routine to load the next scene
        if (SolveChecker() == true)
        {
            print("PuzzelSolved");
            StartCoroutine(LevelDelay());
        }
    }

    //Code waits half a second before loading the scene, in each scene is marked what the next scene to load is
    private IEnumerator LevelDelay()
    {
        yield return new WaitForSeconds(0.5f);
        SceneManager.LoadScene(WhichScene);

    }

    //foreach used for convenience, to immediately look through the entire list instead of one item at a time
    //function will check if all components are on true, if not, it stops and returns false
    //function will be used when a cube is placed in one of the puzzle spots
    private bool SolveChecker()
    {
        foreach (PlaceChecker item in WhereAmI)
        {
            if (item.PuzzlePartSolved == false)
            {
                return false;
            }
        }
        return true;
    }
}
