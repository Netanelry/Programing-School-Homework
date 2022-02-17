using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Ex
{
    class Program
    {
        static void Main(string[] args)
        {
            FruitSalad salad = new FruitSalad()
            {
                _fruits = new FruitBase[]
                {
                    new Apple()
                    {
                        _name = "apple",
                        _calories = 52,
                        _color = "green",
                        _isPinkLady = false,
                    },

                    new Orange()
                    {
                        _name = "orange",
                        _calories = 47,
                        _size = 7.62f,
                    },

                    new Banana()
                    {
                        _name = "banana",
                        _calories = 89,
                        _size = 20.32f,
                        _hasBlackSpots = false,
                        _isGreen = false,
                    }
                }
            };

            Apple newApple = new Apple()
            {
                _name = "Pink Lady",
                _calories = 52,
                _color = "pink",
                _isPinkLady = false,
            };

            GetColor(newApple);

            Banana newBanana = new Banana()
            {
                _name = "yBomb",
                _calories = 89,
                _size = 20.32f,
                _hasBlackSpots = true,
                _isGreen = false,
            };

            GetSize(newBanana);

            GetTotalCaloriesOfSalad(salad);

            HasMyFav(salad);
        }

        //other functions
        public static string GetColor(Apple apple)
        {
            return apple._color;
        }

        public static float GetSize(Banana banana)
        {
            return banana._size;
        }

        public static int GetTotalCaloriesOfSalad(FruitSalad fruitSalad)
        {
            int cal = 0;
            foreach (FruitBase fruit in fruitSalad._fruits)
            {
                cal += fruit._calories;
            }
            return cal;
        }

        public static bool HasMyFav(FruitSalad fruitSalad)
        {
            foreach (FruitBase fruit in fruitSalad._fruits)
            {
                return true;
            }
            return false;
        }

    }
}