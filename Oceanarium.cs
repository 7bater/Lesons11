using System.Collections;
using System.Collections.Generic;

namespace Lessons11
{
    public class Oceanarium : IEnumerable<SeaCreature>
    {
        private SeaCreature[] _creatures;

        public Oceanarium(SeaCreature[] creatures)
        {
            _creatures = creatures;
        }

        public IEnumerator<SeaCreature> GetEnumerator()
        {
            foreach (var creature in _creatures)
            {
                yield return creature;
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}