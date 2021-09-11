﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Http
{
    [System.Serializable]
    class Tarefa
    {
        public int userId;
        public int id;
        public string title;
        public bool completed;

        public void Exibir()
        {
            Console.WriteLine("");
            Console.WriteLine($"user ID: {userId}");
            Console.WriteLine($"id: {id}");
            Console.WriteLine($"title: {title}");
            Console.WriteLine($"Finalizou?: {completed}");
            Console.WriteLine("");
            Console.WriteLine("==========================");
        }
    }
}
