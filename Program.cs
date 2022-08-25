// See https://aka.ms/new-console-template for more information
using System;

namespace SampleRPG2
{
    class Program
    {
        static void Main(string[] args)
        {
            //player1のインスタンス作り、名前と体力を入力
            Player player1 = new Player();
            player1.name = "たかし";
            player1.hp = 100;
            //player2のインスタンス作り、名前と体力を入力
            Player player2 = new Player();
            player2.name = "ひろし";
            player2.hp = 50;

            player1.Attack();   // player1が攻撃する
            player2.Defense();  // player2が防御する
        }
    }
}

