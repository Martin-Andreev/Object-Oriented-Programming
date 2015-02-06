namespace TheSlum.Characters
{
    using System;
    using System.Linq;
    using System.Collections.Generic;
    using TheSlum.Interfaces;

    class Mage : Character, IAttack
    {
        private int attackPoints = 300;

        public Mage(string id, int x, int y, int healthPoints, int defensePoints, Team team, int range, int attackPoints)
            : base(id, x, y, healthPoints, defensePoints, team, range)
        {
            this.AttackPoints = attackPoints;
        }

        public int AttackPoints
        {
            get { return this.attackPoints; }
            set { this.attackPoints = value; }
        }

        public override Character GetTarget(IEnumerable<Character> targetsList)
        {
            var attackableTargets = targetsList
                .Where(t => t.IsAlive == true && !t.Team.Equals(this.Team)).ToList();
            if (attackableTargets.Count == 0)
            {
                return null;
            }
            return attackableTargets.Last();
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
            this.AttackPoints += item.AttackEffect;
        }

        protected override void RemoveItemEffects(Item item)
        {
            this.HealthPoints -= item.HealthEffect;
            this.DefensePoints -= item.DefenseEffect;
            this.AttackPoints -= item.AttackEffect;
            if (this.HealthPoints < 0)
            {
                this.HealthPoints = 1;
            }
        }

        public override string ToString()
        {
            return "-- " + base.ToString() + string.Format(", Attack: {0}", this.AttackPoints);
        }
    }
}
