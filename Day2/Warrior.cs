using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day2
{
    enum State
    {
        Alive, Dead, Graveyard
    }

    class Warrior
    {
        private int hp;
        public string name;
        public State currentState = State.Alive;

        public Warrior(string _name)
        {
            name = _name;
            hp = 10;
        }

        public void LowerHP()
        {
            if (hp <= 3)
            {
                Console.WriteLine($"{name} is Dead. Can't be attacked");
                hp = 0;
                currentState = State.Dead;
            }
            else
            {
                hp -= 3;
            }
        }

        public void Attack(Warrior enemy)
        {
            Console.WriteLine($"{name} attacked {enemy.name}!");
            enemy.LowerHP();
        }

        public override string ToString()
        {
            return $"{name} : {hp}";
        }
    }
}
