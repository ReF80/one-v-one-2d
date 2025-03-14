using DefaultNamespace;
using UnityEngine;

    [CreateAssetMenu(fileName = "Ammo", order = 1)]
    public class ItemData : ScriptableObject, IItem
    {
        [SerializeField] public Sprite icon;
        [SerializeField] public Sprite iconAtribute;
        [SerializeField] public int value;
        [SerializeField] public ItemType type;
        [SerializeField] public float weight;
        [SerializeField] public int stack;
        [SerializeField] public int maxStack;
        [SerializeField] public string btnAction;
        
        public Sprite Icon => icon;

        public enum ItemType
        {
            Armor,
            Helmet,
            Medkit,
            Ammo
        }
    }