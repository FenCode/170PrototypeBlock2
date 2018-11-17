using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class SwipeScript : MonoBehaviour {

    //Basede on code from Gustav_Bok
    //Posted: January 8, 2013 Last Edited: January 8, 2013
    //Accessed: November 10, 2018
    //https://forum.unity.com/threads/swipe-in-all-directions-touch-and-mouse.165416/

    //inside class
    Vector2 firstPressPos;
    Vector2 secondPressPos;
    Vector2 currentSwipe;
    public GameObject matchPanel;
    public GameObject mainMenuPanel;
    public Text promptText;

    private void Start()
    {
        //matchPanel = GameObject.Find("/Canvas/MatchPanel");
        //mainMenuPanel = GameObject.Find("/Canvas/MainMenuPanel");
    }

    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            //save began touch 2d point
            firstPressPos = new Vector2(Input.mousePosition.x, Input.mousePosition.y);
        }
        if (Input.GetMouseButtonUp(0))
        {
            //save ended touch 2d point
            secondPressPos = new Vector2(Input.mousePosition.x, Input.mousePosition.y);

            //create vector from the two points
            currentSwipe = new Vector2(secondPressPos.x - firstPressPos.x, secondPressPos.y - firstPressPos.y);

            //normalize the 2d vector
            currentSwipe.Normalize();

            //swipe upwards
            if (currentSwipe.y > 0 && currentSwipe.x > -0.5f && currentSwipe.x < 0.5f)
            {
                Debug.Log("up swipe");
            }
            //swipe down
            if (currentSwipe.y < 0 && currentSwipe.x > -0.5f && currentSwipe.x < 0.5f)
            {
                Debug.Log("down swipe");
            }
            //swipe left
            if (currentSwipe.x < 0 && currentSwipe.y > -0.5f && currentSwipe.y < 0.5f)
            {
                Debug.Log("left swipe");
                promptText.text = "Do you want to match with Jane?";
                activateMatch();
            }
            //swipe right
            if (currentSwipe.x > 0 && currentSwipe.y > -0.5f && currentSwipe.y < 0.5f)
            {
                Debug.Log("right swipe");
                promptText.text = "Do you want to match with Dawson?";
                activateMatch();
            }
        }

    }

    private void activateMatch()
    {
        matchPanel.SetActive(true);
        mainMenuPanel.SetActive(false);
    }
}
