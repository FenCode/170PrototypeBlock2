using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

//Aspects of a emoji: image, name, and weight it carries
public class Emoji {

    [SerializeField]
    private Image emojiImage;// image for the emoji
    [SerializeField]
    private Sprite emojiIcon;// image for the emoji
    [SerializeField]
    private string emojiName;//name of the emoji
    [SerializeField]
    private int emojiWeight;//holds the emoji emotional value (1-10? 1-100?) 0 for sad, 10 for happy as a test basis for the emoji's

    public Emoji(Sprite newIcon, string newName, int newWeight)//constructor
    {
        this.emojiIcon = newIcon;
        this.emojiName = newName;
        this.emojiWeight = newWeight;
    }

    public Emoji(Image newImage, string newName, int newWeight)//constructor
    {
        this.emojiImage = newImage;
        this.emojiName = newName;
        this.emojiWeight = newWeight;
    }

    public void SetEmojiImage(Sprite mySprite)//set sprite
    {
        if (mySprite != null)
        {
            emojiImage.sprite = mySprite;
        }
        Debug.Log(emojiImage);
    }

    public Image GetEmojiImage()
    {
        return emojiImage;
    }

    public void SetEmojiIcon(Sprite mySprite)//set sprite
    {
        if (mySprite != null)
        {
            emojiIcon = mySprite;
        }
        Debug.Log(emojiIcon);
    }

    public Sprite GetEmojiIcon()
    {
        return emojiIcon;
    }

    public void SetEmojiName(string myName)//set name
    {
        if (myName != null)
        {
            emojiName = myName;
        }
        Debug.Log(emojiName);
    }

    public string GetEmojiName()
    {
        return emojiName;
    }

    public void SetEmojiWeight(int myWeight)//set weight
    {
        if(!(myWeight > 10 && myWeight <= 0))
        {
            emojiWeight = myWeight;
        }
        Debug.Log(emojiWeight);
    }

    public int GetEmojiWeight()
    {
        return emojiWeight;
    }

}
