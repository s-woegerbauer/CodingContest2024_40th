using System;
using System.Collections.Generic;

namespace CodingContest2024_40th.Collections
{
    public class SmartDictionary<TKey, TValue> : Dictionary<TKey, TValue>
        where TKey : notnull
        where TValue : notnull
    {
        private readonly Func<TValue, TValue, TValue> _combineFunction;

        public SmartDictionary(Func<TValue, TValue, TValue>? combineFunction = null)
        {
            _combineFunction = combineFunction ?? ((value1, value2) => (dynamic)value1 + value2);
        }

        public new void Add(TKey key, TValue value)
        {
            if (ContainsKey(key))
            {
                base[key] = _combineFunction(base[key], value);
            }
            else
            {
                base.Add(key, value);
            }
        }
    }
}