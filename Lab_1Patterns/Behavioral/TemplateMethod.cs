using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_1Patterns.Behavioral
{
    public abstract class PotionCrafting
    {
        public void Craft() { AddBase(); AddIngredient(); }
        protected void AddBase() => System.Console.WriteLine("Template: Додано спиртову основу.");
        protected abstract void AddIngredient();
    }
    public class SwallowPotion : PotionCrafting
    {
        protected override void AddIngredient() => System.Console.WriteLine("Template: Додано мозок утопця.");
    }
}
