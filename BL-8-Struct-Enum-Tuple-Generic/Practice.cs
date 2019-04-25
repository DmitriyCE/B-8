using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BL_8_Struct_Enum_Tuple_Generic
{
    partial class Practice
    {
        public static Random random = new Random();


        /// <summary>
        /// BL8-P1/3. Cоздать структуру 2DRectangle, которая будет содержать ширину, высоту и координату.
        /// </summary>
        public struct Rectangle
        {
            public int width;
            public int height;
            public int[] XY;
            public Rectangle(int width, int height)
                {
                    this.width= width;
                    this.height= height;
                    this.XY = new int[]{0, 0};
                }
            public void DisplayToInfo()
            {
                Console.WriteLine($"{width},{height},{XY[0]},{XY[1]}");
            }

        }
        public static void Lb8_P1_3()
        {
            var rect = new Rectangle();
            rect.height = 200;
            rect.width = 300;
            rect.XY = new int[] { 20, 30 };
            rect.DisplayToInfo();
        }


        /// <summary>
        /// BL8-P2/3. Cоздать случайный массив квадратов с количеством элементов 100. 
        /// Используйте класс Random(10), чтоб установить значения сторон. 
        /// </summary>
        public static void Lb8_P2_3()
        {
            
            var massRectangle = new ArrayList();
            for (int i = 0; i < 100; i++)
            {
                var rect = new Rectangle((int)random.Next(1,10), (int)random.Next(1,10));
                massRectangle.Add(rect);
            }
            foreach(Rectangle rect in massRectangle)
            {
                int numDuplicates = 0;
                int width = rect.width;
                int height = rect.height;
                foreach (Rectangle rect1 in massRectangle)
                {
                    if (width == rect.width & height == rect1.height & Object.Equals((object)rect,(object)rect1)==false)
                    {
                        numDuplicates += 1;
                    }
                }
                Console.WriteLine($"number of duplicates = {numDuplicates} ;");
            }
        }

        /// <summary>
        /// BL8-P3/3.Anonymous. Создать метод GetSongData, 
        /// который принимает обьекта типа Song и возвращает анонимный тип, 
        /// который содержит Title, Minutes, Seconds и AlbumYear. 
        /// </summary>
        public static void Lb8_P3_3_Anonymous()
        {            
        }
    }
}
