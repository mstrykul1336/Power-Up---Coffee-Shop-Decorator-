using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

namespace CoffeePattern
{
    public class shotdrop : MonoBehaviour
    {
        public TextMeshProUGUI yourCoffeeText2;
        public void HandleInputData2(int val)
        {
            ICoffee coffee = new Coffee();
            if (val == 0)
            {
                ICoffee ShotOneDecorator = new ShotOneDecorator(coffee);
                yourCoffeeText2.text = coffee.GetCoffeeType();
                yourCoffeeText2.text = "with one shot of espresso";
            }

            if (val == 1)
            {
                ICoffee ShotTwoDecorator = new ShotTwoDecorator(coffee);
                yourCoffeeText2.text = coffee.GetCoffeeType();
                yourCoffeeText2.text = "with two shots of espresso";
            }
            if (val == 2)
            {
                ICoffee ShotThreeDecorator = new ShotThreeDecorator(coffee);
                yourCoffeeText2.text = coffee.GetCoffeeType();
                Debug.Log("3 shot");
                yourCoffeeText2.text = "with three shots of espresso";

            }
        }
    }
}