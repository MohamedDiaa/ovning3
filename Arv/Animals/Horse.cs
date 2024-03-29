﻿using System;
using System.Xml.Linq;

namespace Arv
{
	public class Horse: Animal
	{
        private double weight;

        public Horse(string namn, double vikt, double age, double weight) : base(namn: namn, vikt: vikt, age: age)
        {
            this.weight = weight;
		}

        public override void DoSound()
        {
            Console.WriteLine("it sound like a horse");
        }

        public override string Stats()
        {
            string baseString = base.Stats();

            return $"{base.Stats()}, weight: {weight}";
        }
    }
}

