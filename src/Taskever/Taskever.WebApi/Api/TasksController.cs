﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Abp.Modules.Core.Services;
using Abp.WebApi.Controllers;
using Taskever.Services;
using Taskever.Services.Dto;

namespace Taskever.Web.Api
{
    public class TasksController : AbpApiController
    {
        private readonly ITaskService _taskService;

        public TasksController(ITaskService taskService)
        {
            _taskService = taskService;
        }

        public IEnumerable<TaskDto> GetTasks()
        {
            return _taskService.GetMyTasks();
        }
    }
}
