using System;

namespace DefiningClassesPartOne
{
    class Display
    {
        private double displaySize = 0;
        private int displayColors = 0;
        //does nothing since the fields are already initialized
        public Display()
        {

        }
        //sets the fields with whatever the input is
        public Display(double displaySize, int displayColors)
        {
            //calling properties to execute validation
            this.DisplaySize = displaySize;
            this.DisplayColors = displayColors;
        }

        public double DisplaySize
        {
            get
            {
                return this.displaySize;
            }
            set
            {
                if(value < 1 && value > (double)150)
                {
                    throw new ArgumentException("The input value for display size is incorrect! It must be 1+ and 150-");
                }
                else
                {
                    this.displaySize = value;
                }
            }
        }
        public int DisplayColors
        {
            get
            {
                return this.displayColors;
            }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentException("ENTER MORE COLORS!");
                }
                else
                {
                    this.displayColors = value;
                }
            }

        }
    }
}
