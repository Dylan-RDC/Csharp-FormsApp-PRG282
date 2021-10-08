using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_Milestone2_PRG282.BusinessLayer
{
    class Module
    {
        public Module() { }
        public Module(string moduleCode, string moduleName, string moduleDescription, string links)
        {
            ModuleCode = moduleCode;
            ModuleName = moduleName;
            Description = moduleDescription;
            Links = links;
        }

        public string ModuleCode { get; set; }
        public string ModuleName { get; set; }
        public string Description { get; set; }
        public string Links { get; set; }

        public string toString()
        {
            return $"Module code: {this.ModuleCode}\tModule name: {this.ModuleName}\tDiscription: {this.Description}\tLinks: {this.Links}";
        }
    }
}
