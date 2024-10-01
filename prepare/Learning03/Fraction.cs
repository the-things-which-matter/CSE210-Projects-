
using System.Runtime.CompilerServices;

public class Fraction
    {
        private int _topNumber;
        private int _bottomNumber;

        public void SetTopNumber(int top)
            {
                _topNumber = top;
            }
        public int GettopNumber()
            {
                return _bottomNumber;
            }
            //Getter and setter functions

            public void SetBottomNumber(int bottom)
                {
                    _bottomNumber = bottom;
                }

            public int GetBottomNumber()
                {
                    return _bottomNumber;
                }

                //constructors
        public Fraction()
            {
                _topNumber = 1;
                _bottomNumber = 1;
                //float divide = _topNumber / _bottomNumber;
                Console.WriteLine($"The fraction is {_topNumber}/{_bottomNumber}");
            }

        public Fraction(int enterTop)
            {
                _topNumber = enterTop;
                _bottomNumber = 1;
               // divideTwo = _topNumber/_bottomNumber;
                Console.WriteLine($"The fraction is {_topNumber}/{_bottomNumber}");
            }
        
        public Fraction(int userTop, int userBottom)
            {
                _topNumber = userTop;
                _bottomNumber = userBottom;
                Console.WriteLine($"The fraction is {_topNumber}/{_bottomNumber}");
            }




            public string GetFractionString()
                {
                     string line =$"{_topNumber}/{_bottomNumber}";
                     return line;
                }

            public double GetDecimalValue()
                {
                    return(double)_topNumber/(double)_bottomNumber;
                    
                    
                }
        
    }
//public class Journal
   // {
//        public List<Entry> _entries = new List<Entry>();

  //      public void AddEntry(Entry newEntry)
  //          {

   //         }
 //       public void Display()
   //         {

    //        }

    //    public void SaveToFile(string file)
        //    {

        //    }
    //    public void LaodFromFile(string file)
      //      {
                
     //       }
   // }