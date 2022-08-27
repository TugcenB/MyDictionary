namespace MyDictionary
{
    class MyDictionary<TKey,TValue>
    {
        TKey[] _array;
        TValue[] _array2;
        TKey[] _tempArray;
        TValue[] _tempArray2;
        public MyDictionary()
        {
            _array = new TKey[0];
            _array2 = new TValue[0];
        }
        public void Add(TKey key, TValue value)
        {
            _tempArray = _array;
            _tempArray2 = _array2;
            _array = new TKey[_array.Length+1];
            _array2 = new TValue[_array2.Length + 1];
            for (int i = 0; i < _tempArray.Length; i++)
            {
                _array[i] = _tempArray[i];
                _array2[i] = _tempArray2[i];

            }
            _array[_array.Length-1] = key;
            _array2[_array2.Length-1] = value;
        }
        
        public int Count
        {
            get { return _array.Length; }
        }
        public void Show()
        {
            Console.WriteLine("Key\tValue");
            for (int i = 0; i < _array.Length; i++)
            {
                Console.WriteLine(_array[i].ToString() + "\t" + _array2[i]);
            }
            
        } 
    }
}