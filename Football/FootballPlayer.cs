﻿namespace Football
{
    class FootballPlayer : Person
    {
        public int Number { get; set; }
        public double Height { get; set; }
        public FootballPlayer(string name, int age, int number, double height) : base(name, age)
        {
            Number = number;
            Height = height;
        }
    }
}
