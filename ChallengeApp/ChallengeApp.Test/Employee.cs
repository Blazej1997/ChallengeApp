﻿
namespace ChallengeApp.Test
{
    internal class Employee
    {
        private string v1;
        private string v2;
        private int v3;

        public Employee(string v1, string v2, int v3)
        {
            this.v1 = v1;
            this.v2 = v2;
            this.v3 = v3;
        }

        public object? Result { get; internal set; }

        internal void AddScore(int v)
        {
            throw new NotImplementedException();
        }
    }
}