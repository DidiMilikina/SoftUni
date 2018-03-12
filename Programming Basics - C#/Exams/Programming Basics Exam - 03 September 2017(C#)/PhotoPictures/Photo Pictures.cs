using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhotoPictures
{
    class PhotoPictures
    {
        static void Main(string[] args)
        {
            int numberPictures = int.Parse(Console.ReadLine());
            string typePicture = Console.ReadLine();
            string onlineOrOffice = Console.ReadLine();

            double discount = 0;
            double pricePerPhoto = 0;

            if (typePicture == "9X13")
            {
                pricePerPhoto = 0.16;
                if (numberPictures >= 50)
                {
                    discount = 0.05;
                }
            }

            else if (typePicture == "10X15")
            {
                pricePerPhoto = 0.16;
                if (numberPictures >= 80)
                {
                    discount = 0.03;
                }
            }

            else if (typePicture == "13X18")
            {
                pricePerPhoto = 0.38;

                if (numberPictures >= 50 && numberPictures <= 100)
                {
                    discount = 0.03;
                }
                else if (numberPictures > 100)
                {
                    discount = 0.05;
                }
            }

            else if (typePicture == "20X30")
            {
                pricePerPhoto = 2.9;

                if (numberPictures >= 10 && numberPictures <= 50)
                {
                    discount = 0.07;
                }
                else if (numberPictures > 50)
                {
                    discount = 0.09;
                }
            }

            double price = pricePerPhoto * numberPictures;
            double discountPrice = (1 - discount) * price;

            if (onlineOrOffice == "online")
            {
                discountPrice = discountPrice * 0.98;
            }

            Console.WriteLine($"{discountPrice:f2}BGN");
        }
    }
}
