using System;
using Unity.VisualScripting;
using UnityEngine;

[Serializable]
public class Armor
{
    [field: SerializeField]
    public int headArmor { get; set; } = 0;
    
    [field: SerializeField]
    public int bodyArmor { get; set; } = 0;
    
    public void PutOn(int value, ItemData.ItemType type)
    {
        switch (type)
        {
            case ItemData.ItemType.Helmet:
                HeadArmor(value);
                break;
            case ItemData.ItemType.Armor:
                BodyArmor(value);
                break;
        }
    }

    private void HeadArmor(int value) => headArmor = value;
    private void BodyArmor(int value) => bodyArmor = value;
}