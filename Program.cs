using System;
using Encog.Neural.Networks;
using Encog.Neural.Networks.Layers;
using Encog.Engine.Network.Activation;
using Encog.ML.Data;
using Encog.Neural.Networks.Training.Propagation.Resilient;
using Encog.ML.Train;
using Encog.ML.Data.Basic;
using Encog;
using System.Drawing;
using System.Threading;


namespace encog_sample_csharp
{
    internal class Program
    {
        //DUSANOV DEO
        public static double[,] pikseliStop;
        public static double[,] pikseliStop2;
        public static double[,] pikseliStop3;
        public static double[,] pikseliZnakop;
        public static double[,] pikseliZnakop2;
        public static double[,] pikseliPrvenstvo;
        public static double[,] pikseliPrvenstvo2;
        public static double[,] pikseliPrvenstvo3;
        public static double[,] pikseliBrzina;
        public static double[,] pikseliBrzina2;
        public static double[,] pikseliBrzina3;

        public static double[,] pikseliStopTest;
        public static double[,] pikseliZnakopTest;
        public static double[,] pikseliPrvenstvoTest;
        public static double[,] pikseliBrzinaTest;

        public Program()
        {

        }
      //DUSANOV DEO

        private static void Main(string[] args)
        {
            //DUSANOV DEO
            Program p = new Program();
            Console.WriteLine("PROGRAM POCEO");

            //za stop znak
            Image stopSlika = Image.FromFile(@"...\stop.png");
            Bitmap stopBit = new Bitmap(stopSlika);
            pikseliStop = p.ubaciUMatricu(pikseliStop, stopBit);

            Image stopSlika2 = Image.FromFile(@"...\stop2.png");
            Bitmap stopBit2 = new Bitmap(stopSlika2);
            pikseliStop2 = p.ubaciUMatricu(pikseliStop2, stopBit2);

            Image stopSlika3 = Image.FromFile(@"...\stop3.jpg");
            Bitmap stopBit3 = new Bitmap(stopSlika3);
            pikseliStop3 = p.ubaciUMatricu(pikseliStop3, stopBit3);


            Thread.Sleep(500);

            //za znak opasnosti
            Image znakopSlika = Image.FromFile(@"...\znak-opasnosti.jpg");
            Bitmap znakopBit = new Bitmap(znakopSlika);
            pikseliZnakop = p.ubaciUMatricu(pikseliZnakop, znakopBit);

            Image znakopSlika2 = Image.FromFile(@"...\znak-opasnosti2.png");
            Bitmap znakopBit2 = new Bitmap(znakopSlika2);
            pikseliZnakop2 = p.ubaciUMatricu(pikseliZnakop2, znakopBit2);

            Thread.Sleep(500);

            //za znak prvenstva
            Image prvenstvoSlika = Image.FromFile(@"...\prvenstvo.jpg");
            Bitmap prvenstvoBit = new Bitmap(prvenstvoSlika);
            pikseliPrvenstvo = p.ubaciUMatricu(pikseliPrvenstvo, prvenstvoBit);

            Image prvenstvoSlika2 = Image.FromFile(@"...\prvenstvo2.png");
            Bitmap prvenstvoBit2 = new Bitmap(prvenstvoSlika2);
            pikseliPrvenstvo2 = p.ubaciUMatricu(pikseliPrvenstvo2, prvenstvoBit2);

            Image prvenstvoSlika3 = Image.FromFile(@"...\prvenstvo3.png");
            Bitmap prvenstvoBit3 = new Bitmap(prvenstvoSlika3);
            pikseliPrvenstvo3 = p.ubaciUMatricu(pikseliPrvenstvo3, prvenstvoBit3);
            
            Thread.Sleep(500);

            //za znak ogranicenja brzine
            Image brzinaSlika = Image.FromFile(@"...\ogranicenje-brzine.jpg");
            Bitmap brzinaBit = new Bitmap(brzinaSlika);
            pikseliBrzina = p.ubaciUMatricu(pikseliBrzina, brzinaBit);

            Image brzinaSlika2 = Image.FromFile(@"...\ogranicenje-brzine2.jpg");
            Bitmap brzinaBit2 = new Bitmap(brzinaSlika2);
            pikseliBrzina2 = p.ubaciUMatricu(pikseliBrzina2, brzinaBit2);

            Image brzinaSlika3 = Image.FromFile(@"...\ogranicenje-brzine3.jpg");
            Bitmap brzinaBit3 = new Bitmap(brzinaSlika3);
            pikseliBrzina3 = p.ubaciUMatricu(pikseliBrzina3, brzinaBit3);

            double[] stopNiz = new double[stopBit.Height * stopBit.Width];
            double[] stopNiz2 = new double[stopBit2.Height * stopBit2.Width];
            double[] stopNiz3 = new double[stopBit3.Height * stopBit3.Width];
            double[] znakopNiz = new double [znakopBit.Height * znakopBit.Width];
            double[] znakopNiz2 = new double[znakopBit2.Height * znakopBit2.Width];
            double[] prvenstvoNiz = new double [prvenstvoBit.Height * prvenstvoBit.Width];
            double[] prvenstvoNiz2 = new double[prvenstvoBit2.Height * prvenstvoBit2.Width];
            double[] prvenstvoNiz3 = new double[prvenstvoBit3.Height * prvenstvoBit3.Width];
            double[] brzinaNiz = new double [brzinaBit.Height * brzinaBit.Width];
            double[] brzinaNiz2 = new double[brzinaBit2.Height * brzinaBit2.Width];
            double[] brzinaNiz3 = new double[brzinaBit3.Height * brzinaBit3.Width];

            int uk = 0;
            for(int v = 0 ; v < stopBit.Height; v++)
            {
                for(int k = 0; k < stopBit.Width; k++)
                {
                    stopNiz[uk] = pikseliStop[v, k];
                    uk++;
                }
                //uk++;
            }

            uk = 0;
            for (int v = 0; v < stopBit2.Height; v++)
            {
                for (int k = 0; k < stopBit2.Width; k++)
                {
                    stopNiz2[uk] = pikseliStop2[v, k];
                    uk++;
                }
                //uk++;
            }

            uk = 0;
            for (int v = 0; v < stopBit3.Height; v++)
            {
                for (int k = 0; k < stopBit3.Width; k++)
                {
                    stopNiz3[uk] = pikseliStop3[v, k];
                    uk++;
                }
                //uk++;
            }

            uk = 0;
            for (int v = 0; v < znakopBit.Height; v++)
            {
                for (int k = 0; k < znakopBit.Width; k++)
                {
                    znakopNiz[uk] = pikseliZnakop[v, k];
                    uk++;
                }
                //uk++;
            }

            uk = 0;
            for (int v = 0; v < znakopBit2.Height; v++)
            {
                for (int k = 0; k < znakopBit2.Width; k++)
                {
                    znakopNiz2[uk] = pikseliZnakop2[v, k];
                    uk++;
                }
                //uk++;
            }

            uk = 0;
            for (int v = 0; v < prvenstvoBit.Height; v++)
            {
                for (int k = 0; k < prvenstvoBit.Width; k++)
                {
                    prvenstvoNiz[uk] = pikseliPrvenstvo[v, k];
                    uk++;
                }
                //uk++;
            }

            uk = 0;
            for (int v = 0; v < prvenstvoBit2.Height; v++)
            {
                for (int k = 0; k < prvenstvoBit2.Width; k++)
                {
                    prvenstvoNiz2[uk] = pikseliPrvenstvo2[v, k];
                    uk++;
                }
                //uk++;
            }

            uk = 0;
            for (int v = 0; v < prvenstvoBit3.Height; v++)
            {
                for (int k = 0; k < prvenstvoBit3.Width; k++)
                {
                    prvenstvoNiz3[uk] = pikseliPrvenstvo3[v, k];
                    uk++;
                }
                //uk++;
            }

            uk = 0;
            for (int v = 0; v < brzinaBit.Height; v++)
            {
                for (int k = 0; k < brzinaBit.Width; k++)
                {
                    brzinaNiz[uk] = pikseliBrzina[v, k];
                    uk++;
                }
                //uk++;
            }

            uk = 0;
            for (int v = 0; v < brzinaBit2.Height; v++)
            {
                for (int k = 0; k < brzinaBit2.Width; k++)
                {
                    brzinaNiz2[uk] = pikseliBrzina2[v, k];
                    uk++;
                }
                //uk++;
            }
            uk = 0;
            for (int v = 0; v < brzinaBit3.Height; v++)
            {
                for (int k = 0; k < brzinaBit3.Width; k++)
                {
                    brzinaNiz3[uk] = pikseliBrzina3[v, k];
                    uk++;
                }
                //uk++;
            }


            double[][]znaciInput =
            {
            stopNiz,
            stopNiz2,
            stopNiz3,
            znakopNiz,
            znakopNiz2,
            prvenstvoNiz,
            prvenstvoNiz2,
            prvenstvoNiz3,
            brzinaNiz,
            brzinaNiz2,
            brzinaNiz3
            };

            double[][] znaciIdeal =
            {
            new[] {1.0, 0, 0, 0},
            new[] {1.0, 0, 0, 0},
            new[] {1.0, 0, 0, 0},
            new[] {0, 1.0, 0, 0},
            new[] {0, 1.0, 0, 0},
            new[] {0, 0, 1.0, 0},
            new[] {0, 0, 1.0, 0},
            new[] {0, 0, 1.0, 0},
            new[] {0, 0, 0, 1.0},
            new[] {0, 0, 0, 1.0},
            new[] {0, 0, 0, 1.0}
            };

        //DUSANOV DEO
        //SMANJI SLIKE I MATRICE

        // create a neural network, without using a factory
        var network = new BasicNetwork();
            //network.AddLayer(new BasicLayer(null, true, 2));
            network.AddLayer(new BasicLayer(null, true,25*25));
            //network.AddLayer(new BasicLayer(new ActivationSigmoid(), true,1000));
            network.AddLayer(new BasicLayer(new ActivationSigmoid(), true,500));
            network.AddLayer(new BasicLayer(new ActivationSigmoid(), true, 400));
         //   network.AddLayer(new BasicLayer(new ActivationSigmoid(), true, 400));
         //   network.AddLayer(new BasicLayer(new ActivationSigmoid(), true,400));
            network.AddLayer(new BasicLayer(new ActivationSigmoid(), true, 200));
           network.AddLayer(new BasicLayer(new ActivationSigmoid(), true, 100));
         //   network.AddLayer(new BasicLayer(new ActivationSigmoid(), true, 100));
        //    network.AddLayer(new BasicLayer(new ActivationSigmoid(), true, 100));
       //     network.AddLayer(new BasicLayer(new ActivationSigmoid(), true, 100));
           network.AddLayer(new BasicLayer(new ActivationSigmoid(), true, 50));
            //network.AddLayer(new BasicLayer(new ActivationSigmoid(), true, 25));
            network.AddLayer(new BasicLayer(new ActivationSigmoid(), false, 4));
            network.Structure.FinalizeStructure();
            network.Reset();

            // create training data
            IMLDataSet trainingSet = new BasicMLDataSet(znaciInput, znaciIdeal);

            // train the neural network
            IMLTrain train = new ResilientPropagation(network, trainingSet);

            int epoch = 1;

            do
            {
                train.Iteration();
                Console.WriteLine(@"Epoch #" + epoch + @" Error:" + train.Error);
                epoch++;
            } while (train.Error > 0.001);

            train.FinishTraining();

            // test the neural network
            Console.WriteLine(@"Neural Network Results:");

            /////////////////////////////////////////////////
            //TU STAVI NOVU MATRICU
            //DUSAN DODAO

            //za stop znak
            Image stopSlikaTest = Image.FromFile(@"...\stop_test.jpg");
            Bitmap stopBitTest = new Bitmap(stopSlikaTest);
            pikseliStopTest = p.ubaciUMatricu(pikseliStopTest, stopBitTest);

            Thread.Sleep(500);

            //za znak opasnosti
            Image znakopSlikaTest = Image.FromFile(@"...\znak-opasnosti_test.png");
            Bitmap znakopBitTest = new Bitmap(znakopSlikaTest);
            pikseliZnakopTest = p.ubaciUMatricu(pikseliZnakopTest, znakopBitTest);

            Thread.Sleep(500);

            //za znak prvenstva
            Image prvenstvoSlikaTest = Image.FromFile(@"...\prvenstvo_test.png");
            Bitmap prvenstvoBitTest = new Bitmap(prvenstvoSlikaTest);
            pikseliPrvenstvoTest = p.ubaciUMatricu(pikseliPrvenstvoTest, prvenstvoBitTest);

            Thread.Sleep(500);

            //za znak ogranicenja brzine
            Image brzinaSlikaTest = Image.FromFile(@"...\ogranicenje-brzine_test.jpg");
            Bitmap brzinaBitTest = new Bitmap(brzinaSlikaTest);
            pikseliBrzinaTest = p.ubaciUMatricu(pikseliBrzinaTest, brzinaBitTest);

            double[] stopNizTest = new double[stopBitTest.Height * stopBitTest.Width];
            double[] znakopNizTest = new double[znakopBitTest.Height * znakopBitTest.Width];
            double[] prvenstvoNizTest = new double[prvenstvoBitTest.Height * prvenstvoBitTest.Width];
            double[] brzinaNizTest = new double[brzinaBitTest.Height * brzinaBitTest.Width];


            int uk2 = 0;
            for (int v = 0; v < stopBitTest.Height; v++)
            {
                for (int k = 0; k < stopBitTest.Width; k++)
                {
                    stopNizTest[uk2] = pikseliStopTest[v, k];
                    uk2++;
                }
                //uk++;
            }

            uk2 = 0;
            for (int v = 0; v < znakopBitTest.Height; v++)
            {
                for (int k = 0; k < znakopBitTest.Width; k++)
                {
                    znakopNizTest[uk2] = pikseliZnakopTest[v, k];
                    uk2++;
                }
                //uk++;
            }

            uk2 = 0;
            for (int v = 0; v < prvenstvoBitTest.Height; v++)
            {
                for (int k = 0; k < prvenstvoBitTest.Width; k++)
                {
                    prvenstvoNizTest[uk2] = pikseliPrvenstvoTest[v, k];
                    uk2++;
                }
                //uk++;
            }

            uk2 = 0;
            for (int v = 0; v < brzinaBitTest.Height; v++)
            {
                for (int k = 0; k < brzinaBitTest.Width; k++)
                {
                    brzinaNizTest[uk2] = pikseliBrzinaTest[v, k];
                    uk2++;
                }
                //uk++;
            }

            double[][] znaciInput2 =
            {
            stopNizTest,
            znakopNizTest,
            prvenstvoNizTest,
            brzinaNizTest
            };

            double[][] znaciIdeal2 =
            {
            new[] {1.0, 0, 0, 0},
            new[] {0, 1.0, 0, 0},
            new[] {0, 0, 1.0, 0},
            new[] {0, 0, 0, 1.0}
            };

            IMLDataSet trainingSet2 = new BasicMLDataSet(znaciInput2, znaciIdeal2);
            //DUSAN DODAO
            /////////////////////////////////////////////////
            int znak = 0;
            foreach (IMLDataPair pair in trainingSet2)
            {


            
                IMLData output = network.Compute(pair.Input);
                //Console.WriteLine(pair.Input[0] + @"," + pair.Input[1]
                //                  + @", actual=" + output[0] + @",ideal=" + pair.Ideal[0] );
                if (znak == 0)
                {
                    Console.WriteLine("test za znak stop: " +
                                       @" actual=" + output[0] + "  " + output[1] + "  " + output[2] + "  " + output[3] 
                                       + @",ideal=" + pair.Ideal[0] + "  " + pair.Ideal[1] + "  " + pair.Ideal[2] + "  " + pair.Ideal[3]);
                }
                else if(znak == 1)
                {
                    Console.WriteLine("test za znak opasnosti: " +
                                       @" actual=" + output[0] + "  " + output[1] + "  " + output[2] + "  " + output[3]
                                       + @",ideal=" + pair.Ideal[0] + "  " + pair.Ideal[1] + "  " + pair.Ideal[2] + "  " + pair.Ideal[3]);
                }
                else if(znak == 2)
                {
                    Console.WriteLine("test za znak prvenstva: " +
                                       @" actual=" + output[0] + "  " + output[1] + "  " + output[2] + "  " + output[3]
                                       + @",ideal=" + pair.Ideal[0] + "  " + pair.Ideal[1] + "  " + pair.Ideal[2] + "  " + pair.Ideal[3]);
                }
                else if (znak == 3)
                {
                    Console.WriteLine("test za znak brzine: " +
                                       @" actual=" + output[0] + "  " + output[1] + "  " + output[2] + "  " + output[3]
                                       + @",ideal=" + pair.Ideal[0] + "  " + pair.Ideal[1] + "  " + pair.Ideal[2] + "  " + pair.Ideal[3]);
                }
                znak++;

            }
            Console.ReadLine();
            EncogFramework.Instance.Shutdown();
        }

        //DUSANOVA FUNKCIJA
        public double[,] ubaciUMatricu(double[,] m, Bitmap bit)
        {

            int sirina = bit.Width;
            int visina = bit.Height;

            m = new double[visina, sirina];

            //obrada slike u crno belu

            Bitmap bit2 = new Bitmap(sirina, visina);

            /*for (int v = 0; v < visina; v++)
            {
                for (int k = 0; k < sirina; k++)
                {
                    Color px = bit.GetPixel(v, k);
                    Color px2 = bit2.GetPixel(v, k);

                    if ((px.R >= 200 && px.R <= 255) && (px.G >= 200 && px.G <= 255) && (px.B >= 200 && px.B <= 255))
                    {
                        bit2.SetPixel(v, k, Color.White);
                    }
                    else
                    {
                        bit2.SetPixel(v, k, Color.Black);
                    }

                }
            }
            Console.WriteLine("okrecena slika");*/

           for (int v = 0; v < visina; v++)
            {
                for (int k = 0; k < sirina; k++)
                {
                    Color px = bit.GetPixel(v, k);
                    //Color px = bit2.GetPixel(v, k);
                    if ((px.R < 70) && (px.G < 70) && (px.B < 70))
                    {
                        m[v, k] = 1.0;
                        //Console.WriteLine("upisao 1");
                    }
                    else
                    {
                        m[v, k] = 0;
                       // Console.WriteLine("upisao 0");
                    }
                }
            }

            Console.WriteLine("GOTOV SA OBRADOM SLIKE");


            return m;
        }
    }
}
