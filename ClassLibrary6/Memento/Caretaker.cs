﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary6.Memento
{
    public class Caretaker
    {
        private List<Memento> _savedStates = new List<Memento>();

        public void AddMemento(Memento memento)
        {
            _savedStates.Add(memento);
        }

        public Memento GetMemento(int index)
        {
            return _savedStates[index];
        }
    }
}
