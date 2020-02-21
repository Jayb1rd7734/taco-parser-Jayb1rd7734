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
            if (line == null || line == "") return null;

            var cells = line.Split(',');

            if (cells.Length != 3) return null;

            return new TacoBell(cells);
        }
    }
}