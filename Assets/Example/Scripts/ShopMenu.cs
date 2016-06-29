using UnityEngine;
using System.Collections.Generic;

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

    void Reset()
    {
        var list = new List<Drink>();

        {
            var d = new Drink();
            d.Name = "Darjeeling";
            d.Price = 10.99f;
            list.Add(d);
        }

        {
            var d = new Drink();
            d.Name = "Assam";
            d.Price = 9.99f;
            list.Add(d);
        }

        {
            var d = new Drink();
            d.Name = "Orange Pekoe";
            d.Price = 8.99f;
            list.Add(d);
        }

        {
            var d = new Drink();
            d.Name = "Rose Hip";
            d.Price = 7.99f;
            list.Add(d);
        }

        this.Drinks = list.ToArray();
    }
}
