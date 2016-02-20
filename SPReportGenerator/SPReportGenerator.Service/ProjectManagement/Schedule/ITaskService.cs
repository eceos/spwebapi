using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using SPReportGenerator.Model.ProjectManagement.Schedule;

namespace SPReportGenerator.Service.ProjectManagement.Schedule
{
    public interface ITaskService
    {
        bool CreateTask(Task task);

        IEnumerable<Task> GetAllTask();

        IEnumerable<Task> GetAllTaskNotCompleted();


    }
}
