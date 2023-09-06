using System;
using System.Collections;

namespace DynamicArray
{
    public class IntArrayList : IEnumerable
    {
        private int[] _container;
        private int _currentSize;
        private int _containerSize;
        private readonly int _defaultSize = 2;
        public  int Count{get => _currentSize; }
        public  int Capacity{get => _containerSize; }

        public int this[int index]
        {
            get {
                if (index >= _currentSize || index < 0) {
                    throw new IndexOutOfRangeException();
                }
                return _container[index];
            }
            set
            {
                _container[index] = value;
            }
            
        }

        public IntArrayList()
        {
            _container = new int[_defaultSize];
            _containerSize = _defaultSize;
        }

        public IntArrayList(int containerSize)
        {
            _container = new int[containerSize];
            _containerSize = containerSize;
        }

        public void PushBack(int value)
        {
            if (_currentSize + 1 > _containerSize)
            {
                int[] newContainer = new int[_container.Length * 2];
                for (int i = 0; i < _currentSize + 1; ++i ) {
                    newContainer[i] =  _container[i];
                }

                _container = newContainer;
            }
            _currentSize++;
            _container[_currentSize - 1] = value;
        }

        public void PopBack()
        {
            if (_currentSize > 0)
            {
                --_currentSize;
            }
        }

        public bool TryInsert(int index, int value)
        {
            if (index < _currentSize)
            {
                _container[index] = value;
                return true;
            }
            return false;
        }

        public bool TryErase(int index)
        {
            if (_currentSize > index)
            {
                for (int i = index; i < _containerSize - 1; ++i ) {
                    _container[i] = _container[i + 1];
                }
                --_currentSize;
                return true;
            }
            return false;
        }

        public bool TryGetAt(int index, out int result)
        {
            if (_currentSize <= index)
            {
                result = 0;
                return false;
            }
            result = _container[index];
            return true;
        }
        
        public void Clear()
        {
            _currentSize = 0;

        }

        public bool TryForceCapacity(int newCapacity)
        {
            if (newCapacity < 0)
                return false;
            
            int[] newContainer = new int[newCapacity];
            for (int i = 0; i < _currentSize; ++i ) {
                newContainer[i] =  _container[i];
            }
            _container = newContainer;
            _containerSize = newCapacity;
            return true;




        }

        public int Find(int value)
        {
            for (int i = 0; i < _currentSize; i++)
            {
                if (value == _container[i])
                    return i ;
            }
            return -1;
            
        }


        public IEnumerator GetEnumerator()
        {
            return _container.GetEnumerator();
        }
    }
}