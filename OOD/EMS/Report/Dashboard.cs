using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OOD.EMS.Management;
using OOD.EMS.Execution;
using OOD.EMS.Audit;
using OOD.EMS.Users;

namespace OOD.EMS.Report
{
    class Dashboard
    {
        private int generalGoals, executiveGoals, tasks;
        private int headManagers, executiveManagers, inspectors;
        
        private ExecutionProgram program;
        private int progress;

        private Metric metric;
        private MetricValue[] metricValues;

        public int GeneralGoals { get { return generalGoals; } }
        public int ExecutiveGoals { get { return executiveGoals; } }
        public int Tasks { get { return tasks; } }

        public int HeadManagers { get { return headManagers; } }
        public int ExecutiveManagers { get { return executiveManagers; } }
        public int Inspectors { get { return inspectors; } }

        public ExecutionProgram Program { get { return program; } }
        public int Progress { get { return progress; } }

        public Metric Metric { get { return metric; } }
        public MetricValue[] MetricValues { get { return metricValues; } }

        private void collectInfo()
        {
            this.generalGoals = GeneralGoalStorage.getInstance().all().Count;
            this.executiveGoals = ExecutiveGoalStorage.getInstance().all().Count;
            this.tasks = TaskStorage.getInstance().all().Count;

            var users = UserStorage.getInstance().all();
            headManagers =
                (from user in users
                 where user.ALevel is HeadManager
                 select user).Count();
            executiveManagers =
                (from user in users
                 where user.ALevel is Manager
                 select user).Count();
            inspectors =
                (from user in users
                 where user.ALevel is Inspector
                 select user).Count();


            this.progress = program.getProgress();

            var values =
                (from value in MetricValueStorage.getInstance().all()
                where value.pairMetric == this.metric
                select value).OrderBy(value => value.Date);
            
            this.metricValues = values.ToArray();
        }
        
        public void show(ExecutionProgram program, Metric metric)
        {
            this.program = program;
            this.metric = metric;
            collectInfo();
        }

        public void refresh()
        {
            collectInfo();
        }
    }
}
