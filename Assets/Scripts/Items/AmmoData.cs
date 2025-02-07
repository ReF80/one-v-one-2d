using UnityEngine;

namespace DefaultNamespace
{
    [CreateAssetMenu(fileName = "Ammo", order = 1)]
    public class AmmoData : ScriptableObject, IItem
    {
        [SerializeField] private Sprite icon;
        [SerializeField] private int ammo;
        [SerializeField] private string type;
        [SerializeField] private float weight;
    
        public Sprite Icon => icon;
        public int Ammo => ammo;
        public string Type => type;
        public float Weight => weight;
    }
}