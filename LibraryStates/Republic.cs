using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryStates
{
    public class Republic: State
    {
        readonly string Type = "Республика";

        //Президент
        private string president;
        public string President
        {
            get
            {
                return president;
            }
            set
            {
                president = value;
            }
        }

        //Вид республики
        private string kindOfRepublic;
        public string KindOfRepublic
        {
            get
            {
                return kindOfRepublic;
            }
            set
            {
                kindOfRepublic = value;
            }
        }

        public Republic(string Name, string Capital, int YearOfFoundation, string President,string KindOfRepublic)
        {
            try
            {
                this.Name = Name;
                this.Capital = Capital;
                this.YearOfFoundation = YearOfFoundation;
                this.President = President;
                this.KindOfRepublic = KindOfRepublic;
            }
            catch(Exception ex) 
            {
                throw ex;
            };
        }

        //Вернуть форму государства
        public override string GetTypeStates()
        {
            return Type;
        }

        //Вывести государство в консоль
        public override string StateToString()
        {
            return $"{Type}: Название - {Name} / Столица - {Capital} / Возраст - {YearOfFoundation} / Президент - {President} / Вид республики - {KindOfRepublic}";
        }

        //Проверка на содержание в полях совпадений
        public override bool IsContains(string searchText)
        {
            if (Name == searchText ||
                Capital == searchText || 
                YearOfFoundation.ToString() == searchText ||
                President == searchText || 
                KindOfRepublic == searchText)
                return true;
            else
                return false;
        }
    }
}
