using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

namespace CoffeePattern
{
    public class Program : MonoBehaviour
    {
    }

    public interface ICoffee
    {
        string GetCoffeeType();
    }
    

    public class Coffee : ICoffee
    {
        public string GetCoffeeType()
        {
            return "This is a basic espresso";
        }
    }

    public class CoffeeDecorator : ICoffee
    {
        private ICoffee _coffee;
        public TextMeshProUGUI yourCoffeeText;
        public CoffeeDecorator(ICoffee coffee)
        {
            _coffee = coffee;
        }
        public virtual string GetCoffeeType()
        {
            return _coffee.GetCoffeeType();
        }
    }

    public class MilkDecorator : CoffeeDecorator
    {
        public MilkDecorator(ICoffee coffee) : base (coffee) {}
        public override string GetCoffeeType()
        {
            string type = base.GetCoffeeType();
            type += "\r\n with 2% milk.";
            Debug.Log("working");
            return type;
        }
            
    }

    public class OatDecorator : CoffeeDecorator
    {
        public OatDecorator(ICoffee coffee) : base (coffee) {}
        public override string GetCoffeeType()
        {
            string type = base.GetCoffeeType();
            type += "\r\n with oat milk.";
            return type;
        }
    }

    public class AlmondDecorator : CoffeeDecorator
    {
        public AlmondDecorator(ICoffee coffee) : base (coffee) {}
        public override string GetCoffeeType()
        {
            string type = base.GetCoffeeType();
            type += "\r\n wth almond milk.";
            return type;
        }
    }

    public class SizeOneDecorator : CoffeeDecorator
    {
        public SizeOneDecorator(ICoffee coffee) : base (coffee) {}
        public override string GetCoffeeType()
        {
            string type = base.GetCoffeeType();
            type += "\r\n 16oz.";
            return type;
        }
    }

    public class SizeTwoDecorator : CoffeeDecorator
    {
        public SizeTwoDecorator(ICoffee coffee) : base (coffee) {}
        public override string GetCoffeeType()
        {
            string type = base.GetCoffeeType();
            type += "\r\n 24oz.";
            return type;
        }
    }

    public class SizeThreeDecorator : CoffeeDecorator
    {
        public SizeThreeDecorator(ICoffee coffee) : base (coffee) {}
        public override string GetCoffeeType()
        {
            string type = base.GetCoffeeType();
            type += "\r\n 32oz.";
            return type;
        }
    }

    public class ShotOneDecorator : CoffeeDecorator
    {
        public ShotOneDecorator(ICoffee coffee) : base (coffee) {}
        public override string GetCoffeeType()
        {
            string type = base.GetCoffeeType();
            type += "\r\n with one shot.";
            return type;
        }
    }

    public class ShotTwoDecorator : CoffeeDecorator
    {
        public ShotTwoDecorator(ICoffee coffee) : base (coffee) {}
        public override string GetCoffeeType()
        {
            string type = base.GetCoffeeType();
            type += "\r\n with two shots.";
            return type;
        }
    }

    public class ShotThreeDecorator : CoffeeDecorator
    {
        public ShotThreeDecorator(ICoffee coffee) : base (coffee) {}
        public override string GetCoffeeType()
        {
            string type = base.GetCoffeeType();
            type += "\r\n with three shots.";
            return type;
        }
    }

    public class SyrupDecorator : CoffeeDecorator
    {
        public SyrupDecorator(ICoffee coffee) : base (coffee) {}
        public override string GetCoffeeType()
        {
            string type = base.GetCoffeeType();
            type += "with flavored syrup.";
            return type;
        }
    }

    public class CreamDecorator : CoffeeDecorator
    {
        public CreamDecorator(ICoffee coffee) : base (coffee) {}
        public override string GetCoffeeType()
        {
            string type = base.GetCoffeeType();
            type += "with whipped cream.";
            return type;
        }
    }

    public class DrizzleDecorator : CoffeeDecorator
    {
        public DrizzleDecorator(ICoffee coffee) : base (coffee) {}
        public override string GetCoffeeType()
        {
            string type = base.GetCoffeeType();
            type += "with syrup drizzle.";
            return type;
        }
    }
}
