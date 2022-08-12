using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3_JOHN_THE_ROBOT
{
    internal class Humanoid
    {
        private ISkillType _skillType { get; set; }

        public Humanoid()
        { 
        
        }
        public Humanoid(ISkillType skillType)
        { 
          
            _skillType = skillType;
        
        }


        public string ShowSkill()
        { 
         return _skillType == null ? "no skill is defined" : _skillType.GetTypeName();
        }
    }
}
