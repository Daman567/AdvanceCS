using Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Interfaces
{
    public interface ICreatureService
    {
        public void InitializeCreatures(int preyCount, int predatorCount);
       

        public bool IsExtinction();
        public void Move(int timeout);
    }
}
