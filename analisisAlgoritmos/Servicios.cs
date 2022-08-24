using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Dynamic;
using System.Globalization;
using System.Linq;
using System.Net;
using System.Diagnostics;

namespace analisisAlgoritmos
{
    public class Servicios
    {
        private int Ciclos { get; set; }
        private bool ClientNotify { get; set; }

        /*private string Password { get; set; }
        private string DataBase { get; set; }
        private string UnitsRange { get; set; }
        private string ShopId { get; set; }
        */
        public Servicios(int ciclos, bool clientNotify = false)
        {
            this.Ciclos = ciclos;
            /*this.User = user;
            this.Password = pwd;
            this.ShopId = shopId;
            this.Token = token;
            this.DataBase = dataBase;
            this.UnitsRange = unitsRange;*/
            this.ClientNotify = clientNotify;
        }

        public static List<dynamic> ThreeSum(List<Object> a)
        {
            List<dynamic> result = new List<dynamic>();

            Stopwatch timer1 = new Stopwatch();

            
            int N = a.Count;
            int cnt = 0;
            Console.WriteLine(a);
            for (int i=0; i < N; i++)
            {
                timer1.Start();
                for (int j = 0; j < N; j++)
                {
                    for (int k = 0; k < N; k++)
                    {
                        if (a[i] + a[j] + a[k] == 0)
                        {
                            cnt++;
                        }
                        timer1.Stop();
                        var time = timer1.ElapsedMilliseconds;
                        result.Add(time);

                    }

                }
                timer1.Restart();
            }
            return result;
        }

        public static bool TwoSumFast()
        {

            return true;
        }
        public static bool ThreeSumFast()
        {

            return true;
        }

    }
}
