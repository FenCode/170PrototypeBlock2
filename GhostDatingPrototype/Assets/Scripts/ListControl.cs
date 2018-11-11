using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ListControl : MonoBehaviour
{
    private List<Emoji> listEmoji;//list of emojis
    private List<GameObject> buttons;
    [SerializeField]
    private GameObject btnTemplate;
    //[SerializeField]
    //private Sprite[] emojiSprites;
    private Sprite HappyEmoji;
    private Sprite SadEmoji;
    private Sprite AngryEmoji;
    private Sprite ThinkingEmoji;

    void Start()
    {
        listEmoji = new List<Emoji>();
        buttons = new List<GameObject>();

        if(buttons.Count > 0)
        {
            foreach(GameObject button in buttons)
            {
                Destroy(button.gameObject);
            }
            buttons.Clear();
        }

        foreach(Emoji emoji in listEmoji)
        {
            GameObject button = Instantiate(btnTemplate) as GameObject;
            button.SetActive(true);
            button.GetComponent<Emoji>().GetEmojiImage();
            button.transform.SetParent(btnTemplate.transform.parent, false);
        }

        Emoji emoji1 = new Emoji(HappyEmoji, "emoji_happy", 10);
        Emoji emoji2 = new Emoji(SadEmoji, "emoji_sad", 3);
        Emoji emoji3 = new Emoji(AngryEmoji, "emoji_mad", 1);
        Emoji emoji4 = new Emoji(ThinkingEmoji, "emoji_thinking", 8);

        listEmoji.Add(emoji1);
        listEmoji.Add(emoji2);
        listEmoji.Add(emoji3);
        listEmoji.Add(emoji4);
    }

    public class PlayerItemEmoji
    {
        public Sprite emojiSprite;
    }
}