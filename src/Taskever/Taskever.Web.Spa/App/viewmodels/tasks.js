﻿define(["jquery", "knockout", 'durandal/app', 'plugins/dialog', 'models/dtos', 'services/task'], function ($, ko, app, dialogs, dtos, taskService) {
    var tasks = ko.mapping.fromJS([]);

    return {
        tasks: tasks,

        activate: function () {
            taskService.getMyTasks(tasks)
                .then(function(data) {
                    ko.mapping.fromJS(data, tasks);
                });
        },

        showTaskCreateDialog: function () {
            dialogs.show('viewmodels/createTaskDialog')
                .then(function (data) {
                    if (data) {
                        tasks.push(data);
                    }
                });
        },
        
        deleteTask: function (item) {
            console.log(item);
            taskService.deleteTask({ id: item.id() })
                .then(function() {
                    tasks.remove(item);
                });
        }
    };
});