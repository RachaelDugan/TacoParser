using System;

namespace LoggingKata
{
    /// <summary>
    /// Parses a POI file to locate all the Taco Bells
    /// </summary>
    public class TacoParser
    {
        readonly ILog logger = new TacoLogger();
        
        public ITrackable Parse(string line)
        {
            //logger.LogInfo("........");

           
            TacoBell restaurant = new TacoBell();
            // Take your line and use line.Split(',') to split it up into an array of strings, separated by the char ','
            var cells = line.Split(',');

            // If your array.Length is less than 3, something went wrong
            if (cells.Length < 3)
            {
                // Log that and return null
                Console.WriteLine("Opps, something went wrong!"); // Do not fail if one record parsing fails, return null
                logger.LogError("Not enough values to parse", null);
                return null; // TODO Implement
            }
            Point coordinates = new Point();
            
            coordinates.Latitude = double.Parse(cells[0]); // grab the latitude from your array at index 0
            coordinates.Longitude = double.Parse(cells[1]); // grab the longitude from your array at index 1
            restaurant.Location = coordinates;
            restaurant.Name = cells[2]; // grab the name from your array at index 2
            return restaurant;
        }
       
    }
}
            // Your going to need to parse your string as a `double`
            // which is similar to parsing a string as an `int`




            // You'll need to create a TacoBell class *done*
            // that conforms to ITrackable

            // Then, you'll need an instance of the TacoBell class *done
            // With the name and point set correctly

            // Then, return the instance of your TacoBell class *done
            // Since it conforms to ITrackable
