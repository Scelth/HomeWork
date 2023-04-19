using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// Мы не должны зависеть от интерфейсов, которые они не используют.
// То есть другими словами, мы не нагружаем интерфейсы ненужными для классов методами, каждый интерфейс реализует один метод.
namespace SOLID
{
    public interface IMoveable
    {
        void Move();
    }

    public interface IAttackable
    {
        void Attack();
    }

    public interface IDefendable
    {
        void Defend();
    }

    public class Civilian : IMoveable
    {
        public void Move()
        {
            // Реализация перемещения гражданина
        }
    }

    public class Warrior : IAttackable
    {
        public void Attack()
        {
            // Реализация атаки воина
        }
    }

    public class Tank : IDefendable
    {
        public void Defend() 
        {
            // Реализация защиты танка
        }
    }
}
