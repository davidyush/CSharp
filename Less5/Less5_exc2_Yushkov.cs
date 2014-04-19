using System;

namespace DidntHearAboutIndexer
{
    abstract class FermAnimal
    {
        abstract public void SoundOfRoar();

        public FermAnimal(string roar,bool isAMammal)
        {
            _roar = roar;
            _isAMammal = isAMammal;
        }

        public string GetRoar
        {
            get { return _roar; }
        }

        public string Collar
        {
            get { return _collar; }
            set { _collar = value; }
        }

        //типа индексатор
        public string this[int index]
        {
            get
            {
                switch (index)
                {
                    case 0:
                        return _roar;
                    case 1:
                        return _collar;
                    default:
                        return string.Format("is it a mammal? {0}", _isAMammal);
                }
            }
        }
        
        protected string _collar = string.Empty;
        protected string _roar;
        protected bool _isAMammal = false;
        
    }
    /// <summary>
    /// Чем дальше, тем больше ненужного хлама
    /// </summary>
    class Cow : FermAnimal
    {
        private bool _hasMilk;

        public Cow(bool hasMilk, string roar, bool isAMammal)
            : base(roar, isAMammal)
        {
            _hasMilk = hasMilk;

            if (roar != "Mu-mu")
                _roar = "Mu-mu";
        }

        public bool MilkTheCow()
        {
            if (!_hasMilk)
            {
                Console.WriteLine("Mu-mu-mu..I have no milk");
            }
            else
            {
                Console.WriteLine("Mu-mu-mu let my calf milk please");
            }
            return true;
        }

        public override void SoundOfRoar()
        {
            Console.WriteLine(_roar);     
        }
    }
    
    class Goat : FermAnimal
    {
        private int _lengthOfHorns;

        public Goat(int lengthOfHorns,string roar, bool isAMammal)
            : base(roar,isAMammal)
        {
            if (lengthOfHorns > 0 && lengthOfHorns < 100)
            {
                _lengthOfHorns = lengthOfHorns;
            }
            if (roar != "Me-me")
            {
                _roar = "Me-me";
            }
        }

        public void ButtingHorns()
        {
            if (_lengthOfHorns > 40)
            {
                Console.WriteLine("Me-me u wanna mess?");
            }
            else
            {
                Console.WriteLine("Me-me i dont wanna mess with u");
            }
        }

        public override void SoundOfRoar()
        {
            Console.WriteLine(_roar);
        }
    }

    class Cock : FermAnimal
    {
        private bool _isItMorningNow;
        
        public Cock(bool morning, string roar, bool isAMammal)
            : base(roar, isAMammal)
        {
            _isItMorningNow = morning;

            if (roar != "Ku-ka-re-ku")
            {
                _roar = "Ku-ka-re-ku";
            }
        }

        public void ToBeAnAlarmClock()
        {
            if (_isItMorningNow == true)
            {
                Console.WriteLine("Get up, stand up, Stand up for your right");
            }
        }
        
        public override void SoundOfRoar()
        {
            Console.WriteLine(_roar);
        }
    }

    class PoorFermer
    {
        private string _collar4Cow = "this animal can take milk";
        private string _collar4Goat  = "this animal can butting horns";
        private string _collar4Cock  = "DANGER! this animal can wake us";
        private string _name;

        public PoorFermer(string name)
        {
            if (Char.IsDigit(name[0]))
                _name = "Valera";
        }

        public void AttachACollar(FermAnimal obj)
        {
            if (obj[0] == "Mu-mu")
            {
                obj.Collar = _collar4Cow;
            }
            else if(obj[0] == "Me-me")
            {
                obj.Collar = _collar4Goat;
            }
            else if (obj[0] == "Ku-ka-re-ku")
            {
                obj.Collar = _collar4Cock;
            }
        }

            public void ToDig()
            {
                Console.WriteLine("i'm digging now");
            }

            public void NotToDig()
            {
                Console.WriteLine("i'm not digging now");
            }
    }
    
    class Program
    {
        static void Main(string[] args)
        {
            FermAnimal[] animals = new FermAnimal[3];
            
                animals[0] = new Cow(true, "Mu-mu", true);
                animals[1] = new Goat(50, "bu-bu", true);
                animals[2] = new Cock(true, "ku-ka-re-ku", false);    
            
            PoorFermer Valera = new PoorFermer("999RNK");

            for (int i = 0; i < animals.Length; i++)
            {
                Valera.AttachACollar(animals[i]);
            }
            for (int i = 0; i < animals.Length; i++)
            {
                Console.WriteLine(animals[i][0]);
                Console.WriteLine(animals[i][1]);
            }    
            Console.ReadKey();
        }
    }
}
