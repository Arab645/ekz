namespace LAB2part2
{
    public class Converter
    {
        private double _usd;
        private double _euro;
        private double _pln;

        public Converter(double usd, double euro, double pln)
        {
            _usd = usd;
            _euro = euro;
            _pln = pln;
        }

        public double ChangeUahInUsd(double uah)
        {
            return uah / _usd;
        }

        public double ChangeUahInEuro(double uah)
        {
            return uah / _euro;
        }

        public double ChangeUahInPln(double uah)
        {
            return uah / _pln;
        }

        public double ChangeUsdInUah(double usd)
        {
            return usd * _usd;
        }

        public double ChangeEuroInUah(double euro)
        {
            return euro * _euro;
        }

        public double ChangePlnInUah(double pln)
        {
            return pln * _pln;
        }
    }
}