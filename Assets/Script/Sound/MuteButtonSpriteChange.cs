using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class MuteButtonSpriteChange : MonoBehaviour
{

    Button targetButton;
    Image targetImage;
    public Sprite[] notMuteSprite;
    public Sprite[] muteSprite;

    SpriteState muteState;
    SpriteState notMuteState;

    bool IsMute = false;
    // Start is called before the first frame update
    void Start()
    {
        targetButton = this.gameObject.GetComponent<Button>();
        targetImage = this.gameObject.GetComponent<Image>();

        muteState.pressedSprite = muteSprite[2];
        muteState.highlightedSprite = muteSprite[1];
        muteState.selectedSprite = muteSprite[0];

        notMuteState.pressedSprite = notMuteSprite[2];
        notMuteState.highlightedSprite = notMuteSprite[1];
        notMuteState.selectedSprite = notMuteSprite[0];
    }

    public void SetButtonSprite(){
        IsMute = !IsMute;
        if(IsMute){
            targetImage.sprite = muteSprite[0];
            targetButton.spriteState = muteState;
        }
        else
        {
            targetImage.sprite = notMuteSprite[0];
            targetButton.spriteState = notMuteState;
        }
    }

}
