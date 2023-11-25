﻿using System;
using System.Collections.Generic;

namespace LAB7part2
{
    public class Repository<T>
    {
        private List<T> items = new List<T>();

        public void Add(T item)
        {
            items.Add(item);
        }

        public List<T> Find(Criteria<T> criteria)
        {
            List<T> result = new List<T>();
            foreach (var item in items)
            {
                if (criteria(item))
                {
                    result.Add(item);
                }
            }
            return result;
        }
    }

    public delegate bool Criteria<T>(T item);

}