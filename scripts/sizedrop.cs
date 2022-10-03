using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

namespace CoffeePattern
{
    public class sizedrop : MonoBehaviour
    {
        public TextMeshProUGUI yourCoffeeText1;
        public void HandleInputData2(int val)
        {
            ICoffee coffee = new Coffee();
            if (val == 0)
            {
                ICoffee SizeOneDecorator = new SizeOneDecorator(coffee);
                yourCoffeeText1.text = coffee.GetCoffeeType();
                yourCoffeeText1.text = "16oz";
            }

            if (val == 1)
            {
                ICoffee SizeTwoDecorator = new SizeTwoDecorator(coffee);
                yourCoffeeText1.text = coffee.GetCoffeeType();
                yourCoffeeText1.text = "24oz";
            }

            if (val == 2)
            {
                ICoffee SizeThreeDecorator = new SizeThreeDecorator(coffee);
                yourCoffeeText1.text = coffee.GetCoffeeType();
                yourCoffeeText1.text = "32oz";
            }
        }
    }
}