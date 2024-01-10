using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GlobalButtonSpriteScript : MonoBehaviour
{

    public Sprite[] allSprites;
    private Image currentSprite;
    private RectTransform rectTrans;

    // Start is called before the first frame update
    void Start()
    {
        currentSprite = GetComponent<Image>();
        rectTrans = GetComponent<RectTransform>();
        rectTrans.localScale = new Vector3(2, 2, 1);
    }

    // Update is called once per frame
    void Update()
    {
        if (!LevelSelectionScript.levelOneComplete)
        {
            currentSprite.sprite = allSprites[0];
        }
        else if (LevelSelectionScript.levelOneComplete && !LevelSelectionScript.levelTwoComplete)
        {
            currentSprite.sprite = allSprites[1];
        }
        else if (LevelSelectionScript.levelTwoComplete)
        {
            currentSprite.sprite = allSprites[2];
        }
    }
}
