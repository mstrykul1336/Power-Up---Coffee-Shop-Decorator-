using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

namespace CoffeePattern
{
    public class dropdowns : MonoBehaviour
    {
        public TextMeshProUGUI yourCoffeeText;
        public void HandleInputData(int val)
        {
            ICoffee coffee = new Coffee();
            if (val == 0)
            {
                ICoffee MilkDecorator = new MilkDecorator(coffee);
                yourCoffeeText.text = coffee.GetCoffeeType();
                yourCoffeeText.text = "with 2% milk";
            }

            if (val == 1)
            {
                ICoffee OatDecorator = new OatDecorator(coffee);
                yourCoffeeText.text = coffee.GetCoffeeType();
                yourCoffeeText.text = "with oat milk";
            }

            if (val == 2)
            {
                ICoffee AlmondDecorator = new AlmondDecorator(coffee);
                yourCoffeeText.text = coffee.GetCoffeeType();
                Debug.Log("almond milk");
                yourCoffeeText.text = "with almond milk";
            }
        }
    }
}