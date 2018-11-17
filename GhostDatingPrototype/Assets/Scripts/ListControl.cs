using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ListControl : MonoBehaviour
{
    //button template to create rest of the buttons
    [SerializeField]
    private GameObject btnTemp;

    //so we can get the sprites that are needed, using these four  emoji's as an example
    [SerializeField]
    private Sprite HappyEmoji;
    [SerializeField]
    private Sprite SadEmoji;
    [SerializeField]
    private Sprite AngryEmoji;
    [SerializeField]
    private Sprite ThinkingEmoji;

    private List<Emoji> listEmoji;//list of emojis
    private List<GameObject> buttons;//list of buttons

    //image object to assign sprite
    Image img;

    //created emojis
    private Emoji emoji1;
    private Emoji emoji2;
    private Emoji emoji3;
    private Emoji emoji4;

    void Start()
    {
        listEmoji = new List<Emoji>();
        buttons = new List<GameObject>();

        //this will check if there are buttons already been made
        //deletes the old buttons and replaces them with newer iteration
        //prevents creating buttons on top of eachother
        if(buttons.Count > 0)
        {
            foreach (GameObject button in buttons)
            {
                Destroy(button.gameObject);
            }
            buttons.Clear();
        }

        //example emojis
        //could also make serializeble fields to input these values
        emoji1 = new Emoji(HappyEmoji, "emoji_happy", 10);
        emoji2 = new Emoji(SadEmoji, "emoji_sad", 3);
        emoji3 = new Emoji(AngryEmoji, "emoji_mad", 1);
        emoji4 = new Emoji(ThinkingEmoji, "emoji_thinking", 8);

        listEmoji.Add(emoji1);
        listEmoji.Add(emoji2);
        listEmoji.Add(emoji3);
        listEmoji.Add(emoji4);

        //adding to the list

        //alternative way of adding
        //listEmoji.Add(new Emoji(HappyEmoji, "emoji_happy", 10));
        //listEmoji.Add(new Emoji(SadEmoji, "emoji_sad", 3));
        //listEmoji.Add(new Emoji(AngryEmoji, "emoji_mad", 1));
        //listEmoji.Add(new Emoji(ThinkingEmoji, "emoji_thinking", 8));

        //creating the buttons based on the number of emojis
        foreach (Emoji e in listEmoji)
        {
            GameObject button = Instantiate(btnTemp) as GameObject;
            button.SetActive(true);
            button.GetComponent<Emoji>().setEmoji(e);//set to the button the emoji that corresponds to it
            img = button.GetComponent<Image>();
            img.sprite = button.GetComponent<Emoji>().GetEmojiIcon();//setting to the image of the sprite emoji
            button.transform.SetParent(btnTemp.transform.parent, false);
        }
    }

    void Update()
    {
        
    }

    //used to see correlation between button and emoji
    public void ButtonClicked(Sprite sprite, string name, int weight)
    {
        Debug.Log(sprite);
        Debug.Log(name);
        Debug.Log(weight);
    }
}