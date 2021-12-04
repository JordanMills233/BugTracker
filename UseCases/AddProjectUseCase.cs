﻿using Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UseCases.DataStorePlugInInterfaces;

namespace UseCases
{
    public class AddProjectUseCase : IAddProjectUseCase
    {
        private readonly IProjectRepository projectRepository;

        public AddProjectUseCase(IProjectRepository projectRepository)
        {
            this.projectRepository = projectRepository;
        }

        public void Execute(Project project)
        {
            projectRepository.AddProject(project);
        }
    }
}
