using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns_Core.FactoryMethod
{
    public class Resume : Document
    {
        // Factory Method implementation
        public override void CreatePages()
        {
            Pages.Add(new SkillsPage());
            Pages.Add(new EducationPage());
            Pages.Add(new ExperiencePage());
        }
    }
}
