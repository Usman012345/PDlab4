using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task1.classes
{
    class angle
    {
        string display;
        int degrees;
        float mins;
        char direction;
        public angle()
        {

        }
        public angle(int degrees,float mins,char direction)
        {
            this.degrees = degrees;
            this.mins = mins;
            this.direction = direction;
        }
        public void change_direction(int degrees, float mins, char direction)
        {
            this.degrees = degrees;
            this.mins = mins;
            this.direction = direction;
        }
        public string display_no(string latitude,string longitude, List<ship> ship_nos, List<angle> latitudes, List<angle> longitudes)
        {
            string display_, display1;
            for (int x=0;x<latitudes.Count;x++)
            {
              display_ = latitudes[x].degrees.ToString() + "\u00b0" + latitudes[x].mins.ToString() + "'" + latitudes[x].direction;
                display1=longitudes[x].degrees.ToString() + "\u00b0" + longitudes[x].mins.ToString() + "'" + longitudes[x].direction;
                if (display_ == latitude && display1==longitude)
                {
                    return ship_nos[x].ship_no;
                }
                        }
            return null;
        }
        public string display_(string ship_no,List<ship> ship_nos, List<angle> angles)
        {
            
            for (int x = 0; x < ship_nos.Count; x++)
            {
                if (ship_nos[x].ship_no == ship_no)
                { 
                    display = angles[x].degrees.ToString() +"\u00b0"+ angles[x].mins.ToString()+"'"+angles[x].direction;
                    
                }
                else
                {
                    return null;
                }
            }
            
            return display;
        }
    }
}
