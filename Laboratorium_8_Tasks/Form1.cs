using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
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
            for (int i = fromNum; i <= toNum; i++)
            {
                bool isPrime = true;
                for (int k = 2; k < i; k++)
                {
                    if (i % k == 0)
                    {
                        isPrime = false;
                        break;
                    }
                }

                if (isPrime && i > 1)
                {
                    amountOfPrime++;
                }
            }
            return amountOfPrime;
        }

        static bool ifPrime(int num)
        {
            if(num <= 1)
            {
                return false;
            }
            bool result = true;
            for (int k = 2; k < num; k++)
            {
                if (num % k == 0)
                {
                    result = false;
                    break;
                }
            }
            return result;
        }

        public int secondPrimeChecker(int fromNum, int toNum)
        {
            int amountOfPrime = 0;
            for (int i = fromNum; i < toNum; i++)
            {
                var task = Task.Factory.StartNew(() => ifPrime(i), TaskCreationOptions.AttachedToParent);
                if (task.Result)
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
            prgBr_ThreadProcess.Value = 0;
            lbl_Process.Text = $"Processing 0%";
        }

        private void btn_Start_Click(object sender, EventArgs e)
        {
            int fromNumber = Convert.ToInt32(txt_From.Text);
            int toNumber = Convert.ToInt32(txt_To.Text);
            Task<int> task = new Task<int>(() => secondPrimeChecker(fromNumber, toNumber));
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
            rtxt_ThreadStreamer.Text = "";
            prgBr_ThreadProcess.Value = 0;

            Stopwatch watch = new Stopwatch();

            var tasks = new List<Task<int>>();
            int numberOfThreads = Convert.ToInt32(txt_NumOfThreads.Text);
            int fromNumber = Convert.ToInt32(txt_From.Text);
            int toNumber = Convert.ToInt32(txt_To.Text);
            int Step = (toNumber - fromNumber) / numberOfThreads;
            int primeNumber = 0;

            fromNumber = 0;
            toNumber = Step;

            watch.Start();
            for (int i = 0; i < numberOfThreads; i++)
            {
                tasks.Add(Task.Run(() => 
                {
                    return primeChecker(fromNumber, fromNumber + Step);
                }));
                fromNumber += Step + 1;
            }
            int stepNum = 0;
            foreach (var task in tasks)
            {
                stepNum++;
                if (!task.IsCompleted)
                {
                    task.Wait();
                }
                rtxt_ThreadStreamer.Text += task.Status + " - " + task.Result + "\n";
                primeNumber += task.Result;
                txt_Answer.Text = primeNumber.ToString();
                prgBr_ThreadProcess.Value = (int)((double)stepNum / numberOfThreads * 100);
                lbl_Process.Text = $"Processing {prgBr_ThreadProcess.Value}%";
            }
            watch.Stop();

            TimeSpan ts = watch.Elapsed;
            rtxt_ThreadStreamer.Text += $"\nTime: {ts}";
        }
    }
}
