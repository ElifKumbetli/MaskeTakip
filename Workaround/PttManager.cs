using Entities.Concrete;

namespace Workaround
{
    internal class PttManager
    {
        private PersonManager personManager;

        public PttManager(PersonManager personManager)
        {
            this.personManager = personManager;
        }

        internal void GiveMask(Person person1)
        {
            throw new NotImplementedException();
        }
    }
}