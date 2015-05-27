using Microsoft.AspNet.Razor.Runtime.TagHelpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Abhi1.TagHelpers
{
    [TargetElement("entity", Attributes = "type")]
    public class EntityTagHelper : TagHelper
    {
        public override void Process(TagHelperContext context, TagHelperOutput output)
        {
            int type;
            output.TagName = "img";
            Int32.TryParse(context.AllAttributes["type"].ToString(), out type);
            string image = String.Empty;
            switch (type)
            {
                case 0:
                    image = "/images/employee.png";
                    break;
                case 1:
                    image = "/images/department.png";
                    break;
                case 2:
                    image = "/images/group.png";
                    break;
            }
            output.Attributes["src"] = image;
        }
    }
}
