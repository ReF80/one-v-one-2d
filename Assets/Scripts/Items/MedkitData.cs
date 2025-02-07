using UnityEngine;

namespace DefaultNamespace
{
    [CreateAssetMenu(fileName = "Medkit", order = 1)]
    public class MedkitData : ScriptableObject, IItem
    {
        [SerializeField] private Sprite icon;
        [SerializeField] private int heal;
        [SerializeField] private string type;
        [SerializeField] private float weight;
    
        public Sprite Icon => icon;
        public string Type => type;
        public int Heal => heal;
        public float Weight => weight;
    }
}