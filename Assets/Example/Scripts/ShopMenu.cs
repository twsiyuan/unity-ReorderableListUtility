using UnityEngine;

public class ShopMenu : MonoBehaviour
{
    public Drink[] Drinks = new Drink[0];

    [System.Serializable]
    public struct Drink
    {
        public string Name;
        public float Price;
        public Color Color;
    }
}
