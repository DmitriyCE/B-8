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
            
            var massRectangle = new List<Rectangle>();
            for (int i = 0; i < 100; i++)
            {
                Rectangle rect = new Rectangle((int)random.Next(1,10), (int)random.Next(1,10));
                massRectangle.Add(rect);
            }
            int numDuplicate = 0;
            for (int i = 0; i < massRectangle.Count; i++)
            {
                for (int j = 1; j+i < 100; j++)
                {
                    Rectangle h = massRectangle[i];
                    if( Convert.ToInt32(massRectangle[i].height)== Convert.ToInt32(massRectangle[j+i].height) & Convert.ToInt32(massRectangle[i].width) == Convert.ToInt32(massRectangle[j + i].width))
                    {
                        numDuplicate += 1;
                        break;
                    }
                }
            }
            Console.WriteLine(numDuplicate);
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
