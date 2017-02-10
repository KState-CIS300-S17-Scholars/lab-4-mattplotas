using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void uxFindButton_Click(object sender, EventArgs e)
        {
            
            SieveList sl = new SieveList();
            try
            {
                int bound = Convert.ToInt32(uxBoundBox.Text);
                sl.BuildList(bound);
                if (bound >= 2)
                {
                    sl.FindPrimes();
                    Console.WriteLine(sl);
                    StringBuilder sb = new StringBuilder();
                    foreach (int num in sl)
                    {
                        sb.Append(num + " ");
                    }
                    uxResultBox.Text = sb.ToString();
                }else
                {
                    uxResultBox.Text = "";
                }
            }
            catch
            {
                MessageBox.Show("Please enter a valid number.");
            }
        }
    }

    public class SieveList : IEnumerable<int>
    {
        private Node head, tail;

        public SieveList(){ }

        public void BuildList(int bound)
        {
            Node temp = head = new Node(2, null);
            for (int i = 3; i < bound; i++){
                temp.Next = new Node(i, null);
                temp = temp.Next;
            }
            tail = temp.Next = new Node(bound, null);
        }

        public override string ToString()
        {
            return head.Data + " " + tail.Data;
        }
        public void FindPrimes()
        {
            Node divisor, dividend, previous;
            divisor = previous = head;
            while (divisor.Data <= Math.Sqrt(tail.Data))
            {
                dividend = divisor.Next;
                while(dividend != null)
                {
                    if (dividend.Data % divisor.Data == 0)
                        previous.Next = dividend.Next;
                    previous = dividend;
                    dividend = dividend.Next;
                }
                divisor = divisor.Next;
            }
        }

        public IEnumerator<int> GetEnumerator()
        {
            return new SieveEnumerator(head);
            throw new NotImplementedException();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return new SieveEnumerator(head);
            throw new NotImplementedException();
        }

        private class Node
        {
            private int data;
            private Node next;

            public Node(int data, Node next)
            {
                this.data = data;
                this.next = next;
            }

            public int Data
            {
                get
                {
                    return data;
                }
                set
                {
                    data = value;
                }
            }

            public Node Next
            {
                get
                {
                    return next;
                }
                set
                {
                    next = value;
                }
            }
        }

        private class SieveEnumerator : IEnumerator<int>
        {

            private Node currentNode;
            public SieveEnumerator(Node head)
            {
                Node dummy = new Node(0, head);
                currentNode = dummy;
            }

            public int Current
            {
                get
                {
                    return currentNode.Data;
                    //throw new NotImplementedException();
                }
            }

            object IEnumerator.Current
            {
                get
                {
                    return currentNode.Data;
                    //throw new NotImplementedException();
                }
            }

            public void Dispose()
            {
                //throw new NotImplementedException();
            }

            public bool MoveNext()
            {
                if (currentNode.Next == null)
                    return false;
                currentNode = currentNode.Next;
                return true;
                //throw new NotImplementedException();
            }

            public void Reset()
            {
                //throw new NotImplementedException();
            }
        }
    }
}
