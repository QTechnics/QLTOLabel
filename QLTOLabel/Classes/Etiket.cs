namespace QLTOLabel
{
    class Etiket
    {
        private string _Barkod;
        private int _ID;

        public int ID
        {
            get { return _ID; }
            set
            {
                _ID = value;
            }
        }


        public string Barkod
        {
            get { return _Barkod; }
            set
            {
                _Barkod = value;
            }
        }
        
    }
}
