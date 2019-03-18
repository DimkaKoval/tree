using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tree
{
    class Tree
    {
        private string value;
        private int count;
        private Tree left;
        private Tree right;

        // вставка
        public void Insert(string value)
        {
            if (this.value == null)
                this.value = value;
            else
            {
                if (this.value.CompareTo(value) == 1)
                {
                    if (left == null)
                        this.left = new Tree();
                    left.Insert(value);
                }
                else if (this.value.CompareTo(value) == -1)
                {
                    if (right == null)
                        this.right = new Tree();
                    right.Insert(value);
                }
                else
                    throw new Exception("Вузол вже існує");
            }

            this.count = Recount(this);
        }
        // пошук
        public Tree Search(string value)
        {
            if (this.value == value)
                return this;
            else if (this.value.CompareTo(value) == 1)
            {
                if (left != null)
                    return this.left.Search(value);
                else
                    throw new Exception("Пошукового вузла в дереві не існує");
            }
            else
            {
                if (right != null)
                    return this.right.Search(value);
                else
                    throw new Exception("Пошукового вузла в дереві не існує");
            }
        }
        // відображення
        public string Display(Tree t)
        {
            string result = "";
            if (t.left != null)
                result += Display(t.left);

            result += t.value + " ";

            if (t.right != null)
                result += Display(t.right);

            return result;
        }
        // підрахунок
        private int Recount(Tree t)
        {
            int count = 0;

            if (t.left != null)
                count += Recount(t.left);

            count++;

            if (t.right != null)
                count += Recount(t.right);

            return count;
        }
        // очистка
        public void Clear()
        {
            this.value = null;
            this.left = null;
            this.right = null;
        }
        // перевірка
        public bool IsEmpty()
        {
            if (this.value == null)
                return true;
            else
                return false;
        }
        // видалення
        public void Remove(string value)
        {
            Tree t = Search(value);
            string[] str1 = Display(t).TrimEnd().Split(' ');
            string[] str2 = new string[str1.Length - 1];

            int i = 0;
            foreach (string s in str1)
            {
                if (s != value)
                    str2[i++] = s;
            }

            t.Clear();
            foreach (string s in str2)
                t.Insert(s);

            this.count = Recount(this);
        }
    }
}
