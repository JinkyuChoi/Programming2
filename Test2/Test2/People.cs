using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test2
{
    public class People
    {
        private List<Person> _people = new List<Person>();

        public int Count { get { return _people.Count; } }

        public void Add(Person person)
        {
            _people.Add(person);
        }
        public void Clear()
        {
            _people.Clear();
        }
        public IEnumerable<Person> GetAllPeople()
        {
            List<Person> result = new List<Person>(_people);
            return result;
        }
        public IEnumerable<Person> GetAndroidPeople()
        {
            IEnumerable<Person> people = _people
                .Where(p => p.MobileType == EMobileType.Android);

            List<Person> result = new List<Person>(people);
            return result;
        }
        public IEnumerable<Person> GetApplePeople()
        {
            IEnumerable<Person> people = _people
                .Where(p => p.MobileType == EMobileType.Apple);

            List<Person> result = new List<Person>(people);
            return result;
        }
    }
}
