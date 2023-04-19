using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// D - гласит, что модули верхнего уровня не должны зависеть от модулей нижнего уровня, а оба типа модулей должны зависеть от абстракций
namespace SOLID
{
    // Интерфейс INPCBehaviour определяет метод Execute() для выполнения поведения.
    public interface INPCBehaviour
    {
        void Execute();
    }

    // Классы MoveBehaviour, AttackBehaviour и DefendBehaviour реализуют этот интерфейс и реализуют соответствующее поведение для перемещения, атаки и защиты
    public class MoveBehaviour : INPCBehaviour
    {
        public void Execute()
        {
            // Реализация поведения перемещения
        }
    }

    public class AttackBehaviour : INPCBehaviour
    {
        public void Execute()
        {
            // Реализация поведения атаки
        }
    }

    public class DefendBehaviour : INPCBehaviour
    {
        public void Execute()
        {
            // Реализация поведения защиты
        }
    }

    // Класс NPC зависит только от интерфейса INPCBehaviour, а не от конкретных классов поведения.
    // Это позволяет легко изменять поведение персонажа, просто передавая ему новый объект поведения, который реализует интерфейс INPCBehaviour
    public class NPC
    {
        private readonly INPCBehaviour _behaviour;

        public NPC(INPCBehaviour behaviour)
        {
            _behaviour = behaviour;
        }

        public void ExecuteBehaviour()
        {
            _behaviour.Execute();
        }
    }
}
