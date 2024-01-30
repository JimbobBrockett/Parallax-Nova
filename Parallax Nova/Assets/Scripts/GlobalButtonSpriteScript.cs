using UnityEngine;
using UnityEngine.UI;

public class GlobalButtonSpriteScript : MonoBehaviour
{

    public Sprite[] allSprites;
    private Image currentSprite;
    private RectTransform rectTrans;

    void Start()
    {
        currentSprite = GetComponent<Image>();
        rectTrans = GetComponent<RectTransform>();
        rectTrans.localScale = new Vector3(2, 2, 1);
    }

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
