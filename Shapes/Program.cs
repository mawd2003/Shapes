using System;

namespace project
{
    public class Shapes
    {
        double PI = 3.14;
        private int r;
        private int x_morabaa;
        private int y_morabaa;
        private int x_zozanaghe;
        private int y_zozanaghe;
        private int z_zozanaghe;
        private int x_mosalas;
        private int y_mosalas;

        public int R
        {
            get { return r; }
            set
            {
                if (value > 0)
                {
                    r = value;
                }
            }
        }
        public int X_Morabaa
        {
            get { return x_morabaa; }
            set
            {
                if (value > 0)
                {
                    x_morabaa = value;
                }
            }
        }

        public int Y_Morabaa
        {
            get { return y_morabaa; }
            set
            {
                if (value > 0)
                {
                    y_morabaa = value;
                }
            }
        }
        public int X_Zozanaghe
        {
            get { return x_zozanaghe; }
            set
            {
                if (value > 0)
                {
                    x_zozanaghe = value;
                }
            }
        }
        public int Y_Zozanaghe
        {
            get { return y_zozanaghe; }
            set
            {
                if (value > 0)
                {
                    y_zozanaghe = value;
                }
            }
        }
        public int Z_Zozanaghe
        {
            get { return z_zozanaghe; }
            set
            {
                if (value > 0)
                {
                    z_zozanaghe = value;
                }
            }
        }
        public int X_Mosalas
        {
            get { return x_mosalas; }
            set
            {
                if (value > 0)
                {
                    x_mosalas = value;
                }
            }
        }
        public int Y_Mosalas
        {
            get { return y_mosalas; }
            set
            {
                if (value > 0)
                {
                    y_mosalas = value;
                }
            }
        }
        public Shapes() { }
        public Shapes(int R, int X_Morabaa, int Y_Morabaa, int X_Zozanaghe, int Y_Zozanaghe, int Z_Zozanaghe, int X_Mosalas, int Y_Mosalas)
        {
            r = R;
            x_morabaa = X_Morabaa;
            y_morabaa = Y_Morabaa;
            x_zozanaghe = X_Zozanaghe;
            y_zozanaghe = Y_Zozanaghe;
            z_zozanaghe = Z_Zozanaghe;
            x_mosalas = X_Mosalas;
            y_mosalas = Y_Mosalas;
        }
        public double Mohitdayereh()
        {
            return 2 * r * PI;
        }
        public double Masahatdayereh()
        {
            return r * r * PI;
        }
        public int Mohihtmorabaa()
        {
            return (x_morabaa + y_morabaa) * 2;
        }
        public int Masahatmorabaa()
        {
            return x_morabaa * y_morabaa;
        }
        public double Masahatzozanaghe()
        {
            return ((x_zozanaghe + y_zozanaghe) / 2) * z_zozanaghe;
        }
        public int Mohitmosalas()
        {
            return x_mosalas + x_mosalas + x_mosalas;
        }
        public double Masahatmosalas()
        {
            return (x_mosalas * y_mosalas) / 2;
        }
    }
    class test1
    {
        public static void Main()
        {
            Console.WriteLine("Adad mored nazar ra vared konid :");
            Console.WriteLine("1:DAYREH ");
            Console.WriteLine("2:Morabaa ");
            Console.WriteLine("3:Zozanaghe ");
            Console.WriteLine("4:Mosalas ");

            int input = Convert.ToInt32(Console.ReadLine());
            Shapes sh = new Shapes();

            if (input == 1)
            {
                Console.WriteLine("Shoa ra vared konid :");
                int r = Convert.ToInt32(Console.ReadLine());
                sh.R = r;
                Console.WriteLine("Mohittdayere is");
                Console.WriteLine(sh.Mohitdayereh());
                Console.WriteLine("Masahatdayere is");
                Console.WriteLine(sh.Masahatdayereh());
            }
            else if (input == 2)
            {
                Console.WriteLine("Zelh aval ra vared konid :");
                int xmorabaa = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Zelh dovom ra vared konid :");
                int ymorabaa = Convert.ToInt32(Console.ReadLine());
                sh.X_Morabaa = xmorabaa;
                sh.Y_Morabaa = ymorabaa;
                Console.WriteLine("Mohitmorabaa is");
                Console.WriteLine(sh.Mohihtmorabaa());
                Console.WriteLine("Masahatmorabaa is");
                Console.WriteLine(sh.Masahatmorabaa());
            }
            else if (input == 3)
            {
                Console.WriteLine("Zelh aval ra vared konid :");
                int xzozanaghe = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Zelh dovom ra vared konid :");
                int yzozanaghe = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Ertefah ra vared konid :");
                int zzozanaghe = Convert.ToInt32(Console.ReadLine());
                sh.X_Zozanaghe = xzozanaghe;
                sh.Y_Zozanaghe = yzozanaghe;
                sh.Z_Zozanaghe = zzozanaghe;
                Console.WriteLine("Masahatzozanaghe is");
                Console.WriteLine(sh.Masahatzozanaghe());
            }
            else if (input == 4)
            {
                Console.WriteLine("Zelh aval ra vared konid :");
                int xmosalas = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Zelh dovom ra vared konid :");
                int ymosalas = Convert.ToInt32(Console.ReadLine());
                sh.X_Mosalas = xmosalas;
                sh.Y_Mosalas = ymosalas;
                Console.WriteLine("Mohitmosalas is");
                Console.WriteLine(sh.Mohitmosalas());
                Console.WriteLine("Masahatmosalas is");
                Console.WriteLine(sh.Masahatmosalas());
            }
            Console.ReadKey();
        }
    }
}

