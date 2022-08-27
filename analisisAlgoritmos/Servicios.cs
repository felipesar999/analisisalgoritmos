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
using System.ComponentModel;

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
        public static List<dynamic> TwoSumFast()
        {
            List<dynamic> result = new List<dynamic>();

            Console.WriteLine("Por favor digite la cantidad de datos: ");
            int cant = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Por favor digite el dato a buscar");
            int x = Convert.ToInt32(Console.ReadLine());

            List<dynamic> universo = new List<dynamic>();

            for(int i=0; i < cant; i++)
            {
                universo.Add(i + 1);
            }

            

            int inicio = 0;
            int final = universo.Count() -1;
            float middle = 0;
            int middle1 = 0;
            int cont = 0;
            Stopwatch timer2 = new Stopwatch();
            timer2.Start();

            while (inicio <= final)
            {
                Stopwatch timer1 = new Stopwatch();
                timer1.Start();

                middle = (inicio + final) / 2;
                middle1 = (int)Math.Floor(middle);
                var encont = universo[middle1];

                if (x == universo[middle1])
                {
                    
                    timer1.Stop();
                    var time = timer1.Elapsed.TotalSeconds;
                    var res = new {
                            posicion = middle1,
                            repet = cont,
                            time = time,
                        };
                    Console.WriteLine(res);
                    result.Add(res);
                    return result;
                }
                if (encont > x)
                {
                    timer1.Stop();
                    var time = timer1.Elapsed.TotalSeconds;
                    timer1.Restart();
                    final = middle1 -1;
                    cont++;
                    var res = new
                    {
                        posicion = middle1,
                        repet = cont,
                        time = time,
                    };
                    result.Add(res);
                    Console.WriteLine(res);
                }
                else
                {
                    timer1.Stop();
                    var time = timer1.Elapsed.TotalSeconds;
                    timer1.Restart();
                    inicio = middle1 + 1;
                    cont++;
                    var res = new
                    {
                        posicion = middle1,
                        repet = cont,
                        time = time,
                    };
                    result.Add(res);
                    Console.WriteLine(res);
                }                
                
            }
            if (inicio > final)
            {

                timer2.Stop();
                var time = timer2.Elapsed.TotalSeconds;
                var res = new
                {
                    posicion = middle1,
                    repet = cont,
                    time = time,
                };
                result.Add(res);
                Console.WriteLine(res);
                return result;
            }

            return result;
        }
        public static List<dynamic> ThreeSumFast()
        {
            List<dynamic> result = new List<dynamic>();

            Console.WriteLine("Por favor digite la cantidad de datos: ");
            int cant = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Por favor digite el dato a buscar");
            int x = Convert.ToInt32(Console.ReadLine());

            List<dynamic> universo = new List<dynamic>();

            for (int i = 0; i < cant; i++)
            {
                universo.Add(i + 1);
            }

            Stopwatch timer1 = new Stopwatch();
            timer1.Start();
            int final = universo.Count() - 1;
            int cont = 0;
            int uni = 0;

            for(int i=0; i < final; i++)
            {
                for (int j = i + 1; j < final; j++)
                {
                    uni = rank((-universo[i]) - (universo[j]), universo);
                    if (uni > j) cont++;
                }

            }

            timer1.Stop();
            var time = timer1.Elapsed.TotalSeconds;
            var res = new
            {
                posicion = uni,
                repet = cont,
                time = time,
            };
            Console.WriteLine(res);
            result.Add(res);
            return result;
        }

        private static int rank(int key, List<dynamic> universo )
        {
            int lo = 0;
            int hi = universo.Count() - 1;
            while (lo <= hi)
            {
                int mid = lo + (hi - lo) / 2;
                if (key < universo[mid]) hi = mid - 1;
                else if (key > universo[mid]) lo = mid + 1;
                else return mid;
                
            }
            return -1;
        }

    }
    
}
