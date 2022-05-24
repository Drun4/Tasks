using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Laboratorium_8_Tasks
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public int primeChecker(int fromNum, int toNum)
        {
            int amountOfPrime = 0;
            for (int i = fromNum; i < toNum; i++)
            {
                int[] array = new int[i];
                for (int j = 0; j < i; j++)
                {
                    array[j] = j + 1;
                }

                int devisorsAmount = 0;
                for (int k = 0; k < array.Length; k++)
                {
                    if (i % array[k] == 0)
                    {
                        devisorsAmount++;
                    }
                }

                if (devisorsAmount == 2)
                {
                    amountOfPrime++;
                }
            }
            return amountOfPrime;
        }

        private void btn_Clear_Click(object sender, EventArgs e)
        {
            txt_From.Text = "";
            txt_To.Text = "";
            txt_Answer.Text = "";
            txt_NumOfThreads.Text = "";
            rtxt_ThreadStreamer.Text = "";
        }

        private void btn_Start_Click(object sender, EventArgs e)
        {
            int fromNumber = Convert.ToInt32(txt_From.Text);
            int toNumber = Convert.ToInt32(txt_To.Text);
            Task<int> task = new Task<int>(() => primeChecker(fromNumber, toNumber));
            rtxt_ThreadStreamer.Text = "Task Loading";
            rtxt_ThreadStreamer.ForeColor = Color.Red;
            task.Start();
            task.Wait();
            rtxt_ThreadStreamer.Text = "Task Completed";
            rtxt_ThreadStreamer.ForeColor = Color.Green;
            txt_Answer.Text = task.Result.ToString();
        }

        private void btn_StartMany_Click(object sender, EventArgs e)
        {
            rtxt_ThreadStreamer.ForeColor = Color.Black;
            Stopwatch watch = new Stopwatch();

            rtxt_ThreadStreamer.Text = "";

            int numberOfThreads = Convert.ToInt32(txt_NumOfThreads.Text);
            int fromNumber = Convert.ToInt32(txt_From.Text);
            int toNumber = Convert.ToInt32(txt_To.Text);
            int Step = (toNumber - fromNumber) / numberOfThreads;

            int primeNumber = 0;

            fromNumber = 0;
            toNumber = Step;

            var tasks = new List<Task<int>>();

            watch.Start();
            for (int i = 0; i < numberOfThreads; i++)
            {
                tasks.Add(Task.Run(() => 
                {
                    return primeChecker(fromNumber, toNumber);
                }));
                
                fromNumber += Step;
                toNumber += Step;
            }
            foreach (var task in tasks)
            {
                if (task.IsCompleted)
                {
                    rtxt_ThreadStreamer.Text += task.Status + " - " + task.Result + "\n";
                    primeNumber += task.Result;
                    txt_Answer.Text = primeNumber.ToString();
                }
                else
                {
                    task.Wait();
                    rtxt_ThreadStreamer.Text += task.Status + " - " + task.Result + "\n";
                    primeNumber += task.Result;
                    txt_Answer.Text = primeNumber.ToString();
                }
            }
            watch.Stop();

            TimeSpan ts = watch.Elapsed;
            rtxt_ThreadStreamer.Text += $"\n\nTime: {ts}";
        }
    }
}
