﻿using NKN.Models.Extensions;
using System.Collections.Generic;
using Umbraco.Web;

namespace NKN.Models.Generated
{
    public partial class ProjectCategoryLanding
    {
        public IEnumerable<ProjectDetail> AllProjects => this.Descendants<ProjectDetail>();
    }
}
