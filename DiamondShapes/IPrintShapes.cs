using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DiamondShapes
{
    public interface IPrintShapes
    {
        public string PrintDiamond(char alphabet);
        public bool IsValidInput(char alphabet);
        string ShowValidationMessage(char alphabet);
    }
}
