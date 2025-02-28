﻿using System;
using System.Collections.Generic;

namespace Aspektorientierte_Programmierung
{
    public class LoggerRepository : IRepository // Dektorator
    {
        public LoggerRepository(IRepository parent)
        {
            this.parent = parent;
        }
        private IRepository parent;

        private void Log(string message)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine($"[{DateTime.Now.ToLongDateString()}]: {message}");
            Console.ResetColor();
        }

        public void Delete<T>(T item)
        {
            Log("Vor dem Delete");
            parent.Delete(item);
            Log("Nach dem Delete");
        }

        public IEnumerable<T> GetAll<T>()
        {
            Log("Vor dem GetAll");
            parent.GetAll<Person>();
            Log("Nach dem GetAll");
            return null;
        }

        public T GetByID<T>(int ID)
        {
            Log("Vor dem GetByID");
            parent.GetByID<T>(ID);
            Log("Nach dem GetByID");
            return default;
        }

        public void Insert<T>(T item)
        {
            Log("Vor dem Insert");
            parent.Insert(item);
            Log("Nach dem Insert");
        }

        public void Update<T>(T item)
        {
            Log("Vor dem Update");
            parent.Update(item);
            Log("Nach dem Update");
        }
    }
}
