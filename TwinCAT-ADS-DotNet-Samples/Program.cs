﻿using System;
using System.Collections.Generic;
using System.Diagnostics;
using TwinCAT.Ads.TypeSystem;
using TwinCAT.TypeSystem;

namespace TwinCAT_ADS_DotNet_Samples
{
    internal class Program
    {
        static void Main(string[] args)
        {  
            Console.WriteLine("Hello World");
            Read_Samples reader = new Read_Samples();
            Method_Call_Samples methods = new Method_Call_Samples();
            Write_Samples writer = new Write_Samples(); 
            List<string> symbols = new List<string>();
            using(Connection_Samples adsconnection = new Connection_Samples())
            {
                ///////////////////Simple Connection sample, checks the status of connection//////////////
                //adsconnection.ConnectionUsingAdsSession("169.254.61.77.1.1", 851);
                //adsconnection.ConnectionUsingAdsSession("169.254.61.77.1.1", 353);
                // adsconnection.ConnectionUsingAdsSession("169.254.127.143.2.1", 1001);
                // adsconnection.CheckConnection();
                // Console.WriteLine(adsconnection.info.ToString());
                // Console.WriteLine(adsconnection.deviceInfo.ToString());
                // Console.WriteLine(adsconnection.connectionState);
                //Console.ReadLine();


                /////////////////Read/Write SUM Data From an IO Task///////////////////
                //adsconnection.ConnectionUsingAdsSession("169.254.61.77.1.1", 301);
                //adsconnection.LoadSymbolsFromTarget(1);
                //string[] targets = { "Task 4.Inputs.Var 464",
                //                        "Task 4.Inputs.Var 469",
                //                        "Task 4.Inputs.Var 470",
                //                        "Task 4.Inputs.Var 471"};
                //string[] outputs = {"Task 4.Outputs.Var 347",
                //                        "Task 4.Outputs.Var 348" };
                //object[] values = { false, false };
                //Object[] result =  reader.SumReadPrimativeTypes(adsconnection.loader, adsconnection.adsConnection, targets);
                //Console.WriteLine(result[0] + " " + result[1]+ " " + result[2] + " "+ result[3]);
                //Console.ReadLine();
                //writer.SumWritePrimativeTypes(adsconnection.loader, adsconnection.adsConnection, outputs, values);
                //Console.ReadLine();


                ///////////////////////Read direct IO data from EtherCAT Master ADS device////////////////////////
                //adsconnection.ConnectionUsingAdsSession("169.254.61.77.1.1", 27908);
                //adsconnection.LoadSymbolsFromTarget(1);
                //string[] targets = { "Term 3 (EL9227-5500).OCP Inputs Channel 1.Load",
                //                        "Term 4 (EL1008).Channel 1.Input",
                //                        "Term 3 (EL9227-5500).OCP Inputs Channel 2.Current",
                //                        "Term 10 (ELX1054).Channel 1.Input"};
                //Console.WriteLine(reader.ReadPrimativeWithSymbolicAccess(adsconnection.loader, targets[0]));
                //Console.WriteLine(reader.ReadPrimativeWithSymbolicAccess(adsconnection.loader, targets[1]));
                //Console.WriteLine(reader.ReadPrimativeWithSymbolicAccess(adsconnection.loader, targets[2]));
                //Console.WriteLine(reader.ReadPrimativeWithSymbolicAccess(adsconnection.loader, targets[3]));
                //Console.ReadLine();


                ////////////////////////Call Method inside PLC///////////////////////////////////////////////////
                // methods.DisplayRpcMethods(adsconnection.loader,"MAIN.fbMath");
                // methods.CallMethodInPLC(adsconnection.adsConnection, 
                //      "MAIN.fbMath","mAdd",new object[] { (short)1, (short)2 });
                //Console.ReadLine();    


                //////////////////Read array data from TcCOM object in TwinCAT/////////////////////////////
                //Console.WriteLine("Array Access");
                //double[] buffer = new double[8];
                //buffer = reader.ReadArrayWithSymbolicAccess(adsconnection.loader, 
                //    "Object1 (MyTestModel).MyTestModel_B.Constant5" );
                //foreach (double d in buffer)
                //{
                //    Console.WriteLine(d.ToString());
                //}
                //Console.ReadLine();
                //Console.WriteLine("Single Access");
                //Console.WriteLine(reader.ReadPrimativeWithSymbolicAccess(adsconnection.loader,
                //                   "Object1 (MyTestModel).MyTestModel_B.Constant5[2]"));
                //Console.ReadLine();



                ////////////////////////Read samples for primitive and structs/////////////////////////////////////
                //Console.WriteLine(reader.ReadPrimativeWithSymbolicAccess(adsconnection.loader, "MAIN.iInt"));
                // byte[] val1 = reader.ReadComplexWithSymbolicAccess(adsconnection.loader, "MAIN.testStruct");
                //object value = reader.ReadComplexWithDynamicSymbolAccess(adsconnection.loader, "MAIN.testStruct");
                //Console.ReadLine();


                //////////////////////////Event reading - set up Event handler on symbol/////////////////////////////
                //adsconnection.ConnectionUsingAdsSession("169.254.61.77.1.1", 851);
                //adsconnection.LoadSymbolsFromTarget(1);
                //reader.CreateEventOnPrimativeType(adsconnection.loader, "MAIN.realData", OnChangeArray);
                //Console.ReadLine();
                //reader.RemoveEventOnPrimative(adsconnection.loader, "MAIN.realData");
                //Console.ReadLine();


                ////////////////////////////Read CoE index of EtherCAT device//////////////////////////////////////
                // adsconnection.ConnectionUsingAdsSession("169.254.127.143.2.1", 1001);
                // byte[] readBuffer = new byte[8];
                // reader.ReadWithIdxOfs("F302","10180001", adsconnection.adsConnection,readBuffer);
                //Console.ReadLine();

                //////////////////////////Timing ADS read cycles/////////////////////////////
                //adsconnection.ConnectionUsingAdsSession("169.254.61.77.1.1", 851);
                //adsconnection.LoadSymbolsFromTarget(0);
                
                //foreach (IAdsSymbol symbol in adsconnection.loader.Symbols)
                //{
                //    Console.WriteLine(symbol.InstancePath.ToString());
                //    Console.WriteLine(symbol.IndexGroup.ToString());
                //    Console.WriteLine(symbol.IndexOffset.ToString());
                //}
                //byte[] buffer = new byte[8000];
                //Stopwatch stopwatch = Stopwatch.StartNew();

                
                ////double[] val1 = reader.ReadArrayWithSymbolicAccess(adsconnection.loader, "MAIN.arrLreal");
                //reader.ReadWithIdxOfs("4040", "5DFF0", adsconnection.adsConnection, buffer);
                ////reader.ReadWithIdxOfs("4040", "6EE88", adsconnection.adsConnection, buffer);

                //stopwatch.Stop();


                ////double[] buffer2 = new double[buffer.Length / 8];
                ////Buffer.BlockCopy(buffer, 0, buffer2, 0, buffer2.Length * 8);
                //double[] buffer2 = new double[buffer.Length / 8];
                //for (int i = 0; i < buffer2.Length; i++)
                //    buffer2[i] = BitConverter.ToDouble(buffer, i * 8);

                //Console.WriteLine(stopwatch.ElapsedMilliseconds);

                Console.ReadLine();
            }
        }

        static public void OnChangePrimative(object sender, ValueChangedEventArgs e)
        {
            Symbol symbol = (Symbol)e.Symbol;
            Console.WriteLine("The Var " + e.Symbol + " has value " + e.Value);
            Console.WriteLine(sender.ToString());
        }

        static public void OnChangeArray(object sender, ValueChangedEventArgs e)
        {
            Symbol symbol = (Symbol)e.Symbol;
            float[] values = (float[])e.Value;
            foreach(float value in values)
            {
                Console.WriteLine(value.ToString());
            }
            Console.WriteLine(sender.ToString());
        }


    }
}
