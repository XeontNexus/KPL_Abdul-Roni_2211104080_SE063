using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tpmodul13_2211104065
{
    // Subject (yang akan diamati)
    public class Subject
    {
        private List<IObserver> observers = new List<IObserver>();

        // Menambahkan Observer
        public void Attach(IObserver observer)
        {
            observers.Add(observer);
        }

        // Menghapus Observer
        public void Detach(IObserver observer)
        {
            observers.Remove(observer);
        }

        // Memberitahukan Observer tentang perubahan
        public void Notify()
        {
            foreach (var observer in observers)
            {
                observer.Update();
            }
        }
    }

    // Observer (pengamat)
    public interface IObserver
    {
        void Update();
    }

    // ConcreteObserver (pengamat konkret)
    public class ConcreteObserver : IObserver
    {
        private string _name;
        private Subject _subject;

        public ConcreteObserver(string name, Subject subject)
        {
            _name = name;
            _subject = subject;
            _subject.Attach(this);
        }

        public void Update()
        {
            Console.WriteLine($"Observer {_name} has been notified.");
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            // Membuat instance Subject
            var subject = new Subject();

            // Membuat Observer
            var observer1 = new ConcreteObserver("Observer 1", subject);
            var observer2 = new ConcreteObserver("Observer 2", subject);

            // Memberitahukan Observer tentang perubahan pada Subject
            Console.WriteLine("Notifying observers...");
            subject.Notify();

            // Menghapus observer
            subject.Detach(observer1);

            // Memberitahukan Observer yang tersisa
            Console.WriteLine("Notifying observers after detaching Observer 1...");
            subject.Notify();
        }
    }
}
