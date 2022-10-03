using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

namespace CoffeePattern
{
    public class adddrop : MonoBehaviour
    {
        public TextMeshProUGUI yourCoffeeText3;
        public void HandleInputData2(int val)
        {
            ICoffee coffee = new Coffee();
            if (val == 0)
            {
                ICoffee SyrupDecorator = new SyrupDecorator(coffee);
                yourCoffeeText3.text = coffee.GetCoffeeType();
                yourCoffeeText3.text = "with flavored syrup!";
            }

            if (val == 1)
            {
                ICoffee CreamDecorator = new CreamDecorator(coffee);
                yourCoffeeText3.text = coffee.GetCoffeeType();
                yourCoffeeText3.text = "with whipped cream!";
            }

            if (val == 2)
            {
                ICoffee DrizzleDecorator = new DrizzleDecorator(coffee);
                yourCoffeeText3.text = coffee.GetCoffeeType();
                yourCoffeeText3.text = "with flavored syrup drizzle";
            }
        }
    }
}