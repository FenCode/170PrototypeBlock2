using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ListButton : MonoBehaviour {

    [SerializeField]
    private Image emojiIcon;

    public void SetEmoji(Sprite mySprite)
    {
        emojiIcon.sprite = mySprite;
    }
}
