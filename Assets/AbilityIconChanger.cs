using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class AbilityIconChanger : MonoBehaviour
{
    [SerializeField]
    List<Image> iconUI;

    [System.Serializable]
    public class TextureList
    {
        public List<Sprite> sprite;
    }
    public List<TextureList> iconImages;
    public void ChangeAbilitySet(int set)
    {
        for (int i = 0; i < iconUI.Count; i++)
        {
            iconUI[i].sprite = iconImages[set].sprite[i];
        }
    }
}
