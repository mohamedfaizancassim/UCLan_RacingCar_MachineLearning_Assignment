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

namespace genetic_algorithm
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            popBinList();
        }

        List<string> particles = new List<string>(); //Holds particles
        List<string> five_bin = new List<string>(); // Stores 5 potential settings
        List<string> three_bin = new List<string>(); //Stores 3 potential settings

        List<int> fittness_grading = new List<int>(); //Stores Grade Values
        List<string> particle_children = new List<string>();// Stores child particles 
        
        
        List<KeyValuePair<int, string>> particle_grade = new List<KeyValuePair<int, string>>(); //Stores particles with respective grade 
        List<KeyValuePair<int, string>> particle_grade_final = new List<KeyValuePair<int, string>>();

        Random random_1 = new Random(); //New Random Generator
        

        FitFunc fittness = new FitFunc();

                 
        //Key-Value Pair sorting methodology 
        static int compareValue(KeyValuePair<int,string>a, KeyValuePair<int,string>b)
        {
            return a.Key.CompareTo(b.Key);
        }

        //Populating Binary Lists
        public void popBinList()
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



       public void spawnParticles( int noOfParticles)
        {
            for(int i=0; i<=noOfParticles;i++) //Spawns one particle
            {
                string genParticle = ""; //Stores a single particle

                genParticle = five_bin[random_1.Next(0, 5)]; //External Temperature
                genParticle = genParticle + five_bin[random_1.Next(0,5 )]; //Internal Temperature 
                genParticle = genParticle + five_bin[random_1.Next(0, 5)]; //Cylnder Preasure
                genParticle = genParticle + five_bin[random_1.Next(0, 5)]; // Value Opening Preasure
                genParticle = genParticle + five_bin[random_1.Next(0, 5)]; //Load torque
                genParticle = genParticle + five_bin[random_1.Next(0, 5)]; // NOx emissions
                genParticle = genParticle + five_bin[random_1.Next(0, 5)]; //CO emmisions
                genParticle = genParticle + five_bin[random_1.Next(0, 5)]; // HC Emissions
                genParticle = genParticle + five_bin[random_1.Next(0, 5)]; //PM emmisions

                genParticle = genParticle + random_1.Next(0, 2); // UCLan ETD
                genParticle = genParticle + random_1.Next(0, 2); //UCLan FFD
                genParticle = genParticle + random_1.Next(0, 2); //UCLan EL
                genParticle = genParticle + random_1.Next(0, 2); //UCLan BMS
                genParticle = genParticle + random_1.Next(0, 2); //UCLan AFDM

                genParticle = genParticle + three_bin[random_1.Next(0, 3)]; //Fuel Injection Timing

                particles.Add(genParticle); //Adds newly spawn particle to list 
            }

            
        }

        public void fittnessCalculation()
        {

            // Grading all particles 
            for(int a=0; a<particles.Count;a++)
            {
                fittness_grading.Add(fittness.evalFunc(particles[a]));
                                                
            }

            //Grouping particles into Key-Value Pair
            for(int b=0;b<fittness_grading.Count;b++)
            {
                particle_grade.Add(new KeyValuePair<int, string>(fittness_grading[b], particles[b]));
            }

            // Sorting all particles 
            particle_grade.Sort(compareValue);
        }

        //Mutation Operation

        public string mutate(string particle)
        {
            //Spliting Constituant Vars
            string mu_var1 = particle.Substring(0, 5);
            string mu_var2 = particle.Substring(5, 5);
            string mu_var3 = particle.Substring(10, 5);
            string mu_var4 = particle.Substring(15, 5);
            string mu_var5 = particle.Substring(20, 5);
            string mu_var6 = particle.Substring(25, 5);
            string mu_var7 = particle.Substring(30, 5);
            string mu_var8 = particle.Substring(35, 5);
            string mu_var9 = particle.Substring(40, 5);
            string mu_var10 = particle.Substring(45, 1);
            string mu_var11 = particle.Substring(46, 1);
            string mu_var12 = particle.Substring(47, 1);
            string mu_var13 = particle.Substring(48, 1);
            string mu_var14 = particle.Substring(49, 1);
            string mu_var15 = particle.Substring(50, 3);

            //Mutation Takes Place Here
            int mu_loc=random_1.Next(1, 16);

            switch(mu_loc)
            {
                case 1:
                    mu_var1 = five_bin[random_1.Next(0, 5)];
                    break;
                case 2:
                    mu_var2 = five_bin[random_1.Next(0, 5)];
                    break;
                case 3:
                    mu_var3 = five_bin[random_1.Next(0, 5)];
                    break;
                case 4:
                    mu_var4 = five_bin[random_1.Next(0, 5)];
                    break;
                case 5:
                    mu_var5 = five_bin[random_1.Next(0, 5)];
                    break;
                case 6:
                    mu_var6 = five_bin[random_1.Next(0, 5)];
                    break;
                case 7:
                    mu_var7 = five_bin[random_1.Next(0, 5)];
                    break;
                case 8:
                    mu_var8 = five_bin[random_1.Next(0, 5)];
                    break;
                case 9:
                    mu_var9 = five_bin[random_1.Next(0, 5)];
                    break;
                case 10:
                    mu_var10 = Convert.ToString(random_1.Next(0, 2));
                    break;
                case 11:
                    mu_var11 = Convert.ToString(random_1.Next(0, 2));
                    break;
                case 12:
                    mu_var12 = Convert.ToString(random_1.Next(0, 2));
                    break;
                case 13:
                    mu_var13 = Convert.ToString(random_1.Next(0, 2));
                    break;
                case 14:
                    mu_var14 = Convert.ToString(random_1.Next(0, 2));
                    break;
                case 15:
                    mu_var15 = three_bin[random_1.Next(0, 3)];
                    break;
            }

            return mu_var1 + mu_var2 + mu_var3 + mu_var4 + mu_var5 + mu_var6 + mu_var7 + mu_var8 + mu_var9 + mu_var10 + mu_var11 + mu_var12 + mu_var13 + mu_var14 + mu_var15;


        }

        
       
        //CREATING NEW GENERATION   
        public void createNewGen() 
        {
            int numOfVal_1 = Convert.ToInt16(numNumberOfParticles.Value);
            int popToKill = 1 / 2 * numOfVal_1; //Percentage of Population to Kill
            int popToMutate =Convert.ToInt16( 0.1 * numOfVal_1);
            int countMu = 0; //Keeps track of number of mutations
          

            for(int kill=0; kill<=popToKill;kill++)
            {
                //Selecting Two Parents 
                string particle_1 = particle_grade[random_1.Next(popToKill,particle_grade.Count)].Value;
                string particle_2= particle_grade[random_1.Next(popToKill, particle_grade.Count)].Value;

                //Pairing Takes Place Here 
                string part_a = particle_1.Substring(0,25);
                string part_b = particle_2.Substring(25);

                

                particle_children.Add(part_a + part_b);
            }

            particles.Clear(); //Clears Particles

            //Adding Children to Particles List 
            for(int clne=0;clne<particle_children.Count;clne++)
            {
                particles.Add(particle_children[clne]);
            }

            //Adding Good Parents to Particles List 
            for(int clne2=popToKill;clne2<particle_grade.Count;clne2++)
            {
                // particles.Add(particle_grade[clne2].Value);
                int muStatus = random_1.Next(2);

                switch (muStatus)
                {
                    case 1:
                        //Break if muPopulation exceeded
                        if(countMu>popToMutate)
                        {
                            particles.Add(mutate(particle_grade[clne2].Value));
                            break;
                        }
                        //Mutation
                        particles.Add(mutate(particle_grade[clne2].Value));
                        countMu++;
                        break;
                    //Create new mutations list
                    //Update Count Variable
                    case 0:
                        //No Mutation
                        particles.Add(particle_grade[clne2].Value);
                        break;
                }

                //If count> 10% , break. 


            }

        }

        //Decoding Elements 
        public string decodeElements(string element)
        {
            switch(element)
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

        private void cmdSpawn_Click(object sender, EventArgs e)
        {
            spawnParticles(Convert.ToInt16(numNumberOfParticles.Value));
        }

        private void cmdPopulateTxt_Click(object sender, EventArgs e)
        {
            txtParticleView.Text = "";
            for(int n=0;n<particles.Count;n++)
            {
                txtParticleView.Text = txtParticleView.Text + particles[n] + "\r\n";
            }
        }

        private void cmdEvaluvate_Click(object sender, EventArgs e)
        {
            int numGen = Convert.ToInt16(numGenerations.Value);

            for(int gen=0;gen<=numGen;gen++)
            {
                fittnessCalculation();
                createNewGen();

                fittness_grading.Clear();
                particle_children.Clear();
                particle_grade.Clear();
            }


            for(int b=0;b<particles.Count;b++)
            {
                fittness_grading.Add(fittness.evalFunc(particles[b]));
            }

            for (int m = 0;m < fittness_grading.Count; m++)
            {
                particle_grade_final.Add(new KeyValuePair<int, string>(fittness_grading[m], particles[m]));
            }

            particle_grade_final.Sort(compareValue);

            for (int w=0;w<particles.Count;w++)
            {
                txtGrading.Text = txtGrading.Text + particle_grade_final[w] + "\r\n";
            }


           

           
        }

        private void cmdVisualise_Click(object sender, EventArgs e)
        {
            string bestResult = particle_grade_final[particle_grade_final.Count-1].Value;

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

            txtDecodedResult.Text = "Ext Temperature: \t" + best_var1 + "\r\n";
            txtDecodedResult.Text = txtDecodedResult.Text + "Int Temperature: \t" + best_var2 + "\r\n";
            txtDecodedResult.Text = txtDecodedResult.Text + "Clynder Preassure: \t" + best_var3 + "\r\n";
            txtDecodedResult.Text = txtDecodedResult.Text + "Valve Opening Preasure: \t" + best_var4 + "\r\n";
            txtDecodedResult.Text = txtDecodedResult.Text + "Load Torque: \t" + best_var5 + "\r\n";
            txtDecodedResult.Text = txtDecodedResult.Text + "NOx Emissions: \t" + best_var6 + "\r\n";
            txtDecodedResult.Text = txtDecodedResult.Text + "CO Emissions: \t" + best_var7 + "\r\n";
            txtDecodedResult.Text = txtDecodedResult.Text + "HC Emissions: \t" + best_var8 + "\r\n";
            txtDecodedResult.Text = txtDecodedResult.Text + "PM Emissions: \t" + best_var9 + "\r\n";
            txtDecodedResult.Text = txtDecodedResult.Text + "UCLan Electronic Timing Device: \t" + best_var10 + "\r\n";
            txtDecodedResult.Text = txtDecodedResult.Text + "UCLan Fuel Flow Device: \t" + best_var11 + "\r\n";
            txtDecodedResult.Text = txtDecodedResult.Text + "UCLan Emissions Limiter: \t" + best_var12 + "\r\n";
            txtDecodedResult.Text = txtDecodedResult.Text + "UCLan Battery Management System: \t" + best_var13 + "\r\n";
            txtDecodedResult.Text = txtDecodedResult.Text + "UCLan Airflow Management Device: \t" + best_var14 + "\r\n";
            txtDecodedResult.Text = txtDecodedResult.Text + "Fuel Injection Timings: \t" + best_var15 + "\r\n";
        }

        private void cmdReset_Click(object sender, EventArgs e)
        {
            particles.Clear();
            fittness_grading.Clear();
            particle_children.Clear();
            particle_grade.Clear();
            particle_grade_final.Clear();

            txtDecodedResult.Text = string.Empty;
            txtGrading.Text = string.Empty;
            txtParticleView.Text = string.Empty;
        }
    }
}
