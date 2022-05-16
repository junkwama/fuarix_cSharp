using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    internal class Validation
    {
        public static string checkComboBox(ComboBox cb, string label, Label labelComponent)
        {

            labelComponent.Text = "";
            labelComponent.Visible = false;

            string text;
            if (cb.SelectedItem == null)
            {
                text = "bir '" + label + "' seçilmesi lazım";
                labelComponent.Visible = true;
                labelComponent.Text = text;
                return text;
            }
            labelComponent.Visible = true;
            labelComponent.Text = "";
            return "valid";
        }

        public static string checkCheckedList(CheckedListBox clb, string labelText, Label labelComponent)
        {

            labelComponent.Text = "";
            labelComponent.Visible = false;

            string text;
            if (clb.CheckedItems.Count < 1)
            {
                text = "'" + labelText + "' alanı için en az bir değer seçmeniz lazım";
                labelComponent.Visible = true;
                labelComponent.Text = text;
                return text;
            }

            labelComponent.Visible = false;
            labelComponent.Text = "";
            return "valid";
        }

        public static string check(List<ItemToValide> items)
        {
            string value;
            string label;
            string rule;
            Label labelComponent;

            for (int i = 0; i < items.Count; i++)
            {
                items[i].labelComponent.Text = "";
                items[i].labelComponent.Visible = false;
            }

            for (int i = 0; i<items.Count; i++)
            {
                string text;
                value = items[i].value.Trim();
                label = items[i].lableText.Trim();
                rule = items[i].rule.Trim();
                labelComponent = items[i].labelComponent;
                
                switch (rule)
                {

                    case "email":
                        if(value.Length < 1)
                        {
                            text = "Eposta alanı zorunludur";
                            labelComponent.Visible = true;
                            labelComponent.Text = text;
                            return text;
                        }
                        else if ((value.IndexOf("@") < 0) || (value.IndexOf(".") < 0))
                        {
                            text = "Girdiğiniz eposta adresi geçerli değildir";
                            labelComponent.Visible = true;
                            labelComponent.Text = text;
                            return text;
                        }
                        else
                        {
                            labelComponent.Visible = false;
                            labelComponent.Text = "";
                        }
                        break;

                    case "required" :
                        if (value.Length < 1)
                        {
                            text = "'" + label + "' alanı zorunludur";
                            labelComponent.Visible = true;
                            labelComponent.Text = text;
                            return text;
                        }
                        else
                        {
                            labelComponent.Visible = false;
                            labelComponent.Text = "";
                        }
                        break;

                    case "password":
                        if (value.Length != 5)
                        {
                            text = "Şifre 5 karakterli olması lazım";
                            labelComponent.Visible = true;
                            labelComponent.Text = text;
                            return text;
                        }
                        else
                        {
                            labelComponent.Visible = false;
                            labelComponent.Text = "";
                        }
                        break;

                    case "phone":
                        if (value.Length < 1)
                        {
                            text = "Tefelon numarası alanı zorunludur";
                            labelComponent.Visible = true;
                            labelComponent.Text = text;
                            return text;
                        }
                        else if (value.IndexOf('+') < 0)
                        {
                            text = "Tefelon numarası ülke kodu içermeli";
                            labelComponent.Visible = true;
                            labelComponent.Text = text;
                            return text;
                        }
                        else if (value.Length < 10)
                        {
                            text = "Tefelon numarası en az 10 karakterli olmalı";
                            labelComponent.Visible = true;
                            labelComponent.Text = text;
                            return text;
                        }
                        else
                        {
                            labelComponent.Visible = false;
                            labelComponent.Text = "";
                        }
                        break;

                    default:
                        return "valid";
                }
            }
            return "valid";

        }
    }

    public class ItemToValide
    {
        public string lableText;
        public string value;
        public string rule;
        public Label labelComponent;

        public ItemToValide(string value, string rule, string lableText, Label labelComponent)
        {
            this.lableText = lableText;
            this.value = value;
            this.rule = rule;
            this.labelComponent = labelComponent;
        }

    }
}
