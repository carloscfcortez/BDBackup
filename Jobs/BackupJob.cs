using BDBak.Helpers;
using Quartz;
using Quartz.Impl;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Collections.Specialized;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BDBak.Jobs
{
    public class BackupJob
    {
        private static IScheduler scheduler;

        public static void StartdJobs(string _directory, string _dataBase, string[] intervalos)
        {
            RunProgramRunExample(_directory, _dataBase, intervalos).GetAwaiter().GetResult();
        }


        public static void StopJobs()
        {
            scheduler.Shutdown();

            scheduler.Clear();
        }

        private static async Task RunProgramRunExample(string _directory, string _dataBase, string[] intervalos)
        {
            try
            {
                // Grab the Scheduler instance from the Factory
                NameValueCollection props = new NameValueCollection
                {
                    { "quartz.serializer.type", "binary" }
                };
                StdSchedulerFactory factory = new StdSchedulerFactory(props);
                scheduler = await factory.GetScheduler();

                // and start it off
                await scheduler.Start();

                // define the job and tie it to our HelloJob class
                IJobDetail job = JobBuilder.Create<BackupDataBaseJob>()
                    .WithIdentity($"JOB_BAKCUP_{_dataBase}", $"GROUP_JOB_BACKUP_{_dataBase}")
                    .UsingJobData("directory", _directory)
                    .UsingJobData("database", _dataBase)
                    .Build();


                IList<ITrigger> triggers = new List<ITrigger>();
                foreach (var item in intervalos)
                {
                    string[] splitTime = item.Split(':');

                    TimeSpan timeSpan = new TimeSpan(Convert.ToInt32(splitTime[0]), Convert.ToInt32(splitTime[1]), 0);
                    // Trigger the job to run now, and then repeat every 10 seconds
                    ITrigger trigger = TriggerBuilder.Create()
                        .WithIdentity($"TRIGGER_BAKCUP_{_dataBase}_INTERVAL_{item}", $"GROUP_{_dataBase}_TRIGGER_BACKUP_INTERVAL")
                        .StartNow()
                        .WithCronSchedule($"0 {timeSpan.Minutes} {timeSpan.Hours} ? * *")
                        .Build();

                    triggers.Add(trigger);

                    // Tell quartz to schedule the job using our trigger



                    // some sleep to show what's happening
                    //await Task.Delay(TimeSpan.FromSeconds(60));

                    // and last shut down the scheduler when you are ready to close your program
                    //await scheduler.Shutdown();
                }
                IReadOnlyCollection<ITrigger> listOfTriggers = new ReadOnlyCollection<ITrigger>(triggers);
                await scheduler.ScheduleJob(job, listOfTriggers, true);



            }
            catch (SchedulerException se)
            {
                Console.WriteLine(se);
            }
        }
    }


    public class BackupDataBaseJob : IJob
    {
        public async Task Execute(IJobExecutionContext context)
        {
            var _directory = context.JobDetail.JobDataMap.GetString("directory");
            var _database = context.JobDetail.JobDataMap.GetString("database");
            await DatabaseHelper.GerarBak(_directory, _database);
            //await Console.Out.WriteLineAsync("Greetings from HelloJob!");
        }
    }
}
