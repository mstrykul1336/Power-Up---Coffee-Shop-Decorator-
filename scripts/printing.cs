using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
namespace CoffeePattern{
    public class printing : MonoBehaviour
    {
        public TextMeshProUGUI yourCoffeeTextE;
        ICoffee coffee = new Coffee();
        // Start is called before the first frame update
        void Start()
        {
            yourCoffeeTextE.text = coffee.GetCoffeeType();
        }

        // Update is called once per frame
        void Update()
        {
            
        }
    }
}
