using System;
namespace ChristmasWithTypes
{
    public class Christmas
    {
        public string[] Presents;
        public string Santa { get; set; }
        
        public int? TreeHeight { get; set; } //TODO Make the Height property nullable
                                                //int'?' I think is the proper way? I must of missed it while watching the videos.. seems to work out
                                                  // well though..




        //TODO Make the property, "Day", type enum
        public enum Day {Saturday, Sunday, Monday, Tuesday, Wednesday, Thursday, Friday};

    }
}
