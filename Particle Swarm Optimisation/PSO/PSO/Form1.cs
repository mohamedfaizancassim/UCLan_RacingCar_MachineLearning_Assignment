using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using cwklib2017;
namespace PSO
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            popBinList();
        }
                
        List<KeyValuePair<int, string>> particle_fitness= new List<KeyValuePair<int, string>>(); //Particle& Fitness in recurrent loop

        List<int> pBest_fitness = new List<int>(); //Stores pBest Fitness Value
        List<string> pBest_particle = new List<string>(); //Stores pBest Particle

        List<int> current_fitness = new List<int>(); //Current Fitness
        List<string> current_particle = new List<string>(); //  current particle
        List<KeyValuePair<int, string>> particle_fitness_current = new List<KeyValuePair<int, string>>(); // Particle & Fitness at initialisation

        List<string> five_bin = new List<string>(); // Stores 5 potential settings
        List<string> three_bin = new List<string>(); //Stores 3 potential settings

        List<string> new_crnt_particle = new List<string>(); //Holds new current values
        List<KeyValuePair<int, string>> final_result = new List<KeyValuePair<int, string>>(); // Stores Final Result

        List<KeyValuePair<int, string>> gBest_particles = new List<KeyValuePair<int, string>>();

        int[] vel = new int[15]; //Stores Velocities

        

        string gBest = string.Empty; //Stores Global Best 
       

        Random random = new Random();
        FitFunc fitness = new FitFunc();

        
        static int compareKey(KeyValuePair<int, string> a, KeyValuePair<int, string> b) //Key-Value Pair sorting methodology
        {
            return a.Key.CompareTo(b.Key);
        }
              

        
        public void popBinList()//Populating Binary Lists
        {
            five_bin.Add("00001"); // Very High (1)
            five_bin.Add("00010"); // High (2)
            five_bin.Add("00100"); // Medium (4)
            five_bin.Add("01000"); // Low (8)
            five_bin.Add("10000"); // Very Low (16)

            three_bin.Add("001"); // High (1)
            three_bin.Add("010"); // Medium (2)
            three_bin.Add("100"); // Low (4)
        }


        
        public void spawnParticles()//Spawning new particles
        {
            int numParticle = Convert.ToInt16(numNumberOfParticles.Value);

            for (int i = 0; i < numParticle; i++)
            {
                string genParticle = string.Empty;
                genParticle = five_bin[random.Next(0, 5)]; //External Temperature
                genParticle = genParticle + five_bin[random.Next(0, 5)]; //Internal Temperature 
                genParticle = genParticle + five_bin[random.Next(0, 5)]; //Cylnder Preasure
                genParticle = genParticle + five_bin[random.Next(0, 5)]; // Value Opening Preasure
                genParticle = genParticle + five_bin[random.Next(0, 5)]; //Load torque
                genParticle = genParticle + five_bin[random.Next(0, 5)]; // NOx emissions
                genParticle = genParticle + five_bin[random.Next(0, 5)]; //CO emmisions
                genParticle = genParticle + five_bin[random.Next(0, 5)]; // HC Emissions
                genParticle = genParticle + five_bin[random.Next(0, 5)]; //PM emmisions

                genParticle = genParticle + random.Next(0, 2); // UCLan ETD
                genParticle = genParticle + random.Next(0, 2); //UCLan FFD
                genParticle = genParticle + random.Next(0, 2); //UCLan EL
                genParticle = genParticle + random.Next(0, 2); //UCLan BMS
                genParticle = genParticle + random.Next(0, 2); //UCLan AFDM

                genParticle = genParticle + three_bin[random.Next(0, 3)]; //Fuel Injection Timing

                particle_fitness.Add(new KeyValuePair<int, string>(fitness.evalFunc(genParticle), genParticle));
            }

            //Getting gBest Value 
            particle_fitness.Sort(compareKey);
            gBest = particle_fitness[particle_fitness.Count-1].Value;

            //Sotring pBest Fitness and pBest Particle
            for (int a = 0; a < particle_fitness.Count;a++)
            {
                pBest_fitness.Add(particle_fitness[a].Key);
                pBest_particle.Add(particle_fitness[a].Value);
            }
            
        }

        //Initialising first epoch (run once)
        public void init_epoch() //Initialising Epoch
        {
            for(int b= 0;b<particle_fitness.Count;b++)
            {
                current_fitness.Add(particle_fitness[b].Key);
                current_particle.Add(particle_fitness[b].Value);
            }
        }


        //Evaluvating Fitness of Current_particles & updating pBest and gBest
        public void runEpoch()//Epoch Loop
        {
            current_fitness.Clear();
            particle_fitness.Clear();
            for(int n=0;n<current_particle.Count;n++)
            {
                current_fitness.Add(fitness.evalFunc(current_particle[n])); //Calculating new fitness

                if(current_fitness[n]>pBest_fitness[n]) //Updating each particle's pBest
                {
                    pBest_particle[n] = current_particle[n]; // Pointer to new pBest-particle
                    pBest_fitness[n] = fitness.evalFunc(current_particle[n]); //Pointer to new pBest-fitness 
                }
                particle_fitness.Add(new KeyValuePair<int, string>(pBest_fitness[n], pBest_particle[n])); //Key-Value pair based current_particle. 
            }

            particle_fitness.Sort(compareKey); //Sorting particle_fitness based on fitness score

            gBest_particles.Add(new KeyValuePair<int, string>(particle_fitness[particle_fitness.Count - 1].Key, particle_fitness[particle_fitness.Count - 1].Value)); //Adds gBest Particle and Fitness

            gBest_particles.Sort(compareKey); // Sotring gBest based on best Fitness 

            gBest = gBest_particles[gBest_particles.Count-1].Value; //Updating gBest
        }


        

        public int stringToInt(string value) //Converting String to respective Int
        {
            switch (value)
            {
                case "00001":
                    return 5;
                case "00010":
                    return 4;
                case "00100":
                    return 3;
                case "01000":
                    return 2;
                case "10000":
                    return 1;
                case "001":
                    return 3;
                case "010":
                    return 2;
                case "100":
                    return 1;
                case "0":
                    return 0;
                case "1":
                    return 1;

            }
            return 0;
        }

        public string fiveIntToString(int value) //Converting 5-bit int to string
        {
            switch(value)
            {
                case 1:
                    return "10000";
                case 2:
                    return "01000";
                case 3:
                    return "00100";
                case 4:
                    return "00010";
                case 5:
                    return "00001";

            }
            return "error";
        }

        public string threeIntToString(int value) //Converting 3-bit int to string
        {
            switch(value)
            {
                case 1:
                    return "100";
                case 2:
                    return "010";
                case 3:
                    return "001";
            }

            return "error";
         
        }

        public string twoIntToString(int value) //Converting 2-bit int to string
        {
            switch(value)
            {
                case 0:
                    return "0";
                case 1:
                    return "1";
            }

            return "error";
        }
        // Vellocity Equation and new Current_values()
        public void current_new (double C1,double C2,int w, bool init) //Vellocity Calculation
        {

            for(int c=0;c<current_fitness.Count;c++)
            {
                string pBest_wh = pBest_particle[c];
                string current_wh = current_particle[c];
                string gBest_wh = gBest;
                

                if(init==true) //Setting Initial Velocity 
                {
                    vel[0] = w;
                    vel[1] = w;
                    vel[2] = w;
                    vel[3] = w;
                    vel[4] = w; 
                    vel[5] = w;
                    vel[6] = w;
                    vel[7] = w;
                    vel[8] = w;
                    vel[9] = w;
                    vel[10] = w;
                    vel[11] = w;
                    vel[12] = w;
                    vel[13] = w;
                    vel[14] = w;
                }
               

                //Spliting up pBest
                string pBest_var1 = pBest_wh.Substring(0, 5);
                string pBest_var2 = pBest_wh.Substring(5, 5);
                string pBest_var3 = pBest_wh.Substring(10, 5);
                string pBest_var4 = pBest_wh.Substring(15, 5);
                string pBest_var5 = pBest_wh.Substring(20, 5);
                string pBest_var6 = pBest_wh.Substring(25, 5);
                string pBest_var7 = pBest_wh.Substring(30, 5);
                string pBest_var8 = pBest_wh.Substring(35, 5);
                string pBest_var9 = pBest_wh.Substring(40, 5);
                string pBest_var10 = pBest_wh.Substring(45, 1);
                string pBest_var11 = pBest_wh.Substring(46, 1);
                string pBest_var12 = pBest_wh.Substring(47, 1);
                string pBest_var13 = pBest_wh.Substring(48, 1);
                string pBest_var14 = pBest_wh.Substring(49, 1);
                string pBest_var15 = pBest_wh.Substring(50, 3);

                //Spliting up current
                string current_var1 = current_wh.Substring(0, 5);
                string current_var2 = current_wh.Substring(5, 5);
                string current_var3 = current_wh.Substring(10, 5);
                string current_var4 = current_wh.Substring(15, 5);
                string current_var5 = current_wh.Substring(20, 5);
                string current_var6 = current_wh.Substring(25, 5);
                string current_var7 = current_wh.Substring(30, 5);
                string current_var8 = current_wh.Substring(35, 5);
                string current_var9 = current_wh.Substring(40, 5);
                string current_var10 = current_wh.Substring(45, 1);
                string current_var11 = current_wh.Substring(46, 1);
                string current_var12 = current_wh.Substring(47, 1);
                string current_var13 = current_wh.Substring(48, 1);
                string current_var14 = current_wh.Substring(49, 1);
                string current_var15 = current_wh.Substring(50, 3);

                //Spliting up gBest
                string gBest_var1 = gBest_wh.Substring(0, 5);
                string gBest_var2 = gBest_wh.Substring(5, 5);
                string gBest_var3 = gBest_wh.Substring(10, 5);
                string gBest_var4 = gBest_wh.Substring(15, 5);
                string gBest_var5 = gBest_wh.Substring(20, 5);
                string gBest_var6 = gBest_wh.Substring(25, 5);
                string gBest_var7 = gBest_wh.Substring(30, 5);
                string gBest_var8 = gBest_wh.Substring(35, 5);
                string gBest_var9 = gBest_wh.Substring(40, 5);
                string gBest_var10 = gBest_wh.Substring(45, 1);
                string gBest_var11 = gBest_wh.Substring(46, 1);
                string gBest_var12 = gBest_wh.Substring(47, 1);
                string gBest_var13 = gBest_wh.Substring(48, 1);
                string gBest_var14 = gBest_wh.Substring(49, 1);
                string gBest_var15 = gBest_wh.Substring(50, 3);

                //pBest -current
                int pBest_current_1 = stringToInt(pBest_var1) - stringToInt(current_var1);
                int pBest_current_2 = stringToInt(pBest_var2) - stringToInt(current_var2);
                int pBest_current_3 = stringToInt(pBest_var3) - stringToInt(current_var3);
                int pBest_current_4 = stringToInt(pBest_var4) - stringToInt(current_var4);
                int pBest_current_5 = stringToInt(pBest_var5) - stringToInt(current_var5);
                int pBest_current_6 = stringToInt(pBest_var6) - stringToInt(current_var6);
                int pBest_current_7 = stringToInt(pBest_var7) - stringToInt(current_var7);
                int pBest_current_8 = stringToInt(pBest_var8) - stringToInt(current_var8);
                int pBest_current_9 = stringToInt(pBest_var9) - stringToInt(current_var9);
                int pBest_current_10 = stringToInt(pBest_var10) - stringToInt(current_var10);
                int pBest_current_11 = stringToInt(pBest_var11) - stringToInt(current_var11);
                int pBest_current_12 = stringToInt(pBest_var12) - stringToInt(current_var12);
                int pBest_current_13 = stringToInt(pBest_var13) - stringToInt(current_var13);
                int pBest_current_14 = stringToInt(pBest_var14) - stringToInt(current_var14);
                int pBest_current_15 = stringToInt(pBest_var15) - stringToInt(current_var15);

                //gBest-current
                int gBest_current_1 = stringToInt(gBest_var1) - stringToInt(current_var1);
                int gBest_current_2 = stringToInt(gBest_var2) - stringToInt(current_var2);
                int gBest_current_3 = stringToInt(gBest_var3) - stringToInt(current_var3);
                int gBest_current_4 = stringToInt(gBest_var4) - stringToInt(current_var4);
                int gBest_current_5 = stringToInt(gBest_var5) - stringToInt(current_var5);
                int gBest_current_6 = stringToInt(gBest_var6) - stringToInt(current_var6);
                int gBest_current_7 = stringToInt(gBest_var7) - stringToInt(current_var7);
                int gBest_current_8 = stringToInt(gBest_var8) - stringToInt(current_var8);
                int gBest_current_9 = stringToInt(gBest_var9) - stringToInt(current_var9);
                int gBest_current_10 = stringToInt(gBest_var10) - stringToInt(current_var10);
                int gBest_current_11 = stringToInt(gBest_var11) - stringToInt(current_var11);
                int gBest_current_12 = stringToInt(gBest_var12) - stringToInt(current_var12);
                int gBest_current_13 = stringToInt(gBest_var13) - stringToInt(current_var13);
                int gBest_current_14 = stringToInt(gBest_var14) - stringToInt(current_var14);
                int gBest_current_15 = stringToInt(gBest_var15) - stringToInt(current_var15);


                //Calculating Velocity 
                //Five Array Operation
                int velocity_1 =Convert.ToInt16(Math.Round( vel[0] + (C1 * random.NextDouble() * pBest_current_1) + (C2 * random.NextDouble() * gBest_current_1), MidpointRounding.AwayFromZero));
                if(velocity_1+stringToInt(current_var1)>=5)
                {
                    velocity_1 = 5-stringToInt(current_var1);
                }
                if(velocity_1+stringToInt(current_var1)<=1)
                {
                    velocity_1 = 1 - stringToInt(current_var1);
                }

                int velocity_2 = Convert.ToInt16(Math.Round(vel[1]+ (C1 * random.NextDouble() * pBest_current_2) + (C2 * random.NextDouble() * gBest_current_2), MidpointRounding.AwayFromZero));
                if (velocity_2 + stringToInt(current_var2) >= 5)
                {
                    velocity_2 = 5 - stringToInt(current_var2);
                }
                if (velocity_2 + stringToInt(current_var2) <= 1)
                {
                    velocity_2 = 1 - stringToInt(current_var2);
                }

                int velocity_3 = Convert.ToInt16(Math.Round(vel[2] + (C1 * random.NextDouble() * pBest_current_3) + (C2 * random.NextDouble() * gBest_current_3), MidpointRounding.AwayFromZero));
                if (velocity_3 + stringToInt(current_var3) >= 5)
                {
                    velocity_3 = 5 - stringToInt(current_var3);
                }
                if (velocity_3 + stringToInt(current_var3) <= 1)
                {
                    velocity_3 = 1 - stringToInt(current_var3);
                }

                int velocity_4 = Convert.ToInt16(Math.Round(vel[3] + (C1 * random.NextDouble() * pBest_current_4) + (C2 * random.NextDouble() * gBest_current_4), MidpointRounding.AwayFromZero));
                if (velocity_4 + stringToInt(current_var4) >= 5)
                {
                    velocity_4 = 5 - stringToInt(current_var4);
                }
                if (velocity_4 + stringToInt(current_var4) <= 1)
                {
                    velocity_4 = 1 - stringToInt(current_var4);
                }

                int velocity_5 = Convert.ToInt16(Math.Round(vel[4] + (C1 * random.NextDouble() * pBest_current_5) + (C2 * random.NextDouble() * gBest_current_5), MidpointRounding.AwayFromZero));
                if (velocity_5 + stringToInt(current_var5) >= 5)
                {
                    velocity_5 = 5 - stringToInt(current_var5);
                }
                if (velocity_5 + stringToInt(current_var5) <= 1)
                {
                    velocity_5 = 1 - stringToInt(current_var5);
                }

                int velocity_6 = Convert.ToInt16(Math.Round(vel[5] + (C1 * random.NextDouble() * pBest_current_6) + (C2 * random.NextDouble() * gBest_current_6), MidpointRounding.AwayFromZero));
                if (velocity_6 + stringToInt(current_var6) >= 5)
                {
                    velocity_6 = 5 - stringToInt(current_var6);
                }
                if (velocity_6 + stringToInt(current_var6) <= 1)
                {
                    velocity_6 = 1 - stringToInt(current_var6);
                }

                int velocity_7 = Convert.ToInt16(Math.Round(vel[6] + (C1 * random.NextDouble() * pBest_current_7) + (C2 * random.NextDouble() * gBest_current_7), MidpointRounding.AwayFromZero));
                if (velocity_7 + stringToInt(current_var7) >= 5)
                {
                    velocity_7 = 5 - stringToInt(current_var7);
                }
                if (velocity_7 + stringToInt(current_var7) <= 1)
                {
                    velocity_7 = 1 - stringToInt(current_var7);
                }

                int velocity_8 = Convert.ToInt16(Math.Round(vel[7] + (C1 * random.NextDouble() * pBest_current_8) + (C2 * random.NextDouble() * gBest_current_8), MidpointRounding.AwayFromZero));
                if (velocity_8 + stringToInt(current_var8) >= 5)
                {
                    velocity_8 = 5 - stringToInt(current_var8);
                }
                if (velocity_8 + stringToInt(current_var8) <= 1)
                {
                    velocity_8 = 1 - stringToInt(current_var8);
                }

                int velocity_9 = Convert.ToInt16(Math.Round(vel[8] + (C1 * random.NextDouble() * pBest_current_9) + (C2 * random.NextDouble() * gBest_current_9), MidpointRounding.AwayFromZero));
                if (velocity_9 + stringToInt(current_var9) >= 5)
                {
                    velocity_9 = 5 - stringToInt(current_var9);
                }
                if (velocity_9 + stringToInt(current_var9) <= 1)
                {
                    velocity_9 = 1 - stringToInt(current_var9);
                }

                //Binary Array Operation
                int velocity_10 = Convert.ToInt16(Math.Round(vel[9] + (C1 * random.NextDouble() * pBest_current_10) + (C2 * random.NextDouble() * gBest_current_10)));
                int velocity_11 = Convert.ToInt16(Math.Round(vel[10] + (C1 * random.NextDouble() * pBest_current_10) + (C2 * random.NextDouble() * gBest_current_10)));
                int velocity_12 = Convert.ToInt16(Math.Round(vel[11] + (C1 * random.NextDouble() * pBest_current_10) + (C2 * random.NextDouble() * gBest_current_10)));
                int velocity_13 = Convert.ToInt16(Math.Round(vel[12] + (C1 * random.NextDouble() * pBest_current_10) + (C2 * random.NextDouble() * gBest_current_10)));
                int velocity_14 = Convert.ToInt16(Math.Round(vel[13] + (C1 * random.NextDouble() * pBest_current_10) + (C2 * random.NextDouble() * gBest_current_10)));

                //Trinary 
                int velocity_15 = Convert.ToInt16(Math.Round(vel[14] + (C1 * random.NextDouble() * pBest_current_15) + (C2 * random.NextDouble() * gBest_current_15), 0));
                if (velocity_15 + stringToInt(current_var15)>=3)
                {
                    velocity_15 = 3-stringToInt(current_var15);
                }
                if (velocity_15 + stringToInt(current_var15)<=1)
                {
                    velocity_15 = 1 - stringToInt(current_var15);
                }

                //Calculating new locations
                int current_new_1 = stringToInt(current_var1) + velocity_1;
                int current_new_2 = stringToInt(current_var2) + velocity_2;
                int current_new_3 = stringToInt(current_var3) + velocity_3;
                int current_new_4 = stringToInt(current_var4) + velocity_4;
                int current_new_5 = stringToInt(current_var5) + velocity_5;
                int current_new_6 = stringToInt(current_var6) + velocity_6;
                int current_new_7 = stringToInt(current_var7) + velocity_7;
                int current_new_8 = stringToInt(current_var8) + velocity_8;
                int current_new_9 = stringToInt(current_var9) + velocity_9;
                int current_new_10 = stringToInt(current_var10) + velocity_10;
                int current_new_11 = stringToInt(current_var11) + velocity_11;
                int current_new_12 = stringToInt(current_var12) + velocity_12;
                int current_new_13 = stringToInt(current_var13) + velocity_13;
                int current_new_14 = stringToInt(current_var14) + velocity_14;
                int current_new_15 = stringToInt(current_var15) + velocity_15;

                //Triming Binaries 
                if(current_new_10>=1)
                {
                    current_new_10 = 1;
                }
                if(current_new_10<=0)
                {
                    current_new_10 = 0;
                }

                if (current_new_11 >= 1)
                {
                    current_new_11 = 1;
                }
                if (current_new_11 <= 0)
                {
                    current_new_11 = 0;
                }

                if (current_new_12 >= 1)
                {
                    current_new_12 = 1;
                }
                if (current_new_12 <= 0)
                {
                    current_new_12 = 0;
                }

                if (current_new_13 >= 1)
                {
                    current_new_13 = 1;
                }
                if (current_new_13 <= 0)
                {
                    current_new_13 = 0;
                }

                if (current_new_14 >= 1)
                {
                    current_new_14 = 1;
                }
                if (current_new_14 <= 0)
                {
                    current_new_14 = 0;
                }
                //Storing Velocities in vel[] array
                vel[0] = velocity_1;
                vel[1] = velocity_2;
                vel[2] = velocity_3;
                vel[3] = velocity_4;
                vel[4] = velocity_5;
                vel[5] = velocity_6;
                vel[6] = velocity_7;
                vel[7] = velocity_8;
                vel[8] = velocity_9;
                vel[9] = velocity_10;
                vel[10] = velocity_11;
                vel[11] = velocity_12;
                vel[12] = velocity_13;
                vel[13] = velocity_14;
                vel[14] = velocity_15;

                //Disabling init
                init = false;

                //Re-assembling particle

                string particle_new = fiveIntToString(current_new_1) + fiveIntToString(current_new_2) + fiveIntToString(current_new_3) + fiveIntToString(current_new_4)  + fiveIntToString(current_new_5) + fiveIntToString(current_new_6) + fiveIntToString(current_new_7) + fiveIntToString(current_new_8) + fiveIntToString(current_new_9) ;
                particle_new = particle_new + twoIntToString(current_new_10) + twoIntToString(current_new_11) + twoIntToString(current_new_12) + twoIntToString(current_new_13) + twoIntToString(current_new_14);
                particle_new = particle_new + threeIntToString(current_new_15);

                new_crnt_particle.Add(particle_new);
            }

            current_particle.Clear(); //Clears Current Particles

            for(int pop_c=0;pop_c<new_crnt_particle.Count;pop_c++) // Re-populates Current Particle
            {
                current_particle.Add(new_crnt_particle[pop_c]);
            }

            new_crnt_particle.Clear();
        }

         
        public string decodeElements(string element)//Decoding Elements
        {
            switch (element)
            {
                case "00001":
                    return "Very High";
                case "00010":
                    return "High";
                case "00100":
                    return "Medium";
                case "01000":
                    return "Low";
                case "10000":
                    return "Very low";
                case "001":
                    return "High";
                case "010":
                    return "Medium";
                case "100":
                    return "Low";
                case "1":
                    return "Yes";
                case "0":
                    return "No";
            }
            return "Error";
        }


        //GUI COMPONENTS
        private void cmdSpawn_Click(object sender, EventArgs e)
        {
            spawnParticles(); 
            for (int org=0; org<particle_fitness.Count;org++)
            {
                txtOriginal.Text = txtOriginal.Text + particle_fitness[org].Value + "\r\n";
            }
        }

        private void cmdRunPSO_Click(object sender, EventArgs e)
        {
            int noOfEpochs = Convert.ToInt16(numNoOfEpochs.Value);
           
                     
            //Running Epoch
            init_epoch();
            runEpoch();
            current_new(Convert.ToDouble(numC1.Value), Convert.ToDouble(numC2.Value), Convert.ToInt16(numInertia.Value), true);
                        
            for(int numE=0;numE<noOfEpochs;numE++)
            {
                runEpoch();
                current_new(Convert.ToDouble(numC1.Value), Convert.ToDouble(numC2.Value), Convert.ToInt16(numInertia.Value), false);
                
            }

            //Shifting through results
            for (int fr = 0; fr < current_particle.Count; fr++)
            {
                final_result.Add(new KeyValuePair<int, string>(fitness.evalFunc(current_particle[fr]), current_particle[fr]));
            }
            final_result.Sort(compareKey);

            for ( int res=0; res<final_result.Count;res++)
            {
                txtResult.Text = txtResult.Text + final_result[res]+ "\r\n";
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void numNumberOfParticles_ValueChanged(object sender, EventArgs e)
        {

        }

        private void cmdReset_Click(object sender, EventArgs e)
        {
            //Clearing Lists
            pBest_fitness.Clear();
            pBest_particle.Clear();
            current_fitness.Clear();
            current_particle.Clear();
            particle_fitness_current.Clear();
            new_crnt_particle.Clear();
            final_result.Clear();
            gBest_particles.Clear();

            gBest = string.Empty;

            //Clearing Textboxes
            txtOriginal.Text = string.Empty;
            txtResult.Text = string.Empty;
            txtVisualise.Text = string.Empty;

        }

        private void cmdVisualise_Click(object sender, EventArgs e)
        {
            string bestResult = final_result[final_result.Count - 1].Value;

            //Spliting up Final Result
            string best_var1 = decodeElements(bestResult.Substring(0, 5));
            string best_var2 = decodeElements(bestResult.Substring(5, 5));
            string best_var3 = decodeElements(bestResult.Substring(10, 5));
            string best_var4 = decodeElements(bestResult.Substring(15, 5));
            string best_var5 = decodeElements(bestResult.Substring(20, 5));
            string best_var6 = decodeElements(bestResult.Substring(25, 5));
            string best_var7 = decodeElements(bestResult.Substring(30, 5));
            string best_var8 = decodeElements(bestResult.Substring(35, 5));
            string best_var9 = decodeElements(bestResult.Substring(40, 5));
            string best_var10 = decodeElements(bestResult.Substring(45, 1));
            string best_var11 = decodeElements(bestResult.Substring(46, 1));
            string best_var12 = decodeElements(bestResult.Substring(47, 1));
            string best_var13 = decodeElements(bestResult.Substring(48, 1));
            string best_var14 = decodeElements(bestResult.Substring(49, 1));
            string best_var15 = decodeElements(bestResult.Substring(50, 3));

            txtVisualise.Text = "Ext Temperature: \t" + best_var1 + "\r\n";
            txtVisualise.Text = txtVisualise.Text + "Int Temperature: \t" + best_var2 + "\r\n";
            txtVisualise.Text = txtVisualise.Text + "Clynder Preassure: \t" + best_var3 + "\r\n";
            txtVisualise.Text = txtVisualise.Text + "Valve Opening Preasure: \t" + best_var4 + "\r\n";
            txtVisualise.Text = txtVisualise.Text + "Load Torque: \t" + best_var5 + "\r\n";
            txtVisualise.Text = txtVisualise.Text + "NOx Emissions: \t" + best_var6 + "\r\n";
            txtVisualise.Text = txtVisualise.Text + "CO Emissions: \t" + best_var7 + "\r\n";
            txtVisualise.Text = txtVisualise.Text + "HC Emissions: \t" + best_var8 + "\r\n";
            txtVisualise.Text = txtVisualise.Text + "PM Emissions: \t" + best_var9 + "\r\n";
            txtVisualise.Text = txtVisualise.Text + "UCLan Electronic Timing Device: \t" + best_var10 + "\r\n";
            txtVisualise.Text = txtVisualise.Text + "UCLan Fuel Flow Device: \t" + best_var11 + "\r\n";
            txtVisualise.Text = txtVisualise.Text + "UCLan Emissions Limiter: \t" + best_var12 + "\r\n";
            txtVisualise.Text = txtVisualise.Text + "UCLan Battery Management System: \t" + best_var13 + "\r\n";
            txtVisualise.Text = txtVisualise.Text + "UCLan Airflow Management Device: \t" + best_var14 + "\r\n";
            txtVisualise.Text = txtVisualise.Text + "Fuel Injection Timings: \t" + best_var15 + "\r\n";
        }
    }
}

