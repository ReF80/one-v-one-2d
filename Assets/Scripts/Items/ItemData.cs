using DefaultNamespace;
using UnityEngine;

    [CreateAssetMenu(fileName = "Ammo", order = 1)]
    public class ItemData : ScriptableObject, IItem
    {
        [SerializeField] public Sprite icon;
        [SerializeField] public int value;
        [SerializeField] public ItemType type;
        [SerializeField] public float weight;
        [SerializeField] public float stack;
        
        public Sprite Icon => icon;

        public enum ItemType
        {
            Armor,
            Helmet,
            Medkit,
            Ammo
        }
    }