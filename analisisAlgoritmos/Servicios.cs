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
using Microsoft.VisualBasic;

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

            foreach (int ind in a)
            {
                var lis = new List<dynamic>();
                int cnt = 0;
                int repet = 0;

                for (int u =0; u < ind; u++)
                {
                    Random rnd = new Random();
                    lis.Add(rnd.Next(0, 10));
                }

                int N = ind;

                timer1.Start();
                string inicio = DateTime.Now.ToString("HH:mm:ss");
                for (int i = 0; i < N; i++)
                {
                    
                    for (int j = 0; j < N; j++)
                    {

                        for (int k = 0; k < N; k++)
                        {

                            if (lis[i] + lis[j] + lis[k] == 0)
                            {
                               cnt++;
                            }

                            repet++;

                        }

                    }
                    
                }
                string final = DateTime.Now.ToString("HH:mm:ss");
                timer1.Stop();
                var time = timer1.Elapsed.TotalSeconds;
                var res = new 
                {
                    Inicial =ind,
                    horaInicial = inicio,
                    horaFinal = final,
                    tSegundos = time,
                    can_0 = cnt,
                    repet = repet

                };
                result.Add(res);
                Console.WriteLine(res);
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
