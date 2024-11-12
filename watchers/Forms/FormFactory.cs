using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace watchers.Forms;

internal class FormFactory
{
    public IForm CreateForm(string type)
    {
        switch (type)
        {
            case "form1":
                return new Form1();
            case "form2":
                return new Form2();
            case "form3":
                return new Form3();
            case "form4":
                return new Form4();
            default:
                throw new ArgumentOutOfRangeException($"invalid form {type}");
        }
    }

    public bool IsValidForm(string form)
    {
        var forms = new List<string>
        {
            "form1",
            "form2",
            "form3",
            "form4"
        };

        return forms.Contains(form);
    }
}
