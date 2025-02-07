using UnityEngine;

namespace DefaultNamespace
{
    [CreateAssetMenu(fileName = "Armor", order = 1)]
    public class ArmorData : ScriptableObject, IItem
    {
        [SerializeField] private Sprite icon;
        [SerializeField] private int armor;
        [SerializeField] private string type;
        [SerializeField] private float weight;
    
        public Sprite Icon => icon;
        public string Type => type;
        public int Armor => armor;
        public float Weight => weight;
    }
}