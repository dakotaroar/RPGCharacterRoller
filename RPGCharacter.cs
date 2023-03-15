using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media;

namespace RPGCharacterRoller
{
    internal class RPGCharacter
    {
        #region Fields
        // Fields
        private int _strength;
        private int _intelligence;
        private int _wisdom;
        private int _dexterity;
        private int _stamina;
        private int _charisma;
        private int _maxCharisma = 20;
        private int _maxDexterity = 20;
        private int _maxIntelligence = 20;
        private int _maxStamina = 20;
        private int _maxStrength = 20;
        private int _maxWisdom = 20;
        private List<RPGCharacter> _partyMembers = new List<RPGCharacter>();
        private Brush _favoriteColor;
        private CharacterClasses _characterClasses = CharacterClasses.None;
        private Random _rng = new Random();
        #endregion

        #region Properties
        public string Name { get; set; }
        public long XP {  get; set; }
        public int Level { get; set; }
        public CharacterClasses CharacterClass
        {
            get { return _characterClasses; }
            set { _characterClasses = value; }
        }
        public List<RPGCharacter> PartyMembers
        {
            get { return _partyMembers; }
            set { _partyMembers = value; }
        }
        public Brush FavoriteColor
        {
            get { return _favoriteColor; }
            set { _favoriteColor = value; }
        }

        public int Charisma { get { return _charisma; } }
        public int Dexterity { get { return _dexterity; } }
        public int Intelligence { get { return _intelligence; } }
        public int Stamina { get { return _stamina; } }
        public int Strength { get { return _strength; } }
        public int Wisdom { get { return _wisdom; } }
        
        #endregion

        public RPGCharacter(Random rng)
        {
            _rng = rng;
            Roll();
        }

        #region Roll
        public void Roll()
        {
            _charisma = _rng.Next(1, _maxCharisma + 1);
            _dexterity = _rng.Next(1, _maxDexterity + 1);
            _intelligence = _rng.Next(1, _maxIntelligence + 1);
            _stamina = _rng.Next(1, _maxStamina + 1);
            _strength = _rng.Next(1, _maxStrength + 1);
            _wisdom = _rng.Next(1, _maxWisdom + 1);
        }

        public static int RollDice(int numberOfDice, int sidesPerDice, Random r)
        {
            int total = 0;

            for (int i = 0; i < numberOfDice; i++)
            {
                total = total + r.Next(1, sidesPerDice + 1);
            }

            return total;
        }
        #endregion

    }

    #region Character Classes
    public enum CharacterClasses
    {
        None = 0,
        Ranger,
        Mage,
        Rogue,
        Bard,
        Goliath,
        Paladin,
    }
    #endregion

}
