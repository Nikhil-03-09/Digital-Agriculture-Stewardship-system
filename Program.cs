﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.Collections;
using System.ComponentModel;
using System.Security.Cryptography.X509Certificates;
using System.Text.RegularExpressions;
using System.Dynamic;
using System.Data;
using System.Xml.Schema;
using System.Linq.Expressions;
using project_1;

namespace project_1
{
    public class admin
    {
        public Hashtable c = new Hashtable();
        public Hashtable h = new Hashtable();
        public Hashtable f = new Hashtable();
        public SortedList<string, double> so = new SortedList<String, double>();
        public SortedList<String, int> m = new SortedList<String, int>();
        public SortedList<String, int> m12 = new SortedList<String, int>();
        public string mail = "@gmail.com$";
        public string na = "^[A-Z]";


        public void soil()
        {
            int a, a3, a2;
            string c1, i1, key;
        ad:
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.WriteLine("\n\n\t\t\t\t\t\t\t        ADMIN PAGE\n\t\t\t\t\t\t\t     ================");
            Console.WriteLine("---------------------------------------------------------------------------------------------------------------------------------------------------");
            Console.WriteLine("\n\n\t\t\t\t\t\t-------------Soil information------------");
            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.WriteLine("\n");
            Console.WriteLine("\n\t\t\t\t\t\tChoose any one of following : ");
            Console.WriteLine("\n\t\t\t\t\t\t1.Add soil info\n\t\t\t\t\t\t2.Update soil info\n\t\t\t\t\t\t3.Delete soil info\n\t\t\t\t\t\t4.Display soil info\n\t\t\t\t\t\t5.Exit");
            Console.Write("\n\t\t\t\t\t\tchoice : ");
            a = Convert.ToInt32(Console.ReadLine());

            switch (a)
            {
                case 1:
                    Console.ForegroundColor = ConsoleColor.DarkRed;
                    Console.Write("\n\t\t\t\t\t\tEnter how many entries you want add :  ");
                    a2 = Convert.ToInt32(Console.ReadLine());
                    for (int i = 0; i < a2; i++)
                    {
                        Console.Write("\n\t\t\t\t\t\tSoil type - " + (i + 1) + ")  ");
                        c1 = Console.ReadLine();
                        Console.Write("\n\t\t\t\t\t\tSoil Information -->");
                        i1 = Console.ReadLine();
                        h.Add(c1, i1);
                    }
                    Console.Clear();
                    Console.WriteLine("\n\n\n");
                    display();
                    Thread.Sleep(5000);

                    goto ad;
                case 2:
                    string c4, c5, c6, c7, c8;
                    Console.ForegroundColor = ConsoleColor.DarkMagenta;
                    Console.WriteLine("\n\t\t\t\t\t\tEnter Which part you want to update\n\t\t\t\t\t\t1.soil type\n\t\t\t\t\t\t2.Soil info");
                    Console.Write("\n\t\t\t\t\t\tChoice  : ");
                    a3 = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("\n\n");
                    display();
                    if (a3 == 1)
                    {
                    k8:
                        Console.Write("\n\t\t\t\t\t\tEnter which soil type value to update : ");
                        c4 = Console.ReadLine();
                        if (h.ContainsKey(c4))
                        {
                            Console.Write("\n\t\t\t\t\t\tEnter new value : ");
                            c5 = Console.ReadLine();
                            h.Add(c5, h[c4]);
                            h.Remove(c4);
                        }
                        else
                        {
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.WriteLine("\n\t\t\t\t\t\tEnter valid type!");
                            Thread.Sleep(4000);
                            goto k8;
                        }

                    }
                    else
                    {
                    k9:
                        Console.Write("\n\t\t\t\t\t\tEnter which soil type info to update : ");
                        c6 = Console.ReadLine();
                        if (h.ContainsKey(c6))
                        {
                            Console.Write("\n\t\t\t\t\t\tEnter new value : ");
                            c7 = Console.ReadLine();
                            h.Remove(c6);
                            h.Add(c6, c7);
                        }
                        else
                        {
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.WriteLine("\n\t\t\t\t\t\tEnter valid type!");
                            Thread.Sleep(4000);
                            goto k9;
                        }
                    }
                    Console.Clear();
                    Console.WriteLine("\n\n\n");

                    display();
                    Thread.Sleep(5000);
                    goto ad;
                case 3:
                    display();
                re:
                    Console.ForegroundColor = ConsoleColor.DarkMagenta;
                    Console.Write("\n\t\t\t\t\t\tEnter which entry soil type to remove : ");
                    key = Console.ReadLine();
                    if (h.ContainsKey(key))
                    {

                        h.Remove(key);
                        Console.Clear();
                        Console.WriteLine("\n\n\n");
                        display();
                        Thread.Sleep(2000);
                    }
                    else
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("\n\t\t\t\t\t\tEnter only contents present!");
                        Thread.Sleep(5000);
                        goto re;
                    }
                    goto ad;
                case 4:
                    Console.Clear();
                    Console.WriteLine("\n\n\n");
                    display();
                    Thread.Sleep(5000);
                    goto ad;
                case 5:
                    Console.ForegroundColor = ConsoleColor.DarkRed;
                    Console.WriteLine("\n\t\t\t\t\t\t**************Exiting****************");
                    Thread.Sleep(5000);
                    return;
                    break;
                default:
                    Console.WriteLine("\n\t\t\t\t\t\tvalid option please");
                    goto ad;


            }

        }
        public void display()
        {
            int a = 1;
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("\n\t\t\t\t\t\t   Soil Type \t  \t----> \t \tSoil info ");
            Console.WriteLine("\t\t\t\t\t\t---------------------------------------------------");
            foreach (DictionaryEntry x in h)
            {
                Console.Write("\t\t\t\t\t\t  " + a + ")   " + x.Key);
                Console.Write("\n\n\t\t\t\t\t\t\t\t\t---->\t\t" + x.Value + "\n");
                a++;

            }
        }
        public void crop()
        {
            int a, a3, a2;
            string c1, i1, key;
        ad:
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.WriteLine("\n\n\t\t\t\t\t\t\t        ADMIN PAGE\n\t\t\t\t\t\t\t     ================");
            Console.WriteLine("---------------------------------------------------------------------------------------------------------------------------------------------------");
            Console.WriteLine("\n\n\t\t\t\t\t\t-------------Crop information------------");
            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.WriteLine("\n");
            Console.WriteLine("\n\t\t\t\t\t\tChoose any on of following : ");
            Console.WriteLine("\n\t\t\t\t\t\t1.Add crop info\n\t\t\t\t\t\t2.Update info\n\t\t\t\t\t\t3.Delete info\n\t\t\t\t\t\t4.Display Crop info\n\t\t\t\t\t\t5.Exit");
            Console.Write("\n\t\t\t\t\t\tchoice : ");
            a = Convert.ToInt32(Console.ReadLine());

            switch (a)
            {
                case 1:
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.Write("\n\t\t\t\t\t\tEnter how many Crop Types you want to add :   ");
                    a2 = Convert.ToInt32(Console.ReadLine());
                    for (int i = 0; i < a2; i++)
                    {
                        Console.Write("\n\t\t\t\t\t\tCrop Type  " + (i + 1) + ")   ");
                        c1 = Console.ReadLine();
                        Console.Write("\n\t\t\t\t\t\t  Crop information--->  ");
                        i1 = Console.ReadLine();
                        c.Add(c1, i1);
                    }
                    Console.Clear();
                    Console.WriteLine("\n\n\n");
                    display1();
                    Thread.Sleep(5000);
                    goto ad;
                    break;
                case 2:
                    string k2, k3, k4, k5;
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    display1();
                    Console.WriteLine("\n\t\t\t\t\t\tEnter Which part you want to update\n\t\t\t\t\t\t1.Crop type\n\t\t\t\t\t\t2.Crop info");
                    a3 = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("\n\n");

                    if (a3 == 1)
                    {
                    k8:
                        Console.Write("\n\t\t\t\t\t\tEnter which Crop Type to update : ");
                        k2 = Console.ReadLine();
                        if (c.ContainsKey(k2))
                        {
                            Console.Write("\n\t\t\t\t\t\tEnter new Crop Type  : ");
                            k3 = Console.ReadLine();
                            c.Add(k3, c[k2]);
                            c.Remove(k2);
                        }
                        else
                        {
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.WriteLine("\n\t\t\t\t\t\tEnter valid type!");
                            Thread.Sleep(4000);
                            goto k8;
                        }

                    }
                    else
                    {
                    k9:
                        Console.Write("\n\t\t\t\t\t\tEnter Which Crop Type for update : ");
                        k4 = Console.ReadLine();
                        if (h.ContainsKey(k4))
                        {
                            Console.Write("\n\t\t\t\t\t\tEnter new crop info   : ");
                            k5 = Console.ReadLine();
                            c.Remove(k4);
                            c.Add(k4, k5);
                        }
                        else
                        {
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.WriteLine("\n\t\t\t\t\t\tEnter valid type!");
                            Thread.Sleep(4000);
                            goto k9;
                        }
                    }
                    Console.Clear();
                    Console.WriteLine("\n\n\n");
                    display1();
                    goto ad;
                    break;
                case 3:
                    Console.ForegroundColor = ConsoleColor.DarkGray;
                    display1();
                Mi:
                    Console.Write("\n\t\t\t\t\t\tEnter which Crop Type you want to remove : ");
                    key = Console.ReadLine();
                    if (c.ContainsKey(key))
                    {
                        c.Remove(key);
                        Console.WriteLine("\n\t\t\t\t\t\t************Deleted*************");
                        Thread.Sleep(2000);
                        Console.Clear();
                        Console.WriteLine("\n\n\n");
                        display1();
                    }
                    else
                    {
                        Console.WriteLine("\n\t\t\t\t\t\tEnter only contents present!");
                        Thread.Sleep(3000);
                        goto Mi;
                    }
                    goto ad;
                    break;
                case 4:
                    Console.Clear();
                    Console.WriteLine("\n\n\n");
                    Console.ForegroundColor = ConsoleColor.White;
                    display1();
                    Thread.Sleep(4000);
                    goto ad;
                case 5:
                    Console.ForegroundColor = ConsoleColor.DarkRed;
                    Console.WriteLine("\n\t\t\t\t\t\t**************Exiting****************");
                    Thread.Sleep(5000);
                    return;
                    break;
                default:
                    Console.WriteLine("\n\t\t\t\t\t\tvalid option please");
                    goto ad;
                    break;



            }

        }
        public void display1()
        {
            int a = 1;
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("\n\t\t\t\t\t\t   Crop Type \t  \t----> \t \tCrop info ");
            Console.WriteLine("\t\t\t\t\t\t---------------------------------------------------");
            foreach (DictionaryEntry x in c)
            {

                Console.Write("\t\t\t\t\t\t  " + a + ")   " + x.Key);
                Console.Write("\n\n\t\t\t\t\t\t\t\t\t---->\t\t" + x.Value + "\n");
                a++;

            }
        }
        public void fert()
        {

            int f7, f6, f40 = 0;
            string f8, f9, f5;
        fe:
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.WriteLine("\n\n\t\t\t\t\t\t\t        ADMIN PAGE\n\t\t\t\t\t\t\t     ================");
            Console.WriteLine("---------------------------------------------------------------------------------------------------------------------------------------------------");
            Console.WriteLine("\n\n\t\t\t\t\t  -------------Fertilizers & pesticides information------------");
            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.WriteLine("\n");

            Console.WriteLine("\n\t\t\t\t\t\tchoose :\n\t\t\t\t\t\t\t1.add info\n\t\t\t\t\t\t\t2.update info\n\t\t\t\t\t\t\t3.delete info\n\t\t\t\t\t\t\t4.Display info\n\t\t\t\t\t\t\t5.Exit");
            Console.Write("\n\t\t\t\t\t\tChoice : ");
            f7 = Convert.ToInt32(Console.ReadLine());
            switch (f7)
            {
                case 1:
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.Write("\n\t\t\t\t\t\tEnter how many entries you want add :  ");
                    f6 = Convert.ToInt32(Console.ReadLine());
                    f40 = f6;
                    for (int i = 0; i < f6; i++)
                    {
                        Console.Write("\n\t\t\t\t\t       Fertilizer & Pesticides Type --> " + (i + 1) + ")  ");
                        f8 = Console.ReadLine();
                        Console.Write("\n\t\t\t\t\t       Fertilizer & Pesticides info -->     ");
                        f9 = Console.ReadLine();
                        f.Add(f8, f9);
                    }
                    Console.Clear();
                    Console.WriteLine("\n\n\n");
                    display5();
                    Thread.Sleep(5000);
                    goto fe;
                    break;
                case 2:
                    string k2, k3, k4, k5;
                    int a3;
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    display5();
                    Console.WriteLine("\n\t\t\t\t\t\tEnter Which part you want to update\n\t\t\t\t\t\t1.Fertilizer & Pesticides Type\n\t\t\t\t\t\t2.Fertilizer & Pesticides info");
                    Console.Write("\n\t\t\t\t\t\tChoice  : ");
                    a3 = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("\n\n");
                    if (a3 == 1)
                    {
                    k8:
                        Console.Write("\n\t\t\t\t\tEnter which Fertilizer & Pesticides Type to update :  ");
                        k2 = Console.ReadLine();
                        if (f.ContainsKey(k2))
                        {
                            Console.Write("\n\t\t\t\t\tEnter new Fertilizer & Pesticides Type  :  ");
                            k3 = Console.ReadLine();
                            f.Add(k3, f[k2]);
                            f.Remove(k2);
                        }
                        else
                        {
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.WriteLine("\n\t\t\t\t\t\tEnter valid type!");
                            Thread.Sleep(4000);
                            goto k8;
                        }

                    }
                    else
                    {
                    k9:
                        Console.Write("\n\t\t\t\t\tEnter Which Fertilizer & Pesticides Type for update :  ");
                        k4 = Console.ReadLine();
                        if (f.ContainsKey(k4))
                        {
                            Console.Write("\n\t\t\t\t\tEnter new Fertilizer & Pesticides info   :  ");
                            k5 = Console.ReadLine();
                            f.Remove(k4);
                            f.Add(k4, k5);
                        }
                        else
                        {
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.WriteLine("\n\t\t\t\t\t\tEnter valid type!");
                            Thread.Sleep(4000);
                            goto k9;
                        }
                    }
                    Console.Clear();
                    Console.WriteLine("\n\n\n");
                    display5();
                    Thread.Sleep(5000);
                    goto fe;
                    break;


                case 3:
                Fi:
                    Console.Write("\n\t\t\t\t\tEnter which entry you want to remove : ");
                    f5 = Console.ReadLine();
                    if (f.ContainsKey(f5))
                    {
                        Console.WriteLine("\n\t\t\t\t\t\t*************Deleting*************");
                        f.Remove(f5);
                        Console.Clear();
                        Console.WriteLine("\n\n\n");
                        display5();
                        Thread.Sleep(4000);
                    }
                    else
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("\n\t\t\t\t\t\tEnter only contents present!");
                        Thread.Sleep(2000);
                        goto Fi;
                    }
                    goto fe;
                    break;
                case 4:
                    Console.Clear();
                    Console.WriteLine("\n\n\n");
                    display5();
                    Thread.Sleep(5000);
                    goto fe;
                    break;

                case 5:
                    Console.ForegroundColor = ConsoleColor.DarkRed;
                    Console.WriteLine("\n\t\t\t\t\t\t**************Exiting****************");
                    Thread.Sleep(5000);
                    return;
                    break;
                default:
                    Console.WriteLine("\n\t\t\t\t\t\tvalid option please");
                    goto fe;
                    break;
            }

        }
        public void display5()
        {
            int a = 1;
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("\n\t\t\t\t=============================================================================================");
            Console.WriteLine("\n\t\t\t\t   Fertilizer & Pesticides Type \t  \t----> \t \tFertilizer & Pesticides info ");
            Console.WriteLine("\n\t\t\t\t---------------------------------------------------------------------------------------------");
            foreach (DictionaryEntry x in f)
            {

                Console.Write("\t\t\t\t\t\t" + a + ")   " + x.Key);
                Console.Write("\n\n\t\t\t\t\t\t\t\t\t\t ---->\t\t" + x.Value + "\n");
                a++;
            }

        }
        public void mar()
        {
            int ma, cost, a, a2, a3;
            string p1, key;
            Console.ForegroundColor = ConsoleColor.Yellow;
        ad:
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.WriteLine("\n\n\t\t\t\t\t\t\t        ADMIN PAGE\n\t\t\t\t\t\t\t     ================");
            Console.WriteLine("---------------------------------------------------------------------------------------------------------------------------------------------------");
            Console.WriteLine("\n\n\t\t\t\t\t\t-------------Market value information------------");
            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.WriteLine("\n");
            Console.WriteLine("\n\t\t\t\t\t\tChoose any one of following : ");
            Console.WriteLine("\n\t\t\t\t\t\t1.Add crop info\n\t\t\t\t\t\t2.Update info\n\t\t\t\t\t\t3.Delete info\n\t\t\t\t\t\t4.Display Crop info\n\t\t\t\t\t\t5.Exit");
            Console.Write("\n\t\t\t\t\t\tchoice : ");
            a = Convert.ToInt32(Console.ReadLine());

            switch (a)
            {
                case 1:
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.Write("\n\t\t\t\t\t\tEnter how many Crop Types you want to add :   ");
                    a2 = Convert.ToInt32(Console.ReadLine());
                    for (int i = 0; i < a2; i++)
                    {
                        Console.Write("\n\t\t\t\t\t\t" + (i + 1) + "  ");
                        p1 = Console.ReadLine();
                        Console.Write("\t\t\t\t\t\t-->cost : Rs.");
                        cost = Convert.ToInt32(Console.ReadLine());
                        m.Add(p1, cost);
                    }
                    Console.Clear();
                    Console.WriteLine("\n\n\n");
                    display4();
                    Thread.Sleep(5000);
                    goto ad;

                case 2:
                    string k2, k3, k4;
                    int k5;
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    display4();
                    Console.WriteLine("\n\t\t\t\t\t\tEnter Which part you want to update\n\t\t\t\t\t\t1.Crop type\n\t\t\t\t\t\t2.Crop Cost");
                    Console.Write("\n\t\t\t\t\t\tChoice : ");
                    a3 = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("\n\n");

                    if (a3 == 1)
                    {
                    k8:
                        Console.Write("\n\t\t\t\t\t\tEnter which Crop Type to update : ");
                        k2 = Console.ReadLine();
                        if (m.ContainsKey(k2))
                        {
                            Console.Write("\n\t\t\t\t\t\tEnter new Crop Type  : ");
                            k3 = Console.ReadLine();
                            m.Add(k3, m[k2]);
                            m.Remove(k2);
                        }
                        else
                        {
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.WriteLine("\n\t\t\t\t\t\tEnter valid type!");
                            Thread.Sleep(4000);
                            goto k8;
                        }

                    }
                    else
                    {
                    k9:
                        Console.Write("\n\t\t\t\t\t\tEnter Which Crop Type for update : ");
                        k4 = Console.ReadLine();
                        if (m.ContainsKey(k4))
                        {
                            Console.Write("\n\t\t\t\t\t\tEnter new crop cost   : ");
                            k5 = Convert.ToInt32(Console.ReadLine());
                            m.Remove(k4);
                            m.Add(k4, k5);
                        }
                        else
                        {
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.WriteLine("\n\t\t\t\t\t\tEnter valid type!");
                            Thread.Sleep(4000);
                            goto k9;
                        }
                    }
                    Console.Clear();
                    Console.WriteLine("\n\n\n");
                    display4();
                    goto ad;
                    break;
                case 3:
                    Console.ForegroundColor = ConsoleColor.DarkGray;
                    display4();
                Mi:
                    Console.Write("\n\t\t\t\t\t\tEnter which Crop Type you want to remove : ");
                    key = Console.ReadLine();
                    if (c.ContainsKey(key))
                    {
                        c.Remove(key);
                        Console.WriteLine("\n\t\t\t\t\t\t************Deleted*************");
                        Thread.Sleep(2000);
                        Console.Clear();
                        Console.WriteLine("\n\n\n");
                        display4();
                    }
                    else
                    {
                        Console.WriteLine("\n\t\t\t\t\t\tEnter only contents present!");
                        Thread.Sleep(3000);
                        goto Mi;
                    }
                    goto ad;
                    break;
                case 4:
                    Console.Clear();
                    Console.WriteLine("\n\n\n");
                    Console.ForegroundColor = ConsoleColor.White;
                    display4();
                    Thread.Sleep(4000);
                    goto ad;
                case 5:
                    Console.ForegroundColor = ConsoleColor.DarkRed;
                    Console.WriteLine("\n\t\t\t\t\t\t**************Exiting****************");
                    Thread.Sleep(5000);
                    return;
                    break;
                default:
                    Console.WriteLine("\n\t\t\t\t\t\tvalid option please");
                    goto ad;
                    break;



            }


        }
        public void display4()
        {
            int a = 1;
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("\n\t\t\t\t\t\t Crop Type \t  \t----> \t \tCrop cost ");
            Console.WriteLine("\t\t\t\t\t\t---------------------------------------------------");
            foreach (var x in m)
            {

                Console.Write("\t\t\t\t\t\t  " + a + ")   " + x.Key);
                Console.Write("\n\n\t\t\t\t\t\t\t\t\t---->\t\tRs ." + x.Value + "\n");
                a++;

            }
        }
        public void cropb(string w)
        {

            string n, len, gmail, m1;
            double no, tot = 0, n1;
            int u = 0, k, k1;
            Regex cu = new Regex(na);
            Regex c = new Regex(mail);
        ba: Console.Clear();
            Console.ForegroundColor = ConsoleColor.DarkCyan;
            Console.WriteLine("\n\t\t\t\t\t\t\t\tBilling");
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("---------------------------------------------------------------------------------------------------------------------------------------------------");
            Console.ForegroundColor = ConsoleColor.DarkCyan;
            Console.WriteLine("\n\t\t\t\t\t\t\t      Billing details\n\t\t\t\t\t\t\t    ==================");
            Console.ForegroundColor = ConsoleColor.White;
       

            Console.ForegroundColor = ConsoleColor.White;
            Console.Write("\n\t\t\t\t\t\t\tName                       :  ");

            n = Console.ReadLine();
            if (cu.IsMatch(n))
            {

            nu:
                Console.ForegroundColor = ConsoleColor.White;
                Console.Write("\n\t\t\t\t\t\t\tMobile No (10-digits)      :  ");

                no = Convert.ToInt64(Console.ReadLine());
                len = no.ToString();
                if ((len.Length == 10))
                {
                m:
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.Write("\n\t\t\t\t\t\t\tMail                       :  ");
                    gmail = Console.ReadLine();
                    if (c.IsMatch(gmail))
                    {

                        Console.WriteLine("\n\n\n");
                        Console.ForegroundColor = ConsoleColor.White;

                        display4();
                        Thread.Sleep(2000);
                        Console.Write("\n\n\t\t\t\t\t\tEnter no of products to buy : ");
                        k = Convert.ToInt32(Console.ReadLine());
                        for (int i = 0; i < k; i++)
                        {
                            Console.Write("\n\t\t\t\t\t\t " + (i + 1) + ")  ");
                            m1 = Console.ReadLine();
                            if (m.ContainsKey(m1))
                            {
                                Console.WriteLine("\n\t\t\t\t\t\t      ****************Item added****************");
                                m12.Add(m1, m[m1]);
                                tot = tot + m12[m1];

                            }
                            else
                            {
                                Console.WriteLine("\n\t\t\t\t\t\tItem Invalid");
                            }
                        }
                        Console.WriteLine("\n\t\t\t\t\t\t\tPrinting Bill................");
                        Thread.Sleep(9500);
                        Console.Clear();
                        Console.ForegroundColor = ConsoleColor.DarkCyan;
                        Console.WriteLine("\n\t\t\t\t\t\t                   Bill\n\t\t\t\t\t\t\t        ________");
                        Console.ForegroundColor = ConsoleColor.DarkRed;
                        Console.WriteLine("--------------------------------------------------------------------------------------------------------------------------------------------------");
                        Console.ForegroundColor = ConsoleColor.Cyan;
                        Console.WriteLine("\n\t\t\t\t\t\tUser Id                       :   " + w);
                        Console.WriteLine("\n\t\t\t\t\t\tName                          :   " + n);
                        Console.WriteLine("\n\t\t\t\t\t\tMobile number                 :   " + no);
                        Console.WriteLine("\n\t\t\t\t\t\tMail Id                       :   " + gmail);
                        Console.ForegroundColor = ConsoleColor.DarkBlue;
                        Console.WriteLine("----------------------------------------------------------------------------------------------------------------------------------------------------");
                        Console.WriteLine("----------------------------------------------------------------------------------------------------------------------------------------------------");
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("\n\t\t\t\t\t\t\t         Products\n\t\t\t\t\t\t\t          ----------");
                        Console.ForegroundColor = ConsoleColor.DarkGreen; ;
                        foreach (var x in m12)
                        {
                            Console.WriteLine("\n\t\t\t\t\t\t " + (u + 1) + ")           " + x.Key + "                         " + x.Value);
                            u++;
                        }
                        Console.WriteLine("\n\t\t\t\t\t\t\t\t                         ----------");
                        Console.WriteLine("\n\t\t\t\t\t\t      Total Cost             -           Rs. " + tot);
                        Console.WriteLine("\n\t\t\t\t\t\t      Discount               -               3%");
                        Console.WriteLine("-----------------------------------------------------------------------------------------------------------------------------------------------------");
                        Console.WriteLine("\n\t\t\t\t\t\t      Final Cost             -          Rs. " + (tot * 0.03));
                        Console.ForegroundColor = ConsoleColor.DarkRed;
                        Console.ForegroundColor = ConsoleColor.Yellow;
                        Console.WriteLine("-----------------------------------------------------------------------------------------------------------------------------------------------------");
                        Console.WriteLine("*****************************************************************************************************************************************************");
                        Console.WriteLine("\n\t\t\t\t\t\t\t   Thank you ! Visit Again");
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("*****************************************************************************************************************************************************");
                        Thread.Sleep(10000);
                        return;

                    }

                    else
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("\n\t\t\t\t\t\t\tShould Contain @gmail.com");
                        Console.WriteLine("\n\t\t\t\t\t\tRe-Enter details");
                        goto ba;
                    }

                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("\n\t\t\t\t\t\t\tShould Contain 10-digits");
                    Console.WriteLine("\n\t\t\t\t\t\tRe-Enter details");
                    goto ba;
              }
            }

            else
                Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("\n\t\t\t\t\t\t\tFirst Letter should be capital");
            Console.WriteLine("\n\t\t\t\t\t\tRe-Enter details");
            goto ba;
        }
    }

}
public class Bill : admin
    {
        public SortedList<string, double> f2 = new SortedList<String, double>();
        public SortedList<string, double> f12 = new SortedList<String, double>();
        public SortedList<String, int> m22 = new SortedList<String, int>();
        public string mail = "@gmail.com$";
        public string na = "^[A-Z]";
        public int m11;
        
        public void fertc()
        {
            int a, f6, f40;
            string f8;
            double f9;
        fe:
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.WriteLine("\n\n\t\t\t\t\t\t\t        ADMIN PAGE\n\t\t\t\t\t\t\t     ================");
            Console.WriteLine("---------------------------------------------------------------------------------------------------------------------------------------------------");
            Console.WriteLine("\n\n\t\t\t\t\t  -------------Fertilizers & pesticides Market Cost-----------");
            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.WriteLine("\n");
            Console.WriteLine("\n\t\t\t\t\t\tChoose : \n\t\t\t\t\t\t\t1.Add\n\t\t\t\t\t\t\t2.Update\n\t\t\t\t\t\t\t3.Delete\n\t\t\t\t\t\t\t4.Display\n\t\t\t\t\t\t\t5.Exit");
            Console.Write("\n\t\t\t\t\t\tchoice : ");
            a = Convert.ToInt32(Console.ReadLine());
            switch (a)
            {
                case 1:
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.Write("\n\t\t\t\t\t\tEnter how many entries you want add :  ");
                    f6 = Convert.ToInt32(Console.ReadLine());
                    f40 = f6;
                    for (int i = 0; i < f6; i++)
                    {
                        Console.Write("\n\t\t\t\t\t         Fertilizer & Pesticides Type --> " + (i + 1) + ")  ");
                        f8 = Console.ReadLine();
                        Console.Write("\n\t\t\t\t\t         Cost of Fertilizer & Pesticides -->  Rs. ");
                        f9 = Convert.ToInt64(Console.ReadLine());
                        f2.Add(f8, f9);
                    }
                    Console.Clear();
                    Console.WriteLine("\n\n\n");
                    display6();
                    Thread.Sleep(5000);
                    goto fe;
                case 2:
                    string k2, k3, k4;
                    double k5;
                    int a3;
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    display6();
                    Console.WriteLine("\n\t\t\t\t\t\tEnter Which part you want to update\n\t\t\t\t\t\t1.Fertilizer & Pesticides Type\n\t\t\t\t\t\t2.Fertilizer & Pesticides Cost");
                    Console.Write("\n\t\t\t\t\t\tChoice  : ");
                    a3 = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("\n\n");
                    if (a3 == 1)
                    {
                    k8:
                        Console.Write("\n\t\t\t\t\t  Enter which Fertilizer & Pesticides Type to update :  ");
                        k2 = Console.ReadLine();
                        if (f2.ContainsKey(k2))
                        {
                            Console.Write("\n\t\t\t\t\t  Enter new Fertilizer & Pesticides Type  :  ");
                            k3 = Console.ReadLine();
                            f2.Add(k3, f2[k2]);
                            f2.Remove(k2);
                        }
                        else
                        {
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.WriteLine("\n\t\t\t\t\t\tEnter valid type!");
                            Thread.Sleep(4000);
                            goto k8;
                        }

                    }
                    else
                    {
                    k9:
                        Console.Write("\n\t\t\t\t\tEnter Which Fertilizer & Pesticides Type for update :  ");
                        k4 = Console.ReadLine();
                        if (f2.ContainsKey(k4))
                        {
                            Console.Write("\n\t\t\t\t\tEnter new Fertilizer & Pesticides Cost   :  ");
                            k5 = Convert.ToInt64(Console.ReadLine());
                            f2.Remove(k4);
                            f2.Add(k4, k5);
                        }
                        else
                        {
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.WriteLine("\n\t\t\t\t\t\tEnter valid type!");
                            Thread.Sleep(4000);
                            goto k9;
                        }
                    }
                    Console.Clear();
                    Console.WriteLine("\n\n\n");
                    display6();
                    Thread.Sleep(5000);
                    goto fe;
                    break;
                case 3:
                    string f5;
                    display6();
                Fi:
                    Console.Write("\n\t\t\t\t\tEnter which entry you want to remove : ");
                    f5 = Console.ReadLine();
                    if (f2.ContainsKey(f5))
                    {
                        Console.WriteLine("\n\t\t\t\t\t\t*************Deleting*************");
                        f2.Remove(f5);
                        Console.Clear();
                        Console.WriteLine("\n\n\n");
                        display5();
                        Thread.Sleep(4000);
                    }
                    else
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("\n\t\t\t\t\t\tEnter only contents present!");
                        Thread.Sleep(2000);
                        goto Fi;
                    }
                    goto fe;
                    break;
                case 4:
                    Console.Clear();
                    Console.WriteLine("\n\n\n");
                    display6();
                    Thread.Sleep(5000);
                    goto fe;
                    break;
                case 5:
                    Console.ForegroundColor = ConsoleColor.DarkRed;
                    Console.WriteLine("\n\t\t\t\t\t\t**************Exiting****************");
                    Thread.Sleep(5000);
                    return;
                    break;
                default:
                    Console.WriteLine("\n\t\t\t\t\t\tvalid option please");
                    goto fe;
                    break;

            }
        }
        public void display6()
        {
            int a = 1;
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("\n\t\t\t\t========================================================================================");
            Console.WriteLine("\n\t\t\t\t Fertilizer & Pesticides Type \t  \t----> \t \tCost of Fertilizer & Pesticides");
            Console.WriteLine("\n\t\t\t\t------------------------------------------------------------------------------------------");
            foreach (var x in f2)
            {

                Console.Write("\t\t\t\t  " + a + ")   " + x.Key);
                Console.Write("\n\n\t\t\t\t\t\t\t\t\t---->\t\t" + x.Value + "\n");
                a++;

            }

        }
        public void billf(string w)
        {
            string n, len, gmail, m1;
            double no, tot = 0, n1;
            int u = 0, k, k1;
            Regex cu = new Regex(na);
            Regex c = new Regex(mail);
        ba: Console.Clear();
            Console.ForegroundColor = ConsoleColor.DarkCyan;
            Console.WriteLine("\n\t\t\t\t\t\t\t\tBilling");
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("---------------------------------------------------------------------------------------------------------------------------------------------------");
            Console.ForegroundColor = ConsoleColor.DarkCyan;
            Console.WriteLine("\n\t\t\t\t\t\t\t      Billing details\n\t\t\t\t\t\t\t    ==================");
            Console.ForegroundColor = ConsoleColor.White;

        
        
            Console.ForegroundColor = ConsoleColor.White;
            Console.Write("\n\t\t\t\t\t\t\tName                       :  ");

            n = Console.ReadLine();
            if (cu.IsMatch(n))
            {

            nu:
                Console.ForegroundColor = ConsoleColor.White;
                Console.Write("\n\t\t\t\t\t\t\tMobile No (10-digits)      :  ");

                no = Convert.ToInt64(Console.ReadLine());
                len = no.ToString();
                if ((len.Length == 10))
                {
                m:
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.Write("\n\t\t\t\t\t\t\tMail                       :  ");
                    gmail = Console.ReadLine();
                    if (c.IsMatch(gmail))
                    {
                        display6();
                        Console.Write("\n\t\t\t\t\t\tEnter no of products to buy : ");
                        k = Convert.ToInt32(Console.ReadLine());
                        for (int i = 0; i < k; i++)
                        {
                            Console.Write("\n\t\t\t\t\t\t " + (i + 1) + ")  ");
                            m1 = Console.ReadLine();
                            if (f2.ContainsKey(m1))
                            {
                                Console.WriteLine("\n\t\t\t\t\t\t      ****************Item added****************");
                                f12.Add(m1, f2[m1]);
                                tot = tot + f12[m1];

                            }
                            else
                            {
                                Console.WriteLine("\n\t\t\t\t\t\tItem Invalid");
                            }
                        }
                        Thread.Sleep(9000);
                        Console.Clear();
                    Console.Clear();
                        Console.ForegroundColor = ConsoleColor.DarkCyan;
                        Console.WriteLine("\n\t\t\t\t\t\t                  Bill\n\t\t\t\t\t\t\t        ________");
                        Console.ForegroundColor = ConsoleColor.DarkRed;
                        Console.WriteLine("--------------------------------------------------------------------------------------------------------------------------------------------------");
                        Console.ForegroundColor = ConsoleColor.Cyan;
                        Console.WriteLine("\n\t\t\t\t\t\tUser Id                       :   " + w);
                        Console.WriteLine("\n\t\t\t\t\t\tName                          :   " + n);
                        Console.WriteLine("\n\t\t\t\t\t\tMobile number                 :   " + no);
                        Console.WriteLine("\n\t\t\t\t\t\tMail Id                       :   " + gmail);
                        Console.ForegroundColor = ConsoleColor.DarkBlue;
                        Console.WriteLine("----------------------------------------------------------------------------------------------------------------------------------------------------");
                        Console.WriteLine("----------------------------------------------------------------------------------------------------------------------------------------------------");
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("\n\t\t\t\t\t\t\t        Products\n\t\t\t\t\t\t\t     ----------");
                        Console.ForegroundColor = ConsoleColor.DarkGreen; ;
                        foreach (var x in f12)
                        {
                            Console.WriteLine("\n\t\t\t\t\t\t    " + (u + 1) + ")           " + x.Key + "                         " + x.Value);
                            u++;
                        }
                        Console.WriteLine("\n\t\t\t\t\t\t\t\t                      ----------");
                        Console.WriteLine("\n\t\t\t\t\t\t      Total Cost             -           Rs. " + tot);
                        Console.WriteLine("\n\t\t\t\t\t\t      Discount               -               30%");
                        Console.WriteLine("----------------------------------------------------------------------------------------------------------------------------------------------------");
                        Console.WriteLine("\n\t\t\t\t\t\t      Final Cost             -          Rs. " + (tot * 0.3));
                        Console.ForegroundColor = ConsoleColor.DarkRed;
                        Console.ForegroundColor = ConsoleColor.Yellow;
                        Console.WriteLine("----------------------------------------------------------------------------------------------------------------------------------------------------");
                        Console.WriteLine("----------------------------------------------------------------------------------------------------------------------------------------------------");
                        Console.WriteLine("\n\t\t\t\t\t\t\t   Thank you ! Visit Again  :)");
                        Console.ForegroundColor = ConsoleColor.DarkRed;
                        Console.WriteLine("----------------------------------------------------------------------------------------------------------------------------------------------------");
                        Thread.Sleep(12000);
                        return;
                    }

                    else
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("\n\t\t\t\t\t\t\tShould Contain @gmail.com");
                    Console.WriteLine("ReEnter your details");
                    goto ba;
                    }

                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("\n\t\t\t\t\t\t\tShould Contain 10-digits");
                Console.WriteLine("ReEnter your details");
                goto ba;
                }
            }

            else
                Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("\n\t\t\t\t\t\t\tFirst Letter should be capital");
        Console.WriteLine("ReEnter your details");
        goto ba;
        }

    
    }



    internal class Program : Bill
    {
        public static string p1 = "admin", i1 = "admin", i2, p2, crop;
        static void Main(string[] args)
        {
            int a, m23 = 0; ;
            Bill bil = new Bill();
            
        st:
            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.Write("\n\n\t\t\t\t\t\t-------------------------------\n\t\t\t\t\t\t|");
            Console.Write("\"Welcome to Digital Farming\"");
            Console.WriteLine("|\t\t\t\t\t\t\n\t\t\t\t\t\t-------------------------------");
            Thread.Sleep(1500);
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("\t\t\t\t\t\twe are here you to assist ");
            Console.WriteLine();
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("\n\t\t\t\t\t\tChoose any one Among the Following\n\t\t\t\t\t\t1.Admin\n\t\t\t\t\t\t2.User");
            Console.Write("\t\t\t\t\t\t ");
            a = Convert.ToInt32(Console.ReadLine());
            Console.Clear();
            if (a == 1)
            {
                int b;
                Console.ForegroundColor = ConsoleColor.DarkGreen;
                Console.WriteLine("\n\n\t\t\t\t\t\t   \"Welcome to Digital Farming\"");
                Console.WriteLine("\t\t\t\t\t\t----------------------------------");
                Thread.Sleep(1500);
            l:
                Console.ForegroundColor = ConsoleColor.DarkMagenta;
                Console.WriteLine("\n\n\t\t\t\t\t\t--> Choose :\n  \t\t\t\t\t\t\t1.login\t\t2.sign up");
                Console.ForegroundColor = ConsoleColor.DarkRed;
                Console.Write("\n\t\t\t\t\t\tEnter your choice : ");
                b = Convert.ToInt32(Console.ReadLine());
                if (b == 1)
                {
                    String a1, b1;
                    Console.Clear();
                    Console.ForegroundColor = ConsoleColor.DarkYellow;
                    Console.WriteLine("\n\n\t\t\t\t\t\t   \"Welcome to Admin Login page\"");
                    Console.WriteLine("\t\t\t\t\t\t----------------------------------");
                    Thread.Sleep(1500);
                    if (m23 == 0)
                    {
                        Console.WriteLine("\n\t\t\t\t\t\tDefault Admin id,Password : admin");

                    }
                    else
                    {
                        Console.WriteLine("\n\t\t\t\t\t\t     your creidtnals please");
                    }

                    Console.ForegroundColor = ConsoleColor.DarkBlue;
                    Console.Write("\n\n\t\t\t\t\t\tAdmin id : ");
                    a1 = Console.ReadLine();
                    Console.Write("\n\t\t\t\t\t\tPassword : ");
                    b1 = Console.ReadLine();
                Console.WriteLine("\n\n\t\t\t\t\t\t\tLogging you in......");
                Thread.Sleep(1000);
                if (a1 != i1 || b1 != p1)
                    {
                        Console.Clear();
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("\n\t\t\t\t\t\t*Invalid Admin id or password\n");

                        goto l;
                    }
                    else
                    {
                        Console.Clear();
                        int k, c1;
                    am:
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine("\n\n\t\t\t\t\t\t    \tWelcome Admin \"" + i1 + "\" to digital farming");
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("\n====================================================================================================================================================");
                        Console.ForegroundColor = ConsoleColor.Yellow;
                        Console.WriteLine("\n\t\t\t\t\t\tEnter your choice ");
                        Console.WriteLine("\n\t\t\t\t\t\t\t 1.Soil info\n\t\t\t\t\t\t\t 2.Crop info\n\t\t\t\t\t\t\t 3.Fertilizers & Pesticides info \n\t\t\t\t\t\t\t 4.Fertilizers & Pesticides cost\n\t\t\t\t\t\t\t 5.Market value of Crops\n\t\t\t\t\t\t\t 6.Exit");
                        Console.ForegroundColor = ConsoleColor.White;
                        Console.Write("\n\n\t\t\t\t\t\tChoice  : ");
                        k = Convert.ToInt32(Console.ReadLine());
                        switch (k)
                        {
                            case 1:
                                bil.soil();
                                Console.Clear();
                                goto am;
                                break;
                            case 2:
                                bil.crop();
                                Console.Clear();
                                goto am;
                                break;
                            case 3:
                                bil.fert();
                                Console.Clear();
                                goto am;
                                break;
                            case 4:
                                bil.fertc();
                                Console.Clear();
                                goto am;
                            case 5:
                                bil.mar();
                                Console.Clear();
                                goto am;
                            case 6:
                                Console.ForegroundColor = ConsoleColor.DarkRed;
                                Console.WriteLine("\n\t\t\t\t\t\t**************Exiting****************");
                                Thread.Sleep(5000);
                                Console.Clear();
                                goto st;
                            default: goto am;
                        }

                    }

                }

                else
                {
                    Console.Clear();
                    Console.ForegroundColor = ConsoleColor.DarkYellow;
                    m23 = 1;
                    Console.WriteLine("\n\n\t\t\t\t\t\t    \"Welcome to Sign up page\"");
                    Console.WriteLine("\t\t\t\t\t\t-------------------------------");
                    Thread.Sleep(1500);
                    Console.ForegroundColor = ConsoleColor.Magenta;
                    Console.Write("\n\t\t\t\t\t\tSet up new Admin id  : ");
                    i1 = Console.ReadLine();
                    Console.Write("\n\t\t\t\t\t\tSet up Password      : ");
                    p1 = Console.ReadLine();
                    Console.ForegroundColor = ConsoleColor.DarkCyan;
                    Console.WriteLine("\n\t\t\t\t\t\t  **** Congragulations ****!");
                    Thread.Sleep(2000);
                    Console.Clear();
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.WriteLine("\n\n\t\t\t\t\t\tPlease Login With the creditnals!\n");
                    Console.Clear();
                    goto l;
                }

            }
            else if (a == 2)
            {
                int c;
            c:
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("\n\t\t\t\t\t\t   \"Welcome to Digital Farming\"");
                Console.WriteLine("\t\t\t\t\t\t----------------------------------");
                Thread.Sleep(1500);
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("\n\t\t\t\t\t\t--> Choose \n\t\t\t\t\t\t\t   1.login\n\t\t\t\t\t\t\t   2.sign up");
                Console.Write("\n\n\t\t\t\t\t\tChoice please : ");
                c = Convert.ToInt32(Console.ReadLine());
                Console.Clear();
                if (c == 1)
                {
                    String a1, b1;
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("\n\t\t\t\t\t\t  \" Welcome to Digital Farming user login page \"");
                    Console.WriteLine("\t\t\t\t\t\t--------------------------------------------------");
                    Thread.Sleep(1500);
                    Console.ForegroundColor = ConsoleColor.Magenta;
                    Console.Write("\n\t\t\t\t\t\t\t\tUser id   : ");
                    a1 = Console.ReadLine();
                    Console.Write("\n\t\t\t\t\t\t\t\tPassword  : ");
                    b1 = Console.ReadLine();
                   // Console.WriteLine("\n\n\t\t\t\t\t\t\t\tLogging you in......");
                    //Thread.Sleep(1000);
                    if (a1 != i2 || b1 != p2)
                    {
                        
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("\n\t\t\t\t\t\t\t    Invalid User id or password");
                    Thread.Sleep(2000);
                        goto c;
                    }
                    else
                    {
                        Console.Clear();
                        int l, l1, l12,l22;
                        String c1;

                    f1:
                        Console.ForegroundColor = ConsoleColor.Blue;
                        Console.WriteLine("\n\n\t\t\t\t\t\t    \tWelcome User \"" + a1 + "\" to digital farming");
                        Console.ForegroundColor = ConsoleColor.Yellow;
                        Console.WriteLine("\n====================================================================================================================================================");
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("\n\t\t\t\t\t  Here you can sell,investigate and guided for the better results");

                        Console.ForegroundColor = ConsoleColor.Magenta;
                        Console.WriteLine("\n\t\t\t\t\t\tplease chooose among the following:\n\t\t\t\t\t\t\t1.Soil info\n\t\t\t\t\t\t\t2.Crop info\n\t\t\t\t\t\t\t3.Fertilizers and pesticides info\n\t\t\t\t\t\t\t4.Fertilizers and pesticides Market Cost\n\t\t\t\t\t\t\t5.Market value of crops\n\t\t\t\t\t\t\t6.Exit");
                        Console.Write("\n\t\t\t\t\t\tChoice : ");
                        l = Convert.ToInt32(Console.ReadLine());

                        switch (l)
                        {
                            case 1:
                                Console.Clear();
                                Console.WriteLine("\n\n\n\n");
                                bil.display();
                                Thread.Sleep(5000);
                                Console.Clear();
                                goto f1;
                            case 2:
                                Console.Clear();
                                Console.WriteLine("\n\n\n\n");
                                bil.display1();

                                Thread.Sleep(5000);
                                Console.Clear();
                                goto f1;
                            case 3:
                                Console.Clear();
                                Console.WriteLine("\n\n\n\n");
                                bil.display5();
                                Thread.Sleep(2000);
                                goto f1;
                            case 4:
                                Console.Clear();
                                Console.WriteLine("\n\n\n\n");
                                bil.display6();
                                Thread.Sleep(5000);
                                Console.WriteLine("\n\t\t\t\t\t\tDo you want to buy fertilizers & Pesticides : \n\t\t\t\t\t\t1.Yes\n\t\t\t\t\t\t2.No");
                                Console.Write("\n\t\t\t\t\t\t Choice : ");
                                l12 = Convert.ToInt32(Console.ReadLine());
                                if (l12 == 1)
                                {
                                    Console.Clear();
                                    bil.billf(a1);
                                }
                                Console.Clear();
                                goto f1;
                            case 5:
                                Console.Clear();
                                Console.WriteLine("\n\n\n\n");
                               
                                 bil.display4();
                                Thread.Sleep(5000);
                                Console.WriteLine("\n\n\t\t\t\t\t\tDo you want to Sell crops : \n\t\t\t\t\t\t1.Yes\n\t\t\t\t\t\t2.No");
                                Console.Write("\n\t\t\t\t\t\t Choice : ");
                                l22 = Convert.ToInt32(Console.ReadLine());
                                if (l22 == 1)
                                {
                                Console.Clear();
                                bil.cropb(a1); 
                                }
                                
                                Console.Clear();
                                goto f1;
                                break;


                            case 6:
                                Console.ForegroundColor = ConsoleColor.DarkRed;
                                Console.WriteLine("\n\t\t\t\t\t\t**************Exiting****************");
                                Thread.Sleep(5000);
                                Console.Clear();
                                goto st;


                            default:
                                Console.ForegroundColor = ConsoleColor.Red;
                                Console.WriteLine("\n\t\t\t\t\t\tEnter valid choice");
                                goto f1; break;

                        }


                    }
                }
                else
                {
                    Console.Clear();

                    Console.WriteLine("\n\n\t\t\t\t\t\t    \"Welcome to Sign up page\"");
                    Console.WriteLine("\t\t\t\t\t\t--------------------------------");
                    Thread.Sleep(1500);
                    Console.ForegroundColor = ConsoleColor.Magenta;
                    Console.Write("\n\t\t\t\t\t\tSet up new User id   : ");
                    i2 = Console.ReadLine();
                    Console.Write("\n\t\t\t\t\t\tSet up Password      : ");
                    p2 = Console.ReadLine();
                    Console.ForegroundColor = ConsoleColor.Blue;
                    Console.WriteLine("\n\n\t\t\t\t\t\t  *****Congragulations*****");
                    Thread.Sleep(2000);
                    Console.Clear();
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.WriteLine("\n\t\t\t\t\t\t  Please Login With the creditnals!");
                    goto c;
                }
            }

        }
    }

    


