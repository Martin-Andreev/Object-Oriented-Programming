﻿namespace TheSlum.Characters
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using TheSlum.Interfaces;

    class Healer : Character, IHeal
    {
        private int healingPoints = 60;

        public Healer(string id, int x, int y, int healthPoints, int defensePoints, Team team, int range, int healingPoints)
            : base(id, x, y, healthPoints, defensePoints, team, range)
        {
            this.HealingPoints = healingPoints;
        }

        public int HealingPoints
        {
            get { return this.healingPoints; }
            set { this.healingPoints = value; }
        }

        public override Character GetTarget(IEnumerable<Character> targetsList)
        {
            var healableTagets = targetsList
                .Where(t => t.IsAlive == true && t.Team == this.Team)
                .OrderBy(t => t.HealthPoints)
                .ToList();

            if (!healableTagets.First().Equals(this))
            {
                return healableTagets.First();
            }
            healableTagets.RemoveAt(0);
            return healableTagets.First();
        }

        public override void AddToInventory(Item item)
        {
            this.Inventory.Add(item);
            ApplyItemEffects(item);
        }

        public override void RemoveFromInventory(Item item)
        {
            this.Inventory.Remove(item);
            RemoveItemEffects(item);
        }

        protected override void ApplyItemEffects(Item item)
        {
            this.HealthPoints += item.HealthEffect;
            this.DefensePoints += item.DefenseEffect;
        }

        protected override void RemoveItemEffects(Item item)
        {
            this.HealthPoints -= item.HealthEffect;
            this.DefensePoints -= item.DefenseEffect;
            if (this.HealthPoints < 0)
            {
                this.HealthPoints = 1;
            }
        }

        public override string ToString()
        {
            return "-- " + base.ToString() + string.Format(", Healing: {0}", this.HealingPoints);
        }
    }
}
